using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicGamesLocator
{
    public class GamesInfo
    {
        public List<ManifestInfo> Manifests { set; get; }
        public InstallationLancher Lancher { set; get; }
        public GamesInfo()
        {
            Manifests = new List<ManifestInfo>();
            string path = @"C:\ProgramData\Epic\EpicGamesLauncher\Data\Manifests";
            if (Directory.Exists(path))
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                foreach (FileInfo file in directory.GetFiles())
                {
                    ManifestInfo myDeserializedClass = JsonConvert.DeserializeObject<ManifestInfo>(File.ReadAllText(file.FullName));
                    Manifests.Add(myDeserializedClass);
                }
            }
            path = @"C:\ProgramData\Epic\UnrealEngineLauncher\LauncherInstalled.dat";
            Lancher = JsonConvert.DeserializeObject<InstallationLancher>(File.ReadAllText(path));
        }
        public void EditLocation(string target, string desPath, ManifestInfo manifest)
        {
            //ManifestLocation, InstallLocation, and StagingLocation
            foreach (ManifestInfo manifestInfo in Manifests)
            {
                if (manifestInfo == manifest)
                {
                    manifestInfo.ManifestLocation = manifestInfo.ManifestLocation.Replace(target, desPath);
                    manifestInfo.InstallLocation = manifestInfo.InstallLocation.Replace(target, desPath);
                    manifestInfo.StagingLocation = manifestInfo.StagingLocation.Replace(target, desPath);
                    Lancher.InstallationList.Find(i => i.AppName == manifestInfo.AppName).InstallLocation = desPath;

                }
            }
        }
         
        
        public ListViewItem[] GetListViewItems()
        {
            List<ListViewItem> items = new List<ListViewItem>();
            foreach (ManifestInfo manifest in Manifests)
            {
                ListViewItem item = new ListViewItem(manifest.DisplayName);
                item.SubItems.Add(manifest.InstallationGuid + ".item").Tag = @"C:\ProgramData\Epic\EpicGamesLauncher\Data\Manifests\"+ manifest.InstallationGuid + ".item";
                item.Tag = manifest;
                items.Add(item);
            }
            return items.ToArray();
        }
        public void Save()
        {

        }
    }
}

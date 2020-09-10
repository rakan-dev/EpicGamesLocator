using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicGamesLocator
{
    public class InstallationList
    {
        public string InstallLocation { get; set; }
        public string AppName { get; set; }
        public string AppVersion { get; set; }
    }

    public class InstallationLancher
    {
        public List<InstallationList> InstallationList { get; set; }
    }
}

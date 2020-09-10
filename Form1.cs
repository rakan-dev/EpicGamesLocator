using IOExtensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicGamesLocator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("EpicGamesLauncher");
            if (pname.Length != 0)
            {
                btnKillEpic.Enabled = true;
                grpBox.Enabled = false;
            }
            else
            {
                btnKillEpic.Enabled = false;
                grpBox.Enabled = true;
            }
        } //check if epic running

        private void btnKillEpic_Click(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("EpicGamesLauncher");
            try
            {
                pname[0].Kill();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Process Can't killed Exit Epic Games Manully \r\n " + ex.Message);
            }
            btnKillEpic.Enabled = false;
            grpBox.Enabled = true;
            btnKillEpic.Text = "Epic Games Killed ! yah ";
        } // kill epic process

        private void btnGetGames_Click(object sender, EventArgs e)
        {
            lGames.Items.Clear();
        } // get games and put them in listview

        private void lGames_SelectedIndexChanged(object sender, EventArgs e)
        {

        } // show the current installation path after select the game

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string newPath = fbd.SelectedPath;

                }
            }
        } // edit the installation path
  
        private void progressBar1_ParentChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

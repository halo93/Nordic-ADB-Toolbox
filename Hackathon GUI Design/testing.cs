using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hackathon_GUI_Design
{
    public partial class testing : Form
    {
        ProcessStartInfo info = new ProcessStartInfo();
        public testing()
        {
            InitializeComponent();
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            info.RedirectStandardOutput = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Process process = new Process();

            info.FileName = "tools//adb.exe";
            info.Arguments = "shell pm list packages -3";
            process.StartInfo = info;
            process.Start();

            string strAppNames = process.StandardOutput.ReadToEnd().Trim();
            List<string> listOfAppNames = new List<string>(strAppNames.ToString().Trim().Split("package:"));
            listOfAppNames.Remove("");
            for (int i = 0; i < listOfAppNames.Count; i++)
            {
                listOfAppNames[i] = listOfAppNames[i].Trim();
            }
            Random r = new Random();
            int randomAppIndex = r.Next(0, listOfAppNames.Count() - 1);
            string findActivityCommand = $"cmd package resolve-activity --brief {listOfAppNames[randomAppIndex]} | tail -n 1";
            info.Arguments = $"shell {findActivityCommand}";

            process.Start();
            string mainActivity = process.StandardOutput.ReadToEnd().Trim();
            string command = $"am start -n {mainActivity}";
            Console.WriteLine($"Preparing to open the application '{mainActivity}' on the device");
            info.Arguments = $"shell {command}";
            process.Start();

            toolTip1.SetToolTip(btnStart, $"Click to launch another app");
            label2.Text = $"Launched the app with package {listOfAppNames[randomAppIndex]}";
        }
    }
}

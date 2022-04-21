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
    public partial class GoogleArama : Form
    {
        public GoogleArama()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(1100);
            FacebookGirişSayfası facebook = new FacebookGirişSayfası();
            facebook.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(530);
            GoogleAnaSayfa google = new GoogleAnaSayfa();
            google.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(92);
            GoogleArama googlearama = new GoogleArama();
            googlearama.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(830);
            GoogleGörseller görseller= new GoogleGörseller();
            görseller.Show();
            görseller.textBox1.Text = textBox1.Text;
            this.Hide();
        }

        private void yenidenYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(100);
            GoogleArama googlearama = new GoogleArama();
            googlearama.Show();
            this.Hide();
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(90);
            GoogleAnaSayfa google = new GoogleAnaSayfa();
            google.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(800);
            YoutubeAnaSayfa youtube = new YoutubeAnaSayfa();
            youtube.Show();
            this.Hide();
        }



      

        
    }
}

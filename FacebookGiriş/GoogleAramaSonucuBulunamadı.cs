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
    public partial class GoogleAramaSonucuBulunamadı : Form
    {
        public GoogleAramaSonucuBulunamadı()
        {
            InitializeComponent();
        }

        public string arama;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GoogleAnaSayfa google = new GoogleAnaSayfa();
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(830);
            google.Show();
            this.Hide();
        }

        private void yenidenYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(90);
            GoogleAramaSonucuBulunamadı sonucyok = new GoogleAramaSonucuBulunamadı();
            sonucyok.Show();
            this.Hide();
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoogleAnaSayfa google = new GoogleAnaSayfa();
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(800);
            google.Show();
            this.Hide();
        }
    }
}

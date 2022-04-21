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
    public partial class GoogleAnaSayfa : Form
    {
        public GoogleAnaSayfa()
        {
            InitializeComponent();
        }

        GoogleAramaSonucuBulunamadı sonucyok = new GoogleAramaSonucuBulunamadı();
        GoogleArama googlearama = new GoogleArama();
       

        private void button1_Click(object sender, EventArgs e)
        {
            sonucyok.textBox1.Text = textBox1.Text;
            sonucyok.label7.Text = textBox1.Text;
            googlearama.textBox1.Text = textBox1.Text;

            if (textBox1.Text == "Sosyal Medya" || textBox1.Text == "sosyal medya" || textBox1.Text == "sosyalmedya" || textBox1.Text == "SOSYAL MEDYA") 
            {
                this.Cursor = Cursors.AppStarting;
                System.Threading.Thread.Sleep(1400);

                googlearama.Show();
                this.Hide();
            }
            else if (textBox1.Text == "")
            {

            }
            else
            {
                this.Cursor = Cursors.AppStarting;
                System.Threading.Thread.Sleep(185);

                sonucyok.Show();
                this.Hide();
            }
        }

        private void yenidenYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(120);

            GoogleAnaSayfa google = new GoogleAnaSayfa();
            google.Show();
            this.Hide();
        }
    }
}

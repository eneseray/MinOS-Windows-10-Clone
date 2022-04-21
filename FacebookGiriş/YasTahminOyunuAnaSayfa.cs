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
    public partial class YasTahminOyunuAnaSayfa : Form
    {
        public YasTahminOyunuAnaSayfa()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Masaüstü windows10masaüstü = new Masaüstü();
            windows10masaüstü.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MİNTEGRA YAZILIM TARAFINDAN YAPILMIŞTIR.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YasTahminOyunuOyun oyunaç = new YasTahminOyunuOyun();
            oyunaç.Show();
            this.Hide();
        }
    }
}

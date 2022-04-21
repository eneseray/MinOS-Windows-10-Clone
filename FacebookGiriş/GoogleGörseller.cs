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
    public partial class GoogleGörseller : Form
    {
        public GoogleGörseller()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(830);
            GoogleArama googlearama = new GoogleArama();
            googlearama.Show();
            googlearama.textBox1.Text = textBox1.Text;
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(300);
            GoogleGörseller googlegörsel = new GoogleGörseller();
            googlegörsel.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(500);
            GoogleAnaSayfa google = new GoogleAnaSayfa();
            google.Show();
            this.Hide();
        }

       
        
    }
}

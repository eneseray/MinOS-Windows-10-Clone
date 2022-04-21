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
    public partial class BilgisayarımÖzellikler : Form
    {
        public BilgisayarımÖzellikler()
        {
            InitializeComponent();
        }

        private void label21_MouseMove(object sender, MouseEventArgs e)
        {
            label21.Font = new Font(label21.Font, FontStyle.Underline);
            label21.ForeColor = Color.DodgerBlue;
        }

        private void label21_MouseLeave(object sender, EventArgs e)
        {
            label21.Font = new Font(label21.Font, label21.Font.Style ^ FontStyle.Underline);
            label21.ForeColor = Color.Black;
        }

        private void label22_MouseMove(object sender, MouseEventArgs e)
        {
            label22.Font = new Font(label22.Font, FontStyle.Underline);
            label22.ForeColor = Color.DodgerBlue;
        }

        private void label22_MouseLeave(object sender, EventArgs e)
        {
            label22.Font = new Font(label22.Font, label22.Font.Style ^ FontStyle.Underline);
            label22.ForeColor = Color.Black;
        }

        private void label23_MouseMove(object sender, MouseEventArgs e)
        {
            label23.Font = new Font(label23.Font, FontStyle.Underline);
            label23.ForeColor = Color.DodgerBlue;
        }

        private void label23_MouseLeave(object sender, EventArgs e)
        {
            label23.Font = new Font(label23.Font, label23.Font.Style ^ FontStyle.Underline);
            label23.ForeColor = Color.Black;
        }

        private void label24_MouseMove(object sender, MouseEventArgs e)
        {
            label24.Font = new Font(label24.Font, FontStyle.Underline);
            label24.ForeColor = Color.DodgerBlue;
        }

        private void label24_MouseLeave(object sender, EventArgs e)
        {
            label24.Font = new Font(label24.Font, label24.Font.Style ^ FontStyle.Underline);
            label24.ForeColor = Color.Black;
        }

        private void label20_MouseMove(object sender, MouseEventArgs e)
        {
            label20.Font = new Font(label20.Font, FontStyle.Underline);
            label20.ForeColor = Color.DodgerBlue;
        }

        private void label20_MouseLeave(object sender, EventArgs e)
        {
            label20.Font = new Font(label20.Font, label20.Font.Style ^ FontStyle.Underline);
            label20.ForeColor = Color.Black;
        }

        private void label25_MouseMove(object sender, MouseEventArgs e)
        {
            label25.Font = new Font(label25.Font, FontStyle.Underline);
            label25.ForeColor = Color.DodgerBlue;
        }

        private void label25_MouseLeave(object sender, EventArgs e)
        {
            label25.Font = new Font(label25.Font, label25.Font.Style ^ FontStyle.Underline);
            label25.ForeColor = Color.DarkBlue;
        }

       
        
    }
}

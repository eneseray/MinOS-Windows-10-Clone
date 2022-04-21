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
    public partial class Bilgisayarım : Form
    {
        public Bilgisayarım()
        {
            InitializeComponent();
        }

        int cTıklanınca = 0;
        public void pictureBox7_Click(object sender, EventArgs e)
        {
            cTıklanınca++;         
        }

       public void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            if (cTıklanınca == 1)
            {
                pictureBox7.Image = Image.FromFile(@"resim/cDiskiTıklanınca.png");
            }
            else
            {
                pictureBox7.Image = Image.FromFile(@"resim/cDiskiÜzerineGelince.png");
            }
        }        

        public void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            cTıklanınca = 0;
            pictureBox7.Image = Image.FromFile(@"resim/cDiskiİlkHali.png");
        }

        int dTıklanınca = 0;
        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            if (dTıklanınca == 1)
            {
                pictureBox8.Image = Image.FromFile(@"resim/dDiskiTıklanınca.png");
            }
            else
            {
                pictureBox8.Image = Image.FromFile(@"resim/dDiskiÜzerineGelince.png");
            }          
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            dTıklanınca = 0;
            pictureBox8.Image = Image.FromFile(@"resim/dDiskiİlkHali.png");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            dTıklanınca++;
        }
        
        int bilgisayarımaçmakapama = 0;
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            bilgisayarımaçmakapama++;
            if (bilgisayarımaçmakapama == 1)
            {
                pictureBox10.Image = Image.FromFile(@"resim/angle_right.png");
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                groupBox1.Size = new Size(1028, 27);
                groupBox2.Location=new Point(39,41);
            }
            else
            {
                pictureBox10.Image = Image.FromFile(@"resim/angle_down.png");
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                bilgisayarımaçmakapama = 0;
                groupBox1.Size=new Size(1028, 203);
                groupBox2.Location = new Point(40, 235);
            }
        }

        int bilgisayarımaçmakapama2 = 0;
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            bilgisayarımaçmakapama2++;
            if (bilgisayarımaçmakapama2 == 1)
            {
                pictureBox11.Image = Image.FromFile(@"resim/angle_right.png");
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;   
                groupBox2.Size=new Size(1028, 27);
            }
            else
            {
                pictureBox11.Image = Image.FromFile(@"resim/angle_down.png");
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;             
                bilgisayarımaçmakapama2 = 0;
                groupBox2.Size=new Size(1028, 218);
            }
        }
    }
}

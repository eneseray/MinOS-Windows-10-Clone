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
    public partial class TicTacToeKarşılıklı : Form
    {
        public TicTacToeKarşılıklı()
        {
            InitializeComponent();
        }

        TicTacToeKazan oyunkazan = new TicTacToeKazan();

        bool sıra = true; //true:x false:y
        int beraberliktoplam = 0; //tüm butonlara basıldığını kontrol etme

        void xkazan()
        {
            oyunkazan.Show();
            this.Hide();
            oyunkazan.label2.Text = "X";
        }

        void okazan()
        {
            oyunkazan.Show();
            this.Hide();
            oyunkazan.label2.Text = "O";
        }

        void kazankaybet()
        {
            // X'in kazanma kodları
            if (pictureBox2.Visible == true && pictureBox4.Visible == true && pictureBox6.Visible == true)
            {
                xkazan();
            }
            else  if (pictureBox8.Visible == true && pictureBox10.Visible == true && pictureBox12.Visible == true)
            {
                xkazan();
            }
            else if (pictureBox14.Visible == true && pictureBox16.Visible == true && pictureBox18.Visible == true)
            {
                xkazan();
            }
            else if (pictureBox2.Visible == true && pictureBox10.Visible == true && pictureBox18.Visible == true)
            {
                xkazan();
            }
            else if (pictureBox6.Visible == true && pictureBox10.Visible == true && pictureBox14.Visible == true)
            {
                xkazan();
            }
            else if (pictureBox2.Visible == true && pictureBox8.Visible == true && pictureBox14.Visible == true)
            {
                xkazan();
            }
            else if (pictureBox4.Visible == true && pictureBox10.Visible == true && pictureBox16.Visible == true)
            {
                xkazan();
            }
            else if (pictureBox6.Visible == true && pictureBox12.Visible == true && pictureBox18.Visible == true)
            {
                xkazan();
            }

            // O'nun kazanma kodları
            else if (pictureBox1.Visible == true && pictureBox3.Visible == true && pictureBox5.Visible == true)
            {
                okazan();
            }
            else if (pictureBox7.Visible == true && pictureBox9.Visible == true && pictureBox11.Visible == true)
            {
                okazan();
            }
            else if (pictureBox13.Visible == true && pictureBox15.Visible == true && pictureBox17.Visible == true)
            {
                okazan();
            }
            else if (pictureBox1.Visible == true && pictureBox9.Visible == true && pictureBox17.Visible == true)
            {
                okazan();
            }
            else if (pictureBox5.Visible == true && pictureBox9.Visible == true && pictureBox13.Visible == true)
            {
                okazan();
            }
            else if (pictureBox1.Visible == true && pictureBox7.Visible == true && pictureBox13.Visible == true)
            {
                okazan();
            }
            else if (pictureBox3.Visible == true && pictureBox9.Visible == true && pictureBox15.Visible == true)
            {
                okazan();
            }
            else if (pictureBox5.Visible == true && pictureBox11.Visible == true && pictureBox17.Visible == true)
            {
                okazan();
            }

            else if (beraberliktoplam == 9) //beraberlik kodları
            {
                TicTacToeBeraberlik beraber = new TicTacToeBeraberlik();
                beraber.Show();
                this.Hide();
            }
        }

        void sıraxde()
        {
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Black;
        }
        void sıraoda()
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Red;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            beraberliktoplam++;
            if (sıra == true)
            {
                pictureBox2.Visible = true;
                sıra = false;
                sıraoda();
            }

            else  if (sıra == false)
            {
                pictureBox1.Visible = true;
                sıra = true;
            }
            kazankaybet();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            beraberliktoplam++;
            if (sıra == true)
            {
                pictureBox4.Visible = true;
                sıra = false;
                sıraoda();
            }

            else if (sıra == false)
            {
                pictureBox3.Visible = true;
                sıra = true;
                sıraxde();

            }
            kazankaybet();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            beraberliktoplam++;
            if (sıra == true)
            {
                pictureBox6.Visible = true;
                sıra = false;
                sıraoda();
            }

            else if (sıra == false)
            {
                pictureBox5.Visible = true;
                sıra = true;
                sıraxde();

            }
            kazankaybet();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            beraberliktoplam++;
            if (sıra == true)
            {
                pictureBox8.Visible = true;
                sıra = false;
                sıraoda();
            }

            else if (sıra == false)
            {
                pictureBox7.Visible = true;
                sıra = true;
                sıraxde();

            }
            kazankaybet();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            beraberliktoplam++;
            if (sıra == true)
            {
                pictureBox10.Visible = true;
                sıra = false;
                sıraoda();
            }

            else if (sıra == false)
            {
                pictureBox9.Visible = true;
                sıra = true;
                sıraxde();
            }
            kazankaybet();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            beraberliktoplam++;
            if (sıra == true)
            {
                pictureBox12.Visible = true;
                sıra = false;
                sıraoda();
            }

            else if (sıra == false)
            {
                pictureBox11.Visible = true;
                sıra = true;
                sıraxde();
            }
            kazankaybet();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            beraberliktoplam++;
            if (sıra == true)
            {
                pictureBox14.Visible = true;
                sıra = false;
                sıraoda();
            }

            else if (sıra == false)
            {
                pictureBox13.Visible = true;
                sıra = true;
                sıraxde();
            }
            kazankaybet();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            beraberliktoplam++;
            if (sıra == true)
            {
                pictureBox16.Visible = true;
                sıra = false;
                sıraoda();
            }

            else if (sıra == false)
            {
                pictureBox15.Visible = true;
                sıra = true;
                sıraxde();
            }
            kazankaybet();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            beraberliktoplam++;
            if (sıra == true)
            {
                pictureBox18.Visible = true;
                sıra = false;
                sıraoda();
            }

            else if (sıra == false)
            {
                pictureBox17.Visible = true;
                sıra = true;
                sıraxde();
            }
            kazankaybet();
        }  
    }
}

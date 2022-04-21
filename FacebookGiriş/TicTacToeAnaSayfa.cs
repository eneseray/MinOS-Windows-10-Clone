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
    public partial class TicTacToeAnaSayfa : Form
    {
        public TicTacToeAnaSayfa()
        {
            InitializeComponent();
        }

        byte oyunabasla = 0;
        byte btn2 = 0;
        byte btn3 = 0;
        byte butonyazıları = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            oyunabasla++;
            if (butonyazıları == 2)
            {
                butonyazıları = 0;
                butonyazıları++;
            }
            else
            {
                butonyazıları++;
            }
            timerkapanma.Start();             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btn2==0 ||btn2==1)
            {
                MessageBox.Show("MİNTEGRA YAZILIM TARAFINDAN YAPILMIŞTIR.");
            }
            if (btn2==2)
            {
                TicTacToeKolay kolay = new TicTacToeKolay();
                kolay.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btn3 == 0 || btn3 == 1)
            {
                Masaüstü minosmasaüstü = new Masaüstü();
                minosmasaüstü.Show();
                this.Hide();
            }
            if (btn3 == 2)
            {
                TicTacToeKarşılıklı karşılıklı = new TicTacToeKarşılıklı();
                karşılıklı.Show();
                this.Hide();
            }
        }
        
        private void timerkapanma_Tick(object sender, EventArgs e)
        {
            if (oyunabasla == 1)
            {
                panel1.Location = new Point(panel1.Location.X + 50, panel1.Location.Y);
                if (panel1.Location.X == 990)
                {
                    if (butonyazıları ==1)
                    {
                        button1.Text = "Geri";
                        button2.Text = "Kolay Mod";
                        button3.Text = "Karşılıklı Mod";
                        btn2 = 2;
                        btn3 = 2;
                    }
                    oyunabasla++;
                }   
            }
            if (oyunabasla==2)
            {
                panel1.Location = new Point(panel1.Location.X - 50, panel1.Location.Y);
                if (butonyazıları ==2)
                {
                    button1.Text = "Oyuna Başla";
                    button2.Text = "Hakkında";
                    button3.Text = "Oyundan Çık";
                    btn2 = 1;
                    btn3 = 1;
                }
                if (panel1.Location.X == 690)
                {
                    timerkapanma.Stop();
                    oyunabasla = 0;
                }
            }
        }   
    }
}

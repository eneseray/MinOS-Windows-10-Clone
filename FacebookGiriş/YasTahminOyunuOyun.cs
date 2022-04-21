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
    public partial class YasTahminOyunuOyun : Form
    {
        public YasTahminOyunuOyun()
        {
            InitializeComponent();
        }

        public int islem1 = 0;
        public int islem2 = 0;
        void rasgele1()
        {
            label1.Text = "Yaşını 10 İle Çarp";
            label2.Text = "Sonuca 9 Ekle";
            label3.Text = "Sonucu 2 İle Çarp";
            label4.Text = "Sonuçta 1 Çıkar";
            label5.Text = "Sonucu 10 İle Çarp";
            islem1++;
        }
        void rasgele2()
        {
            label1.Text = "Yaşını 5 İle Çarp";
            label2.Text = "Sonuca 8 Ekle";
            label3.Text = "Sonucu 2 İle Çarp";
            label4.Text = "Sonuçta 6 Çıkar";
            label5.Text = "Sonucu 10 İle Çarp";
            islem2++;
        }
       private void button6_Click(object sender, EventArgs e)
        {
            int girilensayı = Convert.ToInt32(textBox1.Text);
            if(islem1==1)
            {
                girilensayı = girilensayı / 10;
                girilensayı = girilensayı + 1;
                girilensayı = girilensayı / 2;
                girilensayı = girilensayı - 9;
                girilensayı = girilensayı / 10;     
            }
            if (islem2 == 1)
            {
                girilensayı = girilensayı / 10;

                girilensayı = girilensayı + 6;

                girilensayı = girilensayı / 2;

                girilensayı = girilensayı - 8;

                girilensayı = girilensayı / 5;

            }
            MessageBox.Show("Yaşınız: " + girilensayı);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            textBox1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            YasTahminOyunuAnaSayfa yaşbulmaoyunanasayfa = new YasTahminOyunuAnaSayfa();
            yaşbulmaoyunanasayfa.Show();
            this.Hide();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            Random rasgele=new Random();
            int sayi = rasgele.Next(1, 3);

            if (sayi == 1)
            {
                rasgele1();
            }
            else if (sayi == 2)
            {
                rasgele2();
            }
        }


    }
}

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
    public partial class TicTacToeKolay : Form
    {
        public TicTacToeKolay()
        {
            InitializeComponent();
        }

        int tümtoplam = 0; //bütün x ve o lar açıldığı zaman

        int btn1 = 0;
        int btn2 = 0;
        int btn3 = 0;
        int btn4 = 0;
        int btn5 = 0;
        int btn6 = 0;
        int btn7 = 0;
        int btn8 = 0;
        int btn9 = 0;

        int picturebir = 0;
        int pictureüç = 0;
        int picturebeş = 0;
        int pictureyedi = 0;
        int picturedokuz = 0;
        int pictureonbir = 0;
        int pictureonüç= 0;
        int pictureonbeş= 0;
        int pictureonyedi= 0;

        int beraberlik = 0;

        void picture1()
        {
            pictureBox1.Visible = true;
            picturebir++;
            tümtoplam++;
        }
        void picture2()
        {
            pictureBox3.Visible = true;
            pictureüç++;
            tümtoplam++;
        }
        void picture3()
        {
            pictureBox5.Visible = true;
            picturebeş++;
            tümtoplam++;
        }
        void picture4()
        {
            pictureBox7.Visible = true;
            pictureyedi++;
            tümtoplam++;
        }
        void picture5()
        {
            pictureBox9.Visible = true;
            picturedokuz++;
            tümtoplam++;
        }
        void picture6()
        {
            pictureBox11.Visible = true;
            pictureonbir++;
            tümtoplam++;
        }
        void picture7()
        {
            pictureBox13.Visible = true;
            pictureonüç++;
            tümtoplam++;
        }
        void picture8()
        {
            pictureBox15.Visible = true;
            pictureonbeş++;
            tümtoplam++;
        }
        void picture9()
        {
            pictureBox17.Visible = true;
            pictureonyedi++;
            tümtoplam++;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            btn1++;
            tümtoplam++;
            random:
            Random rasgele = new Random();
            int sayi = rasgele.Next(1,9);

            if (sayi == 1)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureüç == 1 || btn2 == 1)
                {
                    goto random;
                }
                else
                {
                    picture2();
                }              
            }
            else if (sayi==2)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturebeş == 1 || btn3 == 1)
                {
                    goto random;
                }
                else
                {
                    picture3();
                }
            }
            else if (sayi == 3)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureyedi == 1 || btn4 == 1)
                {
                    goto random;
                }
                else
                {
                    picture4();
                }
            }
            else if (sayi == 4)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturedokuz == 1 || btn5 == 1)
                {
                    goto random;
                }
                else
                {
                    picture5();
                }
            }
            else if (sayi == 5)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbir == 1 || btn6 == 1)
                {
                    goto random;
                }
                else
                {
                    picture6();
                }
            }
            else if (sayi == 6 )
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonüç == 1 || btn7 == 1)
                {
                    goto random;
                }
                else
                {
                    picture7();
                }
            }
            else if (sayi == 7)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbeş == 1 || btn8 == 1)
                {
                    goto random;
                }
                else
                {
                    picture8();
                }
            }
            else if (sayi == 8)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonyedi == 1 || btn9 == 1)
                {
                    goto random;
                }
                else
                {
                    picture9();
                }
            }
           

            sonuc:
            if (picturebir == 1 && pictureüç== 1 && picturebeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                
                beraberlik++;
            }
            if (pictureyedi == 1 && picturedokuz== 1 && pictureonbir == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureonüç == 1 && pictureonbeş == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && pictureyedi == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureüç == 1 && picturedokuz == 1 && pictureonbeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş== 1 && pictureonbir == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && picturedokuz == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && picturedokuz == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }



            if (btn1 == 1 && btn2 == 1 & btn3 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn4 == 1 && btn5 == 1 && btn6 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn7 == 1 && btn8 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn4 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn2 == 1 && btn5 == 1 && btn8 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn6 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn5 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn5 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }

            if (tümtoplam == 9 && beraberlik == 0)
            {
                TicTacToeBeraberlik beraber = new TicTacToeBeraberlik();
                beraber.Show();
                this.Hide();
            }
           
        }

        public void button2_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            btn2++;
            tümtoplam++;
            random2:
            Random rasgele = new Random();
            int sayi = rasgele.Next(1,9);

            if (sayi == 1)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturebir == 1 || btn1 == 1)
                {
                    goto random2;
                }
                else
                {
                    picture1();
                }
            }
            else if (sayi == 2)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturebeş == 1 || btn3 == 1)
                {
                    goto random2;
                }
                else
                {
                    picture3();
                }
            }
            else if (sayi == 3)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureyedi == 1 || btn4 == 1)
                {
                    goto random2;
                }
                else
                {
                    picture4();
                }
            }
            else if (sayi == 4)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturedokuz == 1 || btn5 == 1)
                {
                    goto random2;
                }
                else
                {
                    picture5();
                }
            }
            else if (sayi == 5)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbir == 1 || btn6 == 1)
                {
                    goto random2;
                }
                else
                {
                    picture6();
                }
            }
            else if (sayi == 6)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonüç == 1 || btn7 == 1)
                {
                    goto random2;
                }
                else
                {
                    picture7();
                }
            }
            else if (sayi == 7)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbeş == 1 || btn8 == 1)
                {
                    goto random2;
                }
                else
                {
                    picture8();
                }
            }
            else if (sayi == 8)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonyedi == 1 || btn9 == 1)
                {
                    goto random2;
                }
                else
                {
                    picture9();
                }
            }

            sonuc:
            if (picturebir == 1 && pictureüç == 1 && picturebeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureyedi == 1 && picturedokuz == 1 && pictureonbir == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureonüç == 1 && pictureonbeş == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && pictureyedi == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureüç == 1 && picturedokuz == 1 && pictureonbeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && pictureonbir == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && picturedokuz == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && picturedokuz == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }



            if (btn1 == 1 && btn2 == 1 & btn3 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn4 == 1 && btn5 == 1 && btn6 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn7 == 1 && btn8 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn4 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn2 == 1 && btn5 == 1 && btn8 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn6 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn5 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn5 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }

            if (tümtoplam == 9 && beraberlik == 0)
            {
                TicTacToeBeraberlik beraber = new TicTacToeBeraberlik();
                beraber.Show();
                this.Hide();
            }
           

        }

        public void button3_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            btn3++;
            tümtoplam++;
            random3:
            Random rasgele = new Random();
            int sayi = rasgele.Next(1,9);

            if (sayi == 1)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturebir == 1 || btn1 == 1)
                {
                    goto random3;
                }
                else
                {
                    picture1();
                }         
            }
            else  if (sayi == 2)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureüç == 1 || btn2 == 1)
                {
                    goto random3;
                }
                else
                {
                    picture2();
                }      
            }
            else if (sayi == 3)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureyedi == 1 || btn4 == 1)
                {
                    goto random3;
                }
                else
                {
                    picture4();
                }
            }
            else if (sayi == 4)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturedokuz == 1 || btn5 == 1)
                {
                    goto random3;
                }
                else
                {
                    picture5();
                }
            }
            else if (sayi == 5)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbir == 1 || btn6 == 1)
                {
                    goto random3;
                }
                else
                {
                    picture6();
                }
            }
            else if (sayi == 6)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonüç == 1 || btn7 == 1)
                {
                    goto random3;
                }
                else
                {
                    picture7();
                }
            }
            else if (sayi == 7)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbeş == 1 || btn8 == 1)
                {
                    goto random3;
                }
                else
                {
                    picture8();
                }
            }
            else if (sayi == 8)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonyedi == 1 || btn9 == 1)
                {
                    goto random3;
                }
                else
                {
                    picture9();
                }
            }

            sonuc:
            if (picturebir == 1 && pictureüç == 1 && picturebeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureyedi == 1 && picturedokuz == 1 && pictureonbir == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureonüç == 1 && pictureonbeş == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && pictureyedi == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureüç == 1 && picturedokuz == 1 && pictureonbeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && pictureonbir == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && picturedokuz == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && picturedokuz == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }



            if (btn1 == 1 && btn2 == 1 & btn3 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn4 == 1 && btn5 == 1 && btn6 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn7 == 1 && btn8 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn4 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn2 == 1 && btn5 == 1 && btn8 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn6 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn5 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn5 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }

            if(tümtoplam==9 && beraberlik==0)
            {
                TicTacToeBeraberlik beraber = new TicTacToeBeraberlik();
                beraber.Show();
                this.Hide();
            }
           

        }

        public void button4_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            btn4++;
            tümtoplam++;
            random4:
            Random rasgele = new Random();
            int sayi = rasgele.Next(1,9);

            if (sayi == 1)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturebir == 1 || btn1 == 1)
                {
                    goto random4;
                }
                else
                {
                    picture1();
                }
            }
            else if (sayi == 2)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureüç == 1 || btn2 == 1)
                {
                    goto random4;
                }
                else
                {
                    picture2();
                }
            }
            else if (sayi == 3)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturebeş == 1 || btn3 == 1)
                {
                    goto random4;
                }
                else
                {
                    picture3();
                }
            }
            else if (sayi == 4)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturedokuz == 1 || btn5 == 1)
                {
                    goto random4;
                }
                else
                {
                    picture5();
                }
            }
            else if (sayi == 5)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbir == 1 || btn6 == 1)
                {
                    goto random4;
                }
                else
                {
                    picture6();
                }
            }
            else if (sayi == 6)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonüç == 1 || btn7 == 1)
                {
                    goto random4;
                }
                else
                {
                    picture7();
                }
            }
            else if (sayi == 7)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbeş == 1 || btn8 == 1)
                {
                    goto random4;
                }
                else
                {
                    picture8();
                }
            }
            else if (sayi == 8)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonyedi == 1 || btn9 == 1)
                {
                    goto random4;
                }
                else
                {
                    picture9();
                }
            }

            sonuc:
            if (picturebir == 1 && pictureüç == 1 && picturebeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureyedi == 1 && picturedokuz == 1 && pictureonbir == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureonüç == 1 && pictureonbeş == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && pictureyedi == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureüç == 1 && picturedokuz == 1 && pictureonbeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && pictureonbir == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && picturedokuz == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && picturedokuz == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }



            if (btn1 == 1 && btn2 == 1 & btn3 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn4 == 1 && btn5 == 1 && btn6 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn7 == 1 && btn8 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn4 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn2 == 1 && btn5 == 1 && btn8 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn6 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn5 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn5 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }

            if (tümtoplam == 9 && beraberlik == 0)
            {
                TicTacToeBeraberlik beraber = new TicTacToeBeraberlik();
                beraber.Show();
                this.Hide();
            }
            

        }

        public void button7_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = true;
            btn7++;
            tümtoplam++;
            random7:
            Random rasgele = new Random();
            int sayi = rasgele.Next(1,9);

            if (sayi == 1)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturebir == 1 || btn1 == 1)
                {
                    goto random7;
                }
                else
                {
                    picture1();
                } 
            }
            else if (sayi == 2)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureüç == 1 || btn2 == 1)
                {
                    goto random7;
                }
                else
                {
                    picture2();
                }
            }
            else if (sayi == 3)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturebeş == 1 || btn3 == 1)
                {
                    goto random7;
                }
                else
                {
                    picture3();
                }
            }
            else if (sayi == 4)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureyedi == 1 || btn4 == 1)
                {
                    goto random7;
                }
                else
                {
                    picture4();
                }
            }
            else if (sayi == 5)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturedokuz == 1 || btn5 == 1)
                {
                    goto random7;
                }
                else
                {
                    picture5();
                }
            }
            else if (sayi == 6)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbir == 1 || btn6 == 1)
                {
                    goto random7;
                }
                else
                {
                    picture6();
                }
            }
            else if (sayi == 7)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbeş == 1 || btn8 == 1)
                {
                    goto random7;
                }
                else
                {
                    picture8();
                }
            }
            else if (sayi == 8)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonyedi == 1 || btn9 == 1)
                {
                    goto random7;
                }
                else
                {
                    picture9();
                }
            }

            sonuc:
            if (picturebir == 1 && pictureüç == 1 && picturebeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureyedi == 1 && picturedokuz == 1 && pictureonbir == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureonüç == 1 && pictureonbeş == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && pictureyedi == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureüç == 1 && picturedokuz == 1 && pictureonbeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && pictureonbir == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && picturedokuz == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && picturedokuz == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }



            if (btn1 == 1 && btn2 == 1 & btn3 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn4 == 1 && btn5 == 1 && btn6 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn7 == 1 && btn8 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn4 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn2 == 1 && btn5 == 1 && btn8 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn6 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn5 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn5 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }

            if (tümtoplam == 9 && beraberlik == 0)
            {
                TicTacToeBeraberlik beraber = new TicTacToeBeraberlik();
                beraber.Show();
                this.Hide();
            }
           
        }

        public void button8_Click(object sender, EventArgs e)
        {
            pictureBox16.Visible = true;
            btn8++;
            tümtoplam++;
            random8:
            Random rasgele = new Random();
            int sayi = rasgele.Next(1, 9);

            if (sayi == 1)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturebir == 1 || btn1 == 1)
                {
                    goto random8;
                }
                else
                {
                    picture1();
                }
            }
            else if (sayi == 2)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureüç == 1 || btn2 == 1)
                {
                    goto random8;
                }
                else
                {
                    picture2();
                }
            }
            else if (sayi == 3)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
               if (picturebeş == 1 || btn3 == 1)
                {
                    goto random8;
                }
                else
                {
                    picture3();
                }
            }
            else if (sayi == 4)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureyedi == 1 || btn4 == 1)
                {
                    goto random8;
                }
                else
                {
                    picture4();
                }
            }
            else if (sayi == 5)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturedokuz == 1 || btn5 == 1)
                {
                    goto random8;
                }
                else
                {
                    picture5();
                }
            }
            else if (sayi == 6)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbir == 1 || btn6 == 1)
                {
                    goto random8;
                }
                else
                {
                    picture6();
                }
            }
            else if (sayi == 7)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonüç == 1 || btn7 == 1)
                {
                    goto random8;
                }
                else
                {
                    picture7();
                }
            }
            
            else if (sayi == 8)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonyedi == 1 || btn9 == 1)
                {
                    goto random8;
                }
                else
                {
                    picture9();
                }
            }

            sonuc:
            if (picturebir == 1 && pictureüç == 1 && picturebeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureyedi == 1 && picturedokuz == 1 && pictureonbir == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureonüç == 1 && pictureonbeş == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && pictureyedi == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureüç == 1 && picturedokuz == 1 && pictureonbeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && pictureonbir == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && picturedokuz == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && picturedokuz == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }



            if (btn1 == 1 && btn2 == 1 & btn3 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn4 == 1 && btn5 == 1 && btn6 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn7 == 1 && btn8 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn4 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn2 == 1 && btn5 == 1 && btn8 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn6 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn5 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn5 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }

            if (tümtoplam == 9 && beraberlik == 0)
            {
                TicTacToeBeraberlik beraber = new TicTacToeBeraberlik();
                beraber.Show();
                this.Hide();
            }

        }

        public void button9_Click(object sender, EventArgs e)
        {
            pictureBox18.Visible = true;
            btn9++;
            tümtoplam++;
            random9:
            Random rasgele = new Random();
            int sayi = rasgele.Next(1,9);

            if (sayi == 1)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturebir == 1 || btn1 == 1)
                {
                    goto random9;
                }
                else
                {
                    picture1();
                }
            }
           else  if (sayi == 2)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureüç == 1 || btn2 == 1)
                {
                    goto random9;
                }
                else
                {
                    picture2();
                }
            }
            else if (sayi == 3)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturebeş == 1 || btn3 == 1)
                {
                    goto random9;
                }
                else
                {
                    picture3();
                }
            }
            else if (sayi == 4)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureyedi == 1 || btn4 == 1)
                {
                    goto random9;
                }
                else
                {
                    picture4();
                }
            }

            else if (sayi == 5)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturedokuz == 1 || btn5 == 1)
                {
                    goto random9;
                }
                else
                {
                    picture5();
                }
            }
            else if (sayi == 6)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbir == 1 || btn6 == 1)
                {
                    goto random9;
                }
                else
                {
                    picture6();
                }
            }
            
            else if (sayi == 7)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbeş == 1 || btn8 == 1)
                {
                    goto random9;
                }
                else
                {
                    picture8();
                }
            }
            
            else if (sayi == 8)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbeş == 1 || btn8 == 1)
                {
                    goto random9;
                }
                else
                {
                    picture8();
                }
            }

            sonuc:
            if (picturebir == 1 && pictureüç == 1 && picturebeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureyedi == 1 && picturedokuz == 1 && pictureonbir == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureonüç == 1 && pictureonbeş == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && pictureyedi == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureüç == 1 && picturedokuz == 1 && pictureonbeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && pictureonbir == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && picturedokuz == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && picturedokuz == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }



            if (btn1 == 1 && btn2 == 1 & btn3 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn4 == 1 && btn5 == 1 && btn6 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn7 == 1 && btn8 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn4 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn2 == 1 && btn5 == 1 && btn8 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn6 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn5 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn5 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }

            if (tümtoplam == 9 && beraberlik == 0)
            {
                TicTacToeBeraberlik beraber = new TicTacToeBeraberlik();
                beraber.Show();
                this.Hide();
            }
        }

        public void button6_Click(object sender, EventArgs e)
        {
            pictureBox12.Visible = true;
            btn6++;
            tümtoplam++;
            random6:
            Random rasgele = new Random();
            int sayi = rasgele.Next(1,9);

            if (sayi == 1)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturebir == 1 || btn1 == 1)
                {
                    goto random6;
                }
                else
                {
                    picture1();
                }
            }
           else  if (sayi == 2)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureüç == 1 || btn2 == 1)
                {
                    goto random6;
                }
                else
                {
                    picture2();
                }
            }
            else if (sayi == 3)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturebeş == 1 || btn3 == 1)
                {
                    goto random6;
                }
                else
                {
                    picture3();
                }
            }
            else if (sayi == 4)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureyedi == 1 || btn4 == 1)
                {
                    goto random6;
                }
                else
                {
                    picture4();
                }
            }

            else if (sayi == 5)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturedokuz == 1 || btn5 == 1)
                {
                    goto random6;
                }
                else
                {
                    picture5();
                }
            }
            else if (sayi == 6)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonüç == 1 || btn7 == 1)
                {
                    goto random6;
                }
                else
                {
                    picture7();
                }
            }
            
            else if (sayi == 7)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbeş == 1 || btn8 == 1)
                {
                    goto random6;
                }
                else
                {
                    picture8();
                }
            }
            else if (sayi == 8)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonyedi == 1 || btn9 == 1)
                {
                    goto random6;
                }
                else
                {
                    picture9();
                }
            }
            
            sonuc:
            if (picturebir == 1 && pictureüç == 1 && picturebeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureyedi == 1 && picturedokuz == 1 && pictureonbir == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureonüç == 1 && pictureonbeş == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && pictureyedi == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureüç == 1 && picturedokuz == 1 && pictureonbeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && pictureonbir == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && picturedokuz == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && picturedokuz == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }



            if (btn1 == 1 && btn2 == 1 & btn3 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn4 == 1 && btn5 == 1 && btn6 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn7 == 1 && btn8 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn4 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn2 == 1 && btn5 == 1 && btn8 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn6 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn5 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn5 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }

            if (tümtoplam == 9 && beraberlik == 0)
            {
                TicTacToeBeraberlik beraber = new TicTacToeBeraberlik();
                beraber.Show();
                this.Hide();
            }
        }

        public void button5_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = true;
            btn5++;
            tümtoplam++;
            random5:
            Random rasgele = new Random();
            int sayi = rasgele.Next(1, 9);

            if (sayi == 1)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturebir == 1 || btn1 == 1)
                {
                    goto random5;
                }
                else
                {
                    picture1();
                }
            }
            else if (sayi == 2)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureüç == 1 || btn2 == 1)
                {
                    goto random5;
                }
                else
                {
                    picture2();
                }
            }
            else if (sayi == 3)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (picturebeş == 1 || btn3 == 1)
                {
                    goto random5;
                }
                else
                {
                    picture3();
                }
            }
            else if (sayi == 4)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureyedi == 1 || btn4 == 1)
                {
                    goto random5;
                }
                else
                {
                    picture4();
                }
            }
            else if (sayi == 5)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbir == 1 || btn6 == 1)
                {
                    goto random5;
                }
                else
                {
                    picture6();
                }
            }
            else if (sayi == 6)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
               if (pictureonüç == 1 || btn7 == 1)
                {
                    goto random5;
                }
                else
                {
                    picture7();
                }
            }
            else if (sayi == 7)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonbeş == 1 || btn8 == 1)
                {
                    goto random5;
                }
                else
                {
                    picture8();
                }
            }
            else if (sayi == 8)
            {
                if (tümtoplam == 9)
                {
                    goto sonuc;
                }
                if (pictureonyedi == 1 || btn9 == 1)
                {
                    goto random5;
                }
                else
                {
                    picture9();
                }
            }

            sonuc:
            if (picturebir == 1 && pictureüç == 1 && picturebeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureyedi == 1 && picturedokuz == 1 && pictureonbir == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureonüç == 1 && pictureonbeş == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && pictureyedi == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (pictureüç == 1 && picturedokuz == 1 && pictureonbeş == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && pictureonbir == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebir == 1 && picturedokuz == 1 && pictureonyedi == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }
            if (picturebeş == 1 && picturedokuz == 1 && pictureonüç == 1)
            {
                TicTacToeKaybet oyunkaybet = new TicTacToeKaybet();
                oyunkaybet.Show();
                this.Hide();
                beraberlik++;
            }



            if (btn1 == 1 && btn2 == 1 & btn3 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn4 == 1 && btn5 == 1 && btn6 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn7 == 1 && btn8 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn4 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn2 == 1 && btn5 == 1 && btn8 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn6 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn1 == 1 && btn5 == 1 && btn9 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }
            if (btn3 == 1 && btn5 == 1 && btn7 == 1)
            {
                TicTacToeKazan oyunkazan = new TicTacToeKazan();
                oyunkazan.Show();
                this.Hide();
                oyunkazan.label2.Visible = false;
                oyunkazan.label1.Text = "Oyunu Kazandınız!";
                oyunkazan.label1.Location = new Point(50, 16);
                beraberlik++;
            }

            if (tümtoplam == 9 && beraberlik == 0)
            {
                TicTacToeBeraberlik beraber = new TicTacToeBeraberlik();
                beraber.Show();
                this.Hide();
            }
        }

    }
}

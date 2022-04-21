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
    public partial class Masaüstü : Form
    {
        public Masaüstü()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(830);
            this.Cursor = Cursors.Default;

            GoogleAnaSayfa google = new GoogleAnaSayfa();
            google.Show();

            timerBaslatKapat.Enabled = true;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(0, 720);
            label1.Text = DateTime.Now.ToShortTimeString();
            label2.Text = DateTime.Now.ToShortDateString();
            toolTip1.SetToolTip(label2,DateTime.Now.ToLongDateString());
        }

        int takvımgoster = 0;
        private void label2_Click(object sender, EventArgs e)
        {
            takvımgoster = takvımgoster + 1;
            if (takvımgoster == 1)
            {
                 monthCalendar1.Visible = true;
            }
            else if (takvımgoster == 2)
            {
                monthCalendar1.Visible = false;
                takvımgoster = 0;
            } 
        }

        int baslat = 0;
        public void pictureBox2_Click(object sender, EventArgs e)
        {
            baslat++;
            if (baslat == 1)
            {
                timerBaslatAc.Enabled = true;
                 panel1.Visible = true;        
            }
            else if (baslat == 2)
            {
                timerBaslatKapat.Enabled = true;
            }
        }

        private void pictureBox15_DoubleClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(750);

            TicTacToeAnaSayfa tictactoe = new TicTacToeAnaSayfa();
            tictactoe.Show();
            this.Hide();
        }

        private void pictureBox14_DoubleClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(110);
            this.Cursor = Cursors.Default;

            SürümNotları surumnot = new SürümNotları();
            surumnot.Show();
        }

        private void pictureBox13_DoubleClick(object sender, EventArgs e)
        {
            HesapMakinesi hesapmakine = new HesapMakinesi();
            hesapmakine.Show();
        }
        int masaustugostergızle = 0;
        private void masaüstüÖgeleriniGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            masaustugostergızle = masaustugostergızle + 1;
            
            if (masaustugostergızle == 1)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox11.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;

                if (panel1.Visible == true)
                {
                    timerBaslatKapat.Enabled = true;
                }
            }
            else if (masaustugostergızle == 2)
            {
                pictureBox8.Visible =true;
                pictureBox9.Visible = true;
                pictureBox11.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;

                if (panel1.Visible == true)
                {
                    timerBaslatKapat.Enabled = true;
                }
                masaustugostergızle = 0;
            }
        }

        private void özelliklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BilgisayarımÖzellikler bilgisayarözellikler = new BilgisayarımÖzellikler();
            bilgisayarözellikler.Show();
        }

        private void açToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(750);

            TicTacToeAnaSayfa tictactoe = new TicTacToeAnaSayfa();
            tictactoe.Show();
            this.Hide();
        }

        private void pictureBox16_DoubleClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(450);
            this.Cursor = Cursors.Default;

            YasTahminOyunuAnaSayfa yaştahminoyunu = new YasTahminOyunuAnaSayfa();
            yaştahminoyunu.Show();
            this.Hide();
        }

        int kapataç=0;
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            kapataç++;
            if (kapataç == 1)
            {
                panel6.Visible = true;
            }
            if (kapataç == 2)
            {
                panel6.Visible = false;
                kapataç = 0;
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(810);
            this.Cursor = Cursors.Default;

            YasTahminOyunuAnaSayfa yaştahminoyunu = new YasTahminOyunuAnaSayfa();
            yaştahminoyunu.Show();
            this.Hide(); 
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(810);
            this.Cursor = Cursors.Default;

            YasTahminOyunuAnaSayfa yaştahminoyunu = new YasTahminOyunuAnaSayfa();
            yaştahminoyunu.Show();
            this.Hide();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(810);
            this.Cursor = Cursors.Default;

            YasTahminOyunuAnaSayfa yaştahminoyunu = new YasTahminOyunuAnaSayfa();
            yaştahminoyunu.Show();
            this.Hide(); 
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(900);
            this.Cursor = Cursors.Default;

            TicTacToeAnaSayfa tictactoe = new TicTacToeAnaSayfa();
            tictactoe.Show();
            this.Hide();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(900);
            this.Cursor = Cursors.Default;

            TicTacToeAnaSayfa tictactoe = new TicTacToeAnaSayfa();
            tictactoe.Show();
            this.Hide();         
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(900);
            this.Cursor = Cursors.Default;

            TicTacToeAnaSayfa tictactoe = new TicTacToeAnaSayfa();
            tictactoe.Show();
            this.Hide();
        }

        public void Form8_Click(object sender, EventArgs e)
        {
            timerBaslatKapat.Enabled = true;
            monthCalendar1.Visible = false;
            takvımgoster = 0;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"resim/windows_icon2.jpg");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"resim/windows_icon1.png");
        }

        private void açToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(450);
            this.Cursor = Cursors.Default;

            YasTahminOyunuAnaSayfa yastahminoyunu = new YasTahminOyunuAnaSayfa();
            yastahminoyunu.Show();
            this.Hide();
        }

        private void pictureBox8_DoubleClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(110);
            this.Cursor = Cursors.Default;

            Bilgisayarım bilgisayarım = new Bilgisayarım();
            bilgisayarım.Show();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(110);
            this.Cursor = Cursors.Default;

            Bilgisayarım bilgisayarım = new Bilgisayarım();
            bilgisayarım.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(830);
            this.Cursor = Cursors.Default;

            GoogleAnaSayfa googlechrome = new GoogleAnaSayfa();
            googlechrome.Show();

            timerBaslatKapat.Enabled = true;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(830);
            this.Cursor = Cursors.Default;

            GoogleAnaSayfa googlechrome = new GoogleAnaSayfa();
            googlechrome.Show();

            timerBaslatKapat.Enabled = true;   
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(830);
            this.Cursor = Cursors.Default;

            GoogleAnaSayfa googlechrome = new GoogleAnaSayfa();
            googlechrome.Show();

            timerBaslatKapat.Enabled = true;  
        }

        private void pictureBox22_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox22.Image = Image.FromFile(@"resim/BaşlatBilgisayarımÜzerineGelince.png");
        }

        private void pictureBox22_MouseLeave(object sender, EventArgs e)
        {
            pictureBox22.Image = Image.FromFile(@"resim/BaşlatBilgisayarımİlkHali.png");
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(180);
            this.Cursor = Cursors.Default;

            Bilgisayarım bilgisayarım = new Bilgisayarım();
            bilgisayarım.Show();

            timerBaslatKapat.Enabled = true;
        }

        private void ortaBoyutluSimgelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox8.Size=new Size(78, 81);
            pictureBox8.Location=new Point(12,12);

            pictureBox9.Size=new Size(70, 116);
            pictureBox9.Location=new Point(12, 105);

            pictureBox11.Size=new Size(82, 115);
            pictureBox11.Location=new Point(8, 227);

            pictureBox13.Size = new Size(65, 106);
            pictureBox13.Location=new Point(17, 357);

            pictureBox14.Size=new Size(78,112);
            pictureBox14.Location=new Point(17, 469);

            pictureBox15.Size = new Size(103, 108);
            pictureBox15.Location=new Point(96, 12);

            pictureBox16.Size = new Size(103, 108);
            pictureBox16.Location=new Point(99, 126);
        }

        private void büyükSimgelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(90, 92);
            pictureBox8.Location = new Point(22, 22);

            pictureBox9.Size = new Size(82, 127);
            pictureBox9.Location = new Point(22, 115);

            pictureBox11.Size = new Size(94, 126);
            pictureBox11.Location = new Point(18, 245);

            pictureBox13.Size = new Size(77, 117);
            pictureBox13.Location = new Point(27, 375);

            pictureBox14.Size = new Size(90, 123);
            pictureBox14.Location = new Point(27, 500);

            pictureBox15.Size = new Size(115, 119);
            pictureBox15.Location = new Point(120, 20);

            pictureBox16.Size = new Size(115, 119);
            pictureBox16.Location = new Point(114, 140);
        }

        private void küçükSimgelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(68, 71);
            pictureBox8.Location = new Point(12, 12);

            pictureBox9.Size = new Size(60, 96);
            pictureBox9.Location = new Point(12, 105);

            pictureBox11.Size = new Size(72, 105);
            pictureBox11.Location = new Point(8, 227);

            pictureBox13.Size = new Size(55, 96);
            pictureBox13.Location = new Point(17, 357);

            pictureBox14.Size = new Size(68, 102);
            pictureBox14.Location = new Point(17, 469);

            pictureBox15.Size = new Size(93, 98);
            pictureBox15.Location = new Point(96, 12);

            pictureBox16.Size = new Size(90, 95);
            pictureBox16.Location = new Point(99, 126);
        }

        private void pictureBox23_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox23.Image = Image.FromFile(@"resim/edgeÜzerineGelince.Png");
        }

        private void pictureBox23_MouseLeave(object sender, EventArgs e)
        {
            pictureBox23.Image = Image.FromFile(@"resim/edgeİlkHali.Png");
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.Gray;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.Gray;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.Gray;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Black;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Black;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Black;            
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.Gray;
        }

        private void pictureBox19_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.Gray;
        }      

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.Gray;
        }

        private void pictureBox20_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.Gray;
        }      

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.Gray;
        }

        private void pictureBox21_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.Gray;
        }   

        private void pictureBox24_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox24.Image = Image.FromFile(@"resim/MağazaÜzerineGelince.png");
        }     

        private void açToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            HesapMakinesi hesapmakine = new HesapMakinesi();
            hesapmakine.Show();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox11.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox11.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            timer1.Enabled = false;
                
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Black;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            panel5.BackColor = Color.Gray;
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            panel5.BackColor = Color.Gray;
        }

        private void pictureBox25_MouseMove(object sender, MouseEventArgs e)
        {
            panel5.BackColor = Color.Gray;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(80);
            this.Cursor = Cursors.Default;

            Wia wia = new Wia();
            wia.Show();

            timerBaslatKapat.Enabled = true;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(80);
            this.Cursor = Cursors.Default;

            Wia wia = new Wia();
            wia.Show();

            timerBaslatKapat.Enabled = true;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(80);
            this.Cursor = Cursors.Default;

            Wia wia = new Wia();
            wia.Show();

            timerBaslatKapat.Enabled = true;
        }

        private void pictureBox24_MouseLeave(object sender, EventArgs e)
        {
            pictureBox24.Image = Image.FromFile(@"resim/MağazaİlkHali.png");
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            kapataç = 0;
            this.Hide();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            timerBaslatKapat.Enabled = true;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            timerBaslatKapat.Enabled = true;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            timerBaslatKapat.Enabled = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            timerBaslatKapat.Enabled = true;
        }

        private void timerBaslatAc_Tick(object sender, EventArgs e)
        {
            panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - 80);
            if (panel1.Location.Y <= 160)
            {
                timerBaslatAc.Enabled = false;
            }     
        }

        private void timerBaslatKapat_Tick(object sender, EventArgs e)
        {
            if (panel1.Location.Y !=720)
            {
                panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + 80);
                if (panel1.Location.Y == 720)
                {
                    timerBaslatKapat.Enabled = false;
                    baslat = 0;

                    panel6.Visible = false; //kapat açın kapanması
                    kapataç = 0;
                }
            }
            else
            {
                timerBaslatKapat.Enabled = false;
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            timerBaslatKapat.Enabled = true;
            GizliPencere gizli = new GizliPencere();
            gizli.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(110);
            this.Cursor = Cursors.Default;

            SürümNotları surumnot = new SürümNotları();
            surumnot.Show();
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(110);
            this.Cursor = Cursors.Default;

            SürümNotları surumnot = new SürümNotları();
            surumnot.Show();
        }



    }
}

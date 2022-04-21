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
    public partial class YoutubeMaviGriBenSendeYandım : Form
    {
        public YoutubeMaviGriBenSendeYandım()
        {
            InitializeComponent();
        }

        private void YoutubeMaviGriBenSendeYandım_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "resim/Mavi Gri - Ben Sende Yandım.mp3";
            timer1.Start();
        }
        int play = 0;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            play++;
            if (play == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                pictureBox3.Image = Image.FromFile(@"resim/Youtubeplaybuton.png");
                timer1.Stop();
            }
            if (play == 2)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBox3.Image = Image.FromFile(@"resim/Youtubeplaybuton1.png");
                play = 0;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int saniye = Convert.ToInt32(label2.Text);
            int dakika = Convert.ToInt32(label73.Text);
            saniye++;
            label2.Text = saniye.ToString();
            if (saniye == 60)
            {
                label2.Text = ("0");
                dakika++;
                label73.Text = dakika.ToString();
            }
            if (dakika == 3 && saniye == 53)
            {
                timer1.Stop();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.fullScreen = true;
        }

        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox10.Image = Image.FromFile(@"resim/KeşfetFmAboneÜzerine.png");
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Image = Image.FromFile(@"resim/KeşfetFmAbone.png");
        }

        private void pictureBox11_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox11.Image = Image.FromFile(@"resim/YoutubeEkleButonuÜzerine.png");
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Image = Image.FromFile(@"resim/YoutubeEkleButonu.png");
        }

        private void pictureBox12_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox12.Image = Image.FromFile(@"resim/YoutubePaylaşButonuÜzerine.png");
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Image = Image.FromFile(@"resim/YoutubePaylaşButonu.png");
        }

        private void pictureBox15_MouseMove(object sender, MouseEventArgs e)
        {
            if (beğenmeaktif == 0)
            {
                pictureBox15.Image = Image.FromFile(@"resim/YoutubeBeğenmeÜzerine.png");
            }
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            if (beğenmeaktif == 0)
            {
                pictureBox15.Image = Image.FromFile(@"resim/YoutubeBeğenme.png");
            }
        }

        private void pictureBox14_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox14.Image = Image.FromFile(@"resim/YoutubeBeğenmedimÜzerine.png");
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Image = Image.FromFile(@"resim/YoutubeBeğenmedim.png");
        }
        int beğenmeaktif = 0;
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            beğenmeaktif++;
            double beğenme = Convert.ToDouble(label7.Text);
            pictureBox15.Image = Image.FromFile(@"resim/YoutubeBeğenmeAktif.png");
            if (beğenmeaktif == 1)
            {
                beğenme++;
                label7.Text = beğenme.ToString();
                label6.ForeColor = Color.RoyalBlue;
                label7.ForeColor = Color.RoyalBlue;
            }
            if (beğenmeaktif == 2)
            {
                pictureBox15.Image = Image.FromFile(@"resim/YoutubeBeğenme.png");
                beğenme--;
                label7.Text = beğenme.ToString();
                beğenmeaktif = 0;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
            }
        }
        int beğenmemeaktif = 0;
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            beğenmemeaktif++;
            double beğenmeme = Convert.ToDouble(label11.Text);
            if (beğenmemeaktif == 1)
            {
                beğenmeme--;
                label11.Text = beğenmeme.ToString();
            }
            if (beğenmemeaktif == 2)
            {
                beğenmeme++;
                label11.Text = beğenmeme.ToString();
                beğenmemeaktif = 0;
            }
        }
        int açıklamayeri = 0;
        private void label45_Click(object sender, EventArgs e)
        {
            açıklamayeri++;
            if (açıklamayeri == 1)
            {
                panel5.Size = new Size(640, 513);
                panel6.Location = new Point(31, 1143);
                panel7.Location = new Point(31, 1206);
                label45.Text = "Daha Az Göster";
            }
            if (açıklamayeri == 2)
            {
                panel5.Size = new Size(640, 67);
                panel6.Location = new Point(31, 700);
                panel7.Location = new Point(31, 760);
                label45.Text = "Daha Fazla Göster";
                açıklamayeri = 0;
            }
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(700);

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            YoutubeAnaSayfa youtube = new YoutubeAnaSayfa();
            youtube.Show();
            this.Hide();
        }

        private void yenidenYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(595);

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            YoutubeMaviGriBenSendeYandım bensende = new YoutubeMaviGriBenSendeYandım();
            bensende.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(700);

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            YoutubeAnaSayfa youtube = new YoutubeAnaSayfa();
            youtube.Show();
            this.Hide();
        }

        private void pictureBox36_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox36.Image = Image.FromFile(@"resim/DumanBalVideoÜzerine.png");
            label22.ForeColor = Color.RoyalBlue;
        }

        private void pictureBox36_MouseLeave(object sender, EventArgs e)
        {
            pictureBox36.Image = Image.FromFile(@"resim/DumanBalVideo.png");
            label22.ForeColor = Color.Black;
        }

        private void label22_MouseMove(object sender, MouseEventArgs e)
        {
            label22.ForeColor = Color.RoyalBlue;
        }

        private void label22_MouseLeave(object sender, EventArgs e)
        {
            label22.ForeColor = Color.Black;
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(800);

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            YoutubeDumanBal bal = new YoutubeDumanBal();
            bal.Show();
            this.Hide();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(800);


            axWindowsMediaPlayer1.Ctlcontrols.stop();

            YoutubeDumanBal bal = new YoutubeDumanBal();
            bal.Show();
            this.Hide();
        }

        private void pictureBox35_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox35.Image = Image.FromFile(@"resim/YoutubeNormEnderDeliÜzerine.png");
            label39.ForeColor = Color.RoyalBlue;
        }

        private void pictureBox35_MouseLeave(object sender, EventArgs e)
        {
            pictureBox35.Image = Image.FromFile(@"resim/YoutubeNormEnderDeli.png");
            label39.ForeColor = Color.Black;
        }

        private void label39_MouseMove(object sender, MouseEventArgs e)
        {
            label39.ForeColor = Color.RoyalBlue;
        }

        private void label39_MouseLeave(object sender, EventArgs e)
        {
            label39.ForeColor = Color.Black;
        }

        private void label39_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(805);

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            YoutubeNormEnderDeli deli = new YoutubeNormEnderDeli();
            deli.Show();
            this.Hide();
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(805);

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            YoutubeNormEnderDeli deli = new YoutubeNormEnderDeli();
            deli.Show();
            this.Hide();
        }

        private void pictureBox28_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox28.Image = Image.FromFile(@"resim/YoutubeDanlaBilicVideo3Üzerine.png");
            label15.ForeColor = Color.RoyalBlue;
        }

        private void pictureBox28_MouseLeave(object sender, EventArgs e)
        {
            pictureBox28.Image = Image.FromFile(@"resim/YoutubeDanlaBilicVideo3.png");
            label15.ForeColor = Color.Black;
        }

        private void label15_MouseMove(object sender, MouseEventArgs e)
        {
            label15.ForeColor = Color.RoyalBlue;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.ForeColor = Color.Black;
        }

        private void pictureBox33_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox33.Image = Image.FromFile(@"resim/YoutubeMuratAbiVideo1Üzerine.png");
            label85.ForeColor = Color.RoyalBlue;
        }

        private void pictureBox33_MouseLeave(object sender, EventArgs e)
        {  
            pictureBox33.Image = Image.FromFile(@"resim/YoutubeMuratAbiVideo1.png");
            label85.ForeColor = Color.Black;
        }

        private void label85_MouseMove(object sender, MouseEventArgs e)
        {
            label85.ForeColor = Color.RoyalBlue;
        }

        private void label85_MouseLeave(object sender, EventArgs e)
        {
            label85.ForeColor = Color.Black;
        }


    }
}

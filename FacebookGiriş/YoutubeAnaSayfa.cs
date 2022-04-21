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
    public partial class YoutubeAnaSayfa : Form
    {
        public YoutubeAnaSayfa()
        {
            InitializeComponent();
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Image=Image.FromFile(@"resim/YoutubeKanalımÜstüne.png");
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(@"resim/YoutubeKanalım.png");
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = Image.FromFile(@"resim/YoutubeTrendlerÜzerine.png");
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile(@"resim/YoutubeTrendler.png");
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = Image.FromFile(@"resim/YoutubeAboneliklerÜzerine.png");
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile(@"resim/YoutubeAbonelikler.png");
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"resim/YoutubeGeçmişÜzerine.png");
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"resim/YoutubeGeçmiş.png");
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.Image = Image.FromFile(@"resim/YoutubeDahaSonraİzleÜzerine.png");
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile(@"resim/YoutubeDahaSonraİzle.png");
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox9.Image = Image.FromFile(@"resim/YoutubeBeğendiğimVideolarÜzerine.png");
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Image = Image.FromFile(@"resim/YoutubeBeğendiğimVideolar.png");
        }

        private void pictureBox11_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox11.Image = Image.FromFile(@"resim/YoutubeAnılPiyancıÜzerine.png");
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Image = Image.FromFile(@"resim/YoutubeAnılPiyancı.png");
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(520);

            GoogleArama googlearama = new GoogleArama();
            googlearama.Show();
            this.Hide();
        }

        private void yenidenYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(520);

            YoutubeAnaSayfa youtube = new YoutubeAnaSayfa();
            youtube.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            YoutubeAnaSayfa youtube = new YoutubeAnaSayfa();
            youtube.Show();
            this.Hide();
        }

        private void pictureBox12_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox12.Image = Image.FromFile(@"resim/YoutubeOrkunIşıtmakÜzerine.png");
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Image = Image.FromFile(@"resim/YoutubeOrkunIşıtmak.png");
        }

        private void pictureBox13_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox13.Image = Image.FromFile(@"resim/YoutubeSdnÜzerine.png");
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Image = Image.FromFile(@"resim/YoutubeSdn.png");
        }

        private void pictureBox14_MouseMove(object sender, MouseEventArgs e)
        {
           pictureBox14.Image = Image.FromFile(@"resim/YoutubeTechnopatÜzerine.png"); 
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Image = Image.FromFile(@"resim/YoutubeTechnopat.png");
        }

        private void pictureBox15_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox15.Image = Image.FromFile(@"resim/YoutubeMuratAbiÜzerine.Png");
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.Image = Image.FromFile(@"resim/YoutubeMuratAbi.Png");
        }

        private void pictureBox16_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox16.Image = Image.FromFile(@"resim/YoutubeDanlaBilicÜzerine.png");
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.Image = Image.FromFile(@"resim/YoutubeDanlaBilic.png");
        }

        private void pictureBox17_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox17.Image = Image.FromFile(@"resim/YoutubeDuruÖnverÜzerine.png"); 
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.Image = Image.FromFile(@"resim/YoutubeDuruÖnver.png");
        }

        private void pictureBox18_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox18.Image = Image.FromFile(@"resim/YoutubeBilgisayarKavramlarıÜzerine.png");
        }

        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            pictureBox18.Image = Image.FromFile(@"resim/YoutubeBilgisayarKavramları.png");
        }

        private void pictureBox19_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox19.Image = Image.FromFile(@"resim/YoutubeTeknoSeyirÜzerine.png"); 
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.Image = Image.FromFile(@"resim/YoutubeTeknoSeyir.png"); 
        }
       
        private void pictureBox20_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox20.Image = Image.FromFile(@"resim/YoutubeWebTeknoÜzerine.png"); 
        }

        private void pictureBox20_MouseLeave(object sender, EventArgs e)
        {
            pictureBox20.Image = Image.FromFile(@"resim/YoutubeWebTekno.png"); 
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Visible = true;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            button3.Visible = false; 
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            button4.Visible = true;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            button4.Visible = false;
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.ForeColor = Color.RoyalBlue;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }

        private void pictureBox24_MouseMove(object sender, MouseEventArgs e)
        {
            label6.ForeColor = Color.RoyalBlue;
        }

        private void pictureBox24_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }

        private void pictureBox26_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox26.Image = Image.FromFile(@"resim/YoutubeDanlaBilicVideo1Üzerine.png");
        }

        private void pictureBox26_MouseLeave(object sender, EventArgs e)
        {
            pictureBox26.Image = Image.FromFile(@"resim/YoutubeDanlaBilicVideo1.png");
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            label8.Font = new Font(label8.Font, FontStyle.Underline);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.Font = new Font(label8.Font, label8.Font.Style ^ FontStyle.Underline); // ^ mantıksal operatörü ile eğer daha önceden o stil özelliği uygulanmışsa iptal edilmesini,uygulanmamışsa uygulanmasını sağlıyor
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            label9.Font = new Font(label9.Font, FontStyle.Underline);
            label9.ForeColor = Color.RoyalBlue;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.Font = new Font(label9.Font, label9.Font.Style ^ FontStyle.Underline);
            label9.ForeColor = Color.SlateGray;
        }

        private void pictureBox27_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox27.Image = Image.FromFile(@"resim/YoutubeDanlaBilicVideo2Üzerine.png");
        }

        private void pictureBox27_MouseLeave(object sender, EventArgs e)
        {
            pictureBox27.Image = Image.FromFile(@"resim/YoutubeDanlaBilicVideo2.png");
        }

        private void label17_MouseMove(object sender, MouseEventArgs e)
        {
            label17.Font = new Font(label17.Font, FontStyle.Underline);
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.Font = new Font(label17.Font, label17.Font.Style ^ FontStyle.Underline);
        }

        private void label16_MouseMove(object sender, MouseEventArgs e)
        {
            label16.Font = new Font(label16.Font, FontStyle.Underline);
            label16.ForeColor = Color.RoyalBlue;
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label16.Font = new Font(label16.Font, label16.Font.Style ^ FontStyle.Underline);
            label16.ForeColor = Color.SlateGray;
        }

        private void pictureBox28_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox28.Image = Image.FromFile(@"resim/YoutubeDanlaBilicVideo3Üzerine.png");
        }

        private void pictureBox28_MouseLeave(object sender, EventArgs e)
        {
            pictureBox28.Image = Image.FromFile(@"resim/YoutubeDanlaBilicVideo3.png");
        }

        private void label22_MouseMove(object sender, MouseEventArgs e)
        {
            label22.Font = new Font(label22.Font, FontStyle.Underline);
        }

        private void label22_MouseLeave(object sender, EventArgs e)
        {
            label22.Font = new Font(label22.Font, label22.Font.Style ^ FontStyle.Underline);
        }

        private void label21_MouseMove(object sender, MouseEventArgs e)
        {
            label21.Font = new Font(label21.Font, FontStyle.Underline);
            label21.ForeColor = Color.RoyalBlue;
        }

        private void label21_MouseLeave(object sender, EventArgs e)
        {
            label21.Font = new Font(label21.Font, label21.Font.Style ^ FontStyle.Underline);
            label21.ForeColor = Color.SlateGray;
        }

        private void pictureBox29_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox29.Image = Image.FromFile(@"resim/YoutubeMuratAbiVideo1Üzerine.png");
        }

        private void pictureBox29_MouseLeave(object sender, EventArgs e)
        {
            pictureBox29.Image = Image.FromFile(@"resim/YoutubeMuratAbiVideo1.png");
        }

        private void label25_MouseMove(object sender, MouseEventArgs e)
        {
            label25.Font = new Font(label25.Font, FontStyle.Underline);
        }

        private void label25_MouseLeave(object sender, EventArgs e)
        {
            label25.Font = new Font(label25.Font, label25.Font.Style ^ FontStyle.Underline);
        }

        private void label24_MouseMove(object sender, MouseEventArgs e)
        {
            label24.Font = new Font(label24.Font, FontStyle.Underline);
            label24.ForeColor = Color.RoyalBlue;
        }

        private void label24_MouseLeave(object sender, EventArgs e)
        {
            label24.Font = new Font(label24.Font, label24.Font.Style ^ FontStyle.Underline);
            label24.ForeColor = Color.SlateGray;
        }

        private void pictureBox32_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox32.Image = Image.FromFile(@"resim/YoutubeMuratAbiVideo2Üzerine.png");
        }

        private void pictureBox32_MouseLeave(object sender, EventArgs e)
        {
            pictureBox32.Image = Image.FromFile(@"resim/YoutubeMuratAbiVideo2.png");
        }

        private void label34_MouseMove(object sender, MouseEventArgs e)
        {
            label34.Font = new Font(label34.Font, FontStyle.Underline);
        }

        private void label34_MouseLeave(object sender, EventArgs e)
        {
            label34.Font = new Font(label34.Font, label34.Font.Style ^ FontStyle.Underline);
        }

        private void label33_MouseMove(object sender, MouseEventArgs e)
        {
            label33.Font = new Font(label33.Font, FontStyle.Underline);
            label33.ForeColor = Color.RoyalBlue;
        }

        private void label33_MouseLeave(object sender, EventArgs e)
        {
            label33.Font = new Font(label33.Font, label33.Font.Style ^ FontStyle.Underline);
            label33.ForeColor = Color.SlateGray;
        }

        private void pictureBox33_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox33.Image = Image.FromFile(@"resim/YoutubeMuratAbiVideo3Üzerine.png");
        }

        private void pictureBox33_MouseLeave(object sender, EventArgs e)
        {
            pictureBox33.Image = Image.FromFile(@"resim/YoutubeMuratAbiVideo3.png");
        }

        private void label39_MouseMove(object sender, MouseEventArgs e)
        {
            label39.Font = new Font(label39.Font, FontStyle.Underline);
        }

        private void label39_MouseLeave(object sender, EventArgs e)
        {
            label39.Font = new Font(label39.Font, label39.Font.Style ^ FontStyle.Underline);
        }

        private void label38_MouseMove(object sender, MouseEventArgs e)
        {
            label38.Font = new Font(label38.Font, FontStyle.Underline);
            label38.ForeColor = Color.RoyalBlue;
        }

        private void label38_MouseLeave(object sender, EventArgs e)
        {
            label38.Font = new Font(label38.Font, label38.Font.Style ^ FontStyle.Underline);
            label38.ForeColor = Color.SlateGray;
        }

        private void pictureBox35_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox35.Image = Image.FromFile(@"resim/YoutubeNormEnderDeliÜzerine.png");
        }

        private void pictureBox35_MouseLeave(object sender, EventArgs e)
        {
            pictureBox35.Image = Image.FromFile(@"resim/YoutubeNormEnderDeli.png");
        }

        private void label47_MouseMove(object sender, MouseEventArgs e)
        {
            label47.Font = new Font(label47.Font, FontStyle.Underline);
        }

        private void label47_MouseLeave(object sender, EventArgs e)
        {
            label47.Font = new Font(label47.Font, label47.Font.Style ^ FontStyle.Underline);
        }

        private void label46_MouseMove(object sender, MouseEventArgs e)
        {
            label46.Font = new Font(label46.Font, FontStyle.Underline);
            label46.ForeColor = Color.RoyalBlue;
        }

        private void label46_MouseLeave(object sender, EventArgs e)
        {
            label46.Font = new Font(label46.Font, label46.Font.Style ^ FontStyle.Underline);
            label46.ForeColor = Color.SlateGray;
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(920);

            YoutubeNormEnderDeli deli = new YoutubeNormEnderDeli();
            deli.Show();
            this.Hide();
        }

        private void label47_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(920);

            YoutubeNormEnderDeli deli = new YoutubeNormEnderDeli();
            deli.Show();
            this.Hide();
        }

        private void label52_MouseLeave(object sender, EventArgs e)
        {
            label52.Font = new Font(label52.Font, label52.Font.Style ^ FontStyle.Underline);
        }

        private void label52_MouseMove(object sender, MouseEventArgs e)
        {
            label52.Font = new Font(label52.Font, FontStyle.Underline);
            label52.ForeColor = Color.RoyalBlue;
        }

        private void label51_MouseLeave(object sender, EventArgs e)
        {
            label51.Font = new Font(label51.Font, label51.Font.Style ^ FontStyle.Underline);
            label51.ForeColor = Color.SlateGray;
        }

        private void label51_MouseMove(object sender, MouseEventArgs e)
        {
            label51.Font = new Font(label51.Font, FontStyle.Underline);
            label51.ForeColor = Color.RoyalBlue;
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(910);

            YoutubeDumanBal bal = new YoutubeDumanBal();
            bal.Show();
            this.Hide();
        }

        private void label52_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(910);

            YoutubeDumanBal bal = new YoutubeDumanBal();
            bal.Show();
            this.Hide();
        }

        private void pictureBox36_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox36.Image = Image.FromFile(@"resim/DumanBalVideoÜzerine.png");
        }

        private void pictureBox36_MouseLeave(object sender, EventArgs e)
        {
            pictureBox36.Image = Image.FromFile(@"resim/DumanBalVideo.png");
        }

        private void pictureBox37_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox37.Image = Image.FromFile(@"resim/MaviGriBenSendeYandımÜzerine.png");
        }

        private void pictureBox37_MouseLeave(object sender, EventArgs e)
        {
            pictureBox37.Image = Image.FromFile(@"resim/MaviGriBenSendeYandım.png");
        }

        private void label57_MouseMove(object sender, MouseEventArgs e)
        {
            label57.Font = new Font(label57.Font, FontStyle.Underline);
        }

        private void label57_MouseLeave(object sender, EventArgs e)
        {
            label57.Font = new Font(label57.Font, label57.Font.Style ^ FontStyle.Underline);
        }

        private void label56_MouseMove(object sender, MouseEventArgs e)
        {
            label56.Font = new Font(label56.Font, FontStyle.Underline);
            label56.ForeColor = Color.RoyalBlue;
        }

        private void label56_MouseLeave(object sender, EventArgs e)
        {     
            label56.Font = new Font(label51.Font, label56.Font.Style ^ FontStyle.Underline);
            label56.ForeColor = Color.SlateGray;
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(900);

            YoutubeMaviGriBenSendeYandım bensende = new YoutubeMaviGriBenSendeYandım();
            bensende.Show();
            this.Hide();
        }

        private void label57_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            System.Threading.Thread.Sleep(900);

            YoutubeMaviGriBenSendeYandım bensende = new YoutubeMaviGriBenSendeYandım();
            bensende.Show();
            this.Hide();
        }

        private void label29_MouseMove(object sender, MouseEventArgs e)
        {
            label29.ForeColor = Color.RoyalBlue;
        }

        private void label29_MouseLeave(object sender, EventArgs e)
        {
            label29.ForeColor = Color.Black;
        }

        private void pictureBox30_MouseMove(object sender, MouseEventArgs e)
        {
            label29.ForeColor = Color.RoyalBlue;
        }

        private void pictureBox30_MouseLeave(object sender, EventArgs e)
        {
            label29.ForeColor = Color.Black;
        }

        private void label41_MouseMove(object sender, MouseEventArgs e)
        {
            label41.ForeColor = Color.RoyalBlue;
        }

        private void label41_MouseLeave(object sender, EventArgs e)
        {
            label41.ForeColor = Color.Black;
        }

        private void pictureBox34_MouseMove(object sender, MouseEventArgs e)
        {
            label41.ForeColor = Color.RoyalBlue;
        }

        private void pictureBox34_MouseLeave(object sender, EventArgs e)
        {
            label41.ForeColor = Color.Black;
        }
    }
}

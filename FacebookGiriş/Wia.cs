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
    public partial class Wia : Form
    {
        public Wia()
        {
            InitializeComponent();
        }

        int emojigoster = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            emojigoster++;
            if (emojigoster == 1)
            {
                panel1.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                pictureBox2.Visible = false;
            }
            else
            {
                panel1.Visible = false;
                emojigoster = 0;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = pictureBox3.Image;
            label2.Visible = true;
            panel1.Visible = false;
            label2.Text = "Emoji Atmayı da Öğrenmiş Helaaallll";
            emojigoster = 0;      
        }
        
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = pictureBox4.Image;
            label2.Visible = true;
            panel1.Visible = false;
            label2.Text = "Höööö Koparırım O Dilini";
            emojigoster = 0;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {         
            panel1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox2.Image = pictureBox5.Image;
            label2.Visible = true;
            label2.Text = "Ay Utandırma Salaakk";
            emojigoster = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            emojigoster = 0;
            label1.Visible = true;
            label2.Visible = true;
            panel1.Visible = false;
            pictureBox2.Visible = false;
            label1.Text = textBox1.Text;

            
            if (label1.Text == "NABER")
            {
                label2.Text = "İyiyim Sen Nasılsın :) ";
                textBox1.Clear();       
            }
            else if (label1.Text == "BENDE İYİYİM")
            {
                label2.Text = "Allah İyilik Versin :)";
                textBox1.Clear();
            }
            else if (label1.Text == "SELAM")
            {
                label2.Text = "Sana da Selaam!";
                textBox1.Clear();
            }           
            else if (label1.Text == "MERABA" || label1.Text =="MERHABA")
            {
                label2.Text = "Sana da Merhaba!";
                textBox1.Clear();
            }
            else if (label1.Text == "NASILSIN")
            {
                label2.Text = "İyiyim Sen Nasılsın :)";
                textBox1.Clear();
            }
            else if (label1.Text == "MERHABA WİA" || label1.Text == "MERHABAWİA")
            {
                label2.Text = " Merhabaaa :)))";
                textBox1.Clear(); 
            }
            else if (label1.Text == "SELAM WİA" ||label1.Text == "SELAMWİA")
            {
                label2.Text = "Selaamm :)))";
                textBox1.Clear();
            }
            else if (label1.Text == "WİA")
            {
                label2.Text = "Bana mı Seslendin Efendim?";
                textBox1.Clear();
            }
            else if (label1.Text == "ADIN NE" || label1.Text == "ADINNE" || label1.Text == "ADIN NE?" || label1.Text == "ADINNE?")
            {
                label2.Text = "Adım Wia. Senin Adın Ne?";
                textBox1.Clear();
            }
            else if (label1.Text == "SEN ERKEK MİSİN")
            {
                label2.Text = " Hayır Ben Bir Kızım.";
                textBox1.Clear();
            }
            else if (label1.Text == "SEN KIZ MISIN" || label1.Text=="SENKIZMISIN" || label1.Text=="SEN KIZMISIN")
            {
                label2.Text = " Evet Ben Bir Kızım.";
                textBox1.Clear();
            }
            else if (label1.Text == "CİNSİYETİN NE")
            {
                label2.Text = "Ben Bir Kızım.";
                textBox1.Clear();
            }       
            else if (label1.Text == "MERABA KARDEŞ" || label1.Text=="MERHABA KARDEŞ")
            {
                label2.Text = "Merabana Meraba Kardeş";
                textBox1.Clear();
            }
            else if (label1.Text == "ALLAH İYİLİK VERSİN")
            {
                label2.Text = "Sağolasın Biraderim";
                textBox1.Clear();
            }
            else if (label1.Text == "BENİM ADIM ENES")
            {
                label2.Text = "Benim Adım da Wia";
                textBox1.Clear();
            }  
            else if (label1.Text=="GÜZEL BAYAN")
            {
                label2.Text = "Çok Tşk Dostum Bacımsın ;)";
                textBox1.Clear();
            }
            else if ( label1.Text=="GEL CS ATAK")
            {
                label2.Text = "Dust 2 Ye Gel. Tek atarım ;)";
                textBox1.Clear();
            }
            else if (label1.Text=="MAL")
            {
                label2.Text = "Benim Adımda Wia ;)";
                textBox1.Clear();
            }
            else if (label1.Text == "NABER YAVRUM")
            {
                label2.Text = "Bu Samimiyet Nereden Geliyor Anlayamadım?";
                textBox1.Clear();
            }
            else if (label1.Text == "NASILSIN")
            {
                label2.Text = "İYİYİM :) SEN NASILSIN? ";
                textBox1.Clear();
            }
            else if (label1.Text == "SHERLOCK HOLMES")
            {
                label2.Text = "Ooo Alırım Bir Dal";
                textBox1.Clear();
            }
          
            else if (label1.Text == "SİRİ SENDEN DAHA İYİ")
            {
                label2.Text = "Hah :) Güldürme Lütfen.";
                textBox1.Clear();
            }
            else if (label1.Text == "SENİ KİM TASARLADI" || label1.Text=="SENİ KİM YAPTI")
            {
                label2.Text = "MİNTEGRA Yazılım Tarafından Tasarlandım";
                textBox1.Clear();
            }
            else if (label1.Text == "NERELİSİN" || label1.Text=="WİA NERELİSİN")
            {
                label2.Text = "Sahibim Gibi Bende Angaralıyım Gardaş";
                textBox1.Clear();
            }
            else if (label1.Text == "OKULU SEVER MİSİN "||label1.Text == "OKULU SEVERMİSİN " || label1.Text == "OKULU SEVER MİSİN?")
            {
                label2.Text = "SADECE ÇARŞAMBA GÜNLERİ :/ ";
                textBox1.Clear();
            }
            else if (label1.Text == "DERS ÇOK SIKICI " || label1.Text == "DERS SIKICI" || label1.Text == "DERS COK SIKICI")
            {
                label2.Text = "O Zaman Uyku Zamanııı!!";
                textBox1.Clear();
            }
            else if (label1.Text == "SENİ SEVİYORUM" || label1.Text == "SENİSEVİYORUM" || label1.Text == "AŞIĞIM SANA" || label1.Text=="SANA AŞIĞIM")
            {
                label2.Text = "Teşekkür Ederim. Ancak Benim Başım Bağlı .s ";
                textBox1.Clear();
            }
            else if (label1.Text == "SAAT KAÇ" || label1.Text == "SAATKAÇ")
            {
                label2.Text = "Hemen Bakıyorum ... " + DateTime.Now.ToShortTimeString();
                textBox1.Clear();
            }
            else if (label1.Text == "BUGÜN HANGİ GÜN" || label1.Text == "GÜNLERDEN NE" || label1.Text == "GÜNLERDENNE" || label1.Text == "BUGÜNHANGİGÜN")
            {
                label2.Text = "Hemen Bakıyorum ... " + DateTime.Now.ToString("dddd");
                textBox1.Clear();
            }
            else if (label1.Text == "HANGİ GÜNDEYİZ" || label1.Text == "HANGİGÜNDEYİZ")
            {
                label2.Text = "Hemen Bakıyorum ... " + DateTime.Now.ToString("dddd");
                textBox1.Clear();
            }
            else if (label1.Text == "HANGİ YILDAYIZ" || label1.Text == "HANGİYILDAYIZ" || label1.Text == "hangi yıldayız")
            {
                label2.Text = "Hemen Bakıyorum ... " + DateTime.Now.ToString("yyyy");
                textBox1.Clear();
            }
            else if (label1.Text == "YIL KAÇ" || label1.Text == "yıl kaç")
            {
                label2.Text = "Hemen Bakıyorum ... " + DateTime.Now.ToString("yyyy");
                textBox1.Clear();
            }
            else if (label1.Text == "BUGÜN AYIN KAÇI" || label1.Text == "BUGÜNAYINKAÇI")
            {
                label2.Text = "Hemen Bakıyorum ... " + DateTime.Now.ToString("dd");
                textBox1.Clear();
            }
            else if (label1.Text == "GOOGLE AÇ" || label1.Text == "GOOGLE" || label1.Text == "GOOGLE GİT")
            {
                System.Threading.Thread.Sleep(1000);
                GoogleAnaSayfa google = new GoogleAnaSayfa();
                google.Show();
                this.Hide();
            }
            else if (label1.Text == "HESAP MAKİNESİNİ AÇ" || label1.Text == "HESAP MAKİNESİ AÇ" || label1.Text == "HESAPMAKİNESİNİAÇ")
            {
                System.Threading.Thread.Sleep(1000);
                HesapMakinesi hesapmakine = new HesapMakinesi();
                hesapmakine.Show();
                this.Hide();
            }
            else if (label1.Text == "KENDİNİ KAPAT" || label1.Text == "KENDİNİKAPAT")
            {
                System.Threading.Thread.Sleep(190);
                this.Hide();
            }
            else if (label1.Text == "KENDİNİ İMHA ET" || label1.Text == "KENDİNİİMHAET" || label1.Text == "KENDİNİ İMHAET" || label1.Text == "KENDİNİİMHA ET")
            {
                System.Threading.Thread.Sleep(190);
                this.Hide();
            }
            else if (label1.Text == "BİLGİSAYARIM" || label1.Text == "BİLGİSAYARIMI AÇ")
            { 
                System.Threading.Thread.Sleep(190);

                Bilgisayarım bilgisayarım = new Bilgisayarım();
                bilgisayarım.Show();
                this.Hide();      
            }
            else if (label1.Text == "YOUTUBE" || label1.Text == "YOUTUBE AÇ")
            {
                this.Cursor = Cursors.AppStarting;
                System.Threading.Thread.Sleep(600);

                YoutubeAnaSayfa youtube = new YoutubeAnaSayfa();
                youtube.Show();

                this.Cursor = Cursors.Default;
            }
            else if (label1.Text == "YENİ SÜRÜM NE ZAMAN GELECEK" || label1.Text == "YENİ SÜRÜM NE ZAMAN GELECEK?" || label1.Text == "YENİ SÜRÜM NE ZAMAN GELİYOR")
            {
                label2.Text = ("Üzgünüm. \nBu Kişisel Bir Soru.");
                textBox1.Clear();
            }
            else if (label1.Text == "HANGİ TAKIMLISIN" || label1.Text == "HANGİTAKIMLISIN" || label1.Text == "HANGİ TAKIMLISIN?")
            {
                label2.Text = ("MİNTEGRA Sporluyum.");
                textBox1.Clear();
            }
            else if (label1.Text == "SEN ÇOK TATLISIN" || label1.Text == "WİA SEN ÇOK TATLISIN" || label1.Text == "ÇOK TATLISIN")
            {
                label2.Text = ("Lütfen Dur.");
                textBox1.Clear();
            }
            else if (label1.Text == "NAPIYORSUN" || label1.Text == "WİA NAPIYORSUN")
            {
                label2.Text = ("Yeni Numaralar Öğreniyorum.");
                textBox1.Clear();
            }
           


            else
            {
                label2.Text = "Üzgünüm Ama Bunu Anlamadım. \nTekrar Yazar Mısın? ";
                textBox1.Clear();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = pictureBox6.Image;
            label2.Visible = true;
            panel1.Visible = false;
            label2.Text = "Saydım. Gerçekten de 32 Dişin var :)";
            emojigoster = 0;
        }

        private void Form4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            emojigoster = 0;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = pictureBox8.Image;
            label2.Visible = true;
            panel1.Visible = false;
            label2.Text = "Ne Oldu Gız Neye Şaşırdın?";
            emojigoster = 0;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = pictureBox7.Image;
            label2.Visible = true;
            panel1.Visible = false;
            label2.Text = "Eheuhehu Gülmekten Gözümden Yaş Geldi";
            emojigoster = 0;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = pictureBox10.Image;
            label2.Visible = true;
            panel1.Visible = false;
            label2.Text = "Evet Bende İlk Duyunca Şaşırmıştım :D";
            emojigoster = 0;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = pictureBox9.Image;
            label2.Visible = true;
            panel1.Visible = false;
            label2.Text = "Niye Pis Pis Gülüyorsun? :D";
            emojigoster = 0;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = pictureBox11.Image;
            label2.Visible = true;
            panel1.Visible = false;
            label2.Text = "Sende Hemen Sinirleniyorsun Yha :Dd";
            emojigoster = 0;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = pictureBox13.Image;
            label2.Visible = true;
            panel1.Visible = false;
            label2.Text = "Dilini Burnuna Değdirebilir Misin?";
            emojigoster = 0;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = pictureBox15.Image;
            label2.Visible = true;
            panel1.Visible = false;
            label2.Text = "Açık da Birşey mi Gördün Kardeş? \nBen Senin Bildiğin Asistanlardan Değilim";
            emojigoster = 0;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = pictureBox16.Image;
            label2.Visible = true;
            panel1.Visible = false;
            label2.Text = "Hm. \nDüşünüyorum Öyleyse Varım.";
            emojigoster = 0;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = pictureBox14.Image;
            label2.Visible = true;
            panel1.Visible = false;
            label2.Text = "Ağlama yaaarrr Ağğğlllaaamaaaa";
            emojigoster = 0;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = pictureBox12.Image;
            label2.Visible = true;
            panel1.Visible = false;
            label2.Text = "Üzülme Be Kıyamam Sana";
            emojigoster = 0;
        }

      
      
    }
}

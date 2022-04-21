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
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
        }

        double s1, s2;
        byte bolme=0, top=0, cıkar=0, carp=0;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            cıkar = 0;
            bolme = 0;
            top = 0;
            carp = 0;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = s1 + " / ".ToString();
            textBox1.Clear();
            bolme++;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = s1 + " X ".ToString();
            textBox1.Clear();
            carp++;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = textBox1.Text + "-";
            }
            else
            {
                s1 = Convert.ToDouble(textBox1.Text);
                textBox2.Text = s1 + " - ".ToString();
                textBox1.Clear();
                cıkar++;
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = s1 + " + ".ToString();
            textBox1.Clear();
            top++;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (bolme==1)
            {
                s2 = Convert.ToDouble(textBox1.Text);
                textBox2.Text=s1+ " / " +s2+ " = ".ToString();
                double bolıslem = s1 / s2;
                textBox1.Text = bolıslem.ToString();
            }
            else if (carp == 1)
            {
                s2 = Convert.ToDouble(textBox1.Text);
                textBox2.Text = s1 + " X " + s2 + " = ".ToString();
                double carpıslem = s1 * s2;
                textBox1.Text = carpıslem.ToString();
            }
            else if (cıkar == 1)
            {
                s2 = Convert.ToDouble(textBox1.Text);
                textBox2.Text = s1 + " - " + s2 + " = ".ToString();
                double cıkarıslem = s1 - s2;
                textBox1.Text = cıkarıslem.ToString();
            }
            else if (top == 1)
            {
                s2 = Convert.ToDouble(textBox1.Text);
                textBox2.Text = s1 + " + " + s2 + " = ".ToString();
                double topıslem = s1 + s2;
                textBox1.Text = topıslem.ToString();
            }
            
        }
       
    }
}

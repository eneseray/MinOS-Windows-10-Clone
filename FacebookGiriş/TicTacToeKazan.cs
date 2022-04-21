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
    public partial class TicTacToeKazan : Form
    {
        public TicTacToeKazan()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!label2.Visible)
            {
                TicTacToeKolay tictactoe = new TicTacToeKolay();
                tictactoe.Show();
                this.Hide(); 
            }
            else
            {
                TicTacToeKarşılıklı karşılıklı = new TicTacToeKarşılıklı();
                karşılıklı.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TicTacToeAnaSayfa tictactoeanasayfa = new TicTacToeAnaSayfa();
            tictactoeanasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Masaüstü minosmasaüstü = new Masaüstü();
            minosmasaüstü.Show();
            this.Hide();
        }
    }
}

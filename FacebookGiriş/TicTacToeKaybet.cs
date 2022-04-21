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
    public partial class TicTacToeKaybet : Form
    {
        public TicTacToeKaybet()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TicTacToeKolay tictactoe = new TicTacToeKolay();
            tictactoe.Show();
            this.Hide();
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

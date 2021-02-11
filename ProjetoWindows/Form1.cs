using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var jogador1 = cbJogador1.SelectedItem;
            var jogador2 = cbJogador2.SelectedItem;

            if (jogador1 == jogador2)
            {
                MessageBox.Show("Empatou");
               
            } else if (jogador1.ToString() == "Pedra" && jogador2.ToString() == "Tesoura")
            {
                MessageBox.Show("jogador1 Ganhou");
            }          
            else if (jogador1.ToString() =="Tesoura" && jogador2.ToString() == "Papel")
            {
                MessageBox.Show("Jogador1 Ganhou");

            }
            else if (jogador1.ToString() == "Papel" && jogador2.ToString() == "Pedra")
            {
                MessageBox.Show("Jogador1 Ganhou");
            }
            else
            {
                MessageBox.Show("Jogador 2 Ganhou");
            }
        }
    }
}

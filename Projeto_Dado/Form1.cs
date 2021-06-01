using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Dado
{
    public partial class Form1 : Form
    {
        private Random rdnDado = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void jogar1_Click(object sender, EventArgs e)
        {
            int valor_dado1;
            valor_dado1 = rdnDado.Next(1, 7);
            switch (valor_dado1)
            {
                case 1:
                    dado1.Image = Properties.Resources.dice1;
                    break;
                case 2:
                    dado1.Image = Properties.Resources.dice2;
                    break;
                case 3:
                    dado1.Image = Properties.Resources.dice3;
                    break;
                case 4:
                    dado1.Image = Properties.Resources.dice4;
                    break;
                case 5:
                    dado2.Image = Properties.Resources.dice5;
                    break;
                case 6:
                    dado1.Image = Properties.Resources.dice6;
                    break;
            }
        }

        private void jogar2_Click(object sender, EventArgs e)
        {
            int valor_dado2;
            valor_dado2 = rdnDado.Next(1, 7);
            switch (valor_dado2)
            {
                case 1:
                    dado2.Image = Properties.Resources.dice1;
                    break;
                case 2:
                    dado2.Image = Properties.Resources.dice2;
                    break;
                case 3:
                    dado2.Image = Properties.Resources.dice3;
                    break;
                case 4:
                    dado2.Image = Properties.Resources.dice4;
                    break;
                case 5:
                    dado2.Image = Properties.Resources.dice5;
                    break;
                case 6:
                    dado2.Image = Properties.Resources.dice6;
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade1___PI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            pnlPersonagem.Top = pnlPersonagem.Top - 20;

            if (pnlPersonagem.Left >= 500 && pnlPersonagem.Top <= 20)
            {
                MessageBox.Show("Você ganhou");
            }
        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            pnlPersonagem.Left = pnlPersonagem.Left - 20;

            if (pnlPersonagem.Left >= 500 && pnlPersonagem.Top <= 20)
            {
                MessageBox.Show("Você ganhou");
            }
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            pnlPersonagem.Top = pnlPersonagem.Top + 20;

            if (pnlPersonagem.Left >= 500 && pnlPersonagem.Top <= 20)
            {
                MessageBox.Show("Você ganhou");
            }
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            pnlPersonagem.Left = pnlPersonagem.Left + 20;

            if (pnlPersonagem.Left >= 500 && pnlPersonagem.Top <= 20)
            {
                MessageBox.Show("Você ganhou");
            }
        }
    }
}

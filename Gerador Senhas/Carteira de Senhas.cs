using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_Senhas
{
    public partial class Carteira_de_Senhas : Form
    {
        public Carteira_de_Senhas()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Painel f = new Painel();
            this.Close();
            this.Hide();
            f.ShowDialog();
        }

        private void BtnCarteira_Click(object sender, EventArgs e)
        {
            Carteira_de_Passwordes f = new Carteira_de_Passwordes();
            f.ShowDialog();
            this.Hide();
        }

        private void BtnPassword_Click(object sender, EventArgs e)
        {
            Porta_Passwordes f = new Porta_Passwordes();
            this.Hide();
            f.ShowDialog();
        }
    }
}

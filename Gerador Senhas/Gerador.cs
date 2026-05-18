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
    public partial class Gerador : Form
    {
        public Gerador()
        {
            InitializeComponent();
            // Define o caractere de máscara para a senha
            txtPass.PasswordChar = '*';
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário e a senha correspondem aos valores esperados
            if (txtUser.Text == "Admin" && txtPass.Text == "12345678")
            {
                // Exibe mensagem de sucesso
                LblEstado.Text = "Login efectuado com sucesso";
                LblEstado.ForeColor = Color.Green; // Opcional: muda a cor para verde

                // Abre o novo formulário (Painel)
                Painel f = new Painel();
                f.Show(); // Mostra o novo formulário

                // Esconde o formulário atual
                this.Hide();
            }
            else
            {
                // Caso os dados estejam incorretos
                LblEstado.Text = "Dados errados tente Outravez";
                LblEstado.ForeColor = Color.Red; // Opcional: muda a cor para vermelho
            }
        }

        private void Gerador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            Fechar();
        }
        private void Fechar()
        {
            if (MessageBox.Show("Deseja Sair do Programa?", "Sair", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.No)return;
            Application.Exit();
        }
    }
}
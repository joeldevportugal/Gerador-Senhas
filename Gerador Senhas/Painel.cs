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
    public partial class Painel : Form
    {
        public Painel()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            
            Gerador f = new Gerador();
            this.Close();
            this.Hide();
            f.ShowDialog();
        }

        private void BtnAcerca_Click(object sender, EventArgs e)
        {
            Acerca f = new Acerca();
            this.Hide();
            f.ShowDialog();
        }

        private void Painel_Load(object sender, EventArgs e)
        {
            // Chamamos logo ao abrir para não esperar 1 segundo pelo Timer
            AtualizarRelogio();
        }
        // Este é o evento do Timer que criámos no passo anterior
        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizarRelogio();
        }
        private void AtualizarRelogio()
        {
            DateTime agora = DateTime.Now;
            string saudacao;
            int hora = agora.Hour;

            // Lógica de saudação
            if (hora >= 5 && hora < 12)
                saudacao = "Bom dia";
            else if (hora >= 12 && hora < 18)
                saudacao = "Boa tarde";
            else
                saudacao = "Boa noite";

            // HH:mm:ss formata para Horas:Minutos:Segundos com dois dígitos
            LblSaudação.Text = $"{saudacao} Admin, são {agora:HH:mm:ss}";
        }

        private void BtnGerador_Click(object sender, EventArgs e)
        {
            Senhas f = new Senhas();
            this.Hide();
            f.ShowDialog();
        }

        private void Btntestar_Click(object sender, EventArgs e)
        {
            Testador_do_Password f = new Testador_do_Password();
            this.Hide();
            f.ShowDialog();
        }

        private void BtnCarterira_Click(object sender, EventArgs e)
        {
            Carteira_de_Senhas f = new Carteira_de_Senhas();
            this.Hide();
            f.ShowDialog();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do Programa?", "Programa", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)return;
            Application.Exit();
        }
    }
}

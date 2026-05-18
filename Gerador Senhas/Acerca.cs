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
    public partial class Acerca : Form
    {
        public Acerca()
        {
            InitializeComponent();
        }

        private void Acerca_Load(object sender, EventArgs e)
        {
            // Configuração do Título da Janela
            this.Text = "Sobre o SafePass Pro";

            // Definição da string com a informação do projeto
            string informacao =
                "SISTEMA DE GESTÃO DE SENHAS v1.0\n" +
                "----------------------------------------------------------\n\n" +
                "PROJETO: Plano de Negócio (200H)\n" +
                "DESENVOLVEDOR: Joel António Gonçalves Tigeleiro\n\n" +
                "SOBRE O SOFTWARE:\n" +
                "Este software foi desenhado para elevar o padrão de segurança digital.\n\n" +
                "Inclui um Gerador de Senhas robusto, um Analisador de Força (Segurança)\n\n" +
                "e uma Carteira Encriptada para armazenamento seguro.\n\n" +
                "FUNCIONALIDADES CHAVE:\n" +
                "• Teste de Vulnerabilidade em Tempo Real\n" +
                "• Algoritmos de Aleatoriedade Criptográfica\n" +
                "• Interface Intuitiva para Gestão de Credenciais\n\n" +
                "----------------------------------------------------------\n" +
                "© 2026 - Todos os direitos reservados.";

            // CORREÇÃO: Atribui a variável ao controle para que ela seja "usada"
            // Se o nome da tua Label no Designer for diferente, altera aqui:
            if (LblDescrição != null)
            {
                LblDescrição.Text = informacao;
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Painel f = new Painel();
            this.Close();
            this.Hide();
            f.ShowDialog();
        }
    }
}
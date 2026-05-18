using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_Senhas
{
    public partial class Porta_Passwordes : Form
    {
        //Aqui Temos a String de Coneção a base de dados 
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Dados;Trusted_Connection=True;";
        public Porta_Passwordes()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Carteira_de_Senhas f = new Carteira_de_Senhas();
            f.ShowDialog();
            this.Close();
        }

        // BOTÃO CARREGAR (cria tabela, guarda senha e carrega lista)
        private async void Carregar_Click(object sender, EventArgs e)
        {
            LblEstado.Text = "A carregar...";
            progressBar1.Value = 0;

            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                LblEstado.Text = $"A carregar... {i}%";
                await Task.Delay(15);
            }

            CriarTabela();
            GuardarPassword();
            CarregarSenhas();

            LblEstado.Text = "Concluído!";
        }
        // CRIA A TABELA SE NÃO EXISTIR
        private void CriarTabela()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string sql = @"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Password' AND xtype='U')
                    CREATE TABLE Password (
                        Id INT IDENTITY(1,1) PRIMARY KEY,
                        Senha NVARCHAR(200)
                    )";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }
        // GUARDA A PASSWORD DIGITADA
        private void GuardarPassword()
        {
            if (string.IsNullOrWhiteSpace(TxtPass.Text))
                return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string sql = "INSERT INTO Password (Senha) VALUES (@senha)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@senha", TxtPass.Text);

                cmd.ExecuteNonQuery();
            }

            TxtPass.Clear();
        }

        // CARREGA AS SENHAS NO LISTBOX E A PRIMEIRA NO TXTCOPIAR
        private void CarregarSenhas()
        {
            LSenhas.Items.Clear();
            txtCopiar.Clear(); // Limpa o campo antes de carregar

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string sql = "SELECT Senha FROM Password";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();

                bool primeiraSenha = true;

                while (dr.Read())
                {
                    string senhaEncontrada = dr["Senha"].ToString();

                    // Adiciona à lista normalmente
                    LSenhas.Items.Add(senhaEncontrada);

                    // Se for a primeira linha do resultado, coloca no TxtCopiar
                    if (primeiraSenha)
                    {
                        txtCopiar.Text = senhaEncontrada;
                        primeiraSenha = false; // Garante que as seguintes apenas vão para a lista
                    }
                }
            }
        }


        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            try
            {
                // 1. Verifica se o campo TxtCopiar tem algum texto
                if (!string.IsNullOrWhiteSpace(txtCopiar.Text))
                {
                    // 2. Copia o texto para a Área de Transferência (Clipboard)
                    Clipboard.SetText(txtCopiar.Text);

                    // 3. Exibe mensagem de sucesso
                    LblEstado.Text = "Copiado para a área de transferência!";
                }
                else
                {
                    // Caso o campo esteja vazio
                    LblEstado.Text = "Erro: Nada para copiar.";
                }
            }
            catch (Exception ex)
            {
                // 4. Caso ocorra algum erro inesperado (ex: falha no sistema de clipboard)
                LblEstado.Text = "Erro ao copiar dados.";
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BOTÃO VER (apenas carrega as senhas)
        private async void Btn_ver_Click(object sender, EventArgs e)
        {
            LblEstado.Text = "A carregar senhas...";
            progressBar1.Value = 0;

            // Loop da barra de progresso
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                LblEstado.Text = $"A carregar senhas... {i}%";
                await Task.Delay(15);
            }

            // Chama o método que vai à base de dados
            CarregarSenhas();

            // VERIFICAÇÃO: Se após carregar, a lista continuar vazia
            if (LSenhas.Items.Count == 0)
            {
                LblEstado.Text = "Aviso: Sem dados.";
                MessageBox.Show("Não existem senhas em Dbo Passwordes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LblEstado.Text = "Senhas carregadas!";
                LblEstado.BackColor = Color.Green;
                LblEstado.ForeColor = Color.White;
            }
        }

        private async Task BtnLimpar_Dados_ClickAsync(object sender, EventArgs e)
        {
            // Confirmação para evitar desastres
            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja apagar todos os dados de [dbo].[Password]?",
                "Confirmar Limpeza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                LblEstado.Text = "A eliminar registos...";
                progressBar1.Value = 0;

                // Feedback visual da barra
                for (int i = 0; i <= 100; i += 25)
                {
                    progressBar1.Value = i;
                    await Task.Delay(10);
                }

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        // Usamos [dbo].[Password] para evitar conflitos com palavras do sistema
                        string sql = "DELETE FROM [dbo].[Password]";

                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                    }

                    LblEstado.Text = "Tabela limpa com sucesso!";
                    progressBar1.Value = 100;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao aceder à tabela [dbo].[Password]: " + ex.Message);
                    LblEstado.Text = "Erro na operação.";
                    progressBar1.Value = 0;
                }
            }
        }


        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            Limpar();
        }

        private void Limpar()
        {
            // Verifica se a lista tem itens OU se as caixas de texto têm conteúdo
            if (LSenhas.Items.Count > 0 || !string.IsNullOrEmpty(TxtPass.Text) || !string.IsNullOrEmpty(txtCopiar.Text))
            {
                // AÇÃO DE LIMPEZA
                txtCopiar.Text = string.Empty;
                TxtPass.Text = string.Empty;
                LSenhas.Items.Clear();

                // Opcional: Adicionar o cabeçalho se desejar
                // LSenhas.Items.Add("LSenhas"); 

                progressBar1.Value = 0;

                // Feedback de Sucesso
                LblEstado.Text = "Dados Limpos Com sucesso!";
                LblEstado.BackColor = Color.Green;
                LblEstado.ForeColor = Color.White;
            }
            else
            {
                // Feedback de Erro (caso já esteja tudo vazio)
                LblEstado.Text = "Não existe dados para Limpar!";
                LblEstado.BackColor = Color.Red;
                LblEstado.ForeColor = Color.White;
            }
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            // 1. Verifica se existem senhas para exportar
            if (LSenhas.Items.Count == 0)
            {
                LblEstado.Text = "Erro: Lista vazia!";
                MessageBox.Show("Não existem senhas na lista para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Configura a janela de guardar arquivo
            SaveFileDialog salvarArquivo = new SaveFileDialog();
            salvarArquivo.Filter = "Arquivo de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
            salvarArquivo.Title = "Exportar Senhas";
            salvarArquivo.FileName = "MinhasSenhas.txt";

            // 3. Abre a janela e verifica se o utilizador clicou em "Guardar"
            if (salvarArquivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Criamos uma lista de strings com o conteúdo do ListBox
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(salvarArquivo.FileName))
                    {
                        foreach (var item in LSenhas.Items)
                        {
                            sw.WriteLine(item.ToString());
                        }
                    }

                    LblEstado.Text = "Exportado com sucesso!";
                    MessageBox.Show("As senhas foram guardadas com sucesso!", "Exportação concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    LblEstado.Text = "Erro ao exportar.";
                    MessageBox.Show("Erro técnico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnLimpar_Dados_Click(object sender, EventArgs e)
        {
            // Confirmação para evitar desastres
            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja apagar todos os dados de [dbo].[Password]?",
                "Confirmar Limpeza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                LblEstado.Text = "A eliminar registos...";
                progressBar1.Value = 0;

                // Feedback visual da barra
                for (int i = 0; i <= 100; i += 25)
                {
                    progressBar1.Value = i;
                    await Task.Delay(10);
                }

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        // Usamos [dbo].[Password] para evitar conflitos com palavras do sistema
                        string sql = "DELETE FROM [dbo].[Password]";

                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                    }

                    LblEstado.Text = "Tabela limpa com sucesso!";
                    progressBar1.Value = 100;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao aceder à tabela [dbo].[Password]: " + ex.Message);
                    LblEstado.Text = "Erro na operação.";
                    progressBar1.Value = 0;
                }
            }
        }

        private void BtnTopo_Click(object sender, EventArgs e)
        {
            // 1. Verifica se existem itens na lista
            if (LSenhas.Items.Count == 0)
            {
                LblEstado.Text = "A lista está vazia.";
                return;
            }

            // 2. Se nada estiver selecionado, começa pelo último item
            if (LSenhas.SelectedIndex == -1)
            {
                LSenhas.SelectedIndex = LSenhas.Items.Count - 1;
            }
            // 3. Se já estiver no primeiro item (índice 0)
            else if (LSenhas.SelectedIndex == 0)
            {
                LblEstado.Text = "Você está no início";
            }
            // 4. Caso contrário, sobe um degrau (decrementa o índice)
            else
            {
                LSenhas.SelectedIndex--;
                LblEstado.Text = "A subir...";
            }

            // 5. Mostra a senha selecionada no TxtCopiar
            if (LSenhas.SelectedItem != null)
            {
                txtCopiar.Text = LSenhas.SelectedItem.ToString();
            }
        }

        private void BtnBaixo_Click(object sender, EventArgs e)
        {
            // 1. Verifica se existem itens na lista para evitar erros
            if (LSenhas.Items.Count == 0)
            {
                LblEstado.Text = "A lista está vazia.";
                return;
            }

            // 2. Define o limite máximo (o índice do último item)
            int ultimoIndice = LSenhas.Items.Count - 1;

            // 3. Se nada estiver selecionado, começa pelo primeiro item (índice 0)
            if (LSenhas.SelectedIndex == -1)
            {
                LSenhas.SelectedIndex = 0;
            }
            // 4. Se já estiver no último item
            else if (LSenhas.SelectedIndex >= ultimoIndice)
            {
                LblEstado.Text = "Você Chegou ao Fim";
            }
            // 5. Caso contrário, desce um degrau (incrementa o índice)
            else
            {
                LSenhas.SelectedIndex++;
                LblEstado.Text = "A descer...";
            }

            // 6. Mostra a password selecionada no TxtCopiar
            if (LSenhas.SelectedItem != null)
            {
                txtCopiar.Text = LSenhas.SelectedItem.ToString();
            }
        }
    }
}

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
    public partial class Carteira_de_Passwordes : Form
    {
        // String para conectar ao servidor (sem especificar o banco ainda)
        string serverConnection = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True";
        // String completa para a aplicação
        string dbConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Dados;Integrated Security=True";
        public Carteira_de_Passwordes()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Carteira_de_Senhas f = new Carteira_de_Senhas();
            this.Close();
            this.Hide();
            f.ShowDialog();
        }

        private async void BtnCarregar_Click(object sender, EventArgs e)
        {
            // 1. Criar Banco e Tabela se não existirem
            CriarBaseDeDadosSeNaoExistir();

            // 2. Validação de interface
            if (string.IsNullOrWhiteSpace(txtServiço.Text) || string.IsNullOrWhiteSpace(txtUtilizador.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            // 3. Feedback Visual
            LBLEstado.Text = "A Carregar Dados...";
            progressBar1.Value = 0;

            try
            {
                // Simulação da ProgressBar
                for (int i = 0; i <= 100; i += 20)
                {
                    progressBar1.Value = i;
                    LBLEstado.Text = $"A Carregar Dados {i}%";
                    await Task.Delay(100);
                }

                // 4. Inserção dos Dados
                using (SqlConnection conn = new SqlConnection(dbConnection))
                {
                    string sql = "INSERT INTO Utilizadores (Servico, Utilizador, Senha) VALUES (@serv, @user, @pass)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@serv", txtServiço.Text);
                    cmd.Parameters.AddWithValue("@user", txtUtilizador.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }

                // 5. Atualizar ListBox e Finalizar
                LSenhas.Items.Add($"{txtServiço.Text} | {txtUtilizador.Text}| {txtPassword.Text}");
                LBLEstado.Text = "Concluído!";
                MessageBox.Show("Dados guardados com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void CriarBaseDeDadosSeNaoExistir()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(serverConnection))
                {
                    conn.Open();

                    // Cria o Banco de Dados se não existir
                    string sqlDb = "IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Dados') CREATE DATABASE Dados";
                    using (SqlCommand cmd = new SqlCommand(sqlDb, conn)) { cmd.ExecuteNonQuery(); }
                }

                using (SqlConnection conn = new SqlConnection(dbConnection))
                {
                    conn.Open();

                    // Cria a Tabela se não existir
                    string sqlTable = @"
                        IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Utilizadores')
                        CREATE TABLE Utilizadores (
                            Id INT PRIMARY KEY IDENTITY(1,1),
                            Servico NVARCHAR(100),
                            Utilizador NVARCHAR(100),
                            Senha NVARCHAR(100)
                        )";
                    using (SqlCommand cmd = new SqlCommand(sqlTable, conn)) { cmd.ExecuteNonQuery(); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar estrutura: " + ex.Message);
            }
        }

        private async void BtnVer_Click(object sender, EventArgs e)
        {
            LSenhas.Items.Clear();

            try
            {
                // 1. Iniciar progresso
                progressBar1.Value = 0;
                for (int i = 0; i <= 100; i += 10)
                {
                    progressBar1.Value = i;
                    LBLEstado.Text = $"A Carregar Dados: {i}%";
                    await Task.Delay(30);
                }

                // 2. Consultar Base de Dados
                using (SqlConnection conn = new SqlConnection(dbConnection))
                {
                    // REMOVIDO "TOP 1" para selecionar tudo
                    string query = "SELECT Servico, Utilizador, Senha FROM Utilizadores ORDER BY Id DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    await conn.OpenAsync();
                    SqlDataReader reader = await cmd.ExecuteReaderAsync();

                    bool temDados = false;

                    // 3. Usar WHILE para percorrer todas as linhas
                    while (await reader.ReadAsync())
                    {
                        temDados = true;

                        string servico = reader["Servico"].ToString();
                        string utilizador = reader["Utilizador"].ToString();
                        string senha = reader["Senha"].ToString();

                        // 4. Adiciona cada linha à ListBox
                        LSenhas.Items.Add($"{servico} | {utilizador} | {senha}");

                        // Opcional: Mostrar o registo mais recente (o primeiro do loop) nas TextBoxes
                        if (LSenhas.Items.Count == 1)
                        {
                            txtServiço.Text = servico;
                            txtUtilizador.Text = utilizador;
                            txtPassword.Text = senha;
                        }
                    }

                    if (!temDados)
                    {
                        MessageBox.Show("Nenhum dado encontrado na base de dados.");
                    }
                }

                LBLEstado.Text = "Dados Carregados! 100%";
                LBLEstado.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                LBLEstado.Text = "Erro.";
            }
        }

        private void BtnLimpar_dados_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(dbConnection))
                {
                    con.Open();
                    // DELETE remove os registros da tabela Utilizadores
                    string query = "DELETE FROM Utilizadores";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                LBLEstado.Text = "Tabela limpa com sucesso!";
                MessageBox.Show("Os dados da tabela Utilizadores foram apagados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao limpar a tabela: " + ex.Message);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            // Verifica se pelo menos um dos campos tem texto ou se a lista tem itens
            if (!string.IsNullOrWhiteSpace(txtServiço.Text) ||
                !string.IsNullOrWhiteSpace(txtUtilizador.Text) ||
                !string.IsNullOrWhiteSpace(txtPassword.Text) ||
                LSenhas.Items.Count > 0)
            {
                // Caso haja dados: Limpa tudo e dá feedback positivo
                txtServiço.Clear();
                txtUtilizador.Clear();
                txtPassword.Clear();
                LSenhas.Items.Clear();
                progressBar1.Value = 0;

                LBLEstado.Text = "Dados Limpos com sucesso!";
                LBLEstado.BackColor = Color.Green;
                LBLEstado.ForeColor = Color.White; // Para melhor leitura no fundo verde
            }
            else
            {
                // Caso já esteja tudo vazio: Avisa o utilizador
                LBLEstado.Text = "Não há Dados a Limpar!";
                LBLEstado.BackColor = Color.Red;
                LBLEstado.ForeColor = Color.White; // Para melhor leitura no fundo vermelho
            }
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            // 1. Verifica se a lista está vazia antes de abrir a janela de guardar
            if (LSenhas.Items.Count == 0)
            {
                MessageBox.Show("Sem dados a Exportar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do método e não executa o resto
            }

            // Prepara a janela para escolher onde salvar
            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Filter = "Ficheiro de Texto|*.txt";
            salvar.Title = "Exportar Lista de Senhas";
            salvar.DefaultExt = "txt";

            if (salvar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Escreve todos os itens da ListBox no ficheiro escolhido
                    System.IO.File.WriteAllLines(salvar.FileName, LSenhas.Items.Cast<object>().Select(x => x.ToString()));

                    MessageBox.Show("Dados exportados para .txt com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao guardar o ficheiro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_Senhas
{
    public partial class Testador_do_Password : Form
    {
        private bool isLLMReady = false;

        public Testador_do_Password()
        {
            InitializeComponent();

            // CORREÇÃO CRÍTICA: Ativa a segurança moderna para comunicar com a Google
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            picLed.BackColor = Color.Red;
            LBLEstado.Text = "Sistema Pronto";

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Painel f = new Painel();
            this.Close();
            this.Hide();
            f.ShowDialog();
        }

        private void BtnLigar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            isLLMReady = true;
            picLed.BackColor = Color.Green;
            LResultado.Items.Clear();
            LResultado.Items.Add("Sistemas Ativos. Pronto para análise.");
            LBLEstado.Text = "LLM Ligado";
        }

        private void BtnDesligarLLM_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            isLLMReady = false;
            picLed.BackColor = Color.Red;
            LResultado.Items.Clear();
            LResultado.Items.Add("Sistema Desligado.");
            LBLEstado.Text = "LLM DESLIGADO";
            progressBar1.Value = 0;
        }

        private async void BTNTESTAR_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (!isLLMReady)
            {
                MessageBox.Show("Por favor, ligue o sistema primeiro!", "Aviso");
                return;
            }

            string senha = txtPass.Text;
            if (string.IsNullOrWhiteSpace(senha)) return;

            // --- Feedback Visual ---
            LBLEstado.Text = "A iniciar Teste";
            progressBar1.Value = 0;
            LResultado.Items.Clear();

            for (int i = 0; i <= 100; i += 20)
            {
                progressBar1.Value = i;
                LBLEstado.Text = $"A testar... {i}%";
                await Task.Delay(50);
            }

            // 1. Rede Neural (Local)
            float scoreRisco = ExecutarRedeNeural(senha);

            // 2. Gemini (Cloud)
            await ExecutarLLMGemini(senha, scoreRisco);

            LBLEstado.Text = "Teste Concluído";
        }


        private float ExecutarRedeNeural(string pass)
        {
            // Lógica de simulação (Enquanto não completas o Model Builder)
            if (pass.Length < 6) return 0.95f; // Risco muito alto
            if (pass.Length < 10) return 0.50f; // Risco médio
            return 0.10f; // Risco baixo
        }

        private async Task ExecutarLLMGemini(string pass, float risco)
        {
            try
            {
                string nivel = (risco > 0.5) ? "ALTO" : "BAIXO";
                string prompt = $"Aja como um perito em cibersegurança. Analise a senha '{pass}'. " +
                               $"O risco detetado pela rede neural foi de {risco * 100:F1}%. " +
                               "Diga quais os ataques prováveis e dê uma recomendação curta.";

                string respostaIA = await ChamarApiGemini(prompt);

                LResultado.Items.Clear();
                LResultado.Items.Add("--- RELATÓRIO TÉCNICO ---");
                LResultado.Items.Add($"SEGURANÇA: {nivel}");
                LResultado.Items.Add($"RISCO LOCAL: {risco * 100:F1}%");
                LResultado.Items.Add("---------------------------");
                LResultado.Items.Add("ANÁLISE DETALHADA:");

                // Divide o texto para caber na ListBox
                string[] frases = respostaIA.Split(new[] { ". ", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var f in frases)
                {
                    LResultado.Items.Add(f.Trim());
                }
            }
            catch (Exception ex)
            {
                LResultado.Items.Add("ERRO TÉCNICO:");
                LResultado.Items.Add(ex.Message);
            }
        }

        private async Task<string> ChamarApiGemini(string prompt)
        {
            // A tua chave que funciona
            string apiKey = "AIzaSyA-ymuttK587kuwU4qUokMmDDllBCcNV0w";

            // Lista de URLs para tentar (o que a Google te deu e o alternativo)
            string[] urls = {
        $"https://generativelanguage.googleapis.com/v1beta/models/gemini-flash-latest:generateContent?key={apiKey}",
        $"https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key={apiKey}"
    };

            using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(30);
                var requestBody = new { contents = new[] { new { parts = new[] { new { text = prompt } } } } };
                string jsonPayload = JsonConvert.SerializeObject(requestBody);

                foreach (string url in urls)
                {
                    try
                    {
                        var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                        var response = await client.PostAsync(url, content);

                        if (response.IsSuccessStatusCode)
                        {
                            string resJson = await response.Content.ReadAsStringAsync();
                            dynamic data = JsonConvert.DeserializeObject(resJson);
                            return data.candidates[0].content.parts[0].text;
                        }
                        // Se der NotFound ou ServiceUnavailable, ele continua o ciclo e tenta o próximo URL
                    }
                    catch { continue; }
                }

                return "Erro: Não foi possível comunicar com os modelos da Google. Verifique a sua ligação ou a validade da chave no AI Studio.";
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            Limpar();
        }
        private void Limpar()
        {
            // Se a caixa de texto NÃO estiver vazia, limpa tudo
            if (txtPass.Text != "")
            {
                txtPass.Text = "";
                LResultado.Items.Clear();
                picLed.BackColor = Color.Red;
                progressBar1.Value = 0;
                LBLEstado.Text = "Dados limpos com sucesso!";
            }
            // Caso contrário (se já estiver tudo limpo)
            else
            {
                LBLEstado.Text = "Os campos já estão vazios.";
            }
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            // 1. Configurar a janela de guardar ficheiro
            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Filter = "Ficheiro de Texto|*.txt";
            salvar.Title = "Guardar Relatório";
            salvar.FileName = "Relatorio_Senhas.txt"; // Nome sugerido

            // 2. Abrir a janela e verificar se o utilizador clicou em "Guardar"
            if (salvar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 3. Criar um escritor de ficheiros para o caminho escolhido
                    using (System.IO.StreamWriter escritor = new System.IO.StreamWriter(salvar.FileName))
                    {
                        // 4. Percorrer cada item da ListBox e escrever no ficheiro
                        foreach (var item in LResultado.Items)
                        {
                            escritor.WriteLine(item.ToString());
                        }
                    }

                    MessageBox.Show("Relatório exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exportar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

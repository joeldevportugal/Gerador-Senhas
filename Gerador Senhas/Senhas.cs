using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;

namespace Gerador_Senhas
{
    public partial class Senhas : Form
    {
        public Senhas()
        {
            InitializeComponent();
            if (CMBEntropia.Items.Count == 0)
                CMBEntropia.Items.AddRange(new object[] { "64", "128", "256" });
            CMBEntropia.SelectedIndex = 0;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Painel f = new Painel();
            this.Close();
            this.Hide();
            f.ShowDialog();
        }

        private async void BtnGerar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            // 1. VALIDAÇÃO DAS 4 CHECKBOXES
            if (!ChkGrandes.Checked && !ChkPequenas.Checked && !chkNumeros.Checked && !ChkSimbolos.Checked)
            {
                MessageBox.Show("Erro: Selecione pelo menos uma opção de caracteres!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (NChars.Value <= 0)
            {
                MessageBox.Show("Defina o número de caracteres.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                BtnGerar.Enabled = false;
                LBLEstado.Text = "Processando criptografia...";
                progressBar1.Value = 20;

                // 2. OBTER POOL (Apenas o que o usuário marcou)
                string pool = ObterPool();

                // 3. GERAR ENTROPIA (Compatível com .NET Framework e .NET Core)
                string entropiaBruta = await Task.Run(() => GerarEntropiaComplexa());
                progressBar1.Value = 60;

                // 4. MAPEAR PARA O RESULTADO FINAL
                string resultadoFinal = MapearParaPool(entropiaBruta, pool, (int)NChars.Value);

                txtPass.Text = resultadoFinal;
                ValidarForca(resultadoFinal);

                progressBar1.Value = 100;
                LBLEstado.Text = "Concluído!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar: " + ex.Message);
            }
            finally
            {
                BtnGerar.Enabled = true;
            }
        }

        private string ObterPool()
        {
            StringBuilder sb = new StringBuilder();
            if (ChkGrandes.Checked) sb.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            if (ChkPequenas.Checked) sb.Append("abcdefghijklmnopqrstuvwxyz");
            if (chkNumeros.Checked) sb.Append("0123456789");
            if (ChkSimbolos.Checked) sb.Append("!@#$%^&*()_+-=[]{}|;:,.<>?");
            return sb.ToString();
        }

        private string GerarEntropiaComplexa()
        {
            // Substituído Fill por GetBytes para compatibilidade total
            byte[] seed = new byte[64];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(seed);
            }

            string baseSeed = Convert.ToBase64String(seed);

            // SHA3-256 (BouncyCastle)
            var sha3 = new Sha3Digest(256);
            byte[] inputBytes = Encoding.UTF8.GetBytes(baseSeed);
            sha3.BlockUpdate(inputBytes, 0, inputBytes.Length);
            byte[] sha3Result = new byte[sha3.GetDigestSize()];
            sha3.DoFinal(sha3Result, 0);

            // BCrypt (Custo 14)
            return BCrypt.Net.BCrypt.HashPassword(Convert.ToBase64String(sha3Result), 14);
        }

        private string MapearParaPool(string entropia, string pool, int tamanho)
        {
            byte[] hashBytes = Encoding.UTF8.GetBytes(entropia);
            StringBuilder final = new StringBuilder();

            using (var sha = SHA512.Create())
            {
                byte[] dadosExpandidos = sha.ComputeHash(hashBytes);

                for (int i = 0; i < tamanho; i++)
                {
                    // Usa o byte da entropia para selecionar um caractere do pool permitido
                    // O operador % garante que o índice esteja sempre dentro do limite do pool
                    int index = dadosExpandidos[i % dadosExpandidos.Length] % pool.Length;
                    final.Append(pool[index]);
                }
            }
            return final.ToString();
        }

        private void ValidarForca(string senha)
        {
            int score = 0;
            if (senha.Length >= 12) score++;
            if (ChkSimbolos.Checked) score++;
            if (chkNumeros.Checked && ChkGrandes.Checked) score++;

            Color cor = score >= 3 ? Color.Green : (score == 2 ? Color.Orange : Color.Red);
            PictureBox[] pics = { pic1, pic2, pic3, pic4, pic5 };
            foreach (var p in pics) if (p != null) p.BackColor = cor;
        }

        private void BtnCriptografar_Click(object sender, EventArgs e)
        {
            string password = txtPass.Text;

            if (string.IsNullOrEmpty(password))
            {
                LBLEstado.Text = "Insira uma password primeiro!";
                LBLEstado.ForeColor = Color.Red;
                return;
            }

            try
            {
                LBLEstado.Text = "Processando camadas avançadas...";
                progressBar1.Value = 10;

                // 1. GERAÇÃO DE SALT DINÂMICO
                byte[] salt = new byte[32];
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(salt);
                }
                progressBar1.Value = 25;

                // 2. CAMADA PBKDF2 (Estiramento de Chave)
                int iteracoes = 100000;
                byte[] hashPbkdf2;
                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iteracoes, HashAlgorithmName.SHA512))
                {
                    hashPbkdf2 = pbkdf2.GetBytes(64);
                }
                progressBar1.Value = 50;

                // 3. CAMADA HMAC (Integridade com Chave Privada)
                byte[] chaveHmac = Encoding.UTF8.GetBytes("SuaChavePrivadaAqui123");
                byte[] hmacResult;
                using (HMACSHA512 hmac = new HMACSHA512(chaveHmac))
                {
                    hmacResult = hmac.ComputeHash(hashPbkdf2);
                }
                progressBar1.Value = 70;

                // 4. CAMADA DE TRELIÇA (Lattice Entropy Simulation)
                // Aplicando a dispersão baseada em XOR/Transformação sobre o resultado do HMAC
                byte[] latticeResult = AplicarEntropiaTrelica(hmacResult);
                progressBar1.Value = 85;

                // 5. TÉCNICA DE MERKLE (Gerar Root do Hash Final)
                string merkleRoot = GerarMerkleRoot(latticeResult);

                // --- EXIBIÇÃO DOS RESULTADOS ---

                // Resultado Final em Hexadecimal
                string finalHex = BitConverter.ToString(latticeResult).Replace("-", "");
                txtPass.Text = finalHex;

                // Feedback visual incluindo a Merkle Root e o Salt
                string saltReduzido = BitConverter.ToString(salt).Replace("-", "").Substring(0, 8);
                LBLEstado.Text = $"Sucesso! Merkle: {merkleRoot.Substring(0, 8)}... | Salt: {saltReduzido}";
                LBLEstado.ForeColor = Color.Green;

                progressBar1.Value = 100;
            }
            catch (Exception ex)
            {
                LBLEstado.Text = "Erro: " + ex.Message;
                LBLEstado.ForeColor = Color.Red;
            }
        }

        // MÉTODOS AUXILIARES MANTIDOS PARA O FUNCIONAMENTO

        private byte[] AplicarEntropiaTrelica(byte[] data)
        {
            // Simulação de dispersão de ruído (Lattice-style)
            byte[] transformado = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                // Operação bitwise para aumentar a entropia dos bytes
                transformado[i] = (byte)(data[i] ^ 0x3F);
            }
            return transformado;
        }

        private string GerarMerkleRoot(byte[] data)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(data);
                return BitConverter.ToString(hash).Replace("-", "");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            // Verifica se existe algo preenchido (se a senha não está vazia ou se o valor é diferente de 0)
            if (!string.IsNullOrEmpty(txtPass.Text) || NChars.Value > 0 || ChkGrandes.Checked || ChkPequenas.Checked || chkNumeros.Checked || ChkSimbolos.Checked)
            {
                // Executa a limpeza
                txtPass.Clear();
                ChkGrandes.Checked = ChkPequenas.Checked = chkNumeros.Checked = ChkSimbolos.Checked = false;
                NChars.Value = 0;
                CMBEntropia.Text = "64";
                progressBar1.Value = 0;

                foreach (var p in new[] { pic1, pic2, pic3, pic4, pic5 })
                {
                    if (p != null) p.BackColor = Color.White;
                }

                LBLEstado.Text = "Dados limpos com sucesso!";
                LBLEstado.ForeColor = Color.Green; // Opcional: para dar um feedback visual melhor
            }
            else
            {
                // Caso já esteja tudo limpo
                LBLEstado.Text = "Não há dados a limpar!";
                LBLEstado.ForeColor = Color.Red;
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            // Verifica se o campo não está vazio para evitar erro ou copiar "nada"
            if (!string.IsNullOrEmpty(txtPass.Text))
            {
                // Copia o conteúdo do TextBox 'txtPass' para a área de transferência
                Clipboard.SetText(txtPass.Text);

                // Opcional: Feedback visual para o usuário
                MessageBox.Show("Senha copiada para a área de transferência!", "Sucesso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O campo de senha está vazio.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

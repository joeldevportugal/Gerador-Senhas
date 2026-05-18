namespace Gerador_Senhas
{
    partial class Porta_Passwordes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Porta_Passwordes));
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.txtCopiar = new System.Windows.Forms.TextBox();
            this.BtnCarregar = new System.Windows.Forms.Button();
            this.BtnCopiar = new System.Windows.Forms.Button();
            this.LSenhas = new System.Windows.Forms.ListBox();
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnLimpar_Dados = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.LblEstado = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnTopo = new System.Windows.Forms.Button();
            this.BtnBaixo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtPass
            // 
            this.TxtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(12, 12);
            this.TxtPass.Multiline = true;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(594, 35);
            this.TxtPass.TabIndex = 0;
            // 
            // txtCopiar
            // 
            this.txtCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopiar.Location = new System.Drawing.Point(12, 69);
            this.txtCopiar.Multiline = true;
            this.txtCopiar.Name = "txtCopiar";
            this.txtCopiar.Size = new System.Drawing.Size(594, 35);
            this.txtCopiar.TabIndex = 1;
            // 
            // BtnCarregar
            // 
            this.BtnCarregar.BackColor = System.Drawing.Color.Coral;
            this.BtnCarregar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnCarregar.FlatAppearance.BorderSize = 0;
            this.BtnCarregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarregar.Location = new System.Drawing.Point(612, 12);
            this.BtnCarregar.Name = "BtnCarregar";
            this.BtnCarregar.Size = new System.Drawing.Size(115, 35);
            this.BtnCarregar.TabIndex = 2;
            this.BtnCarregar.Text = "Carregar";
            this.BtnCarregar.UseVisualStyleBackColor = false;
            this.BtnCarregar.Click += new System.EventHandler(this.Carregar_Click);
            // 
            // BtnCopiar
            // 
            this.BtnCopiar.BackColor = System.Drawing.Color.Coral;
            this.BtnCopiar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnCopiar.FlatAppearance.BorderSize = 0;
            this.BtnCopiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnCopiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopiar.Location = new System.Drawing.Point(612, 69);
            this.BtnCopiar.Name = "BtnCopiar";
            this.BtnCopiar.Size = new System.Drawing.Size(115, 35);
            this.BtnCopiar.TabIndex = 3;
            this.BtnCopiar.Text = "Copiar";
            this.BtnCopiar.UseVisualStyleBackColor = false;
            this.BtnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // LSenhas
            // 
            this.LSenhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSenhas.FormattingEnabled = true;
            this.LSenhas.ItemHeight = 24;
            this.LSenhas.Location = new System.Drawing.Point(12, 119);
            this.LSenhas.Name = "LSenhas";
            this.LSenhas.ScrollAlwaysVisible = true;
            this.LSenhas.Size = new System.Drawing.Size(669, 244);
            this.LSenhas.TabIndex = 4;
            // 
            // BtnVer
            // 
            this.BtnVer.BackColor = System.Drawing.Color.Coral;
            this.BtnVer.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnVer.FlatAppearance.BorderSize = 0;
            this.BtnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer.Location = new System.Drawing.Point(12, 379);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(115, 35);
            this.BtnVer.TabIndex = 5;
            this.BtnVer.Text = "Ver";
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.Btn_ver_Click);
            // 
            // BtnLimpar_Dados
            // 
            this.BtnLimpar_Dados.BackColor = System.Drawing.Color.Coral;
            this.BtnLimpar_Dados.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnLimpar_Dados.FlatAppearance.BorderSize = 0;
            this.BtnLimpar_Dados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnLimpar_Dados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnLimpar_Dados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar_Dados.Location = new System.Drawing.Point(145, 379);
            this.BtnLimpar_Dados.Name = "BtnLimpar_Dados";
            this.BtnLimpar_Dados.Size = new System.Drawing.Size(115, 35);
            this.BtnLimpar_Dados.TabIndex = 6;
            this.BtnLimpar_Dados.Text = "Limpar Dados";
            this.BtnLimpar_Dados.UseVisualStyleBackColor = false;
            this.BtnLimpar_Dados.Click += new System.EventHandler(this.BtnLimpar_Dados_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Coral;
            this.BtnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnLimpar.FlatAppearance.BorderSize = 0;
            this.BtnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Location = new System.Drawing.Point(278, 379);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(115, 35);
            this.BtnLimpar.TabIndex = 7;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Coral;
            this.BtnSair.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Location = new System.Drawing.Point(412, 379);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(115, 35);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.BackColor = System.Drawing.Color.Coral;
            this.BtnExportar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnExportar.FlatAppearance.BorderSize = 0;
            this.BtnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportar.Location = new System.Drawing.Point(566, 379);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(115, 35);
            this.BtnExportar.TabIndex = 9;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.UseVisualStyleBackColor = false;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // LblEstado
            // 
            this.LblEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.ForeColor = System.Drawing.Color.White;
            this.LblEstado.Location = new System.Drawing.Point(12, 430);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(715, 26);
            this.LblEstado.TabIndex = 10;
            this.LblEstado.Text = "Estado";
            this.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 463);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(717, 10);
            this.progressBar1.TabIndex = 11;
            // 
            // BtnTopo
            // 
            this.BtnTopo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnTopo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnTopo.FlatAppearance.BorderSize = 0;
            this.BtnTopo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnTopo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnTopo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTopo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTopo.Location = new System.Drawing.Point(687, 119);
            this.BtnTopo.Name = "BtnTopo";
            this.BtnTopo.Size = new System.Drawing.Size(42, 126);
            this.BtnTopo.TabIndex = 12;
            this.BtnTopo.Text = "^";
            this.BtnTopo.UseVisualStyleBackColor = false;
            this.BtnTopo.Click += new System.EventHandler(this.BtnTopo_Click);
            // 
            // BtnBaixo
            // 
            this.BtnBaixo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBaixo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBaixo.FlatAppearance.BorderSize = 0;
            this.BtnBaixo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBaixo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBaixo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBaixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBaixo.Location = new System.Drawing.Point(687, 251);
            this.BtnBaixo.Name = "BtnBaixo";
            this.BtnBaixo.Size = new System.Drawing.Size(42, 112);
            this.BtnBaixo.TabIndex = 13;
            this.BtnBaixo.Text = "v";
            this.BtnBaixo.UseVisualStyleBackColor = false;
            this.BtnBaixo.Click += new System.EventHandler(this.BtnBaixo_Click);
            // 
            // Porta_Passwordes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 480);
            this.ControlBox = false;
            this.Controls.Add(this.BtnBaixo);
            this.Controls.Add(this.BtnTopo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnLimpar_Dados);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.LSenhas);
            this.Controls.Add(this.BtnCopiar);
            this.Controls.Add(this.BtnCarregar);
            this.Controls.Add(this.txtCopiar);
            this.Controls.Add(this.TxtPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Porta_Passwordes";
            this.Text = "Porta_Passwordes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.TextBox txtCopiar;
        private System.Windows.Forms.Button BtnCarregar;
        private System.Windows.Forms.Button BtnCopiar;
        private System.Windows.Forms.ListBox LSenhas;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnLimpar_Dados;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnTopo;
        private System.Windows.Forms.Button BtnBaixo;
    }
}
namespace Gerador_Senhas
{
    partial class Carteira_de_Passwordes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carteira_de_Passwordes));
            this.label1 = new System.Windows.Forms.Label();
            this.txtServiço = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUtilizador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.BtnCarregar = new System.Windows.Forms.Button();
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LSenhas = new System.Windows.Forms.ListBox();
            this.LBLEstado = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.BtnLimpar_dados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inisira O nome do Serviço";
            // 
            // txtServiço
            // 
            this.txtServiço.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiço.Location = new System.Drawing.Point(12, 40);
            this.txtServiço.Name = "txtServiço";
            this.txtServiço.Size = new System.Drawing.Size(601, 31);
            this.txtServiço.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "insira O Utilizador";
            // 
            // txtUtilizador
            // 
            this.txtUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilizador.Location = new System.Drawing.Point(12, 108);
            this.txtUtilizador.Name = "txtUtilizador";
            this.txtUtilizador.Size = new System.Drawing.Size(601, 31);
            this.txtUtilizador.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Insira A sua Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(12, 182);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(601, 31);
            this.txtPassword.TabIndex = 5;
            // 
            // BtnCarregar
            // 
            this.BtnCarregar.BackColor = System.Drawing.Color.Coral;
            this.BtnCarregar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnCarregar.FlatAppearance.BorderSize = 0;
            this.BtnCarregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarregar.Location = new System.Drawing.Point(12, 226);
            this.BtnCarregar.Name = "BtnCarregar";
            this.BtnCarregar.Size = new System.Drawing.Size(105, 44);
            this.BtnCarregar.TabIndex = 6;
            this.BtnCarregar.Text = "Carregar";
            this.BtnCarregar.UseVisualStyleBackColor = false;
            this.BtnCarregar.Click += new System.EventHandler(this.BtnCarregar_Click);
            // 
            // BtnVer
            // 
            this.BtnVer.BackColor = System.Drawing.Color.Coral;
            this.BtnVer.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnVer.FlatAppearance.BorderSize = 0;
            this.BtnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer.Location = new System.Drawing.Point(143, 226);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(105, 44);
            this.BtnVer.TabIndex = 7;
            this.BtnVer.Text = "Ver";
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Coral;
            this.BtnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnLimpar.FlatAppearance.BorderSize = 0;
            this.BtnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Location = new System.Drawing.Point(266, 226);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(105, 44);
            this.BtnLimpar.TabIndex = 8;
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
            this.BtnSair.Location = new System.Drawing.Point(390, 226);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(105, 44);
            this.BtnSair.TabIndex = 9;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Servico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Utilizador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password";
            // 
            // LSenhas
            // 
            this.LSenhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSenhas.FormattingEnabled = true;
            this.LSenhas.ItemHeight = 20;
            this.LSenhas.Location = new System.Drawing.Point(12, 323);
            this.LSenhas.Name = "LSenhas";
            this.LSenhas.ScrollAlwaysVisible = true;
            this.LSenhas.Size = new System.Drawing.Size(601, 144);
            this.LSenhas.TabIndex = 13;
            // 
            // LBLEstado
            // 
            this.LBLEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEstado.Location = new System.Drawing.Point(123, 473);
            this.LBLEstado.Name = "LBLEstado";
            this.LBLEstado.Size = new System.Drawing.Size(372, 26);
            this.LBLEstado.TabIndex = 14;
            this.LBLEstado.Text = "Estado";
            this.LBLEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(123, 502);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(372, 12);
            this.progressBar1.TabIndex = 15;
            // 
            // BtnExportar
            // 
            this.BtnExportar.BackColor = System.Drawing.Color.Coral;
            this.BtnExportar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnExportar.FlatAppearance.BorderSize = 0;
            this.BtnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportar.Location = new System.Drawing.Point(501, 472);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(112, 41);
            this.BtnExportar.TabIndex = 16;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.UseVisualStyleBackColor = false;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // BtnLimpar_dados
            // 
            this.BtnLimpar_dados.BackColor = System.Drawing.Color.Coral;
            this.BtnLimpar_dados.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnLimpar_dados.FlatAppearance.BorderSize = 0;
            this.BtnLimpar_dados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnLimpar_dados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnLimpar_dados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar_dados.Location = new System.Drawing.Point(12, 474);
            this.BtnLimpar_dados.Name = "BtnLimpar_dados";
            this.BtnLimpar_dados.Size = new System.Drawing.Size(105, 39);
            this.BtnLimpar_dados.TabIndex = 17;
            this.BtnLimpar_dados.Text = "Limpar_dados";
            this.BtnLimpar_dados.UseVisualStyleBackColor = false;
            this.BtnLimpar_dados.Click += new System.EventHandler(this.BtnLimpar_dados_Click);
            // 
            // Carteira_de_Passwordes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 519);
            this.ControlBox = false;
            this.Controls.Add(this.BtnLimpar_dados);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LBLEstado);
            this.Controls.Add(this.LSenhas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnCarregar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUtilizador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServiço);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Carteira_de_Passwordes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carteira_de_Passwordes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServiço;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUtilizador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button BtnCarregar;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox LSenhas;
        private System.Windows.Forms.Label LBLEstado;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.Button BtnLimpar_dados;
    }
}
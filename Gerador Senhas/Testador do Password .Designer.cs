namespace Gerador_Senhas
{
    partial class Testador_do_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Testador_do_Password));
            this.txtPass = new System.Windows.Forms.TextBox();
            this.picLed = new System.Windows.Forms.PictureBox();
            this.BtnLigar = new System.Windows.Forms.Button();
            this.BtnDesligarLLM = new System.Windows.Forms.Button();
            this.BtnTestar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LResultado = new System.Windows.Forms.ListBox();
            this.LBLEstado = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLed)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(12, 12);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(654, 35);
            this.txtPass.TabIndex = 0;
            // 
            // picLed
            // 
            this.picLed.BackColor = System.Drawing.Color.Red;
            this.picLed.Location = new System.Drawing.Point(12, 63);
            this.picLed.Name = "picLed";
            this.picLed.Size = new System.Drawing.Size(58, 27);
            this.picLed.TabIndex = 1;
            this.picLed.TabStop = false;
            // 
            // BtnLigar
            // 
            this.BtnLigar.BackColor = System.Drawing.Color.Coral;
            this.BtnLigar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnLigar.FlatAppearance.BorderSize = 0;
            this.BtnLigar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnLigar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnLigar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLigar.ForeColor = System.Drawing.Color.Black;
            this.BtnLigar.Location = new System.Drawing.Point(12, 105);
            this.BtnLigar.Name = "BtnLigar";
            this.BtnLigar.Size = new System.Drawing.Size(113, 50);
            this.BtnLigar.TabIndex = 2;
            this.BtnLigar.Text = "LIGAR LLM";
            this.BtnLigar.UseVisualStyleBackColor = false;
            this.BtnLigar.Click += new System.EventHandler(this.BtnLigar_Click);
            // 
            // BtnDesligarLLM
            // 
            this.BtnDesligarLLM.BackColor = System.Drawing.Color.Coral;
            this.BtnDesligarLLM.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnDesligarLLM.FlatAppearance.BorderSize = 0;
            this.BtnDesligarLLM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnDesligarLLM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnDesligarLLM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesligarLLM.Location = new System.Drawing.Point(140, 105);
            this.BtnDesligarLLM.Name = "BtnDesligarLLM";
            this.BtnDesligarLLM.Size = new System.Drawing.Size(113, 50);
            this.BtnDesligarLLM.TabIndex = 3;
            this.BtnDesligarLLM.Text = "DESLIGAR LLM";
            this.BtnDesligarLLM.UseVisualStyleBackColor = false;
            this.BtnDesligarLLM.Click += new System.EventHandler(this.BtnDesligarLLM_Click);
            // 
            // BtnTestar
            // 
            this.BtnTestar.BackColor = System.Drawing.Color.Coral;
            this.BtnTestar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnTestar.FlatAppearance.BorderSize = 0;
            this.BtnTestar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnTestar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnTestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTestar.Location = new System.Drawing.Point(273, 105);
            this.BtnTestar.Name = "BtnTestar";
            this.BtnTestar.Size = new System.Drawing.Size(113, 50);
            this.BtnTestar.TabIndex = 4;
            this.BtnTestar.Text = "TESTAR";
            this.BtnTestar.UseVisualStyleBackColor = false;
            this.BtnTestar.Click += new System.EventHandler(this.BTNTESTAR_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Coral;
            this.BtnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnLimpar.FlatAppearance.BorderSize = 0;
            this.BtnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Location = new System.Drawing.Point(407, 105);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(113, 50);
            this.BtnLimpar.TabIndex = 5;
            this.BtnLimpar.Text = "LIMPAR";
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
            this.BtnSair.Location = new System.Drawing.Point(536, 105);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(113, 50);
            this.BtnSair.TabIndex = 6;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LResultado
            // 
            this.LResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LResultado.FormattingEnabled = true;
            this.LResultado.ItemHeight = 24;
            this.LResultado.Location = new System.Drawing.Point(12, 170);
            this.LResultado.Name = "LResultado";
            this.LResultado.ScrollAlwaysVisible = true;
            this.LResultado.Size = new System.Drawing.Size(654, 196);
            this.LResultado.TabIndex = 7;
            // 
            // LBLEstado
            // 
            this.LBLEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEstado.Location = new System.Drawing.Point(8, 379);
            this.LBLEstado.Name = "LBLEstado";
            this.LBLEstado.Size = new System.Drawing.Size(551, 37);
            this.LBLEstado.TabIndex = 8;
            this.LBLEstado.Text = "Estado!";
            this.LBLEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 424);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(550, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // BtnExportar
            // 
            this.BtnExportar.BackColor = System.Drawing.Color.Coral;
            this.BtnExportar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnExportar.FlatAppearance.BorderSize = 0;
            this.BtnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportar.Location = new System.Drawing.Point(565, 375);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(113, 72);
            this.BtnExportar.TabIndex = 10;
            this.BtnExportar.Text = "EXPORTAR";
            this.BtnExportar.UseVisualStyleBackColor = false;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // Testador_do_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 454);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LBLEstado);
            this.Controls.Add(this.LResultado);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnTestar);
            this.Controls.Add(this.BtnDesligarLLM);
            this.Controls.Add(this.BtnLigar);
            this.Controls.Add(this.picLed);
            this.Controls.Add(this.txtPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Testador_do_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testador_de_Password";
            ((System.ComponentModel.ISupportInitialize)(this.picLed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox picLed;
        private System.Windows.Forms.Button BtnLigar;
        private System.Windows.Forms.Button BtnDesligarLLM;
        private System.Windows.Forms.Button BtnTestar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.ListBox LResultado;
        private System.Windows.Forms.Label LBLEstado;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnExportar;
    }
}
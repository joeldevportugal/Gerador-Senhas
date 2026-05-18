namespace Gerador_Senhas
{
    partial class Gerador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerador));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblPass = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(13, 223);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(261, 29);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(12, 295);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(261, 29);
            this.txtPass.TabIndex = 1;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Coral;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(13, 345);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(261, 41);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Location = new System.Drawing.Point(12, 188);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(86, 24);
            this.LblUser.TabIndex = 4;
            this.LblUser.Text = "Utilizador";
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.Location = new System.Drawing.Point(16, 261);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(92, 24);
            this.LblPass.TabIndex = 5;
            this.LblPass.Text = "Password";
            // 
            // LblEstado
            // 
            this.LblEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(13, 442);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(260, 36);
            this.LblEstado.TabIndex = 6;
            this.LblEstado.Text = "Estado";
            this.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Coral;
            this.BtnSair.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(13, 392);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(261, 41);
            this.BtnSair.TabIndex = 7;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Gerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 488);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gerador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecra Login Safe Pass Pro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gerador_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Button BtnSair;
    }
}


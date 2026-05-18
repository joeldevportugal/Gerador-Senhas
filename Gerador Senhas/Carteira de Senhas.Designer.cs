namespace Gerador_Senhas
{
    partial class Carteira_de_Senhas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carteira_de_Senhas));
            this.BtnCarteira = new System.Windows.Forms.Button();
            this.BtnPassword = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCarteira
            // 
            this.BtnCarteira.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCarteira.FlatAppearance.BorderSize = 0;
            this.BtnCarteira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarteira.Image = ((System.Drawing.Image)(resources.GetObject("BtnCarteira.Image")));
            this.BtnCarteira.Location = new System.Drawing.Point(12, 23);
            this.BtnCarteira.Name = "BtnCarteira";
            this.BtnCarteira.Size = new System.Drawing.Size(166, 143);
            this.BtnCarteira.TabIndex = 0;
            this.BtnCarteira.UseVisualStyleBackColor = false;
            this.BtnCarteira.Click += new System.EventHandler(this.BtnCarteira_Click);
            // 
            // BtnPassword
            // 
            this.BtnPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPassword.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPassword.FlatAppearance.BorderSize = 0;
            this.BtnPassword.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPassword.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPassword.Image = ((System.Drawing.Image)(resources.GetObject("BtnPassword.Image")));
            this.BtnPassword.Location = new System.Drawing.Point(184, 23);
            this.BtnPassword.Name = "BtnPassword";
            this.BtnPassword.Size = new System.Drawing.Size(157, 143);
            this.BtnPassword.TabIndex = 1;
            this.BtnPassword.UseVisualStyleBackColor = false;
            this.BtnPassword.Click += new System.EventHandler(this.BtnPassword_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Coral;
            this.BtnSair.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Location = new System.Drawing.Point(264, 192);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(107, 37);
            this.BtnSair.TabIndex = 2;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Carteira_de_Senhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 241);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnPassword);
            this.Controls.Add(this.BtnCarteira);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Carteira_de_Senhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carteira_de_Senhas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCarteira;
        private System.Windows.Forms.Button BtnPassword;
        private System.Windows.Forms.Button BtnSair;
    }
}
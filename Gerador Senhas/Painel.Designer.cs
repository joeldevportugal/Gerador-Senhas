namespace Gerador_Senhas
{
    partial class Painel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painel));
            this.BtnGerador = new System.Windows.Forms.Button();
            this.Btntestar = new System.Windows.Forms.Button();
            this.BtnCarterira = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblSaudação = new System.Windows.Forms.Label();
            this.BtnAcerca = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGerador
            // 
            this.BtnGerador.BackColor = System.Drawing.Color.Coral;
            this.BtnGerador.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnGerador.FlatAppearance.BorderSize = 0;
            this.BtnGerador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnGerador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnGerador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerador.ForeColor = System.Drawing.Color.Black;
            this.BtnGerador.Image = ((System.Drawing.Image)(resources.GetObject("BtnGerador.Image")));
            this.BtnGerador.Location = new System.Drawing.Point(12, 22);
            this.BtnGerador.Name = "BtnGerador";
            this.BtnGerador.Size = new System.Drawing.Size(137, 129);
            this.BtnGerador.TabIndex = 0;
            this.BtnGerador.Text = "Gerador";
            this.BtnGerador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGerador.UseVisualStyleBackColor = false;
            this.BtnGerador.Click += new System.EventHandler(this.BtnGerador_Click);
            // 
            // Btntestar
            // 
            this.Btntestar.BackColor = System.Drawing.Color.Coral;
            this.Btntestar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.Btntestar.FlatAppearance.BorderSize = 0;
            this.Btntestar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.Btntestar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.Btntestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btntestar.Image = ((System.Drawing.Image)(resources.GetObject("Btntestar.Image")));
            this.Btntestar.Location = new System.Drawing.Point(155, 22);
            this.Btntestar.Name = "Btntestar";
            this.Btntestar.Size = new System.Drawing.Size(125, 129);
            this.Btntestar.TabIndex = 1;
            this.Btntestar.Text = "Seguranca";
            this.Btntestar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btntestar.UseVisualStyleBackColor = false;
            this.Btntestar.Click += new System.EventHandler(this.Btntestar_Click);
            // 
            // BtnCarterira
            // 
            this.BtnCarterira.BackColor = System.Drawing.Color.Coral;
            this.BtnCarterira.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnCarterira.FlatAppearance.BorderSize = 0;
            this.BtnCarterira.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnCarterira.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnCarterira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarterira.Image = ((System.Drawing.Image)(resources.GetObject("BtnCarterira.Image")));
            this.BtnCarterira.Location = new System.Drawing.Point(12, 157);
            this.BtnCarterira.Name = "BtnCarterira";
            this.BtnCarterira.Size = new System.Drawing.Size(137, 117);
            this.BtnCarterira.TabIndex = 2;
            this.BtnCarterira.Text = "Carteira";
            this.BtnCarterira.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCarterira.UseVisualStyleBackColor = false;
            this.BtnCarterira.Click += new System.EventHandler(this.BtnCarterira_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Location = new System.Drawing.Point(12, 281);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(268, 32);
            this.BtnLogout.TabIndex = 3;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(293, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LblSaudação
            // 
            this.LblSaudação.AutoSize = true;
            this.LblSaudação.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaudação.Location = new System.Drawing.Point(299, 270);
            this.LblSaudação.Name = "LblSaudação";
            this.LblSaudação.Size = new System.Drawing.Size(0, 20);
            this.LblSaudação.TabIndex = 5;
            // 
            // BtnAcerca
            // 
            this.BtnAcerca.BackColor = System.Drawing.Color.Coral;
            this.BtnAcerca.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnAcerca.FlatAppearance.BorderSize = 0;
            this.BtnAcerca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnAcerca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcerca.Image = ((System.Drawing.Image)(resources.GetObject("BtnAcerca.Image")));
            this.BtnAcerca.Location = new System.Drawing.Point(155, 157);
            this.BtnAcerca.Name = "BtnAcerca";
            this.BtnAcerca.Size = new System.Drawing.Size(125, 117);
            this.BtnAcerca.TabIndex = 6;
            this.BtnAcerca.Text = "Acerca";
            this.BtnAcerca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAcerca.UseVisualStyleBackColor = false;
            this.BtnAcerca.Click += new System.EventHandler(this.BtnAcerca_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnFechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Location = new System.Drawing.Point(12, 319);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(268, 32);
            this.BtnFechar.TabIndex = 7;
            this.BtnFechar.Text = "Fechar Aplicação";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 356);
            this.ControlBox = false;
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnAcerca);
            this.Controls.Add(this.LblSaudação);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnCarterira);
            this.Controls.Add(this.Btntestar);
            this.Controls.Add(this.BtnGerador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Painel";
            this.Text = "Painel Safe Pass Pro";
            this.Load += new System.EventHandler(this.Painel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGerador;
        private System.Windows.Forms.Button Btntestar;
        private System.Windows.Forms.Button BtnCarterira;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblSaudação;
        private System.Windows.Forms.Button BtnAcerca;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnFechar;
    }
}
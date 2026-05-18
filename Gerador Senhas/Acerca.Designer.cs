namespace Gerador_Senhas
{
    partial class Acerca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acerca));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblDescrição = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblDescrição
            // 
            this.LblDescrição.AutoSize = true;
            this.LblDescrição.Location = new System.Drawing.Point(25, 215);
            this.LblDescrição.Name = "LblDescrição";
            this.LblDescrição.Size = new System.Drawing.Size(0, 13);
            this.LblDescrição.TabIndex = 1;
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.Color.Coral;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Location = new System.Drawing.Point(452, 404);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(84, 38);
            this.BtnFechar.TabIndex = 2;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // Acerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 454);
            this.ControlBox = false;
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.LblDescrição);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Acerca";
            this.Text = "Acerca";
            this.Load += new System.EventHandler(this.Acerca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblDescrição;
        private System.Windows.Forms.Button BtnFechar;
    }
}
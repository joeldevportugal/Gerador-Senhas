namespace Gerador_Senhas
{
    partial class Senhas
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.BtnCopiar = new System.Windows.Forms.Button();
            this.ChkGrandes = new System.Windows.Forms.CheckBox();
            this.ChkPequenas = new System.Windows.Forms.CheckBox();
            this.chkNumeros = new System.Windows.Forms.CheckBox();
            this.ChkSimbolos = new System.Windows.Forms.CheckBox();
            this.NChars = new System.Windows.Forms.NumericUpDown();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.BtnCriptografar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.CMBEntropia = new System.Windows.Forms.ComboBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.LBLEstado = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.NChars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(12, 12);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(512, 31);
            this.txtPass.TabIndex = 0;
            // 
            // BtnCopiar
            // 
            this.BtnCopiar.BackColor = System.Drawing.Color.Coral;
            this.BtnCopiar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnCopiar.FlatAppearance.BorderSize = 0;
            this.BtnCopiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnCopiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopiar.Location = new System.Drawing.Point(530, 12);
            this.BtnCopiar.Name = "BtnCopiar";
            this.BtnCopiar.Size = new System.Drawing.Size(93, 31);
            this.BtnCopiar.TabIndex = 1;
            this.BtnCopiar.Text = "Copiar";
            this.BtnCopiar.UseVisualStyleBackColor = false;
            this.BtnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // ChkGrandes
            // 
            this.ChkGrandes.AutoSize = true;
            this.ChkGrandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkGrandes.Location = new System.Drawing.Point(12, 72);
            this.ChkGrandes.Name = "ChkGrandes";
            this.ChkGrandes.Size = new System.Drawing.Size(97, 24);
            this.ChkGrandes.TabIndex = 2;
            this.ChkGrandes.Text = "Grandes";
            this.ChkGrandes.UseVisualStyleBackColor = true;
            // 
            // ChkPequenas
            // 
            this.ChkPequenas.AutoSize = true;
            this.ChkPequenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkPequenas.Location = new System.Drawing.Point(139, 72);
            this.ChkPequenas.Name = "ChkPequenas";
            this.ChkPequenas.Size = new System.Drawing.Size(108, 24);
            this.ChkPequenas.TabIndex = 3;
            this.ChkPequenas.Text = "Pequenas";
            this.ChkPequenas.UseVisualStyleBackColor = true;
            // 
            // chkNumeros
            // 
            this.chkNumeros.AutoSize = true;
            this.chkNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumeros.Location = new System.Drawing.Point(285, 72);
            this.chkNumeros.Name = "chkNumeros";
            this.chkNumeros.Size = new System.Drawing.Size(99, 24);
            this.chkNumeros.TabIndex = 4;
            this.chkNumeros.Text = "Numeros";
            this.chkNumeros.UseVisualStyleBackColor = true;
            // 
            // ChkSimbolos
            // 
            this.ChkSimbolos.AutoSize = true;
            this.ChkSimbolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkSimbolos.Location = new System.Drawing.Point(420, 74);
            this.ChkSimbolos.Name = "ChkSimbolos";
            this.ChkSimbolos.Size = new System.Drawing.Size(101, 24);
            this.ChkSimbolos.TabIndex = 5;
            this.ChkSimbolos.Text = "Simbolos";
            this.ChkSimbolos.UseVisualStyleBackColor = true;
            // 
            // NChars
            // 
            this.NChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NChars.Location = new System.Drawing.Point(559, 68);
            this.NChars.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NChars.Name = "NChars";
            this.NChars.Size = new System.Drawing.Size(64, 29);
            this.NChars.TabIndex = 6;
            // 
            // BtnGerar
            // 
            this.BtnGerar.BackColor = System.Drawing.Color.Coral;
            this.BtnGerar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnGerar.FlatAppearance.BorderSize = 0;
            this.BtnGerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnGerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerar.Location = new System.Drawing.Point(12, 121);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(97, 37);
            this.BtnGerar.TabIndex = 7;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = false;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // BtnCriptografar
            // 
            this.BtnCriptografar.BackColor = System.Drawing.Color.Coral;
            this.BtnCriptografar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnCriptografar.FlatAppearance.BorderSize = 0;
            this.BtnCriptografar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnCriptografar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnCriptografar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCriptografar.Location = new System.Drawing.Point(128, 121);
            this.BtnCriptografar.Name = "BtnCriptografar";
            this.BtnCriptografar.Size = new System.Drawing.Size(93, 37);
            this.BtnCriptografar.TabIndex = 8;
            this.BtnCriptografar.Text = "Criptografar";
            this.BtnCriptografar.UseVisualStyleBackColor = false;
            this.BtnCriptografar.Click += new System.EventHandler(this.BtnCriptografar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Coral;
            this.BtnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnLimpar.FlatAppearance.BorderSize = 0;
            this.BtnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Location = new System.Drawing.Point(244, 121);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(93, 37);
            this.BtnLimpar.TabIndex = 9;
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
            this.BtnSair.Location = new System.Drawing.Point(359, 121);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(93, 37);
            this.BtnSair.TabIndex = 10;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // CMBEntropia
            // 
            this.CMBEntropia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBEntropia.FormattingEnabled = true;
            this.CMBEntropia.Location = new System.Drawing.Point(502, 121);
            this.CMBEntropia.Name = "CMBEntropia";
            this.CMBEntropia.Size = new System.Drawing.Size(121, 32);
            this.CMBEntropia.TabIndex = 11;
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic1.Location = new System.Drawing.Point(12, 178);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(42, 18);
            this.pic1.TabIndex = 12;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic2.Location = new System.Drawing.Point(67, 178);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(42, 18);
            this.pic2.TabIndex = 13;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic3.Location = new System.Drawing.Point(128, 178);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(42, 18);
            this.pic3.TabIndex = 14;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic4.Location = new System.Drawing.Point(188, 178);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(42, 18);
            this.pic4.TabIndex = 15;
            this.pic4.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic5.Location = new System.Drawing.Point(244, 178);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(42, 18);
            this.pic5.TabIndex = 16;
            this.pic5.TabStop = false;
            // 
            // LBLEstado
            // 
            this.LBLEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEstado.ForeColor = System.Drawing.Color.White;
            this.LBLEstado.Location = new System.Drawing.Point(12, 219);
            this.LBLEstado.Name = "LBLEstado";
            this.LBLEstado.Size = new System.Drawing.Size(611, 27);
            this.LBLEstado.TabIndex = 17;
            this.LBLEstado.Text = "Estado";
            this.LBLEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 260);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(611, 13);
            this.progressBar1.TabIndex = 18;
            // 
            // Senhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 283);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LBLEstado);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.CMBEntropia);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCriptografar);
            this.Controls.Add(this.BtnGerar);
            this.Controls.Add(this.NChars);
            this.Controls.Add(this.ChkSimbolos);
            this.Controls.Add(this.chkNumeros);
            this.Controls.Add(this.ChkPequenas);
            this.Controls.Add(this.ChkGrandes);
            this.Controls.Add(this.BtnCopiar);
            this.Controls.Add(this.txtPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Senhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Safe Password 1.0.0.1";
            ((System.ComponentModel.ISupportInitialize)(this.NChars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button BtnCopiar;
        private System.Windows.Forms.CheckBox ChkGrandes;
        private System.Windows.Forms.CheckBox ChkPequenas;
        private System.Windows.Forms.CheckBox chkNumeros;
        private System.Windows.Forms.CheckBox ChkSimbolos;
        private System.Windows.Forms.NumericUpDown NChars;
        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.Button BtnCriptografar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.ComboBox CMBEntropia;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.Label LBLEstado;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
namespace form111
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.zaloguj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.Hasło = new System.Windows.Forms.Label();
            this.zalogujGosc = new System.Windows.Forms.Button();
            this.stworzKonto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zaloguj
            // 
            this.zaloguj.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaloguj.Location = new System.Drawing.Point(241, 272);
            this.zaloguj.Margin = new System.Windows.Forms.Padding(2);
            this.zaloguj.Name = "zaloguj";
            this.zaloguj.Size = new System.Drawing.Size(121, 53);
            this.zaloguj.TabIndex = 0;
            this.zaloguj.Text = "Zaloguj";
            this.zaloguj.UseVisualStyleBackColor = true;
            this.zaloguj.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 129);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(245, 194);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Login.Location = new System.Drawing.Point(170, 128);
            this.Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(46, 19);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login:\r\n";
            this.Login.Click += new System.EventHandler(this.label1_Click);
            // 
            // Hasło
            // 
            this.Hasło.AutoSize = true;
            this.Hasło.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Hasło.Location = new System.Drawing.Point(170, 193);
            this.Hasło.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hasło.Name = "Hasło";
            this.Hasło.Size = new System.Drawing.Size(46, 19);
            this.Hasło.TabIndex = 4;
            this.Hasło.Text = "Haslo:";
            // 
            // zalogujGosc
            // 
            this.zalogujGosc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zalogujGosc.Location = new System.Drawing.Point(106, 272);
            this.zalogujGosc.Margin = new System.Windows.Forms.Padding(2);
            this.zalogujGosc.Name = "zalogujGosc";
            this.zalogujGosc.Size = new System.Drawing.Size(114, 53);
            this.zalogujGosc.TabIndex = 5;
            this.zalogujGosc.Text = "Zaloguj jako gość\r\n";
            this.zalogujGosc.UseVisualStyleBackColor = true;
            this.zalogujGosc.Click += new System.EventHandler(this.zalogujGosc_click);
            // 
            // stworzKonto
            // 
            this.stworzKonto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stworzKonto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stworzKonto.Location = new System.Drawing.Point(385, 272);
            this.stworzKonto.Margin = new System.Windows.Forms.Padding(2);
            this.stworzKonto.Name = "stworzKonto";
            this.stworzKonto.Size = new System.Drawing.Size(119, 53);
            this.stworzKonto.TabIndex = 6;
            this.stworzKonto.Text = "Stwórz konto";
            this.stworzKonto.UseVisualStyleBackColor = false;
            this.stworzKonto.Click += new System.EventHandler(this.button3_click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 72);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteka";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(605, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stworzKonto);
            this.Controls.Add(this.zalogujGosc);
            this.Controls.Add(this.Hasło);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.zaloguj);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel1;

        #endregion

        public System.Windows.Forms.Button zaloguj;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Hasło;
        public System.Windows.Forms.Button zalogujGosc;
        public System.Windows.Forms.Button stworzKonto;
    }
}


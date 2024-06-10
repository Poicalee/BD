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
            zaloguj = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Login = new Label();
            Hasło = new Label();
            zalogujGosc = new Button();
            stworzKonto = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // zaloguj
            // 
            zaloguj.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            zaloguj.Location = new Point(321, 418);
            zaloguj.Name = "zaloguj";
            zaloguj.Size = new Size(161, 82);
            zaloguj.TabIndex = 0;
            zaloguj.Text = "Zaloguj";
            zaloguj.UseVisualStyleBackColor = true;
            zaloguj.Click += btnLogin_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(327, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(327, 298);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Login.ImageAlign = ContentAlignment.BottomLeft;
            Login.Location = new Point(227, 197);
            Login.Name = "Login";
            Login.Size = new Size(60, 23);
            Login.TabIndex = 3;
            Login.Text = "Login:\r\n";
            Login.Click += label1_Click;
            // 
            // Hasło
            // 
            Hasło.AutoSize = true;
            Hasło.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Hasło.Location = new Point(227, 297);
            Hasło.Name = "Hasło";
            Hasło.Size = new Size(60, 23);
            Hasło.TabIndex = 4;
            Hasło.Text = "Hasło:";
            // 
            // zalogujGosc
            // 
            zalogujGosc.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            zalogujGosc.Location = new Point(141, 418);
            zalogujGosc.Name = "zalogujGosc";
            zalogujGosc.Size = new Size(152, 82);
            zalogujGosc.TabIndex = 5;
            zalogujGosc.Text = "Zaloguj jako gość\r\n";
            zalogujGosc.UseVisualStyleBackColor = true;
            zalogujGosc.Click += zalogujGosc_click;
            // 
            // stworzKonto
            // 
            stworzKonto.BackColor = Color.MintCream;
            stworzKonto.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            stworzKonto.Location = new Point(513, 418);
            stworzKonto.Name = "stworzKonto";
            stworzKonto.Size = new Size(159, 82);
            stworzKonto.TabIndex = 6;
            stworzKonto.Text = "Stwórz konto";
            stworzKonto.UseVisualStyleBackColor = false;
            stworzKonto.Click += button3_click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-8, -6);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 111);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(48, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 43);
            label1.TabIndex = 0;
            label1.Text = "Biblioteka";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(807, 602);
            Controls.Add(panel1);
            Controls.Add(stworzKonto);
            Controls.Add(zalogujGosc);
            Controls.Add(Hasło);
            Controls.Add(Login);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(zaloguj);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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


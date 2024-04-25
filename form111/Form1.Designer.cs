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
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.Hasło = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zaloguj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(352, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(352, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 22);
            this.textBox2.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Login.Location = new System.Drawing.Point(226, 167);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(40, 16);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.Click += new System.EventHandler(this.label1_Click);
            // 
            // Hasło
            // 
            this.Hasło.AutoSize = true;
            this.Hasło.Location = new System.Drawing.Point(226, 238);
            this.Hasło.Name = "Hasło";
            this.Hasło.Size = new System.Drawing.Size(46, 16);
            this.Hasło.TabIndex = 4;
            this.Hasło.Text = "Haslo:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Gość";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "Stwórz konto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 481);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Hasło);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Hasło;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
    }
}


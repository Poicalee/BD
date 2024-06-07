namespace form111
{
    partial class Form3
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
            stworz_konto = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Login = new Label();
            label1 = new Label();
            menu = new Button();
            panel1 = new Panel();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // stworz_konto
            // 
            stworz_konto.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            stworz_konto.Location = new Point(209, 411);
            stworz_konto.Name = "stworz_konto";
            stworz_konto.Size = new Size(149, 75);
            stworz_konto.TabIndex = 6;
            stworz_konto.Text = "Stwórz Konto";
            stworz_konto.UseVisualStyleBackColor = true;
            stworz_konto.Click += button_click2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(347, 242);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(347, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 27);
            textBox2.TabIndex = 8;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Login.ImageAlign = ContentAlignment.BottomLeft;
            Login.Location = new Point(261, 166);
            Login.Name = "Login";
            Login.Size = new Size(56, 23);
            Login.TabIndex = 9;
            Login.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(261, 240);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 10;
            label1.Text = "Hasło:";
            // 
            // menu
            // 
            menu.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menu.Location = new Point(460, 411);
            menu.Name = "menu";
            menu.Size = new Size(149, 75);
            menu.TabIndex = 11;
            menu.Text = "Wróć do menu\r\n";
            menu.UseVisualStyleBackColor = true;
            menu.Click += button_click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 97);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.MintCream;
            label2.Location = new Point(47, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 57);
            label2.TabIndex = 0;
            label2.Text = "Biblioteka";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(347, 315);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(181, 27);
            textBox3.TabIndex = 13;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(196, 315);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(144, 37);
            label3.TabIndex = 14;
            label3.Text = "Potwierdź hasło:\r\n";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(800, 563);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(panel1);
            Controls.Add(menu);
            Controls.Add(label1);
            Controls.Add(Login);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(stworz_konto);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Panel panel1;

        #endregion

        public System.Windows.Forms.Button stworz_konto;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button menu;
    }
}
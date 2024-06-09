using System.ComponentModel;

namespace form111
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            panel1 = new Panel();
            menuButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            listViewLogin = new ListView();
            listBox1 = new ListBox();
            usunKonto = new Button();
            wyloguj = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(wyloguj);
            panel1.Controls.Add(menuButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1281, 108);
            panel1.TabIndex = 0;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.MintCream;
            menuButton.FlatAppearance.BorderColor = Color.MintCream;
            menuButton.FlatStyle = FlatStyle.System;
            menuButton.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuButton.Location = new Point(1009, 18);
            menuButton.Margin = new Padding(2, 3, 2, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(111, 60);
            menuButton.TabIndex = 13;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(58, 29);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 52);
            label1.TabIndex = 0;
            label1.Text = "Biblioteka";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(63, 167);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 36);
            label2.TabIndex = 1;
            label2.Text = "Login:\r\n";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(63, 228);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(193, 36);
            label4.TabIndex = 3;
            label4.Text = "Wypożyczone książki:";
            label4.Click += label4_Click;
            // 
            // listViewLogin
            // 
            listViewLogin.Location = new Point(245, 167);
            listViewLogin.Margin = new Padding(5, 4, 5, 4);
            listViewLogin.Name = "listViewLogin";
            listViewLogin.Size = new Size(191, 28);
            listViewLogin.TabIndex = 5;
            listViewLogin.UseCompatibleStateImageBehavior = false;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Microsoft YaHei", 9.75F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(63, 313);
            listBox1.Margin = new Padding(5, 4, 5, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1107, 529);
            listBox1.TabIndex = 6;
            // 
            // usunKonto
            // 
            usunKonto.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            usunKonto.Location = new Point(1019, 192);
            usunKonto.Margin = new Padding(5, 4, 5, 4);
            usunKonto.Name = "usunKonto";
            usunKonto.Size = new Size(151, 44);
            usunKonto.TabIndex = 7;
            usunKonto.Text = "Usuń konto";
            usunKonto.UseVisualStyleBackColor = true;
            // 
            // wyloguj
            // 
            wyloguj.BackColor = Color.MintCream;
            wyloguj.FlatAppearance.BorderColor = Color.MintCream;
            wyloguj.FlatStyle = FlatStyle.System;
            wyloguj.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            wyloguj.Location = new Point(1143, 18);
            wyloguj.Margin = new Padding(2, 3, 2, 3);
            wyloguj.Name = "wyloguj";
            wyloguj.Size = new Size(104, 63);
            wyloguj.TabIndex = 14;
            wyloguj.Text = "Wyloguj";
            wyloguj.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1265, 972);
            Controls.Add(usunKonto);
            Controls.Add(listBox1);
            Controls.Add(listViewLogin);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button usunKonto;

        private System.Windows.Forms.ListView listViewLogin;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button menuButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel1;

        #endregion

        private Button wyloguj;
    }
}
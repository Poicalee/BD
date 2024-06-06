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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(menuButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1121, 81);
            panel1.TabIndex = 0;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.MintCream;
            menuButton.FlatAppearance.BorderColor = Color.MintCream;
            menuButton.FlatStyle = FlatStyle.System;
            menuButton.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuButton.Location = new Point(1013, 22);
            menuButton.Margin = new Padding(2);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(91, 37);
            menuButton.TabIndex = 13;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(51, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 39);
            label1.TabIndex = 0;
            label1.Text = "Biblioteka";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(55, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 27);
            label2.TabIndex = 1;
            label2.Text = "Login:\r\n";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(55, 171);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(169, 27);
            label4.TabIndex = 3;
            label4.Text = "Wypożyczone książki:";
            label4.Click += label4_Click;
            // 
            // listViewLogin
            // 
            listViewLogin.Location = new Point(214, 125);
            listViewLogin.Margin = new Padding(4, 3, 4, 3);
            listViewLogin.Name = "listViewLogin";
            listViewLogin.Size = new Size(168, 22);
            listViewLogin.TabIndex = 5;
            listViewLogin.UseCompatibleStateImageBehavior = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(55, 235);
            listBox1.Margin = new Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(969, 409);
            listBox1.TabIndex = 6;
            // 
            // usunKonto
            // 
            usunKonto.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            usunKonto.Location = new Point(892, 144);
            usunKonto.Margin = new Padding(4, 3, 4, 3);
            usunKonto.Name = "usunKonto";
            usunKonto.Size = new Size(132, 33);
            usunKonto.TabIndex = 7;
            usunKonto.Text = "Usuń konto";
            usunKonto.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1110, 733);
            Controls.Add(usunKonto);
            Controls.Add(listBox1);
            Controls.Add(listViewLogin);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
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
    }
}
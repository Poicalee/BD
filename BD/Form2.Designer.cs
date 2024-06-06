using System.Windows.Forms;

namespace form111
{
    partial class Form2
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
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtYear = new TextBox();
            dodajKsiazkeAction = new Button();
            usunKsiazke = new Button();
            listBoxBooks = new ListBox();
            textGene = new TextBox();
            menuButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtTitle.Location = new Point(36, 138);
            txtTitle.Margin = new Padding(2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(132, 25);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Tytuł";
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtAuthor.Location = new Point(36, 189);
            txtAuthor.Margin = new Padding(2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(132, 25);
            txtAuthor.TabIndex = 1;
            txtAuthor.Text = "Autor";
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtYear.Location = new Point(36, 240);
            txtYear.Margin = new Padding(2);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(132, 25);
            txtYear.TabIndex = 2;
            txtYear.Text = "Rok wydania";
            // 
            // dodajKsiazkeAction
            // 
            dodajKsiazkeAction.FlatStyle = FlatStyle.System;
            dodajKsiazkeAction.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dodajKsiazkeAction.Location = new Point(36, 357);
            dodajKsiazkeAction.Margin = new Padding(2);
            dodajKsiazkeAction.Name = "dodajKsiazkeAction";
            dodajKsiazkeAction.Size = new Size(147, 55);
            dodajKsiazkeAction.TabIndex = 3;
            dodajKsiazkeAction.Text = "Dodaj książkę";
            dodajKsiazkeAction.UseVisualStyleBackColor = true;
            // 
            // usunKsiazke
            // 
            usunKsiazke.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            usunKsiazke.Location = new Point(38, 433);
            usunKsiazke.Margin = new Padding(2);
            usunKsiazke.Name = "usunKsiazke";
            usunKsiazke.Size = new Size(145, 68);
            usunKsiazke.TabIndex = 4;
            usunKsiazke.Text = "Usuń zaznaczoną książkę";
            usunKsiazke.UseVisualStyleBackColor = true;
            usunKsiazke.Click += usunKsiazke_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(215, 138);
            listBoxBooks.Margin = new Padding(2);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(832, 484);
            listBoxBooks.TabIndex = 5;
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
            // 
            // textGene
            // 
            textGene.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textGene.Location = new Point(36, 295);
            textGene.Margin = new Padding(2);
            textGene.Name = "textGene";
            textGene.Size = new Size(132, 25);
            textGene.TabIndex = 11;
            textGene.Text = "Gatunek";
            textGene.TextChanged += textBox1_TextChanged;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.MintCream;
            menuButton.FlatAppearance.BorderColor = Color.MintCream;
            menuButton.FlatStyle = FlatStyle.System;
            menuButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuButton.Location = new Point(1011, 13);
            menuButton.Margin = new Padding(2);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(91, 47);
            menuButton.TabIndex = 12;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(-4, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 76);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 37);
            label1.TabIndex = 0;
            label1.Text = "Biblioteka";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1112, 688);
            Controls.Add(panel1);
            Controls.Add(textGene);
            Controls.Add(listBoxBooks);
            Controls.Add(usunKsiazke);
            Controls.Add(dodajKsiazkeAction);
            Controls.Add(txtYear);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Margin = new Padding(2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteka";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button dodajKsiazkeAction;
        private System.Windows.Forms.Button usunKsiazke;
        private System.Windows.Forms.ListBox listBoxBooks;

        #endregion

        private System.Windows.Forms.TextBox textGene;
        private System.Windows.Forms.Button menuButton;
    }
}
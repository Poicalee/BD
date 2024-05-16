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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.dodajKsiazkeAction = new System.Windows.Forms.Button();
            this.usunKsiazke = new System.Windows.Forms.Button();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.textGene = new System.Windows.Forms.TextBox();
            this.konto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.przegladKsiazek = new System.Windows.Forms.Button();
            this.wypozyczKsiazke = new System.Windows.Forms.Button();
            this.dodajKsiazkeMenu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTitle.Location = new System.Drawing.Point(22, 162);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(114, 25);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Tytuł";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAuthor.Location = new System.Drawing.Point(22, 206);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(114, 25);
            this.txtAuthor.TabIndex = 1;
            this.txtAuthor.Text = "Autor";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtYear.Location = new System.Drawing.Point(22, 250);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(114, 25);
            this.txtYear.TabIndex = 2;
            this.txtYear.Text = "Rok wydania";
            // 
            // dodajKsiazkeAction
            // 
            this.dodajKsiazkeAction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dodajKsiazkeAction.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajKsiazkeAction.Location = new System.Drawing.Point(22, 351);
            this.dodajKsiazkeAction.Margin = new System.Windows.Forms.Padding(2);
            this.dodajKsiazkeAction.Name = "dodajKsiazkeAction";
            this.dodajKsiazkeAction.Size = new System.Drawing.Size(126, 48);
            this.dodajKsiazkeAction.TabIndex = 3;
            this.dodajKsiazkeAction.Text = "Dodaj książkę";
            this.dodajKsiazkeAction.UseVisualStyleBackColor = true;
            // 
            // usunKsiazke
            // 
            this.usunKsiazke.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usunKsiazke.Location = new System.Drawing.Point(24, 417);
            this.usunKsiazke.Margin = new System.Windows.Forms.Padding(2);
            this.usunKsiazke.Name = "usunKsiazke";
            this.usunKsiazke.Size = new System.Drawing.Size(124, 59);
            this.usunKsiazke.TabIndex = 4;
            this.usunKsiazke.Text = "Usuń zaznaczoną książkę";
            this.usunKsiazke.UseVisualStyleBackColor = true;
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.Location = new System.Drawing.Point(175, 162);
            this.listBoxBooks.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(714, 368);
            this.listBoxBooks.TabIndex = 5;
            // 
            // textGene
            // 
            this.textGene.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textGene.Location = new System.Drawing.Point(22, 298);
            this.textGene.Margin = new System.Windows.Forms.Padding(2);
            this.textGene.Name = "textGene";
            this.textGene.Size = new System.Drawing.Size(114, 25);
            this.textGene.TabIndex = 11;
            this.textGene.Text = "Gatunek";
            this.textGene.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // konto
            // 
            this.konto.BackColor = System.Drawing.Color.MintCream;
            this.konto.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.konto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.konto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.konto.Location = new System.Drawing.Point(863, 6);
            this.konto.Margin = new System.Windows.Forms.Padding(2);
            this.konto.Name = "konto";
            this.konto.Size = new System.Drawing.Size(78, 41);
            this.konto.TabIndex = 12;
            this.konto.Text = "Konto\r\n";
            this.konto.UseVisualStyleBackColor = false;
            this.konto.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 66);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteka";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.przegladKsiazek);
            this.panel2.Controls.Add(this.wypozyczKsiazke);
            this.panel2.Controls.Add(this.dodajKsiazkeMenu);
            this.panel2.Controls.Add(this.konto);
            this.panel2.Location = new System.Drawing.Point(1, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 55);
            this.panel2.TabIndex = 14;
            // 
            // przegladKsiazek
            // 
            this.przegladKsiazek.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przegladKsiazek.Location = new System.Drawing.Point(287, 6);
            this.przegladKsiazek.Name = "przegladKsiazek";
            this.przegladKsiazek.Size = new System.Drawing.Size(130, 40);
            this.przegladKsiazek.TabIndex = 15;
            this.przegladKsiazek.Text = "Przeglądaj książki";
            this.przegladKsiazek.UseVisualStyleBackColor = true;
            // 
            // wypozyczKsiazke
            // 
            this.wypozyczKsiazke.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wypozyczKsiazke.Location = new System.Drawing.Point(138, 7);
            this.wypozyczKsiazke.Name = "wypozyczKsiazke";
            this.wypozyczKsiazke.Size = new System.Drawing.Size(130, 40);
            this.wypozyczKsiazke.TabIndex = 14;
            this.wypozyczKsiazke.Text = "Wypożycz książkę";
            this.wypozyczKsiazke.UseVisualStyleBackColor = true;
            this.wypozyczKsiazke.Click += new System.EventHandler(this.wypozycKsiazke_Click);
            // 
            // dodajKsiazkeMenu
            // 
            this.dodajKsiazkeMenu.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajKsiazkeMenu.Location = new System.Drawing.Point(21, 6);
            this.dodajKsiazkeMenu.Name = "dodajKsiazkeMenu";
            this.dodajKsiazkeMenu.Size = new System.Drawing.Size(100, 40);
            this.dodajKsiazkeMenu.TabIndex = 13;
            this.dodajKsiazkeMenu.Text = "Dodaj książkę";
            this.dodajKsiazkeMenu.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(953, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textGene);
            this.Controls.Add(this.listBoxBooks);
            this.Controls.Add(this.usunKsiazke);
            this.Controls.Add(this.dodajKsiazkeAction);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteka";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button przegladKsiazek;

        private System.Windows.Forms.Button wypozyczKsiazke;

        private System.Windows.Forms.Button dodajKsiazkeMenu;

        private System.Windows.Forms.Panel panel2;

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
        private System.Windows.Forms.Button konto;
    }
}
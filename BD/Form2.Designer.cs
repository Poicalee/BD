﻿using System.Windows.Forms;

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
            this.menuButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTitle.Location = new System.Drawing.Point(31, 120);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(114, 25);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Tytuł";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAuthor.Location = new System.Drawing.Point(31, 164);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(114, 25);
            this.txtAuthor.TabIndex = 1;
            this.txtAuthor.Text = "Autor";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtYear.Location = new System.Drawing.Point(31, 208);
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
            this.dodajKsiazkeAction.Location = new System.Drawing.Point(31, 309);
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
            this.usunKsiazke.Location = new System.Drawing.Point(33, 375);
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
            this.listBoxBooks.Location = new System.Drawing.Point(184, 120);
            this.listBoxBooks.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(714, 420);
            this.listBoxBooks.TabIndex = 5;
            // 
            // textGene
            // 
            this.textGene.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textGene.Location = new System.Drawing.Point(31, 256);
            this.textGene.Margin = new System.Windows.Forms.Padding(2);
            this.textGene.Name = "textGene";
            this.textGene.Size = new System.Drawing.Size(114, 25);
            this.textGene.TabIndex = 11;
            this.textGene.Text = "Gatunek";
            this.textGene.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.MintCream;
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.menuButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuButton.Location = new System.Drawing.Point(867, 11);
            this.menuButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(78, 41);
            this.menuButton.TabIndex = 12;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(953, 596);
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
            this.ResumeLayout(false);
            this.PerformLayout();
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
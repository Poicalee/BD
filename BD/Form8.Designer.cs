﻿namespace BD1
{
    partial class Form8
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
            panel1 = new Panel();
            wylogujBttn = new Button();
            menuButton = new Button();
            label1 = new Label();
            nameTextBox = new TextBox();
            dodajCzytelnika = new Button();
            adresTextBox = new TextBox();
            numerKontTextBox = new TextBox();
            hasloTextBox = new TextBox();
            edytujCzytelnika = new Button();
            usunCzytelnika = new Button();
            listBoxUser = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(wylogujBttn);
            panel1.Controls.Add(menuButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 77);
            panel1.TabIndex = 0;
            // 
            // wylogujBttn
            // 
            wylogujBttn.BackColor = Color.MintCream;
            wylogujBttn.FlatAppearance.BorderColor = Color.MintCream;
            wylogujBttn.FlatStyle = FlatStyle.System;
            wylogujBttn.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            wylogujBttn.Location = new Point(1006, 12);
            wylogujBttn.Margin = new Padding(2, 2, 2, 2);
            wylogujBttn.Name = "wylogujBttn";
            wylogujBttn.Size = new Size(91, 47);
            wylogujBttn.TabIndex = 14;
            wylogujBttn.Text = "Wyloguj";
            wylogujBttn.UseVisualStyleBackColor = false;
            wylogujBttn.Click += wylogujBttn_Click;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.MintCream;
            menuButton.FlatAppearance.BorderColor = Color.MintCream;
            menuButton.FlatStyle = FlatStyle.System;
            menuButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuButton.Location = new Point(892, 12);
            menuButton.Margin = new Padding(2, 2, 2, 2);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(91, 47);
            menuButton.TabIndex = 13;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Click += menuButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(46, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 39);
            label1.TabIndex = 1;
            label1.Text = "Biblioteka";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.Location = new Point(46, 128);
            nameTextBox.Margin = new Padding(3, 2, 3, 2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(163, 25);
            nameTextBox.TabIndex = 1;
            nameTextBox.Text = "Imię i nazwisko";
            nameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // dodajCzytelnika
            // 
            dodajCzytelnika.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dodajCzytelnika.Location = new Point(46, 411);
            dodajCzytelnika.Margin = new Padding(3, 2, 3, 2);
            dodajCzytelnika.Name = "dodajCzytelnika";
            dodajCzytelnika.Size = new Size(163, 63);
            dodajCzytelnika.TabIndex = 5;
            dodajCzytelnika.Text = "Dodaj czytelnika";
            dodajCzytelnika.UseVisualStyleBackColor = true;
            dodajCzytelnika.Click += dodajCzytelnika_Click;
            // 
            // adresTextBox
            // 
            adresTextBox.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adresTextBox.Location = new Point(46, 189);
            adresTextBox.Margin = new Padding(3, 2, 3, 2);
            adresTextBox.Name = "adresTextBox";
            adresTextBox.Size = new Size(163, 25);
            adresTextBox.TabIndex = 6;
            adresTextBox.Text = "Adres";
            // 
            // numerKontTextBox
            // 
            numerKontTextBox.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numerKontTextBox.Location = new Point(46, 251);
            numerKontTextBox.Margin = new Padding(3, 2, 3, 2);
            numerKontTextBox.Name = "numerKontTextBox";
            numerKontTextBox.Size = new Size(163, 25);
            numerKontTextBox.TabIndex = 7;
            numerKontTextBox.Text = "Numer kontaktowy";
            numerKontTextBox.TextChanged += textBox3_TextChanged;
            // 
            // hasloTextBox
            // 
            hasloTextBox.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hasloTextBox.Location = new Point(46, 320);
            hasloTextBox.Margin = new Padding(3, 2, 3, 2);
            hasloTextBox.Name = "hasloTextBox";
            hasloTextBox.Size = new Size(163, 25);
            hasloTextBox.TabIndex = 8;
            hasloTextBox.Text = "Hasło";
            // 
            // edytujCzytelnika
            // 
            edytujCzytelnika.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edytujCzytelnika.Location = new Point(46, 496);
            edytujCzytelnika.Margin = new Padding(3, 2, 3, 2);
            edytujCzytelnika.Name = "edytujCzytelnika";
            edytujCzytelnika.Size = new Size(163, 63);
            edytujCzytelnika.TabIndex = 9;
            edytujCzytelnika.Text = "Edytuj zaznaczonego czytelnika";
            edytujCzytelnika.UseVisualStyleBackColor = true;
            edytujCzytelnika.Click += edytujCzytelnika_Click_1;
            // 
            // usunCzytelnika
            // 
            usunCzytelnika.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usunCzytelnika.Location = new Point(46, 592);
            usunCzytelnika.Margin = new Padding(3, 2, 3, 2);
            usunCzytelnika.Name = "usunCzytelnika";
            usunCzytelnika.Size = new Size(163, 63);
            usunCzytelnika.TabIndex = 10;
            usunCzytelnika.Text = "Usuń zaznaczonego czytelnika";
            usunCzytelnika.UseVisualStyleBackColor = true;
            usunCzytelnika.Click += usunCzytelnika_Click;
            // 
            // listBoxUser
            // 
            listBoxUser.Font = new Font("Microsoft YaHei", 9.75F);
            listBoxUser.FormattingEnabled = true;
            listBoxUser.ItemHeight = 19;
            listBoxUser.Location = new Point(259, 121);
            listBoxUser.Margin = new Padding(3, 2, 3, 2);
            listBoxUser.Name = "listBoxUser";
            listBoxUser.Size = new Size(784, 555);
            listBoxUser.TabIndex = 11;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1107, 729);
            Controls.Add(listBoxUser);
            Controls.Add(usunCzytelnika);
            Controls.Add(edytujCzytelnika);
            Controls.Add(hasloTextBox);
            Controls.Add(numerKontTextBox);
            Controls.Add(adresTextBox);
            Controls.Add(dodajCzytelnika);
            Controls.Add(nameTextBox);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form8";
            Text = "Form8";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox nameTextBox;
        private Button dodajCzytelnika;
        private TextBox adresTextBox;
        private TextBox numerKontTextBox;
        private TextBox hasloTextBox;
        private Button edytujCzytelnika;
        private Button usunCzytelnika;
        private Button menuButton;
        private ListBox listBoxUser;
        private Button wylogujBttn;
    }
}
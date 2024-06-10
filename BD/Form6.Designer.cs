﻿using System.ComponentModel;

namespace form111
{
    partial class Form6
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
            label1 = new Label();
            menuButton = new Button();
            UserCRUD = new Button();
            AuthorCRUD = new Button();
            KsiazkiCRUD = new Button();
            PracownikCRUD = new Button();
            WypozyczenieCRUD = new Button();
            wylogujBttn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(wylogujBttn);
            panel1.Controls.Add(menuButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, 0);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 102);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(53, 31);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 80);
            label1.TabIndex = 0;
            label1.Text = "Biblioteka";
            // 
            // menuButton
            // 
            menuButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuButton.Location = new Point(573, 17);
            menuButton.Margin = new Padding(5, 5, 5, 5);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(93, 63);
            menuButton.TabIndex = 2;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = true;
            // 
            // UserCRUD
            // 
            UserCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserCRUD.Location = new Point(55, 177);
            UserCRUD.Name = "UserCRUD";
            UserCRUD.Size = new Size(213, 72);
            UserCRUD.TabIndex = 2;
            UserCRUD.Text = "Edytuj czytelników";
            UserCRUD.UseVisualStyleBackColor = true;
            UserCRUD.Click += UserCRUD_Click;
            // 
            // AuthorCRUD
            // 
            AuthorCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AuthorCRUD.Location = new Point(55, 302);
            AuthorCRUD.Name = "AuthorCRUD";
            AuthorCRUD.Size = new Size(213, 72);
            AuthorCRUD.TabIndex = 4;
            AuthorCRUD.Text = "Edytuj autorów";
            AuthorCRUD.UseVisualStyleBackColor = true;
            AuthorCRUD.Click += AuthorCRUD_Click;
            // 
            // KsiazkiCRUD
            // 
            KsiazkiCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KsiazkiCRUD.Location = new Point(291, 410);
            KsiazkiCRUD.Name = "KsiazkiCRUD";
            KsiazkiCRUD.Size = new Size(213, 72);
            KsiazkiCRUD.TabIndex = 5;
            KsiazkiCRUD.Text = "Edytuj książki";
            KsiazkiCRUD.UseVisualStyleBackColor = true;
            KsiazkiCRUD.Click += KsiazkiCRUD_Click_1;
            // 
            // PracownikCRUD
            // 
            PracownikCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PracownikCRUD.Location = new Point(525, 177);
            PracownikCRUD.Name = "PracownikCRUD";
            PracownikCRUD.Size = new Size(213, 72);
            PracownikCRUD.TabIndex = 6;
            PracownikCRUD.Text = "Edytuj pracowników";
            PracownikCRUD.UseVisualStyleBackColor = true;
            PracownikCRUD.Click += PracownikCRUD_Click_1;
            // 
            // WypozyczenieCRUD
            // 
            WypozyczenieCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WypozyczenieCRUD.Location = new Point(525, 302);
            WypozyczenieCRUD.Name = "WypozyczenieCRUD";
            WypozyczenieCRUD.Size = new Size(213, 72);
            WypozyczenieCRUD.TabIndex = 7;
            WypozyczenieCRUD.Text = "Edytuj wpożyczenia";
            WypozyczenieCRUD.UseVisualStyleBackColor = true;
            WypozyczenieCRUD.Click += WypozyczenieCRUD_Click_1;
            // 
            // wylogujBttn
            // 
            wylogujBttn.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            wylogujBttn.Location = new Point(698, 20);
            wylogujBttn.Margin = new Padding(5);
            wylogujBttn.Name = "wylogujBttn";
            wylogujBttn.Size = new Size(93, 63);
            wylogujBttn.TabIndex = 3;
            wylogujBttn.Text = "Wyloguj";
            wylogujBttn.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(800, 563);
            Controls.Add(WypozyczenieCRUD);
            Controls.Add(KsiazkiCRUD);
            Controls.Add(PracownikCRUD);
            Controls.Add(AuthorCRUD);
            Controls.Add(UserCRUD);
            Controls.Add(panel1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button menuButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel1;

        #endregion

        private Button UserCRUD;
        private Button AuthorCRUD;
        private Button KsiazkiCRUD;
        private Button PracownikCRUD;
        private Button WypozyczenieCRUD;
        private Button wylogujBttn;
    }
}
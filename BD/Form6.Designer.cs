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
            wylogujBttn = new Button();
            menuButton = new Button();
            label1 = new Label();
            UserCRUD = new Button();
            AuthorCRUD = new Button();
            KsiazkiCRUD = new Button();
            PracownikCRUD = new Button();
            WypozyczenieCRUD = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(wylogujBttn);
            panel1.Controls.Add(menuButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 76);
            panel1.TabIndex = 0;
            // 
            // wylogujBttn
            // 
            wylogujBttn.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            wylogujBttn.Location = new Point(611, 15);
            wylogujBttn.Margin = new Padding(4, 4, 4, 4);
            wylogujBttn.Name = "wylogujBttn";
            wylogujBttn.Size = new Size(81, 47);
            wylogujBttn.TabIndex = 3;
            wylogujBttn.Text = "Wyloguj";
            wylogujBttn.UseVisualStyleBackColor = true;
            wylogujBttn.Click += wylogujBttn_Click;
            // 
            // menuButton
            // 
            menuButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuButton.Location = new Point(501, 13);
            menuButton.Margin = new Padding(4, 4, 4, 4);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(81, 47);
            menuButton.TabIndex = 2;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(46, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 60);
            label1.TabIndex = 0;
            label1.Text = "Biblioteka";
            // 
            // UserCRUD
            // 
            UserCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserCRUD.Location = new Point(48, 133);
            UserCRUD.Margin = new Padding(3, 2, 3, 2);
            UserCRUD.Name = "UserCRUD";
            UserCRUD.Size = new Size(186, 54);
            UserCRUD.TabIndex = 2;
            UserCRUD.Text = "Edytuj czytelników";
            UserCRUD.UseVisualStyleBackColor = true;
            UserCRUD.Click += UserCRUD_Click;
            // 
            // AuthorCRUD
            // 
            AuthorCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AuthorCRUD.Location = new Point(48, 226);
            AuthorCRUD.Margin = new Padding(3, 2, 3, 2);
            AuthorCRUD.Name = "AuthorCRUD";
            AuthorCRUD.Size = new Size(186, 54);
            AuthorCRUD.TabIndex = 4;
            AuthorCRUD.Text = "Edytuj autorów";
            AuthorCRUD.UseVisualStyleBackColor = true;
            AuthorCRUD.Click += AuthorCRUD_Click;
            // 
            // KsiazkiCRUD
            // 
            KsiazkiCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KsiazkiCRUD.Location = new Point(255, 308);
            KsiazkiCRUD.Margin = new Padding(3, 2, 3, 2);
            KsiazkiCRUD.Name = "KsiazkiCRUD";
            KsiazkiCRUD.Size = new Size(186, 54);
            KsiazkiCRUD.TabIndex = 5;
            KsiazkiCRUD.Text = "Edytuj książki";
            KsiazkiCRUD.UseVisualStyleBackColor = true;
            KsiazkiCRUD.Click += KsiazkiCRUD_Click_1;
            // 
            // PracownikCRUD
            // 
            PracownikCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PracownikCRUD.Location = new Point(459, 133);
            PracownikCRUD.Margin = new Padding(3, 2, 3, 2);
            PracownikCRUD.Name = "PracownikCRUD";
            PracownikCRUD.Size = new Size(186, 54);
            PracownikCRUD.TabIndex = 6;
            PracownikCRUD.Text = "Edytuj pracowników";
            PracownikCRUD.UseVisualStyleBackColor = true;
            PracownikCRUD.Click += PracownikCRUD_Click_1;
            // 
            // WypozyczenieCRUD
            // 
            WypozyczenieCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WypozyczenieCRUD.Location = new Point(459, 226);
            WypozyczenieCRUD.Margin = new Padding(3, 2, 3, 2);
            WypozyczenieCRUD.Name = "WypozyczenieCRUD";
            WypozyczenieCRUD.Size = new Size(186, 54);
            WypozyczenieCRUD.TabIndex = 7;
            WypozyczenieCRUD.Text = "Edytuj wpożyczenia";
            WypozyczenieCRUD.UseVisualStyleBackColor = true;
            WypozyczenieCRUD.Click += WypozyczenieCRUD_Click_1;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(700, 422);
            Controls.Add(WypozyczenieCRUD);
            Controls.Add(KsiazkiCRUD);
            Controls.Add(PracownikCRUD);
            Controls.Add(AuthorCRUD);
            Controls.Add(UserCRUD);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
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
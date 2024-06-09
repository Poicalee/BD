using System.ComponentModel;

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
            panel1.Location = new Point(-5, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 97);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(52, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 80);
            label1.TabIndex = 0;
            label1.Text = "Biblioteka";
            // 
            // menuButton
            // 
            menuButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuButton.Location = new Point(549, 19);
            menuButton.Margin = new Padding(4, 5, 4, 5);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(93, 60);
            menuButton.TabIndex = 2;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = true;
            // 
            // UserCRUD
            // 
            UserCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserCRUD.Location = new Point(51, 177);
            UserCRUD.Name = "UserCRUD";
            UserCRUD.Size = new Size(212, 72);
            UserCRUD.TabIndex = 2;
            UserCRUD.Text = "Edytuj czytelników";
            UserCRUD.UseVisualStyleBackColor = true;
            UserCRUD.Click += UserCRUD_Click;
            // 
            // AuthorCRUD
            // 
            AuthorCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AuthorCRUD.Location = new Point(51, 303);
            AuthorCRUD.Name = "AuthorCRUD";
            AuthorCRUD.Size = new Size(212, 72);
            AuthorCRUD.TabIndex = 4;
            AuthorCRUD.Text = "Edytuj autorów";
            AuthorCRUD.UseVisualStyleBackColor = true;
            // 
            // KsiazkiCRUD
            // 
            KsiazkiCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KsiazkiCRUD.Location = new Point(287, 411);
            KsiazkiCRUD.Name = "KsiazkiCRUD";
            KsiazkiCRUD.Size = new Size(212, 72);
            KsiazkiCRUD.TabIndex = 5;
            KsiazkiCRUD.Text = "Edytuj książki";
            KsiazkiCRUD.UseVisualStyleBackColor = true;
            // 
            // PracownikCRUD
            // 
            PracownikCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PracownikCRUD.Location = new Point(521, 177);
            PracownikCRUD.Name = "PracownikCRUD";
            PracownikCRUD.Size = new Size(212, 72);
            PracownikCRUD.TabIndex = 6;
            PracownikCRUD.Text = "Edytuj pracowników";
            PracownikCRUD.UseVisualStyleBackColor = true;
            // 
            // WypozyczenieCRUD
            // 
            WypozyczenieCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WypozyczenieCRUD.Location = new Point(521, 303);
            WypozyczenieCRUD.Name = "WypozyczenieCRUD";
            WypozyczenieCRUD.Size = new Size(212, 72);
            WypozyczenieCRUD.TabIndex = 7;
            WypozyczenieCRUD.Text = "Edytuj wpożyczenia";
            WypozyczenieCRUD.UseVisualStyleBackColor = true;
            // 
            // wyloguj
            // 
            wyloguj.BackColor = Color.MintCream;
            wyloguj.FlatAppearance.BorderColor = Color.MintCream;
            wyloguj.FlatStyle = FlatStyle.System;
            wyloguj.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            wyloguj.Location = new Point(674, 16);
            wyloguj.Margin = new Padding(2, 3, 2, 3);
            wyloguj.Name = "wyloguj";
            wyloguj.Size = new Size(104, 63);
            wyloguj.TabIndex = 14;
            wyloguj.Text = "Wyloguj";
            wyloguj.UseVisualStyleBackColor = false;
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
            Margin = new Padding(4, 5, 4, 5);
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
        private Button wyloguj;
    }
}
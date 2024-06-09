namespace BD1
{
    partial class Form12
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
            panel2 = new Panel();
            menuButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            WypozyczenieCRUD = new Button();
            KsiazkiCRUD = new Button();
            AuthorCRUD = new Button();
            wyloguj = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleTurquoise;
            panel2.Controls.Add(menuButton);
            panel2.Location = new Point(5, 105);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 71);
            panel2.TabIndex = 3;
            // 
            // menuButton
            // 
            menuButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuButton.Location = new Point(682, 13);
            menuButton.Margin = new Padding(4, 5, 4, 5);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(93, 38);
            menuButton.TabIndex = 2;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -9);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 107);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(39, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 80);
            label1.TabIndex = 0;
            label1.Text = "Biblioteka";
            label1.Click += label1_Click;
            // 
            // WypozyczenieCRUD
            // 
            WypozyczenieCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WypozyczenieCRUD.Location = new Point(493, 171);
            WypozyczenieCRUD.Name = "WypozyczenieCRUD";
            WypozyczenieCRUD.Size = new Size(212, 72);
            WypozyczenieCRUD.TabIndex = 12;
            WypozyczenieCRUD.Text = "Edytuj wpożyczenia";
            WypozyczenieCRUD.UseVisualStyleBackColor = true;
            // 
            // KsiazkiCRUD
            // 
            KsiazkiCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KsiazkiCRUD.Location = new Point(78, 373);
            KsiazkiCRUD.Name = "KsiazkiCRUD";
            KsiazkiCRUD.Size = new Size(212, 72);
            KsiazkiCRUD.TabIndex = 10;
            KsiazkiCRUD.Text = "Edytuj książki";
            KsiazkiCRUD.UseVisualStyleBackColor = true;
            // 
            // AuthorCRUD
            // 
            AuthorCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AuthorCRUD.Location = new Point(78, 171);
            AuthorCRUD.Name = "AuthorCRUD";
            AuthorCRUD.Size = new Size(212, 72);
            AuthorCRUD.TabIndex = 9;
            AuthorCRUD.Text = "Edytuj autorów";
            AuthorCRUD.UseVisualStyleBackColor = true;
            // 
            // wyloguj
            // 
            wyloguj.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wyloguj.Location = new Point(493, 373);
            wyloguj.Name = "wyloguj";
            wyloguj.Size = new Size(212, 72);
            wyloguj.TabIndex = 13;
            wyloguj.Text = "Wyloguj";
            wyloguj.UseVisualStyleBackColor = true;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(800, 563);
            Controls.Add(wyloguj);
            Controls.Add(WypozyczenieCRUD);
            Controls.Add(KsiazkiCRUD);
            Controls.Add(AuthorCRUD);
            Controls.Add(panel1);
            Name = "Form12";
            Text = "Form12";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button menuButton;
        private Panel panel1;
        private Label label1;
        private Button WypozyczenieCRUD;
        private Button KsiazkiCRUD;
        private Button AuthorCRUD;
        private Button wyloguj;
    }
}
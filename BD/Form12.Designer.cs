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
            panel2.Location = new Point(4, 79);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(699, 53);
            panel2.TabIndex = 3;
            // 
            // menuButton
            // 
            menuButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuButton.Location = new Point(597, 10);
            menuButton.Margin = new Padding(4);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(81, 28);
            menuButton.TabIndex = 2;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -7);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 80);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(34, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 60);
            label1.TabIndex = 0;
            label1.Text = "Biblioteka";
            label1.Click += label1_Click;
            // 
            // WypozyczenieCRUD
            // 
            WypozyczenieCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WypozyczenieCRUD.Location = new Point(431, 128);
            WypozyczenieCRUD.Margin = new Padding(3, 2, 3, 2);
            WypozyczenieCRUD.Name = "WypozyczenieCRUD";
            WypozyczenieCRUD.Size = new Size(186, 54);
            WypozyczenieCRUD.TabIndex = 12;
            WypozyczenieCRUD.Text = "Edytuj wpożyczenia";
            WypozyczenieCRUD.UseVisualStyleBackColor = true;
            WypozyczenieCRUD.Click += WypozyczenieCRUD_Click;
            // 
            // KsiazkiCRUD
            // 
            KsiazkiCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KsiazkiCRUD.Location = new Point(68, 280);
            KsiazkiCRUD.Margin = new Padding(3, 2, 3, 2);
            KsiazkiCRUD.Name = "KsiazkiCRUD";
            KsiazkiCRUD.Size = new Size(186, 54);
            KsiazkiCRUD.TabIndex = 10;
            KsiazkiCRUD.Text = "Edytuj książki";
            KsiazkiCRUD.UseVisualStyleBackColor = true;
            KsiazkiCRUD.Click += KsiazkiCRUD_Click;
            // 
            // AuthorCRUD
            // 
            AuthorCRUD.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AuthorCRUD.Location = new Point(68, 128);
            AuthorCRUD.Margin = new Padding(3, 2, 3, 2);
            AuthorCRUD.Name = "AuthorCRUD";
            AuthorCRUD.Size = new Size(186, 54);
            AuthorCRUD.TabIndex = 9;
            AuthorCRUD.Text = "Edytuj autorów";
            AuthorCRUD.UseVisualStyleBackColor = true;
            AuthorCRUD.Click += AuthorCRUD_Click;
            // 
            // wyloguj
            // 
            wyloguj.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wyloguj.Location = new Point(431, 280);
            wyloguj.Margin = new Padding(3, 2, 3, 2);
            wyloguj.Name = "wyloguj";
            wyloguj.Size = new Size(186, 54);
            wyloguj.TabIndex = 13;
            wyloguj.Text = "Wyloguj";
            wyloguj.UseVisualStyleBackColor = true;
            wyloguj.Click += wyloguj_Click;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(700, 422);
            Controls.Add(wyloguj);
            Controls.Add(WypozyczenieCRUD);
            Controls.Add(KsiazkiCRUD);
            Controls.Add(AuthorCRUD);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form12";
            Text = "Form12";
            Load += Form12_Load;
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
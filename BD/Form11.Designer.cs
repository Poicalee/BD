namespace BD1
{
    partial class Form11
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
            menuButton = new Button();
            label1 = new Label();
            namePracTextBox = new TextBox();
            StanowiskoTextBox = new TextBox();
            pensjaTextBox = new TextBox();
            adresTextBox = new TextBox();
            numerKontTextBox = new TextBox();
            dodajPracownika = new Button();
            edytujPracownika = new Button();
            usunPracownika = new Button();
            listBox1 = new ListBox();
            hasloTextBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(menuButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1266, 106);
            panel1.TabIndex = 2;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.MintCream;
            menuButton.FlatAppearance.BorderColor = Color.MintCream;
            menuButton.FlatStyle = FlatStyle.System;
            menuButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuButton.Location = new Point(1140, 15);
            menuButton.Margin = new Padding(2, 3, 2, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(104, 63);
            menuButton.TabIndex = 13;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(53, 26);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 52);
            label1.TabIndex = 1;
            label1.Text = "Biblioteka";
            // 
            // namePracTextBox
            // 
            namePracTextBox.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namePracTextBox.Location = new Point(54, 165);
            namePracTextBox.Name = "namePracTextBox";
            namePracTextBox.Size = new Size(180, 30);
            namePracTextBox.TabIndex = 3;
            namePracTextBox.Text = "Imię i nazwisko";
            // 
            // StanowiskoTextBox
            // 
            StanowiskoTextBox.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StanowiskoTextBox.Location = new Point(54, 228);
            StanowiskoTextBox.Name = "StanowiskoTextBox";
            StanowiskoTextBox.Size = new Size(180, 30);
            StanowiskoTextBox.TabIndex = 4;
            StanowiskoTextBox.Text = "Stanowisko";
            // 
            // pensjaTextBox
            // 
            pensjaTextBox.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pensjaTextBox.Location = new Point(54, 289);
            pensjaTextBox.Name = "pensjaTextBox";
            pensjaTextBox.Size = new Size(180, 30);
            pensjaTextBox.TabIndex = 5;
            pensjaTextBox.Text = "Pensja";
            // 
            // adresTextBox
            // 
            adresTextBox.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adresTextBox.Location = new Point(54, 354);
            adresTextBox.Name = "adresTextBox";
            adresTextBox.Size = new Size(180, 30);
            adresTextBox.TabIndex = 6;
            adresTextBox.Text = "Adres";
            // 
            // numerKontTextBox
            // 
            numerKontTextBox.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numerKontTextBox.Location = new Point(54, 423);
            numerKontTextBox.Name = "numerKontTextBox";
            numerKontTextBox.Size = new Size(180, 30);
            numerKontTextBox.TabIndex = 7;
            numerKontTextBox.Text = "Numer kontaktowy";
            // 
            // dodajPracownika
            // 
            dodajPracownika.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dodajPracownika.Location = new Point(54, 549);
            dodajPracownika.Name = "dodajPracownika";
            dodajPracownika.Size = new Size(180, 94);
            dodajPracownika.TabIndex = 8;
            dodajPracownika.Text = "Dodaj pracownika";
            dodajPracownika.UseVisualStyleBackColor = true;
            // 
            // edytujPracownika
            // 
            edytujPracownika.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edytujPracownika.Location = new Point(54, 681);
            edytujPracownika.Name = "edytujPracownika";
            edytujPracownika.Size = new Size(180, 94);
            edytujPracownika.TabIndex = 9;
            edytujPracownika.Text = "Edytuj zaznacznego pracownika";
            edytujPracownika.UseVisualStyleBackColor = true;
            // 
            // usunPracownika
            // 
            usunPracownika.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usunPracownika.Location = new Point(54, 816);
            usunPracownika.Name = "usunPracownika";
            usunPracownika.Size = new Size(180, 94);
            usunPracownika.TabIndex = 10;
            usunPracownika.Text = "Usuń zaznacznego pracownika";
            usunPracownika.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(265, 157);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(937, 717);
            listBox1.TabIndex = 11;
            // 
            // hasloTextBox
            // 
            hasloTextBox.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hasloTextBox.Location = new Point(54, 484);
            hasloTextBox.Name = "hasloTextBox";
            hasloTextBox.Size = new Size(180, 30);
            hasloTextBox.TabIndex = 12;
            hasloTextBox.Text = "Hasło (???)";
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1265, 972);
            Controls.Add(hasloTextBox);
            Controls.Add(listBox1);
            Controls.Add(usunPracownika);
            Controls.Add(edytujPracownika);
            Controls.Add(dodajPracownika);
            Controls.Add(numerKontTextBox);
            Controls.Add(adresTextBox);
            Controls.Add(pensjaTextBox);
            Controls.Add(StanowiskoTextBox);
            Controls.Add(namePracTextBox);
            Controls.Add(panel1);
            Name = "Form11";
            Text = "Form11";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button menuButton;
        private Label label1;
        private TextBox namePracTextBox;
        private TextBox StanowiskoTextBox;
        private TextBox pensjaTextBox;
        private TextBox adresTextBox;
        private TextBox numerKontTextBox;
        private Button dodajPracownika;
        private Button edytujPracownika;
        private Button usunPracownika;
        private ListBox listBox1;
        private TextBox hasloTextBox;
    }
}
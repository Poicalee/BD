namespace BD1
{
    partial class Form13
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
            dodajWypozyczenie = new Button();
            listBoxWypozyczenie = new ListBox();
            wypozyczenieDatePicker = new DateTimePicker();
            zwrotDatePicker = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            Ksiazkabox = new ComboBox();
            czytelnikbox = new ComboBox();
            pracownikbox = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(menuButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 80);
            panel1.TabIndex = 1;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.MintCream;
            menuButton.FlatAppearance.BorderColor = Color.MintCream;
            menuButton.FlatStyle = FlatStyle.System;
            menuButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuButton.Location = new Point(998, 11);
            menuButton.Margin = new Padding(2);
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
            // dodajWypozyczenie
            // 
            dodajWypozyczenie.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dodajWypozyczenie.Location = new Point(46, 440);
            dodajWypozyczenie.Margin = new Padding(3, 2, 3, 2);
            dodajWypozyczenie.Name = "dodajWypozyczenie";
            dodajWypozyczenie.Size = new Size(149, 70);
            dodajWypozyczenie.TabIndex = 3;
            dodajWypozyczenie.Text = "Dodaj wypożyczenie";
            dodajWypozyczenie.UseVisualStyleBackColor = true;
            dodajWypozyczenie.Click += dodajWypozyczenie_Click;
            // 
            // listBoxWypozyczenie
            // 
            listBoxWypozyczenie.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxWypozyczenie.FormattingEnabled = true;
            listBoxWypozyczenie.ItemHeight = 20;
            listBoxWypozyczenie.Location = new Point(373, 107);
            listBoxWypozyczenie.Margin = new Padding(3, 2, 3, 2);
            listBoxWypozyczenie.Name = "listBoxWypozyczenie";
            listBoxWypozyczenie.Size = new Size(716, 584);
            listBoxWypozyczenie.TabIndex = 4;
            // 
            // wypozyczenieDatePicker
            // 
            wypozyczenieDatePicker.CalendarFont = new Font("Microsoft YaHei", 9.75F);
            wypozyczenieDatePicker.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wypozyczenieDatePicker.Location = new Point(46, 264);
            wypozyczenieDatePicker.Margin = new Padding(3, 2, 3, 2);
            wypozyczenieDatePicker.Name = "wypozyczenieDatePicker";
            wypozyczenieDatePicker.Size = new Size(270, 25);
            wypozyczenieDatePicker.TabIndex = 8;
            // 
            // zwrotDatePicker
            // 
            zwrotDatePicker.CalendarFont = new Font("Microsoft YaHei", 9.75F);
            zwrotDatePicker.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zwrotDatePicker.Location = new Point(46, 338);
            zwrotDatePicker.Margin = new Padding(3, 2, 3, 2);
            zwrotDatePicker.Name = "zwrotDatePicker";
            zwrotDatePicker.Size = new Size(270, 25);
            zwrotDatePicker.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 234);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 14;
            label2.Text = "Data wypożyczenia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 308);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 15;
            label3.Text = "Data zwrotu:";
            // 
            // Ksiazkabox
            // 
            Ksiazkabox.FormattingEnabled = true;
            Ksiazkabox.Location = new Point(46, 107);
            Ksiazkabox.Name = "Ksiazkabox";
            Ksiazkabox.Size = new Size(121, 23);
            Ksiazkabox.TabIndex = 16;
            // 
            // czytelnikbox
            // 
            czytelnikbox.FormattingEnabled = true;
            czytelnikbox.Location = new Point(46, 148);
            czytelnikbox.Name = "czytelnikbox";
            czytelnikbox.Size = new Size(121, 23);
            czytelnikbox.TabIndex = 17;
            // 
            // pracownikbox
            // 
            pracownikbox.FormattingEnabled = true;
            pracownikbox.Location = new Point(46, 194);
            pracownikbox.Name = "pracownikbox";
            pracownikbox.Size = new Size(121, 23);
            pracownikbox.TabIndex = 18;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(46, 388);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(81, 24);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Oddana";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(181, 388);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(102, 24);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nieoddana";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1107, 729);
            Controls.Add(pracownikbox);
            Controls.Add(czytelnikbox);
            Controls.Add(Ksiazkabox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(zwrotDatePicker);
            Controls.Add(wypozyczenieDatePicker);
            Controls.Add(listBoxWypozyczenie);
            Controls.Add(dodajWypozyczenie);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form13";
            Text = "Form10";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button menuButton;
        private Label label1;
        private Button dodajWypozyczenie;
        private ListBox listBoxWypozyczenie;
        private DateTimePicker wypozyczenieDatePicker;
        private DateTimePicker zwrotDatePicker;
        private Label label2;
        private Label label3;
        private ComboBox Ksiazkabox;
        private ComboBox czytelnikbox;
        private ComboBox pracownikbox;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
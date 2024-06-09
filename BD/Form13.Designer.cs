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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            zwrotDatePicker = new DateTimePicker();
            wypozyczenieDatePicker = new DateTimePicker();
            pracownikTextBox = new TextBox();
            czytelnikTextBox = new TextBox();
            listBoxWypozyczenie = new ListBox();
            dodajWypozyczenie = new Button();
            ksiazkaTextBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(-11, 108);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1285, 78);
            panel1.TabIndex = 5;
            // 
            // menuButton
            // 
            menuButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuButton.Location = new Point(1163, 5);
            menuButton.Margin = new Padding(4, 5, 4, 5);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(103, 63);
            menuButton.TabIndex = 0;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BackColor = Color.Teal;
            label2.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.MintCream;
            label2.Location = new Point(47, 36);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(201, 46);
            label2.TabIndex = 4;
            label2.Text = "Biblioteka";
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Location = new Point(0, -1);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1276, 111);
            label1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 505);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 28;
            label3.Text = "Data zwrotu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 406);
            label4.Name = "label4";
            label4.Size = new Size(168, 23);
            label4.TabIndex = 27;
            label4.Text = "Data wypożyczenia:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(201, 611);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(121, 27);
            radioButton2.TabIndex = 24;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nieoddana";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(47, 611);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(95, 27);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "Oddana";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // zwrotDatePicker
            // 
            zwrotDatePicker.CalendarFont = new Font("Microsoft YaHei", 9.75F);
            zwrotDatePicker.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zwrotDatePicker.Location = new Point(47, 544);
            zwrotDatePicker.Name = "zwrotDatePicker";
            zwrotDatePicker.Size = new Size(308, 30);
            zwrotDatePicker.TabIndex = 22;
            // 
            // wypozyczenieDatePicker
            // 
            wypozyczenieDatePicker.CalendarFont = new Font("Microsoft YaHei", 9.75F);
            wypozyczenieDatePicker.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wypozyczenieDatePicker.Location = new Point(47, 446);
            wypozyczenieDatePicker.Name = "wypozyczenieDatePicker";
            wypozyczenieDatePicker.Size = new Size(308, 30);
            wypozyczenieDatePicker.TabIndex = 21;
            // 
            // pracownikTextBox
            // 
            pracownikTextBox.BorderStyle = BorderStyle.FixedSingle;
            pracownikTextBox.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pracownikTextBox.Location = new Point(47, 357);
            pracownikTextBox.Name = "pracownikTextBox";
            pracownikTextBox.Size = new Size(125, 30);
            pracownikTextBox.TabIndex = 20;
            pracownikTextBox.Text = "Pracownik";
            // 
            // czytelnikTextBox
            // 
            czytelnikTextBox.BorderStyle = BorderStyle.FixedSingle;
            czytelnikTextBox.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            czytelnikTextBox.Location = new Point(47, 297);
            czytelnikTextBox.Name = "czytelnikTextBox";
            czytelnikTextBox.Size = new Size(125, 30);
            czytelnikTextBox.TabIndex = 19;
            czytelnikTextBox.Text = "Czytelnik";
            // 
            // listBoxWypozyczenie
            // 
            listBoxWypozyczenie.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxWypozyczenie.FormattingEnabled = true;
            listBoxWypozyczenie.ItemHeight = 23;
            listBoxWypozyczenie.Location = new Point(389, 206);
            listBoxWypozyczenie.Name = "listBoxWypozyczenie";
            listBoxWypozyczenie.Size = new Size(818, 694);
            listBoxWypozyczenie.TabIndex = 18;
            // 
            // dodajWypozyczenie
            // 
            dodajWypozyczenie.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dodajWypozyczenie.Location = new Point(47, 680);
            dodajWypozyczenie.Name = "dodajWypozyczenie";
            dodajWypozyczenie.Size = new Size(170, 94);
            dodajWypozyczenie.TabIndex = 17;
            dodajWypozyczenie.Text = "Dodaj wypożyczenie";
            dodajWypozyczenie.UseVisualStyleBackColor = true;
            // 
            // ksiazkaTextBox
            // 
            ksiazkaTextBox.BorderStyle = BorderStyle.FixedSingle;
            ksiazkaTextBox.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ksiazkaTextBox.Location = new Point(47, 237);
            ksiazkaTextBox.Name = "ksiazkaTextBox";
            ksiazkaTextBox.Size = new Size(125, 30);
            ksiazkaTextBox.TabIndex = 16;
            ksiazkaTextBox.Text = "Książka";
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1265, 972);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(zwrotDatePicker);
            Controls.Add(wypozyczenieDatePicker);
            Controls.Add(pracownikTextBox);
            Controls.Add(czytelnikTextBox);
            Controls.Add(listBoxWypozyczenie);
            Controls.Add(dodajWypozyczenie);
            Controls.Add(ksiazkaTextBox);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form13";
            Text = "Form13";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button menuButton;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker zwrotDatePicker;
        private DateTimePicker wypozyczenieDatePicker;
        private TextBox pracownikTextBox;
        private TextBox czytelnikTextBox;
        private ListBox listBoxWypozyczenie;
        private Button dodajWypozyczenie;
        private TextBox ksiazkaTextBox;
    }
}
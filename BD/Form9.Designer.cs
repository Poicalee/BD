namespace BD1
{
    partial class Form9
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
            nametextBox = new TextBox();
            dodajAutora = new Button();
            edytujAutora = new Button();
            usunAutora = new Button();
            listBox1 = new ListBox();
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
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1266, 103);
            panel1.TabIndex = 1;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.MintCream;
            menuButton.FlatAppearance.BorderColor = Color.MintCream;
            menuButton.FlatStyle = FlatStyle.System;
            menuButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuButton.Location = new Point(983, 15);
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
            // nametextBox
            // 
            nametextBox.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nametextBox.Location = new Point(56, 153);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(168, 30);
            nametextBox.TabIndex = 2;
            nametextBox.Text = "Imię i Nazwisko";
            // 
            // dodajAutora
            // 
            dodajAutora.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dodajAutora.Location = new Point(54, 331);
            dodajAutora.Name = "dodajAutora";
            dodajAutora.Size = new Size(170, 90);
            dodajAutora.TabIndex = 3;
            dodajAutora.Text = "Dodaj autora";
            dodajAutora.UseVisualStyleBackColor = true;
            // 
            // edytujAutora
            // 
            edytujAutora.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edytujAutora.Location = new Point(56, 483);
            edytujAutora.Name = "edytujAutora";
            edytujAutora.Size = new Size(168, 90);
            edytujAutora.TabIndex = 4;
            edytujAutora.Text = "Edytuj zaznaczonego autora";
            edytujAutora.UseVisualStyleBackColor = true;
            // 
            // usunAutora
            // 
            usunAutora.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usunAutora.Location = new Point(54, 634);
            usunAutora.Name = "usunAutora";
            usunAutora.Size = new Size(170, 90);
            usunAutora.TabIndex = 5;
            usunAutora.Text = "Usuń zaznaczonego autora";
            usunAutora.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(286, 153);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(904, 704);
            listBox1.TabIndex = 6;
            // 
            // wyloguj
            // 
            wyloguj.BackColor = Color.MintCream;
            wyloguj.FlatAppearance.BorderColor = Color.MintCream;
            wyloguj.FlatStyle = FlatStyle.System;
            wyloguj.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            wyloguj.Location = new Point(1129, 15);
            wyloguj.Margin = new Padding(2, 3, 2, 3);
            wyloguj.Name = "wyloguj";
            wyloguj.Size = new Size(104, 63);
            wyloguj.TabIndex = 14;
            wyloguj.Text = "Wyloguj";
            wyloguj.UseVisualStyleBackColor = false;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1265, 917);
            Controls.Add(listBox1);
            Controls.Add(usunAutora);
            Controls.Add(edytujAutora);
            Controls.Add(dodajAutora);
            Controls.Add(nametextBox);
            Controls.Add(panel1);
            Name = "Form9";
            Text = "Form9";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button menuButton;
        private Label label1;
        private TextBox nametextBox;
        private Button dodajAutora;
        private Button edytujAutora;
        private Button usunAutora;
        private ListBox listBox1;
        private Button wyloguj;
    }
}
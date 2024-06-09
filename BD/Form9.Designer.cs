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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(menuButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 77);
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
            menuButton.Click += menuButton_Click_1;
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
            // nametextBox
            // 
            nametextBox.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nametextBox.Location = new Point(49, 115);
            nametextBox.Margin = new Padding(3, 2, 3, 2);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(148, 25);
            nametextBox.TabIndex = 2;
            nametextBox.Text = "Imię i Nazwisko";
            // 
            // dodajAutora
            // 
            dodajAutora.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dodajAutora.Location = new Point(47, 248);
            dodajAutora.Margin = new Padding(3, 2, 3, 2);
            dodajAutora.Name = "dodajAutora";
            dodajAutora.Size = new Size(149, 68);
            dodajAutora.TabIndex = 3;
            dodajAutora.Text = "Dodaj autora";
            dodajAutora.UseVisualStyleBackColor = true;
            dodajAutora.Click += dodajAutora_Click;
            // 
            // edytujAutora
            // 
            edytujAutora.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edytujAutora.Location = new Point(49, 362);
            edytujAutora.Margin = new Padding(3, 2, 3, 2);
            edytujAutora.Name = "edytujAutora";
            edytujAutora.Size = new Size(147, 68);
            edytujAutora.TabIndex = 4;
            edytujAutora.Text = "Edytuj zaznaczonego autora";
            edytujAutora.UseVisualStyleBackColor = true;
            edytujAutora.Click += edytujAutora_Click;
            // 
            // usunAutora
            // 
            usunAutora.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usunAutora.Location = new Point(47, 476);
            usunAutora.Margin = new Padding(3, 2, 3, 2);
            usunAutora.Name = "usunAutora";
            usunAutora.Size = new Size(149, 68);
            usunAutora.TabIndex = 5;
            usunAutora.Text = "Usuń zaznaczonego autora";
            usunAutora.UseVisualStyleBackColor = true;
            usunAutora.Click += usunAutora_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(250, 115);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(792, 529);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1107, 688);
            Controls.Add(listBox1);
            Controls.Add(usunAutora);
            Controls.Add(edytujAutora);
            Controls.Add(dodajAutora);
            Controls.Add(nametextBox);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}
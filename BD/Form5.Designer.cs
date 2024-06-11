using System.ComponentModel;

namespace form111
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            menuButton = new Button();
            listBoxPrzegladKsiazek = new ListBox();
            label3 = new Label();
            ksiazkaTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1116, 83);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.Teal;
            label2.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.MintCream;
            label2.Location = new Point(46, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(176, 34);
            label2.TabIndex = 1;
            label2.Text = "Biblioteka";
            // 
            // menuButton
            // 
            menuButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuButton.Location = new Point(1002, 15);
            menuButton.Margin = new Padding(4);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(90, 47);
            menuButton.TabIndex = 0;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_click;
            // 
            // listBoxPrzegladKsiazek
            // 
            listBoxPrzegladKsiazek.FormattingEnabled = true;
            listBoxPrzegladKsiazek.ItemHeight = 15;
            listBoxPrzegladKsiazek.Location = new Point(50, 166);
            listBoxPrzegladKsiazek.Margin = new Padding(4);
            listBoxPrzegladKsiazek.Name = "listBoxPrzegladKsiazek";
            listBoxPrzegladKsiazek.Size = new Size(1002, 484);
            listBoxPrzegladKsiazek.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(46, 109);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 27);
            label3.TabIndex = 4;
            label3.Text = "Wyszukaj książkę:";
            // 
            // ksiazkaTextBox
            // 
            ksiazkaTextBox.Location = new Point(196, 107);
            ksiazkaTextBox.Margin = new Padding(2);
            ksiazkaTextBox.Name = "ksiazkaTextBox";
            ksiazkaTextBox.Size = new Size(190, 23);
            ksiazkaTextBox.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(402, 101);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(90, 29);
            button1.TabIndex = 10;
            button1.Text = "Szukaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1112, 697);
            Controls.Add(button1);
            Controls.Add(menuButton);
            Controls.Add(ksiazkaTextBox);
            Controls.Add(label3);
            Controls.Add(listBoxPrzegladKsiazek);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ListBox listBoxPrzegladKsiazek;

        private System.Windows.Forms.Button menuButton;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion

        private Label label3;
        public TextBox ksiazkaTextBox;
        private Button button1;
    }
}
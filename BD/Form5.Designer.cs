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
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1276, 111);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.Teal;
            label2.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.MintCream;
            label2.Location = new Point(52, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(201, 46);
            label2.TabIndex = 1;
            label2.Text = "Biblioteka";
            // 
            // menuButton
            // 
            menuButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuButton.Location = new Point(1135, 20);
            menuButton.Margin = new Padding(4, 5, 4, 5);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(103, 63);
            menuButton.TabIndex = 0;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_click;
            // 
            // listBoxPrzegladKsiazek
            // 
            listBoxPrzegladKsiazek.FormattingEnabled = true;
            listBoxPrzegladKsiazek.Location = new Point(76, 184);
            listBoxPrzegladKsiazek.Name = "listBoxPrzegladKsiazek";
            listBoxPrzegladKsiazek.Size = new Size(1119, 664);
            listBoxPrzegladKsiazek.TabIndex = 3;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1271, 929);
            Controls.Add(menuButton);
            Controls.Add(listBoxPrzegladKsiazek);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button menuButton;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion

        private ListBox listBoxPrzegladKsiazek;
    }
}
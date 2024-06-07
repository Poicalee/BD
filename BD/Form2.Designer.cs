using System.Windows.Forms;

namespace form111
{
    partial class Form2
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
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtYear = new TextBox();
            dodajKsiazkeAction = new Button();
            usunKsiazke = new Button();
            listBoxBooks = new ListBox();
            textGene = new TextBox();
            menuButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            edytujKsiazke = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtTitle.Location = new Point(41, 184);
            txtTitle.Margin = new Padding(2, 3, 2, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(168, 29);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Tytuł";
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtAuthor.Location = new Point(41, 252);
            txtAuthor.Margin = new Padding(2, 3, 2, 3);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(166, 29);
            txtAuthor.TabIndex = 1;
            txtAuthor.Text = "Autor";
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtYear.Location = new Point(41, 320);
            txtYear.Margin = new Padding(2, 3, 2, 3);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(166, 29);
            txtYear.TabIndex = 2;
            txtYear.Text = "Rok wydania";
            // 
            // dodajKsiazkeAction
            // 
            dodajKsiazkeAction.FlatStyle = FlatStyle.System;
            dodajKsiazkeAction.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dodajKsiazkeAction.Location = new Point(41, 476);
            dodajKsiazkeAction.Margin = new Padding(2, 3, 2, 3);
            dodajKsiazkeAction.Name = "dodajKsiazkeAction";
            dodajKsiazkeAction.Size = new Size(168, 73);
            dodajKsiazkeAction.TabIndex = 3;
            dodajKsiazkeAction.Text = "Dodaj książkę";
            dodajKsiazkeAction.UseVisualStyleBackColor = true;
            // 
            // usunKsiazke
            // 
            usunKsiazke.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            usunKsiazke.Location = new Point(41, 577);
            usunKsiazke.Margin = new Padding(2, 3, 2, 3);
            usunKsiazke.Name = "usunKsiazke";
            usunKsiazke.Size = new Size(168, 91);
            usunKsiazke.TabIndex = 4;
            usunKsiazke.Text = "Usuń zaznaczoną książkę";
            usunKsiazke.UseVisualStyleBackColor = true;
            usunKsiazke.Click += usunKsiazke_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.Font = new Font("Microsoft YaHei", 9.75F);
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 21;
            listBoxBooks.Location = new Point(246, 184);
            listBoxBooks.Margin = new Padding(2, 3, 2, 3);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(950, 634);
            listBoxBooks.TabIndex = 5;
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
            // 
            // textGene
            // 
            textGene.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textGene.Location = new Point(41, 393);
            textGene.Margin = new Padding(2, 3, 2, 3);
            textGene.Name = "textGene";
            textGene.Size = new Size(166, 29);
            textGene.TabIndex = 11;
            textGene.Text = "Gatunek";
            textGene.TextChanged += textBox1_TextChanged;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.MintCream;
            menuButton.FlatAppearance.BorderColor = Color.MintCream;
            menuButton.FlatStyle = FlatStyle.System;
            menuButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            menuButton.Location = new Point(1155, 17);
            menuButton.Margin = new Padding(2, 3, 2, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(104, 63);
            menuButton.TabIndex = 12;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(-5, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1275, 101);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 29);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 49);
            label1.TabIndex = 0;
            label1.Text = "Biblioteka";
            // 
            // edytujKsiazke
            // 
            edytujKsiazke.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            edytujKsiazke.Location = new Point(41, 705);
            edytujKsiazke.Margin = new Padding(2, 3, 2, 3);
            edytujKsiazke.Name = "edytujKsiazke";
            edytujKsiazke.Size = new Size(166, 91);
            edytujKsiazke.TabIndex = 14;
            edytujKsiazke.Text = "Edytuj zaznaczoną książkę";
            edytujKsiazke.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1271, 917);
            Controls.Add(edytujKsiazke);
            Controls.Add(panel1);
            Controls.Add(textGene);
            Controls.Add(listBoxBooks);
            Controls.Add(usunKsiazke);
            Controls.Add(dodajKsiazkeAction);
            Controls.Add(txtYear);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteka";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button dodajKsiazkeAction;
        private System.Windows.Forms.Button usunKsiazke;
        private System.Windows.Forms.ListBox listBoxBooks;

        #endregion

        private System.Windows.Forms.TextBox textGene;
        private System.Windows.Forms.Button menuButton;
        private Button edytujKsiazke;
    }
}
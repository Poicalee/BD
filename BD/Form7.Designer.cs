using System.ComponentModel;

namespace form111
{
    partial class Form7
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
            panel1 = new Panel();
            label1 = new Label();
            przegladajKsiazki = new Button();
            kontoButt = new Button();
            wypozyczKsiazke = new Button();
            info = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(956, 73);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(56, 22);
            label1.Name = "label1";
            label1.Size = new Size(143, 30);
            label1.TabIndex = 0;
            label1.Text = "Biblioteka";
            // 
            // przegladajKsiazki
            // 
            przegladajKsiazki.Location = new Point(86, 154);
            przegladajKsiazki.Name = "przegladajKsiazki";
            przegladajKsiazki.Size = new Size(125, 42);
            przegladajKsiazki.TabIndex = 1;
            przegladajKsiazki.Text = "Przeglądaj książki";
            przegladajKsiazki.UseVisualStyleBackColor = true;
            przegladajKsiazki.Click += przegladajKsiazki_Click;
            // 
            // kontoButt
            // 
            kontoButt.Location = new Point(366, 154);
            kontoButt.Name = "kontoButt";
            kontoButt.Size = new Size(125, 42);
            kontoButt.TabIndex = 3;
            kontoButt.Text = "Konto";
            kontoButt.UseVisualStyleBackColor = true;
            // 
            // wypozyczKsiazke
            // 
            wypozyczKsiazke.Location = new Point(86, 219);
            wypozyczKsiazke.Name = "wypozyczKsiazke";
            wypozyczKsiazke.Size = new Size(125, 52);
            wypozyczKsiazke.TabIndex = 4;
            wypozyczKsiazke.Text = "Wypożycz książkę";
            wypozyczKsiazke.UseVisualStyleBackColor = true;
            // 
            // info
            // 
            info.Location = new Point(366, 229);
            info.Name = "info";
            info.Size = new Size(125, 42);
            info.TabIndex = 5;
            info.Text = "Informacje";
            info.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(600, 366);
            Controls.Add(info);
            Controls.Add(wypozyczKsiazke);
            Controls.Add(kontoButt);
            Controls.Add(przegladajKsiazki);
            Controls.Add(panel1);
            Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button wypozyczKsiazke;

        private System.Windows.Forms.Button przegladajKsiazki;
        private System.Windows.Forms.Button kontoButt;

        private System.Windows.Forms.Button info;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}
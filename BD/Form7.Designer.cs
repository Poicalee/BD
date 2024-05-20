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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.przegladajKsiazki = new System.Windows.Forms.Button();
            this.kontoButt = new System.Windows.Forms.Button();
            this.wypozyczKsiazke = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(56, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteka";
            // 
            // przegladajKsiazki
            // 
            this.przegladajKsiazki.Location = new System.Drawing.Point(86, 154);
            this.przegladajKsiazki.Name = "przegladajKsiazki";
            this.przegladajKsiazki.Size = new System.Drawing.Size(125, 42);
            this.przegladajKsiazki.TabIndex = 1;
            this.przegladajKsiazki.Text = "Przeglądaj książki";
            this.przegladajKsiazki.UseVisualStyleBackColor = true;
            // 
            // kontoButt
            // 
            this.kontoButt.Location = new System.Drawing.Point(366, 154);
            this.kontoButt.Name = "kontoButt";
            this.kontoButt.Size = new System.Drawing.Size(125, 42);
            this.kontoButt.TabIndex = 3;
            this.kontoButt.Text = "Konto";
            this.kontoButt.UseVisualStyleBackColor = true;
            // 
            // wypozyczKsiazke
            // 
            this.wypozyczKsiazke.Location = new System.Drawing.Point(86, 219);
            this.wypozyczKsiazke.Name = "wypozyczKsiazke";
            this.wypozyczKsiazke.Size = new System.Drawing.Size(125, 52);
            this.wypozyczKsiazke.TabIndex = 4;
            this.wypozyczKsiazke.Text = "Wypożycz książkę";
            this.wypozyczKsiazke.UseVisualStyleBackColor = true;
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(366, 229);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(125, 42);
            this.info.TabIndex = 5;
            this.info.Text = "Informacje";
            this.info.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.info);
            this.Controls.Add(this.wypozyczKsiazke);
            this.Controls.Add(this.kontoButt);
            this.Controls.Add(this.przegladajKsiazki);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
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
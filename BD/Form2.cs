using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form111
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dodajKsiazkeAction.Click += BtnAddBook_Click;
            usunKsiazke.Click += BtnRemoveBook_Click;
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            // Tutaj możesz dodać kod obsługujący dodawanie książki
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string year = txtYear.Text;
            string gene = textGene.Text;
            listBoxBooks.Items.Add($"{title} - {author} ({year}) - {gene}");
        }

        private void BtnRemoveBook_Click(object sender, EventArgs e)
        {
            // Tutaj możesz dodać kod obsługujący usuwanie zaznaczonej książki
            if (listBoxBooks.SelectedIndex != -1)
            {
                listBoxBooks.Items.RemoveAt(listBoxBooks.SelectedIndex);
            }
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            this.Close();
        }

        private void wypozycKsiazke_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form = new Form5();
            form.ShowDialog();
            this.Close();
        }
    }
}

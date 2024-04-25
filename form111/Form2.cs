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
            btnAddBook.Click += BtnAddBook_Click;
            btnRemoveBook.Click += BtnRemoveBook_Click;
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

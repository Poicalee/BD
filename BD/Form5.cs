using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace form111
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=Kubek234;Database=BD";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT title, publication_year, author, genre FROM allbooksview";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string title = reader.GetString(0);
                            int publicationYear = reader.GetInt32(1);
                            string author = reader.GetString(2);
                            string genre = reader.GetString(3);

                            string bookInfo = $"{title} - {author} ({publicationYear}) [{genre}]";
                            listBoxPrzegladKsiazek.Items.Add(bookInfo);
                        }
                    }
                }
            }
        }

        private void menuButton_click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
    }
}

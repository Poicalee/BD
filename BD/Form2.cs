using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace form111
{
    public partial class Form2 : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=Kubek234;Database=postgres";

        public Form2()
        {
            InitializeComponent();
            RefreshListBoxBooks();
            dodajKsiazkeAction.Click += BtnAddBook_Click;
            usunKsiazke.Click += BtnRemoveBook_Click;
        }
        private void BtnRemoveBook_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedIndex != -1)
            {
                string selectedBook = listBoxBooks.SelectedItem.ToString();
                string title = selectedBook.Split('-')[0].Trim(); // Pobierz tytuł wybranej książki

                UsunKsiazke(title); // Wywołaj metodę usuwającą książkę
            }
        }
        private void DodajKsiazke(string tytul, string autor, int rok, string gatunek)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("add_book_and_author", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@p_title", tytul);
                        command.Parameters.AddWithValue("@p_author_name", autor);
                        command.Parameters.AddWithValue("@p_year", rok);
                        command.Parameters.AddWithValue("@p_genre", gatunek);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Książka została dodana do bazy danych", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshListBoxBooks();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania książki: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // In the BtnAddBook_Click event handler
        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            string tytul = txtTitle.Text;
            string autor = txtAuthor.Text;
            int rok = Convert.ToInt32(txtYear.Text);
            string gatunek = textGene.Text;

            DodajKsiazke(tytul, autor, rok, gatunek);
        }





        private void UsunKsiazke(string tytul)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("usun_ksiazke", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@p_tytul", tytul);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Książka została usunięta z bazy danych", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshListBoxBooks(); // Odśwież listę po usunięciu książki
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania książki: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form = new Form7();
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
        private void RefreshListBoxBooks()
        {
            try
            {
                listBoxBooks.Items.Clear(); // Wyczyść istniejącą zawartość ListBox

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM AllBooksView", connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string title = reader.GetString(0);
                                string year = reader.IsDBNull(1) ? "Unknown" : reader.GetInt32(1).ToString();
                                string author = reader.IsDBNull(2) ? "Unknown" : reader.GetString(2);
                                string genre = reader.IsDBNull(3) ? "Unknown" : reader.GetString(3);

                                listBoxBooks.Items.Add($"{title} - {author} - {year} - {genre}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM AllBooksView", connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string title = reader.GetString(0);
                                string year = reader.IsDBNull(1) ? "Unknown" : reader.GetInt32(1).ToString();
                                string author = reader.IsDBNull(2) ? "Unknown" : reader.GetString(2);
                                string genre = reader.IsDBNull(3) ? "Unknown" : reader.GetString(3);

                                listBoxBooks.Items.Add($"{title} - {year} - {author} -{genre}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usunKsiazke_Click(object sender, EventArgs e)
        {

        }

        private void wyloguj_Click(object sender, EventArgs e)
        {

        }
    }
}

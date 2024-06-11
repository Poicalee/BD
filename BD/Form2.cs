using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using BD1;
using form111;

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
            get_authors();
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
        private void DodajKsiazke(string tytul, int autorId, int rok, string gatunek, string position)
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
                        command.Parameters.AddWithValue("@p_author_id", autorId);
                        command.Parameters.AddWithValue("@p_year", rok);
                        command.Parameters.AddWithValue("@p_genre", gatunek);
                        command.Parameters.AddWithValue("@p_position", position);

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

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            string tytul = txtTitle.Text;
            int autorId = PobierzIdAutoraZComboBox();
            int rok = Convert.ToInt32(txtYear.Text);
            string gatunek = textGene.Text;
            string position = textBox2.Text;

            DodajKsiazke(tytul, autorId, rok, gatunek, position);
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
            Form12 form = new Form12();
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
                                string postiton = reader.IsDBNull(4) ? "Unknown" : reader.GetString(4);

                                listBoxBooks.Items.Add($"{title} - {author} - {year} - {genre} - {postiton}");
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


        private void get_authors()
        {
            try
            {
                // Wyczyszczenie zawartości comboBox
                AutorBox.Items.Clear();

                // Połączenie z bazą danych i wykonanie zapytania SQL, które uruchamia funkcję get_books
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM autor_name;", connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Dodanie nazwy książki do comboBox
                                string bookName = reader.GetString(0); // Załóżmy, że funkcja get_books zwraca nazwy książek w pierwszej kolumnie
                                AutorBox.Items.Add(bookName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas pobierania danych o książkach: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int PobierzIdAutoraZComboBox()
        {
            // Załóżmy, że ComboBox z pracownikami ma nazwę pracownikComboBox
            // Zakładamy, że w ComboBox zapisane są identyfikatory pracowników jako wartości tekstowe
            // Możesz zmodyfikować nazwy ComboBox'ów, jeśli są różne
            string autor = AutorBox.SelectedItem.ToString();

            // Tu wykonaj zapytanie do bazy danych, aby pobrać identyfikator pracownika na podstawie jego nazwy
            // Przykładowe zapytanie:
            // SELECT employee_id FROM pracownik WHERE employee_name = 'selectedEmployeeName';
            // Poniżej przykładowe pobranie identyfikatora z bazy danych
            int autorId = 0; // Domyślnie ustawiamy na 0, możesz też ustawić na -1 lub inny wartość oznaczającą brak wybranego pracownika

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT author_id FROM autor WHERE author_name = @authorName", connection))
                {
                    command.Parameters.AddWithValue("@authorName", autor);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        autorId = Convert.ToInt32(result);
                    }
                }
            }

            return autorId;
        }

        private void wylogujBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
    }
}
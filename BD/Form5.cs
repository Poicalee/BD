using BD1.Models;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace form111
{
    public partial class Form5 : Form
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=Kubek234;Database=postgres";

        public Form5()
        {
            InitializeComponent();
            RefreshListBoxBooks();
        }

        private void menuButton_click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void RefreshListBoxBooks()
        {
            try
            {
                listBoxPrzegladKsiazek.Items.Clear(); // Wyczyść istniejącą zawartość ListBox

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
                                string position = reader.IsDBNull(4) ? "Unknown" : reader.GetString(4);

                                listBoxPrzegladKsiazek.Items.Add($"{title} - {author} - {year} - {genre} - {position}");
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

        private void button1_Click(object sender, EventArgs e)
        {
            string tytul = ksiazkaTextBox.Text;

            try
            {
                listBoxPrzegladKsiazek.Items.Clear();

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("szukajksiazkipotytule", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_tytul", tytul);

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.NextResult()) // Odczytaj wyniki z kursora
                            {
                                string title = reader.GetString(0);
                                string year = reader.IsDBNull(1) ? "Unknown" : reader.GetInt32(1).ToString();
                                string author = reader.IsDBNull(2) ? "Unknown" : reader.GetString(2);
                                string genre = reader.IsDBNull(3) ? "Unknown" : reader.GetString(3);
                                string position = reader.IsDBNull(4) ? "Unknown" : reader.GetString(4);

                                listBoxPrzegladKsiazek.Items.Add($"{title} - {author} - {year} - {genre} - {position}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }





}


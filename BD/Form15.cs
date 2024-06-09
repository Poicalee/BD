using BD1.Models;
using form111;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD1
{
    public partial class Form15 : Form
    {
        private readonly PostgresContext context;
        private string connectionString = "Host=localhost;Username=postgres;Password=Kubek234;Database=postgres";
        public Form15()
        {
            InitializeComponent();
            context = new PostgresContext();
            RefreshListBoxAutor();
        }
        private void menuButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form12 form = new Form12();
            form.ShowDialog();
            this.Close();
        }
        private void RefreshListBoxAutor()
        {
            try
            {
                listBox1.Items.Clear(); // Clear existing items in ListBox

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM autor_view", connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string autorId = reader.IsDBNull(0) ? "Unknown" : reader.GetInt32(0).ToString();
                                string authorName = reader.IsDBNull(1) ? "Unknown" : reader.GetString(1);

                                listBox1.Items.Add($"{autorId} - {authorName}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching authors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dodajAutora_Click(object sender, EventArgs e)
        {
            try
            {
                // Pobierz dane z pola tekstowego
                string authorName = nametextBox.Text.Trim();

                // Sprawdź, czy pole nie jest puste
                if (string.IsNullOrEmpty(authorName))
                {
                    MessageBox.Show("Proszę wprowadzić nazwę autora.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Otwórz połączenie z bazą danych
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Utwórz nową komendę, wywołując procedurę dodajautora
                    using (NpgsqlCommand command = new NpgsqlCommand("dodajautora", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Dodaj parametr do komendy
                        command.Parameters.AddWithValue("p_author_name", authorName);

                        // Wykonaj komendę
                        command.ExecuteNonQuery();
                    }
                }

                // Wyświetl komunikat o sukcesie
                MessageBox.Show("Autor został dodany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcjonalnie, wyczyść pole tekstowe


                // Opcjonalnie, odśwież listę autorów
                RefreshListBoxAutor();
            }
            catch (Exception ex)
            {
                // Wyświetl komunikat o błędzie
                MessageBox.Show("Wystąpił błąd podczas dodawania autora: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void edytujAutora_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy wybrano autora z listy
            if (listBox1.SelectedIndex != -1)
            {
                // Pobierz ID i nową nazwę autora z pól tekstowych
                int authorId = int.Parse(listBox1.SelectedItem.ToString().Split('-')[0].Trim());
                string newAuthorName = nametextBox.Text;

                // Wywołaj funkcję edytowania autora
                EdytujAutora(authorId, newAuthorName);
            }
            else
            {
                MessageBox.Show("Please select an author to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usunAutora_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy wybrano autora z listy
            if (listBox1.SelectedIndex != -1)
            {
                // Pobierz ID autora z listy
                int authorId = int.Parse(listBox1.SelectedItem.ToString().Split('-')[0].Trim());

                // Wywołaj funkcję usuwania autora
                UsunAutora(authorId);
            }
            else
            {
                MessageBox.Show("Please select an author to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EdytujAutora(int authorId, string newAuthorName)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("EdytujAutora", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@p_author_id", authorId);
                        command.Parameters.AddWithValue("@p_new_author_name", newAuthorName);

                        command.ExecuteNonQuery();
                    }
                }

                // Odśwież listę autorów po edycji
                RefreshListBoxAutor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while editing author: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsunAutora(int authorId)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("UsunAutora", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("@p_author_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = authorId;
                        command.ExecuteNonQuery();
                    }
                }

                // Odśwież listę autorów po usunięciu
                RefreshListBoxAutor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting author: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

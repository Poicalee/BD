    using BD1.Models;
    using form111;
    using Npgsql;
    using Microsoft.EntityFrameworkCore;
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
    public partial class Form8 : Form
    {
        private readonly PostgresContext context;
        private string connectionString = "Host=localhost;Username=postgres;Password=Kubek234;Database=postgres";

        public Form8()
        {
            InitializeComponent();
            context = new PostgresContext();
            RefreshListBoxCzytelnicy();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void edytujCzytelnika_1(int readerId, string readerName, string readerAddress, string readerPhone, string password)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("edytuj_czytelnika", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@p_reader_id", readerId);
                        command.Parameters.AddWithValue("@p_reader_name", readerName);
                        command.Parameters.AddWithValue("@p_reader_address", readerAddress);
                        command.Parameters.AddWithValue("@p_reader_phone", readerPhone);
                        command.Parameters.AddWithValue("@p_password", password);

                        command.ExecuteNonQuery();
                    }
                }

                // Odśwież listę czytelników po edycji
                RefreshListBoxCzytelnicy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas edycji czytelnika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form = new Form6();
            form.ShowDialog();
            this.Close();
        }

        private void RefreshListBoxCzytelnicy()
        {
            try
            {
                listBoxUser.Items.Clear(); // Clear existing items in ListBox

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM czytelnicy_view", connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string readerId = reader.IsDBNull(0) ? "Unknown" : reader.GetInt32(0).ToString();
                                string readerName = reader.IsDBNull(1) ? "Unknown" : reader.GetString(1);
                                string readerAddress = reader.IsDBNull(2) ? "Unknown" : reader.GetString(2);
                                string rederePhone = reader.IsDBNull(3) ? "Unknown" : reader.GetString(3);

                                listBoxUser.Items.Add($"{readerId} - {readerName} - {readerAddress} - {rederePhone}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching employees: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dodajCzytelnika_1(string readerName, string readerAddress, string readerPhone, string password)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("dodajczytelnika", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("p_readername", NpgsqlTypes.NpgsqlDbType.Varchar, readerName);
                        command.Parameters.AddWithValue("p_readeraddress", NpgsqlTypes.NpgsqlDbType.Varchar, readerAddress);
                        command.Parameters.AddWithValue("p_readerphone", NpgsqlTypes.NpgsqlDbType.Varchar, readerPhone);
                        command.Parameters.AddWithValue("p_password", NpgsqlTypes.NpgsqlDbType.Varchar, password);

                        command.ExecuteNonQuery();
                    }
                }

                // Odśwież listę czytelników po dodaniu
                RefreshListBoxCzytelnicy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania czytelnika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dodajCzytelnika_Click(object sender, EventArgs e)
        {
            string readerName = nameTextBox.Text;
            string readerAddress = adresTextBox.Text;
            string readerPhone = numerKontTextBox.Text;
            string password = hasloTextBox.Text;

            dodajCzytelnika_1(readerName, readerAddress, readerPhone, password);
        }



        private void usunCzytelnika_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedReader = listBoxUser.SelectedItem?.ToString();

                if (selectedReader != null)
                {
                    int readerId = int.Parse(selectedReader.Split('-')[0].Trim());

                    // Wywołanie funkcji UsunCzytelnika
                    context.Database.ExecuteSqlInterpolated($@"SELECT UsunCzytelnika({readerId})");

                    // Odśwież listę czytelników po usunięciu
                    RefreshListBoxCzytelnicy();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting reader: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edytujCzytelnika_Click_1(object sender, EventArgs e)
        {
            try
            {
                string selectedReader = listBoxUser.SelectedItem?.ToString();

                if (selectedReader != null)
                {
                    // Pobierz identyfikator zaznaczonego czytelnika
                    int readerId = int.Parse(selectedReader.Split('-')[0].Trim());

                    string readerName = nameTextBox.Text;
                    string readerAddress = adresTextBox.Text;
                    string readerPhone = numerKontTextBox.Text;
                    string password = hasloTextBox.Text;

                    // Wywołaj metodę edycji czytelnika
                    edytujCzytelnika_1(readerId, readerName, readerAddress, readerPhone, password);
                }
                else
                {
                    MessageBox.Show("Wybierz czytelnika do edycji z listy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas edycji czytelnika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


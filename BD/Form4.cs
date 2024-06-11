using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace form111
{
    public partial class Form4 : Form
    {
        private string login;

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(string login) : this()
        {
            this.login = login;
            label2.Text = "" + login;

            // Wyświetlanie wypożyczonych książek dla danego użytkownika
            ShowUserLoans(login);
        }

        private void ShowUserLoans(string login)
        {
            try
            {
                string connectionString = "Host=localhost;Username=postgres;Password=Kubek234;Database=postgres";
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM showuserloans((SELECT reader_id FROM czytelnik WHERE reader_name = @login))", connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Pobierz dane wypożyczenia z wyniku zapytania i dodaj do listBox
                                string loanInfo = $"{reader.GetString(0)}, {reader.GetDateTime(1).ToString("yyyy-MM-dd")}, {reader.GetDateTime(2).ToString("yyyy-MM-dd")}";
                                listBox1.Items.Add(loanInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wyświetlania wypożyczonych książek: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obsługa zdarzenia zmiany zaznaczenia w listBox
        }

        private void wylogujBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void usunKonto_Click(object sender, EventArgs e)
        {

        }
    }
}

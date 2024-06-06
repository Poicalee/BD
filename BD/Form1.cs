using System;
using System.Windows.Forms;
using Npgsql;
using BD1.Models;

namespace form111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zalogujGosc_click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form = new Form5();
            form.ShowDialog();
            this.Close();
        }

        private void button3_click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            if (CheckCredentials(login, password))
            {
                MessageBox.Show("Logowanie powiodło się", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form7 form = new Form7();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckCredentials(string login, string password)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=Kubek234;Database=postgres";
            string functionCall = "SELECT check_credentials(@login, @password)";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(functionCall, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

                        bool isValid = (bool)command.ExecuteScalar();
                        return isValid;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking credentials: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

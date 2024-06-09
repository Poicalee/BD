using System;
using System.Windows.Forms;
using BD1.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace form111
{
    public partial class Form1 : Form
    {
        private readonly PostgresContext context;

        public Form1()
        {
            InitializeComponent();
            context = new PostgresContext(); // Initialize the PostgresContext
            textBox2.PasswordChar = '*';
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
            bool isAdmin;

            if (CheckCredentials(login, password, out isAdmin))
            {
                MessageBox.Show("Logowanie powiodło się", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                if (isAdmin)
                {
                    Form6 form = new Form6();
                    form.ShowDialog();
                }
                else
                {
                    Form7 form = new Form7();
                    form.ShowDialog();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckCredentials(string login, string password, out bool isAdmin)
        {
            isAdmin = false;

            try
            {
                if (login == "admin" && password == "admin")
                {
                    isAdmin = true;
                    return true;
                }
                else
                {
                    using (var connection = (NpgsqlConnection)context.Database.GetDbConnection())
                    {
                        connection.Open();
                        using (var command = new NpgsqlCommand("SELECT check_credentials(@login, @password)", connection))
                        {
                            command.Parameters.AddWithValue("@login", login);
                            command.Parameters.AddWithValue("@password", password);

                            bool isValid = (bool)command.ExecuteScalar();
                            return isValid;
                        }
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
            // No implementation needed
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // No implementation needed
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            // No implementation needed
        }
    }
}

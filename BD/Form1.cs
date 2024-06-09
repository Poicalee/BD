using System;
using System.Windows.Forms;
using BD1;
using BD1.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace form111
{
    public partial class Form1 : Form
    {
        private readonly PostgresContext context;
        private string connectionString = "Host=localhost;Username=postgres;Password=Kubek234;Database=postgres";

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

                Form formToShow;

                if (isAdmin)
                {
                    // Użytkownik jest adminem, otwieramy Form6
                    formToShow = new Form6();
                }
                else
                {
                    // Użytkownik nie jest adminem, ale może być pracownikiem
                    // Sprawdzamy w funkcji CheckCredentials, czy jest pracownikiem
                    // Jeśli tak, otwieramy Form12, w przeciwnym razie otwieramy Form7
                    bool isEmployee = IsEmployee(login);
                    formToShow = isEmployee ? new Form12() : new Form7(login);
                }

                formToShow.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsEmployee(string login)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand commandIsEmployee = new NpgsqlCommand("SELECT COUNT(*) FROM pracownik WHERE employee_name = @login", connection))
                    {
                        commandIsEmployee.Parameters.AddWithValue("@login", login);
                        int count = Convert.ToInt32(commandIsEmployee.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas sprawdzania poświadczeń: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();
                        using (var command = new NpgsqlCommand("SELECT check_credentials(@login, @password)", connection))
                        {
                            command.Parameters.AddWithValue("@login", login);
                            command.Parameters.AddWithValue("@password", password);

                            bool isValid = (bool)command.ExecuteScalar();

                            // Logowanie
                            Console.WriteLine($"IsValid: {isValid}");

                            // Sprawdzenie czy użytkownik jest pracownikiem
                            if (isValid)
                            {
                                using (NpgsqlCommand commandIsEmployee = new NpgsqlCommand("SELECT COUNT(*) FROM pracownik WHERE employee_name = @login", connection))
                                {
                                    commandIsEmployee.Parameters.AddWithValue("@login", login);
                                    int count = Convert.ToInt32(commandIsEmployee.ExecuteScalar());

                                    // Logowanie
                                    Console.WriteLine($"IsEmployee: {count > 0}");

                                    if (count > 0)
                                    {
                                        // Użytkownik jest pracownikiem
                                        isAdmin = false; // Może nie być adminem, ale jest pracownikiem
                                        return true; // Zwracamy true, aby otworzyć Form12
                                    }
                                }
                            }

                            return isValid;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas sprawdzania poświadczeń: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

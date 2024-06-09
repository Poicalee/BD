using BD1.Models;
using form111;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BD1
{
    public partial class Form11 : Form
    {
        private readonly PostgresContext context; // Adjust as necessary
        private string connectionString = "Host=localhost;Username=postgres;Password=Kubek234;Database=postgres";
        public Form11()
        {
            InitializeComponent();
            context = new PostgresContext();
            RefreshListBoxPracownicy(); // Call this method to fetch and display data from pracownicy_view
        }



        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form = new Form6();
            form.ShowDialog();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshListBoxPracownicy()
        {
            try
            {
                listBox1.Items.Clear(); // Clear existing items in ListBox

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM pracownicy_view", connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string employeeId = reader.IsDBNull(0) ? "Unknown" : reader.GetInt32(0).ToString();
                                string employeeName = reader.IsDBNull(1) ? "Unknown" : reader.GetString(1);
                                string employeeAddress = reader.IsDBNull(2) ? "Unknown" : reader.GetString(2);
                                string employeePhone = reader.IsDBNull(3) ? "Unknown" : reader.GetString(3);
                                string employeePosition = reader.IsDBNull(4) ? "Unknown" : reader.GetString(4);
                                string employeeSalary = reader.IsDBNull(5) ? "Unknown" : reader.GetDecimal(5).ToString();

                                listBox1.Items.Add($"{employeeId} - {employeeName} - {employeeAddress} - {employeePhone} - {employeePosition} - {employeeSalary}");
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

        private void dodajPracownika_Click_1(object sender, EventArgs e)
        {
            try
            {
                string employeeName = namePracTextBox.Text;
                string employeePosition = StanowiskoTextBox.Text;
                decimal employeeSalary = decimal.Parse(pensjaTextBox.Text);
                string employeeAddress = adresTextBox.Text;
                string employeePhone = numerKontTextBox.Text;
                string password = hasloTextBox.Text;

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("DodajPracownika", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@p_employee_name", NpgsqlTypes.NpgsqlDbType.Text, employeeName);
                        command.Parameters.AddWithValue("@p_employee_position", NpgsqlTypes.NpgsqlDbType.Text, employeePosition);
                        command.Parameters.AddWithValue("@p_employee_salary", employeeSalary);
                        command.Parameters.AddWithValue("@p_employee_address", NpgsqlTypes.NpgsqlDbType.Text, employeeAddress);
                        command.Parameters.AddWithValue("@p_employee_phone", NpgsqlTypes.NpgsqlDbType.Text, employeePhone);
                        command.Parameters.AddWithValue("@p_password", NpgsqlTypes.NpgsqlDbType.Text, password);


                        command.ExecuteNonQuery();
                    }
                }

                RefreshListBoxPracownicy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania pracownika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usunPracownika_Click(object sender, EventArgs e)
        {
            try
            {
                // Sprawdź, czy jakiś element jest zaznaczony
                if (listBox1.SelectedItem == null)
                {
                    MessageBox.Show("Proszę zaznaczyć pracownika do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Pobierz zaznaczony element
                string selectedItem = listBox1.SelectedItem.ToString();

                // Załóżmy, że employeeId jest pierwszym elementem w zaznaczonej linii
                int employeeId = int.Parse(selectedItem.Split('-')[0].Trim());

                using (var connection = (NpgsqlConnection)context.Database.GetDbConnection())
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("UsunPracownika", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_employee_id", employeeId);

                        command.ExecuteNonQuery();
                    }
                }

                // Odśwież listę pracowników po usunięciu
                RefreshListBoxPracownicy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania pracownika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edytujPracownika_Click(object sender, EventArgs e)
        {
            try
            {
                // Sprawdź, czy jakiś element jest zaznaczony
                if (listBox1.SelectedItem == null)
                {
                    MessageBox.Show("Proszę zaznaczyć pracownika do edycji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Pobierz zaznaczony element
                string selectedItem = listBox1.SelectedItem.ToString();

                // Załóżmy, że employeeId jest pierwszym elementem w zaznaczonej linii
                int employeeId = int.Parse(selectedItem.Split('-')[0].Trim());

                // Pobierz dane z TextBoxów
                string employeeName = namePracTextBox.Text;
                string employeePosition = StanowiskoTextBox.Text;
                decimal employeeSalary = decimal.Parse(pensjaTextBox.Text);
                string employeeAddress = adresTextBox.Text;
                string employeePhone = numerKontTextBox.Text;

                using (var connection = (NpgsqlConnection)context.Database.GetDbConnection())
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("EdytujPracownika", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@p_employee_id", employeeId);
                        command.Parameters.AddWithValue("@p_employee_name", employeeName);
                        command.Parameters.AddWithValue("@p_employee_position", employeePosition);
                        command.Parameters.AddWithValue("@p_employee_salary", employeeSalary);
                        command.Parameters.AddWithValue("@p_employee_address", employeeAddress);
                        command.Parameters.AddWithValue("@p_employee_phone", employeePhone);

                        command.ExecuteNonQuery();
                    }
                }

                RefreshListBoxPracownicy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas edycji pracownika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
using BD1.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form111
{
    public partial class Form3 : Form
{
        private string connectionString = "Host=localhost;Username=postgres;Password=Kubek234;Database=postgres";

        private readonly PostgresContext context;
        public Form3()
        {
            InitializeComponent();
            context = new PostgresContext();
        }
        private void button_click(Object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
        private void button_click2(Object sender, EventArgs e)
        {
            string readerName = textBox2.Text;
            string readerAddress = textBox5.Text;
            string readerPhone = textBox4.Text;
            string password = textBox1.Text;

            SaveLoginAndPasswordToDatabase(readerName, readerAddress, readerPhone, password);
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
        private void SaveLoginAndPasswordToDatabase(string readerName,string readerAddress,string readerPhone, string password)
        {

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("DodajCzytelnika", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("p_readername", NpgsqlTypes.NpgsqlDbType.Varchar, readerName);
                        command.Parameters.AddWithValue("p_readeraddress", NpgsqlTypes.NpgsqlDbType.Varchar, readerAddress);
                        command.Parameters.AddWithValue("p_readerphone", NpgsqlTypes.NpgsqlDbType.Varchar, readerPhone);
                        command.Parameters.AddWithValue("p_password", NpgsqlTypes.NpgsqlDbType.Varchar, password);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Czytelnik został dodany do bazy danych.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania czytelnika: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

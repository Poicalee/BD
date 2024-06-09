using BD1.Models;
using form111;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BD1
{
    public partial class Form10 : Form
    {
        private readonly PostgresContext context;

        public Form10()
        {
            InitializeComponent();
            context = new PostgresContext();
            RefreshListBoxWypozyczenie();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dodajWypozyczenie_Click(object sender, EventArgs e)
        {

        }

        private void edytujWypozyczenie_Click(object sender, EventArgs e)
        {

        }

        private void usunWypozyczenie_Click(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form = new Form6();
            form.ShowDialog();
            this.Close();
        }

        private void listBoxWypozyczenie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshListBoxWypozyczenie()
        {
            try
            {
                listBoxWypozyczenie.Items.Clear(); // Clear existing items in ListBox

                using (var connection = (NpgsqlConnection)context.Database.GetDbConnection())
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM vw_wypozyczenie", connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string loanDate = reader.IsDBNull(0) ? "Unknown" : reader.GetDateTime(0).ToString("yyyy-MM-dd");
                                string returnDate = reader.IsDBNull(1) ? "Unknown" : reader.GetDateTime(1).ToString("yyyy-MM-dd");
                                string returned = reader.IsDBNull(2) ? "Unknown" : reader.GetBoolean(2).ToString();
                                string readerName = reader.IsDBNull(3) ? "Unknown" : reader.GetString(3);
                                string bookTitle = reader.IsDBNull(4) ? "Unknown" : reader.GetString(4);
                                string authorName = reader.IsDBNull(5) ? "Unknown" : reader.GetString(5);

                                listBoxWypozyczenie.Items.Add($"{loanDate} - {returnDate} - {returned} - {readerName} - {bookTitle} - {authorName}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching loans: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

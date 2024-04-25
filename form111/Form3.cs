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
        public Form3()
        {
            InitializeComponent();
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
            SaveLoginAndPasswordToFile(textBox1.Text,textBox2.Text);
        }
        private void SaveLoginAndPasswordToFile(string login, string password)
        {
            string filePath = "C:\\Users\\Karol\\Desktop\\loginy.txt";

            try
            {
                // Tworzenie lub otwieranie istniejącego pliku w celu zapisania loginu i hasła
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Login: " + login);
                    writer.WriteLine("Password: " + password);
                }

                MessageBox.Show("Login and password saved to file successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving login and password to file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

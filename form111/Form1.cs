using System;
using System.IO;
using System.Windows.Forms;

namespace form111
{
    public partial class Form1 : Form
    {
        
        private string storedLogin;
        private string storedPassword;

        public Form1()
        {
            InitializeComponent();

            // Wczytanie danych z pliku po utworzeniu formularza
            string[] loginAndPassword = LoadLoginAndPasswordFromFile();
            if (loginAndPassword != null && loginAndPassword.Length == 2)
            {
                storedLogin = loginAndPassword[0];
                storedPassword = loginAndPassword[1];
            }
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

        private string[] LoadLoginAndPasswordFromFile()
        {
            //string filePath = "C:\\Users\\Karol\\Desktop\\loginy.txt";
            //nie wiem czemu nie działa z relatywną ścieżką, ale i tak będzie brał z baz danych to wywalone
            string filePath = "C:\\Users\\gubblebum\\RiderProjects\\BD\\form111\\pass.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    if (lines.Length >= 2)
                    {
                        string login = lines[0].Substring(lines[0].IndexOf(":") + 2);
                        string password = lines[1].Substring(lines[1].IndexOf(":") + 2);

                        return new string[] { login, password };
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading login and password from file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private bool CheckCredentials(string login, string password)
        {
            if (login == storedLogin && password == storedPassword)
            {
                return true;
            }
            else
            {
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

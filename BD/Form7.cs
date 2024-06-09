using System;
using System.Windows.Forms;

namespace form111
{
    public partial class Form7 : Form
    {
        private string login;
        public Form7()
        {
            InitializeComponent();
        }
        public Form7(string login) : this()
        {
            this.login = login;
        }


        private void przegladajKsiazki_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form = new Form5();
            form.ShowDialog();
            this.Close();
        }

        private void kontoButt_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(login);
            form4.ShowDialog();
        }
    }
}
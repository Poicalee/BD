using System;
using System.Windows.Forms;

namespace form111
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }


        private void przegladajKsiazki_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
            this.Close();
        }

        private void kontoButt_Click(object sender, EventArgs e)
        {

        }
    }
}
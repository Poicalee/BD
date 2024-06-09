using BD1;
using System;
using System.Windows.Forms;

namespace form111
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void KsiazkiCRUD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
            this.Close();
        }
        private void UserCRUD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form = new Form8();
            form.ShowDialog();
            this.Close();
        }
        private void AutorCRUD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 form = new Form9();
            form.ShowDialog();
            this.Close();
        }
        private void PracownikCRUD_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form11 form = new Form11();
            form.ShowDialog();
            this.Close();
        }
        private void WypozyczenieCRUD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form = new Form10();
            form.ShowDialog();
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void WypozyczenieCRUD_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form = new Form10();
            form.ShowDialog();
            this.Close();
        }

        private void AuthorCRUD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 form = new Form9();
            form.ShowDialog();
            this.Close();
        }

        private void KsiazkiCRUD_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
            this.Close();
        }
    }
}
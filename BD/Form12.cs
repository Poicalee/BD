using form111;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD1
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WypozyczenieCRUD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 form = new Form13();
            form.ShowDialog();
            this.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void KsiazkiCRUD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 form = new Form14();
            form.ShowDialog();
            this.Close();

        }

        private void AuthorCRUD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 form = new Form15();
            form.ShowDialog();
            this.Close();
        }

        private void wyloguj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
    }
}

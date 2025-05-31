using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Projekt
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtIme.Text;
            string lozinka = txtLozinka.Text;

            if (korisnickoIme == "Zaposlenik1" && lozinka == "1234")
            {
                MessageBox.Show("Prijava uspješna!");

                this.Hide();
                ZaposlenikForm zaposlenik = new ZaposlenikForm();
                zaposlenik.Show();
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka.");
            }
        }
    }
}


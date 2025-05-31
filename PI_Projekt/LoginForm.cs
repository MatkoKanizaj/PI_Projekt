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

            if (korisnickoIme == "admin" && lozinka == "admin123")
            {
                MessageBox.Show("Prijava uspješna!");

                this.Hide();
                StartForm startForm = new StartForm();
                startForm.Show();
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka.");
            }
        }
    }
}


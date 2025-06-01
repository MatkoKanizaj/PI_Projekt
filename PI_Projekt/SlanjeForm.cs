using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Interop;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PI_Projekt
{
    public partial class SlanjeForm : Form
    {
        public SlanjeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPosalji_click(object sender, EventArgs e)
{
            if (comboKonfiguracije.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo odaberite konfiguraciju.");
                return;
            }

            string konfiguracija = comboKonfiguracije.SelectedItem.ToString();

   
            if (radioButton2.Checked)
            {
                string email = txtemail.Text;

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Unesite e-mail adresu.");
                    return;
                }

       
                MessageBox.Show($"Konfiguracija '{konfiguracija}' poslana je na e-mail: {email}");
            }
            else if (radioButton1.Checked)
            {
      
                MessageBox.Show($"Konfiguracija '{konfiguracija}' poslana je zaposleniku u trgovini.");
            }
            else
            {
                MessageBox.Show("Molim odaberite način slanja (e-mail ili zaposleniku).");
            }
        }


        private void SlanjeForm_Load(object sender, EventArgs e)
        {
            comboKonfiguracije.Items.Add("Office konfiguracija");
            comboKonfiguracije.Items.Add("Gaming konfiguracija");
            comboKonfiguracije.Items.Add("Budget konfiguracija");
            comboKonfiguracije.Items.Add("Video editing konfiguracija");
            comboKonfiguracije.Items.Add("Konfiguracija kupca");

        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show(
            "Jeste li sigurni da se želite vratiti na početni zaslon?",
            "Potvrda",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (rezultat == DialogResult.Yes)
            {
                this.Hide();
                StartForm back = new StartForm();
                back.Show();
            }
        }

    }
}

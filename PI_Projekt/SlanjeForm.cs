using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Interop;
using System.Linq;
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
            string konfiguracija = comboKonfiguracije.Text;
            string primatelj = txtemail.Text;

            if (konfiguracija == "")
            {
                MessageBox.Show("Odaberi konfiguraciju!", "Greška");
                return;
            }

            if (radioButton2.Checked)
            {
                if (primatelj == "")
                {
                    MessageBox.Show("Unesi e-mail primatelja!", "Greška");
                    return;
                }

                MessageBox.Show("Konfiguracija \"" + konfiguracija + "\" poslana na e-mail: " + primatelj + ".", "Uspješno");
            }
            else if (radioButton1.Checked)
            {
                MessageBox.Show("Konfiguracija \"" + konfiguracija + "\" proslijeđena zaposleniku.", "Uspješno");
            }
            else
            {
                MessageBox.Show("Odaberi način slanja!", "Greška");
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

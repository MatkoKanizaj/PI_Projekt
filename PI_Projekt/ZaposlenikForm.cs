using DBLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PI_Projekt
{
    public partial class ZaposlenikForm : Form
    {
        public ZaposlenikForm()
        {
            InitializeComponent();
            DB.SetConfiguration("PI2425_mkanizaj23_DB", "PI2425_mkanizaj23_User", "-K>rQwHt");
            UcitajKomponente();
        }

        private void UcitajKomponente()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Naziv", "Naziv");
            dataGridView1.Columns.Add("Tip", "Tip");
            dataGridView1.Columns.Add("Proizvodac", "Proizvođač");
            dataGridView1.Columns.Add("Model", "Model");
            dataGridView1.Columns.Add("Cijena", "Cijena");
            dataGridView1.Columns.Add("KolicinaNaSkladistu", "Količina");
            dataGridView1.Columns.Add("Opis", "Opis");
            dataGridView1.Columns.Add("Kompatibilnost", "Kompatibilnost");

            List<Komponenta> lista = KomponentaRepozitorij.DohvatiSve();

            foreach (var k in lista)
            {
                dataGridView1.Rows.Add(
                    k.Naziv,
                    k.Tip,
                    k.Proizvodac,
                    k.Model,
                    k.Cijena.ToString("F2"),
                    k.KolicinaNaSkladistu,
                    k.Opis,
                    k.Kompatibilnost
                );
            }
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            Komponenta nova = new Komponenta
            {
                Naziv = txtNaziv.Text,
                Tip = txtTip.Text,
                Proizvodac = txtproiz.Text,
                Model = txtModel.Text,
                Cijena = decimal.Parse(txtCijena.Text),
                KolicinaNaSkladistu = int.Parse(txtKolicina.Text),
                Opis = txtOpis.Text,
                Kompatibilnost = txtKompatibilnost.Text
            };

            try
            {
                KomponentaRepozitorij.Dodaj(nova);
                MessageBox.Show("Komponenta uspješno dodana.");
                UcitajKomponente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dodavanja: " + ex.Message);
            }
        }
    }
}

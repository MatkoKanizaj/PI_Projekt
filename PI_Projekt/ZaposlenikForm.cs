using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PI_Projekt
{
    public partial class ZaposlenikForm : Form
    {
        string konekcija = "Server=31.147.206.65;Database=PI2425_mkanizaj23_DB;User Id=PI2425_mkanizaj23_User;Password=-K>rQwHt;Encrypt=False;TrustServerCertificate=True;";

        public ZaposlenikForm()
        {
            InitializeComponent();
            UcitajKomponente();
        }

        private void UcitajKomponente()
        {
            try
            {
          
                DataTable tablica = new DataTable();

               
                using (SqlConnection veza = new SqlConnection(konekcija))
                {
                    veza.Open();

                    string upit = "SELECT Naziv, Tip, Proizvođač, Model, Cijena, KoličinaNaSkladištu, Opis, Kompatibilnost FROM Komponenta";

                    SqlDataAdapter adapter = new SqlDataAdapter(upit, veza);
                    adapter.Fill(tablica);

                    dataGridView1.DataSource = tablica;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška pri dohvaćanju podataka: ");
            }
        }
    }
}
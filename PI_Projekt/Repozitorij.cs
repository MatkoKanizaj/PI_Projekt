using DBLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace PI_Projekt
{
    public class Komponenta
    {
        public string Naziv { get; set; }
        public string Tip { get; set; }
        public string Proizvodac { get; set; }
        public string Model { get; set; }
        public decimal Cijena { get; set; }
        public int KolicinaNaSkladistu { get; set; }
        public string Opis { get; set; }
        public string Kompatibilnost { get; set; }
    }

    public static class KomponentaRepozitorij
    {
        public static List<Komponenta> DohvatiSve()
        {
            List<Komponenta> lista = new List<Komponenta>();
            DB.OpenConnection();

            var reader = DB.GetDataReader("SELECT * FROM Komponenta");

            while (reader.Read())
            {
                var k = new Komponenta()
                {
                    Naziv = reader["Naziv"].ToString(),
                    Tip = reader["Tip"].ToString(),
                    Proizvodac = reader["Proizvođač"].ToString(),
                    Model = reader["Model"].ToString(),
                    Cijena = Convert.ToDecimal(reader["Cijena"]),
                    KolicinaNaSkladistu = Convert.ToInt32(reader["KoličinaNaSkladištu"]),
                    Opis = reader["Opis"].ToString(),
                    Kompatibilnost = reader["Kompatibilnost"].ToString()
                };
                lista.Add(k);
            }

            reader.Close();
            DB.CloseConnection();
            return lista;
        }

        public static void Dodaj(Komponenta k)
        {
            DB.OpenConnection();

            string sql = $@"
                INSERT INTO Komponenta (Naziv, Tip, Proizvođač, Model, Cijena, KoličinaNaSkladištu, Opis, Kompatibilnost)
                VALUES (
                    '{k.Naziv}',
                    '{k.Tip}',
                    '{k.Proizvodac}',
                    '{k.Model}',
                    {k.Cijena.ToString().Replace(",", ".")},
                    {k.KolicinaNaSkladistu},
                    '{k.Opis}',
                    '{k.Kompatibilnost}'
                )";

            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }


    }
}

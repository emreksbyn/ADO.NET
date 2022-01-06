using System;
using System.Data.SqlClient;
using System.Data;

namespace _3_ADO.NET_AdresDefteri
{
    public class Kisi
    {
        public Kisi()
        {

        }

        public Kisi(string ad, string soyad, int grupID, bool kadinMi, DateTime dogumTarihi, string evTelefonu, string cepTelefonu, string ePosta, string adres, string resimYolu)
        {
            this.Adi = ad;
            this.Soyadi = soyad;
            this.GrupID = grupID;
            this.KadinMi = kadinMi;
            this.DogumTarihi = dogumTarihi;
            this.EvTelefonu = evTelefonu;
            this.CepTelefonu = cepTelefonu;
            this.EPostaAdresi = ePosta;
            this.Adresi = adres;
            this.ResimYolu = resimYolu;
        }

        public int KisiID { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public int GrupID { get; set; }

        public bool KadinMi { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string EvTelefonu { get; set; }

        public string CepTelefonu { get; set; }

        public string EPostaAdresi { get; set; }

        public string Adresi { get; set; }

        public string ResimYolu { get; set; }


        public static bool KisiEkle(Kisi eklenecekKisi)
        {

            using (SqlConnection conn = Baglanti.Connection())
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Kisiler VALUES (@Adi, @Soyadi, @GrupID, @KadinMi, @DogumTarihi, @EvTelefonu, @CepTelefonu, @EPostaAdresi, @Adresi, @ResimYolu)", conn);

                cmd.Parameters.AddWithValue("@Adi", eklenecekKisi.Adi);
                cmd.Parameters.AddWithValue("@Soyadi", eklenecekKisi.Soyadi);
                cmd.Parameters.AddWithValue("@GrupID", eklenecekKisi.GrupID);
                cmd.Parameters.AddWithValue("@KadinMi", eklenecekKisi.KadinMi);
                cmd.Parameters.AddWithValue("@DogumTarihi", eklenecekKisi.DogumTarihi);
                cmd.Parameters.AddWithValue("@EvTelefonu", eklenecekKisi.EvTelefonu);
                cmd.Parameters.AddWithValue("@CepTelefonu", eklenecekKisi.CepTelefonu);
                cmd.Parameters.AddWithValue("@EPostaAdresi", eklenecekKisi.EPostaAdresi);
                cmd.Parameters.AddWithValue("@Adresi", eklenecekKisi.Adresi);
                cmd.Parameters.AddWithValue("@ResimYolu", eklenecekKisi.ResimYolu);

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                return cmd.ExecuteNonQuery() > 0;

            }
        }

        public static bool KisiSil(Kisi silinecekKisi)
        {
            SqlConnection conn = Baglanti.Connection();

            using (conn)
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM Kisiler WHERE KisiID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", silinecekKisi.KisiID);

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool KisiGuncelle(Kisi guncellenecekKisi)
        {
            SqlConnection conn = Baglanti.Connection();

            using (conn)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Kisiler SET Adi = @Adi, Soyadi = @Soyadi, GrupID = @GrupID, KadinMi = @KadinMi, DogumTarihi = @DogumTarihi, EvTelefonu = @EvTel, CepTelefonu = @CepTel, EPostaAdresi = @EPosta, Adresi = @Adresi, ResimYolu = @ResimYolu WHERE KisiID = @ID", conn);

                cmd.Parameters.AddWithValue("@Adi", guncellenecekKisi.Adi);
                cmd.Parameters.AddWithValue("@Soyadi", guncellenecekKisi.Soyadi);
                cmd.Parameters.AddWithValue("@GrupID", guncellenecekKisi.GrupID);
                cmd.Parameters.AddWithValue("@KadinMi", guncellenecekKisi.KadinMi);
                cmd.Parameters.AddWithValue("@DogumTarihi", guncellenecekKisi.DogumTarihi);
                cmd.Parameters.AddWithValue("@EvTel", guncellenecekKisi.EvTelefonu);
                cmd.Parameters.AddWithValue("@CepTel", guncellenecekKisi.CepTelefonu);
                cmd.Parameters.AddWithValue("@EPosta", guncellenecekKisi.EPostaAdresi);
                cmd.Parameters.AddWithValue("@Adresi", guncellenecekKisi.Adresi);
                cmd.Parameters.AddWithValue("@ResimYolu", guncellenecekKisi.ResimYolu);
                cmd.Parameters.AddWithValue("@ID", guncellenecekKisi.KisiID);


                if (conn.State != ConnectionState.Open)
                    conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static Kisi[] Kisiler()
        {
            SqlConnection conn = Baglanti.Connection();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Kisiler", conn);

            if (conn.State != ConnectionState.Open)
                conn.Open();

            int toplamKayit = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.CommandText = "SELECT * FROM Kisiler";

            SqlDataReader rdr = cmd.ExecuteReader();

            Kisi[] kisiler = new Kisi[toplamKayit];

            int sayac = 0;

            while (rdr.Read())
            {
                Kisi kisi = new Kisi()
                {
                    KisiID = rdr.GetInt32(0),
                    Adi = rdr.GetString(1),
                    Soyadi = rdr.GetString(2),
                    GrupID = rdr.GetInt32(3),
                    KadinMi = rdr.GetBoolean(4),
                    DogumTarihi = rdr.GetDateTime(5),
                    EvTelefonu = rdr["EvTelefonu"].ToString(),
                    CepTelefonu = rdr["CepTelefonu"].ToString(),
                    EPostaAdresi = rdr["EPostaAdresi"].ToString(),
                    Adresi = rdr["Adresi"].ToString(),
                    ResimYolu = rdr["ResimYolu"].ToString()
                };

                kisiler[sayac] = kisi;
                sayac++;
            }

            conn.Close();

            return kisiler;
        }

        public override string ToString()
        {
            return this.Adi + " " + this.Soyadi;
        }
    }
}

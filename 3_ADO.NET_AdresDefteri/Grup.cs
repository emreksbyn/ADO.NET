using System.Data.SqlClient;
using System.Collections;

namespace _3_ADO.NET_AdresDefteri
{
    public class Grup
    {
        public Grup()
        {

        }

        public Grup(int grupID, string grupAdi)
        {
            this.GrupID = grupID;
            this.GrupAdi = grupAdi;
        }

        public Grup(string grupAdi)
        {
            this.GrupAdi = grupAdi;
        }

        public int GrupID { get; set; }

        public string GrupAdi { get; set; }

        public static bool GrupEkle(Grup eklenecekGrup)
        {
            SqlConnection conn = Baglanti.Connection();

            SqlCommand cmd = new SqlCommand("INSERT INTO Gruplar VALUES(@Adi)", conn);
            cmd.Parameters.AddWithValue("@Adi", eklenecekGrup.GrupAdi);

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            return cmd.ExecuteNonQuery() > 0;
        }


        public static bool GrupSil(Grup silinecekGrup)
        {
            SqlConnection conn = Baglanti.Connection();

            SqlCommand cmd = new SqlCommand("DELETE FROM Gruplar WHERE GrupID = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", silinecekGrup.GrupID);

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            return cmd.ExecuteNonQuery() > 0;
        }

        public static object[] Gruplar()
        {
            SqlConnection conn = Baglanti.Connection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Gruplar", conn);

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            ArrayList gruplar = new ArrayList();

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Grup yeniGrup = new Grup(rdr.GetInt32(0), rdr.GetString(1));
                gruplar.Add(yeniGrup);
            }

            conn.Close();

            return gruplar.ToArray();
        }
    }
}

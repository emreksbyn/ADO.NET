using System.Data.SqlClient;

namespace _3_ADO.NET_AdresDefteri
{
    public class Baglanti
    {
        public static SqlConnection Connection()
        {
            SqlConnectionStringBuilder connSb = new SqlConnectionStringBuilder("Server=.; Database=AdresDefteri; Integrated Security = TRUE")
            {
                Pooling = true,
                MinPoolSize = 3,
                MaxPoolSize = 10,
                MultipleActiveResultSets = true
            };

            return new SqlConnection(connSb.ConnectionString);
        }
    }
}

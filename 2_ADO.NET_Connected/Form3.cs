using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Transactions;

namespace _2_ADO.NET_Connected
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=.; Database=Northwind; Integrated Security=SSPI");
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlTransaction tran = conn.BeginTransaction();

            SqlCommand cmdAl = new SqlCommand("UPDATE Hesaplar SET Bakiye = Bakiye + @Tutar WHERE HesapNumarasi = @AlanHesap", conn);

            cmdAl.Parameters.AddWithValue("@Tutar", numTutar.Value);
            cmdAl.Parameters.AddWithValue("@AlanHesap", txtAlan.Text);

            cmdAl.Transaction = tran;

            SqlCommand cmdGonder = new SqlCommand("UPDATE Hesaplar SET Bakiye = Bakiye - @Tutar WHERE HesapNumarasi = @GonderenHesap", conn);

            cmdGonder.Parameters.AddWithValue("@Tutar", numTutar.Value);
            cmdGonder.Parameters.AddWithValue("@GonderenHesap", txtGonderen.Text);

            cmdGonder.Transaction = tran;

            try
            {
                cmdAl.ExecuteNonQuery();
                throw new InsufficientMemoryException();
                cmdGonder.ExecuteNonQuery();
                // Buraya kadar gelinebildiyse, yukarıdaki tüm kodlar çalıştırılmış demektir :
                tran.Commit();
            }
            catch (Exception)
            {
                MessageBox.Show("Havale sırasında beklenmedik bir hata oluştu. Lütfen daha sonra tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tran.Rollback();
            }

        }

        private void btnGonderYeni_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    // Çalıştırılacak (execute) olan SqlCommand nesnelerinin üzerinde çalışacağı SqlConnection nesnesinin TransactionScope içerisinde açılması (Open()) gerekmektedir. Eğer ilgili SqlConnection nesnesi daha önceden açık ise (State == ConnectionState.Open) çalıştırılacak olan komutlar transaction'a dahil olmazlar. Bu nedenle işlem bittikten sonra SqlConnection nesnesinin kapatılması gerekmektedir (finally bloğu). Çünkü eğer kapatılmazsa, butona tekrar tıklandığında SqlConnection açık olacağından, üzerinden çalıştırılacak hiçbir komut (SqlCommand nesneleri) transaction'a dahil olmayacaktır.
                    SqlCommand cmdAl = new SqlCommand("UPDATE Hesaplar SET Bakiye = Bakiye + @Tutar WHERE HesapNo = @AlanHesap", conn);

                    cmdAl.Parameters.AddWithValue("@Tutar", numTutar.Value);
                    cmdAl.Parameters.AddWithValue("@AlanHesap", txtAlan.Text);

                    SqlCommand cmdGonder = new SqlCommand("UPDATE Hesaplar SET Bakiye = Bakiye - @Tutar WHERE HesapNo = @GonderenHesap", conn);

                    cmdGonder.Parameters.AddWithValue("@Tutar", numTutar.Value);
                    cmdGonder.Parameters.AddWithValue("@GonderenHesap", txtGonderen.Text);

                    cmdAl.ExecuteNonQuery();
                    throw new FormatException("Havale sırasında beklenmedik bir hata oluştu. Lütfen daha sonra tekrar deneyiniz.");
                    cmdGonder.ExecuteNonQuery();
                    // Buraya kadar gelinebildiyse, yukarıdaki tüm kodlar çalıştırılmış demektir :
                    scope.Complete();

                }
            }
            catch (Exception ex)
            {
                // Catch parantezinde parametre olarak Exception yerine FormatException tanımlandığından, Catch bloğuna düşülmesi için, fırlatılacak olan exception'ın FormatException olması gerekmektedir. Başka bir exception fırlatılması durumunda (IndexOutOfRangeException, FieldAccessException, SqlException vb.) catch bloğuna düşülmeyecektir. Catch bloğuna düşülmesi için, parametre olarak ya ilgili exception ile aynı tipte bir değişken tanımlanmalıdır (FormatException ex) ya da tüm exception'ları kapsayan Exception tipinde tanımlanmalıdır (Exception ex).
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ne olursa olsun, SqlConnection nesnesi kapatılacak -ki butona bir daha tıklandığında, TransactionScope başlangıcında bağlantı kapalı olsun ve TransactionScope içerisinde açılsın! Aksi halde Transaction çalışmaz.
                conn.Close();
            }

        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _2_ADO.NET_Connected
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conn;

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=.; Database=Northwind; Integrated Security = TRUE");

            if (conn.State != ConnectionState.Open)
                conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT ProductName FROM Products", conn);

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                cmbProductName.Items.Add(rdr[0].ToString());
            }

            conn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Prosedure kullanmak için :
            SqlCommand cmd = new SqlCommand("uspElemanEkle", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Adi", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@Soyadi", txtLastName.Text);
            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters["@ID"].Direction = ParameterDirection.Output;
            if (conn.State != ConnectionState.Open)
                conn.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                int id = Convert.ToInt32(cmd.Parameters["@ID"].Value);
                MessageBox.Show(id + " numaralı yeni çalışan başarıyla eklendi");
            }
            else
            {
                MessageBox.Show("Çalışan eklenemedi");
            }
        }

        private void btnStockByID_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("[uspStokMiktari]", conn);
            cmd.CommandType = CommandType.StoredProcedure;


            int urunID = int.Parse(txtProductID.Text);

            cmd.Parameters.AddWithValue("@UrunID", urunID);

            cmd.Parameters.Add("@stok", SqlDbType.Int);
            cmd.Parameters["@stok"].Direction = ParameterDirection.ReturnValue;

            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.ExecuteNonQuery();

            int stok = Convert.ToInt32(cmd.Parameters["@stok"].Value);

            MessageBox.Show(String.Format("{0} numaralı ürünün stok miktarı : {1}", urunID, stok));
        }

        private void btnStockByName_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT ProductID FROM Products WHERE ProductName = @Name", conn);
            cmd.Parameters.AddWithValue("@Name", cmbProductName.SelectedItem.ToString());

            if (conn.State != ConnectionState.Open)
                conn.Open();
            object gelen = cmd.ExecuteScalar();

            int urunID = Convert.ToInt32(gelen);
            cmd.Parameters.Clear();

            cmd.CommandText = "uspStokMiktari";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunID", urunID);

            cmd.Parameters.Add("@stok", SqlDbType.Int);
            cmd.Parameters["@stok"].Direction = ParameterDirection.ReturnValue;

            cmd.ExecuteNonQuery();

            int stok = Convert.ToInt32(cmd.Parameters["@stok"].Value);

            MessageBox.Show(String.Format("{0} numaralı ürünün stok miktarı : {1}", urunID, stok));

        }
    }
}

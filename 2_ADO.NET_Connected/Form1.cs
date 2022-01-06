using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _2_ADO.NET_Connected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn;

        Customer selectedCustomer;

        private void Clear()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                    item.ResetText();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=.; Database=Northwind; Trusted_Connection=SSPI");

            GetCustomers();

        }
        private void GetCustomers()
        {
            lstboxCustomers.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT CustomerID, CompanyName, ContactName, Phone, Country FROM Customers", conn);

            if (conn.State != ConnectionState.Open)
                conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Customer customer = new Customer()
                {
                    CustomerID = rdr.GetString(0),
                    CompanyName = rdr.GetString(1),
                    ContactName = rdr.GetString(2),
                    Phone = rdr.GetString(3),
                    Country = rdr.GetString(4)
                };

                lstboxCustomers.Items.Add(customer);
            }

            conn.Close();
        }

        private void lstboxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstboxCustomers.SelectedItem == null)
                return;

            selectedCustomer = lstboxCustomers.SelectedItem as Customer;

            txtCustomerID.Text = selectedCustomer.CustomerID;
            txtCompanyName.Text = selectedCustomer.CompanyName;
            txtContactName.Text = selectedCustomer.ContactName;
            txtPhone.Text = selectedCustomer.Phone;
            txtCountry.Text = selectedCustomer.Country;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Bu şekildeki kullanım SQL Injection' a yani sorgunun amacı dışına, zarar verici amaçla kullanılmasına izin verir.
            SqlCommand cmdYanlis = new SqlCommand("DELETE FROM Customers WHERE CustomerID = '" + txtCustomerID.Text + "'", conn);

            // Bunun önüne geçmek için parametreleri kullanmalıyız.
            SqlCommand cmd = new SqlCommand("DELETE FROM Customers WHERE CustomerID = @ID", conn);

            SqlParameter param = new SqlParameter("@ID", SqlDbType.Char, 5);
            param.Value = selectedCustomer.CustomerID;

            cmd.Parameters.Add(param);

            if (conn.State != ConnectionState.Open)
                conn.Open();

            int etkilenenSatirSayisi = cmd.ExecuteNonQuery();

            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Kayıt başarıyla silindi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt silinemedi.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            GetCustomers();

            Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer()
            {
                CustomerID = txtCustomerID.Text,
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                Phone = txtPhone.Text,
                Country = txtCountry.Text
            };

            SqlCommand cmd = new SqlCommand("INSERT INTO Customers (CustomerID, CompanyName, ContactName, Phone, Country) VALUES(@ID, @CompanyName, @ContactName, @Phone, @Country)", conn);

            cmd.Parameters.Add("@ID", SqlDbType.Char, 5);
            cmd.Parameters[0].Value = newCustomer.CustomerID;

            cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 40);
            cmd.Parameters["@CompanyName"].Value = newCustomer.CompanyName;

            cmd.Parameters.Add("@ContactName", SqlDbType.NVarChar, 30);
            cmd.Parameters["@ContactName"].Value = newCustomer.ContactName;

            cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 24);
            cmd.Parameters["@Phone"].Value = newCustomer.Phone;

            SqlParameter paramCountry = new SqlParameter("@Country", newCustomer.Country);

            cmd.Parameters.Add(paramCountry);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Yeni kayıt başarıyla eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Yeni kayıt eklenemedi.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            GetCustomers();

            Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Customers SET CompanyName = @CompanyName, ContactName = @ContactName, Phone = @Phone, Country = @Country WHERE CustomerID = @ID", conn);

            Customer customer = new Customer()
            {
                CustomerID = txtCustomerID.Text,
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                Phone = txtPhone.Text,
                Country = txtCountry.Text
            };

            cmd.Parameters.AddWithValue("@ID", selectedCustomer.CustomerID);
            cmd.Parameters.AddWithValue("@CompanyName", customer.CompanyName);
            cmd.Parameters.AddWithValue("@ContactName", customer.ContactName);
            cmd.Parameters.AddWithValue("@Phone", customer.Phone);
            cmd.Parameters.AddWithValue("@Country", customer.Country);

            if (selectedCustomer.CustomerID != txtCustomerID.Text)
            {
                if (MessageBox.Show("Güncellemek istediğiniz kaydın CustomerID bilgisi aynı kalacaktır.\nDevam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                    return;
            }

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Kayıt başarıyla güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayıt güncellenemedi.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            GetCustomers();

            Clear();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            // Eğer çalıştırılacak olan sorgu sonucu geriye scalar bir değer döndürülmek istenirse (tek satır, tek kolon - tek hücre) SqlCommand nesnesinin ExecuteScalar() metodu kullanılır. 

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Customers", conn);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            object gelen = cmd.ExecuteScalar();

            int toplam = Convert.ToInt32(gelen);

            MessageBox.Show("Toplam kayıt sayısı : " + toplam);

            MessageBox.Show("Toplam kayıt sayısı : " + lstboxCustomers.Items.Count.ToString());


            // Geriye koca bir tablo dönen sorgu çalıştırıldığında :
            cmd.CommandText = "SELECT ProductName, UnitPrice  FROM Products";

            object gelen2 = cmd.ExecuteScalar();

            MessageBox.Show(String.Format("SELECT ProductName, UnitPrice FROM Prodocuts - sorgusundan geriye dönen değer : {0}", gelen2));
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (sender as TextBox);

            txt.SelectionStart = txt.Text.Length;

            if (txt.Text.Length > 5)
                txt.Text = txt.Text.Remove(5);

            txt.Text = txt.Text.ToUpper();
        }
    }
}

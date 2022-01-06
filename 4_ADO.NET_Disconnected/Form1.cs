using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_ADO.NET_Disconnected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet("Northwind");

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employees", "Server=.; Database=Northwind; Integrated Security=SSPI");

            da.Fill(ds);

            dgvVeriler.DataSource = ds.Tables[0];
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            // Arka planda hangi nesne, hangi nesnenin özelliği olarak kullanılmakta :
            SqlConnection conn = new SqlConnection("Server=.; Database=Northwind; Integrated Security=SSPI");

            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers");

            cmd.Connection = conn;

            DataSet ds = new DataSet("Northwind");

            DataTable dt = new DataTable("Customers");

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            da.Fill(dt);

            ds.Tables.Add(dt);

            dgvVeriler.DataSource = ds.Tables["Customers"];
        }
    }
}

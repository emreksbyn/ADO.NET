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

namespace XML_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        DataSet ds;

        private void Form1_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM Customers", "Server=.; Database=Northwind; Integrated Security=true");

            ds = new DataSet("Northwind");
        }

        private void btnDoldur_Click(object sender, EventArgs e)
        {
            da.Fill(ds);

            dgvCustomers.DataSource = ds.Tables[0];
        }

        private void btnXmlYaz_Click(object sender, EventArgs e)
        {
            ds.WriteXml("..\\..\\Customers.xml");
            MessageBox.Show("Müşteriler tablosu başarıyla XML olarak yazıldı");
        }

        private void btnXmlOku_Click(object sender, EventArgs e)
        {
            ds.ReadXml("..\\..\\Customers.xml");
            dgvCustomers.DataSource = ds.Tables[0];
        }
    }
}

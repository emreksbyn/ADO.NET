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
using System.Xml;

namespace XML_Giris
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        XmlTextWriter xtw;
        SqlConnection conn;
        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server =.; Database = Northwind; Integrated Security = true");
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products", conn);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            xtw = new XmlTextWriter("..\\..\\Urunler.xml", Encoding.GetEncoding(1254));
            xtw.Formatting = Formatting.Indented;

            //XML dokümanı yazmaya başlarnır :
            xtw.WriteStartDocument();

            xtw.WriteComment("Ürünlerin tam listesi");

            //Root element (ürünler) yazılmaya başlanır:
            xtw.WriteStartElement("Urunler");

            while (rdr.Read())
            {
                //Urun elementi yazmaya başlanır:
                xtw.WriteStartElement("Urun");

                xtw.WriteAttributeString("ID", rdr.GetInt32(0).ToString());

                for (int i = 1; i < rdr.FieldCount; i++)
                {
                    // Ürün elementinin altına kolanlar bir kerede yazılır :

                    xtw.WriteElementString(Turkcelestir(rdr.GetName(i)), rdr[i].ToString());
                }
                //ürün elementin tag'i kapatılır.
                xtw.WriteEndElement();
            }

            //Root elementin tag'i kapatılır.
            xtw.WriteEndElement();

            //XML dokümanı yazımı bitirilir.
            xtw.WriteEndDocument();

            // XmlTextWrite nesneni kapatılır -böylece kullanılmakta olan kaynaklar (.xml dosyası) release edilir.
            xtw.Close();

            conn.Close();

            MessageBox.Show("Ürünler XML olarak export edilmiştir.");
        }
        private string Turkcelestir(string yabanci)
        {
            switch (yabanci)
            {
                case "ProductName":
                    return "UrunAdi";
                case "SupplierID":
                    return "TedarikciID";
                case "CategoryID":
                    return "KategoriID";
                case "QuantityPerUnit":
                    return "BirimAdetMiktari";
                case "UnitPrice":
                    return "BirimFiyati";
                case "UnitsInStock":
                    return "Stok";
                case "UnitsOnOrder":
                    return "SiparisSayisi";
                case "ReorderLevel":
                    return "YenidenSiparisSeviyesi";
                case "Discontinued":
                    return "TedariktenKalkti";
                default:
                    return yabanci;
            }
        }
    }
}

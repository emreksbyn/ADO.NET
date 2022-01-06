using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace XML_Devam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn;

        XmlTextWriter xtw;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Server=.; Database=Northwind; Trusted_Connection=SSPI");
        }

        private void btnWriteXML_Click(object sender, EventArgs e)
        {
            xtw = new XmlTextWriter("..\\..\\Products.xml", Encoding.GetEncoding(1254));

            SqlCommand cmd = new SqlCommand("SELECT * FROM Products", conn);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            xtw.Formatting = Formatting.Indented;

            xtw.WriteStartDocument();

            xtw.WriteStartElement("Products");

            while (rdr.Read())
            {
                xtw.WriteStartElement("Product");

                xtw.WriteAttributeString("ID", rdr.GetInt32(0).ToString());

                for (int i = 1; i < rdr.FieldCount; i++)
                {
                    xtw.WriteElementString(rdr.GetName(i), rdr[i].ToString());
                }

                xtw.WriteEndElement();
            }

            xtw.WriteEndElement();

            xtw.WriteEndDocument();

            xtw.Close();

            conn.Close();

            MessageBox.Show("XML başarıyla yazdırıldı");
        }

        private void btnReadXML_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();

            // XML dökümanı XmlDocument nesnesine yüklenir :
            xDoc.Load("..\\..\\Products.xml");

            // Root element olan Suppliers nodu komple seçildi :
            XmlNode rootNode = xDoc.SelectSingleNode("Products");

            // Suppliers nodunun ilk nodu seçilir :
            XmlNode firstNode = rootNode.FirstChild;

            XmlAttribute att = firstNode.Attributes["ID"];

            string mainColumn = att.Name;

            XmlNodeList childNodes = firstNode.ChildNodes;

            lstviewSuppliers.Columns.Add(mainColumn, 30);

            foreach (XmlNode item in childNodes)
            {
                lstviewSuppliers.Columns.Add(item.LocalName, 120);
            }

            ListViewGroup group1 = new ListViewGroup("A-M");
            ListViewGroup group2 = new ListViewGroup("M-Z");

            lstviewSuppliers.Groups.Add(group1);
            lstviewSuppliers.Groups.Add(group2);

            // Veriler :

            XmlNodeList supplierNodes = xDoc.SelectNodes("Products/Product");

            int sayac = 0;

            foreach (XmlNode item in supplierNodes)
            {
                if (item.Attributes["ID"].Value.StartsWith("M") && sayac == 0)
                    sayac++;
                ListViewItem li = new ListViewItem(item.Attributes["ID"].Value, lstviewSuppliers.Groups[sayac]);

                foreach (XmlNode node in item.ChildNodes)
                {
                    li.SubItems.Add(node.InnerText);
                }

                lstviewSuppliers.Items.Add(li);
            }
        }
    }
}

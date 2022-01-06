using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace XML_Devam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        DataTable dtCategories;
        XmlDocument xDoc;
        DataSet ds;

        private void Form2_Load(object sender, EventArgs e)
        {
            xDoc = new XmlDocument();
            xDoc.Load("..//..//Products.xml");

            da = new SqlDataAdapter("SELECT CategoryID, CategoryName FROM Categories", "Server=.; Database=Northwind; Integrated Security=true");

            ds = new DataSet("Northwind");

            dtCategories = new DataTable("Categories");

            da.Fill(dtCategories);

            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryID";
            cmbCategories.DataSource = dtCategories;
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;

            txtProducts.ScrollBars = ScrollBars.Both;
            txtProductsNode.ScrollBars = ScrollBars.Both;

            ds.ReadXml("..//..//Products.xml");

            txtProducts.Text = ds.GetXml();
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProductsNode.ResetText();

            XmlNodeList nodes = xDoc.SelectNodes(String.Format("Products/Product[CategoryID = {0}]", cmbCategories.SelectedValue));

            // Element bazlı filtreleme için Element/Element[Element = değer]

            // Attribute bazlı filtreleme için Element/Element[@Attribute = değer]

            foreach (XmlNode item in nodes)
            {
                foreach (XmlNode node in item.ChildNodes)
                {
                    txtProductsNode.Text += node.InnerText;
                    txtProductsNode.Text += "\r\n";
                }

                txtProductsNode.Text += "\r\n--------------------------------------------------\r\n";
            }
        }
    }
}

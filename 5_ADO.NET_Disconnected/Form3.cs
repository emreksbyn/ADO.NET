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

namespace _5_ADO.NET_Disconnected
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        DataTable dtProducts;
        DataTable dtCategories;
        DataTable dtSuppliers;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataView dv;

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=.; Database=Northwind; Integrated Security=SSPI");

            dtProducts = new DataTable("Products");
            dtCategories = new DataTable("Categories");
            dtSuppliers = new DataTable("Suppliers");

            dv = new DataView(dtProducts);

            da = new SqlDataAdapter("SELECT CategoryName, CategoryID FROM Categories", conn);
            da.Fill(dtCategories);

            da.SelectCommand.CommandText = "SELECT SupplierID, CompanyName FROM Suppliers";
            da.Fill(dtSuppliers);

            da.SelectCommand.CommandText = "SELECT * FROM Products";
            da.Fill(dtProducts);

            dgvProducts.DataSource = dtProducts;

            cmbKolonlar.Items.AddRange(new string[] { "CategoryID", "SupplierID" });
            cmbKolonlar.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbVeriler.DropDownStyle = ComboBoxStyle.DropDownList;

            da.SelectCommand.CommandText = "SELECT Column_Name FROM INFORMATION_SCHEMA.Columns WHERE Table_Name = @Param";

            da.SelectCommand.Parameters.AddWithValue("@Param", "Products");

            DataTable dtProductColumns = new DataTable();
            da.Fill(dtProductColumns);

            cmbUrunlerKolonlar.DisplayMember = "Column_Name";
            cmbUrunlerKolonlar.ValueMember = "Column_Name";
            cmbUrunlerKolonlar.DataSource = dtProductColumns;

            numMaksimum.Maximum = (decimal)dtProducts.Compute("MAX(UnitPrice)", null);

            scb = new SqlCommandBuilder(da);
        }
        private void cmbKolonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbVeriler.DataSource = null;

            switch (cmbKolonlar.SelectedItem.ToString())
            {
                case "CategoryID":
                    cmbVeriler.DisplayMember = "CategoryName";
                    cmbVeriler.ValueMember = "CategoryID";
                    cmbVeriler.DataSource = dtCategories;
                    break;
                case "SupplierID":
                    cmbVeriler.DisplayMember = "CompanyName";
                    cmbVeriler.ValueMember = "SupplierID";
                    cmbVeriler.DataSource = dtSuppliers;
                    break;
            }

        }
        private void cmbVeriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVeriler.SelectedItem == null)
                return;

            string kolon = cmbKolonlar.SelectedItem.ToString();

            int veriID = (int)cmbVeriler.SelectedValue;

            dv.RowFilter = String.Format("{0} = {1}", kolon, veriID);

            dgvProducts.DataSource = dv;
        }

        private void cmbUrunlerKolonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUrunlerKolonlar.SelectedItem == null)
                return;

            if (cmbUrunlerKolonlar.SelectedItem.ToString() == "Varsayılan")
            {
                //dgvProducts.DataSource = dtProducts;
                dv.Sort = String.Empty;
                return;
            }

            string kolon = cmbUrunlerKolonlar.SelectedValue.ToString();

            string siralama = radioBuyuktenKucuge.Checked ? "DESC" : "ASC";

            dv.Sort = String.Format("{0} {1}", kolon, siralama);

            dgvProducts.DataSource = dv;
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            cmbUrunlerKolonlar_SelectedIndexChanged(null, null);
        }

        private void btnFiyatUygula_Click(object sender, EventArgs e)
        {
            dv.RowFilter = String.Format("UnitPrice > {0} AND UnitPrice < {1}", numMinimum.Value, numMaksimum.Value);

            //dv.RowFilter = String.Format("UnitPrice BETWEEN {0} AND {1}", numMinimum.Value, numMaksimum.Value);

            dgvProducts.DataSource = dv;
        }

        private void btnFiyatKaldir_Click(object sender, EventArgs e)
        {
            dv.RowFilter = String.Empty;
        }

        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = String.Format("ProductName LIKE '{0}%'", txtUrunAdi.Text);

            dgvProducts.DataSource = dv;
        }

        private void btnUrunAdiGuncelle_Click(object sender, EventArgs e)
        {
            DataRowView drow = dv[dgvProducts.SelectedCells[0].OwningRow.Index];

            drow.BeginEdit();
            drow["ProductName"] = txtYeniUrunAdi.Text;
            drow.EndEdit();

        }
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedCells.Count > 0)
                lblUrunAdi.Text = dgvProducts.SelectedCells[0].OwningRow.Cells["ProductName"].Value.ToString();
            lblUrunAdi.SendToBack();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dv.Delete(dgvProducts.SelectedCells[0].OwningRow.Index);
        }
    }
}

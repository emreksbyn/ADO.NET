using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _5_ADO.NET_Disconnected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dtProducts;
        DataTable dtCategories;
        SqlCommandBuilder scb;
        SqlDataAdapter da;

        private void Form1_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT CategoryID, CategoryName FROM Categories", "Server=.; Database=Northwind; Integrated Security = true");

            dtCategories = new DataTable("Categories");

            da.Fill(dtCategories);

            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryID";

            da.SelectCommand.CommandText = "SELECT * FROM Products";

            dtProducts = new DataTable("Products");

            da.Fill(dtProducts);

            cmbCategories.DataSource = dtCategories;

            DataRow drow = dtCategories.NewRow();
            drow[0] = 0;
            drow[1] = "All";
            dtCategories.Rows.InsertAt(drow, 0);

            cmbCategories.SelectedIndex = 0;

            dgvProducts.DataSource = dtProducts;
            scb = new SqlCommandBuilder(da);

        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtProducts.Clear();

            SqlDataAdapter da = new SqlDataAdapter(String.Empty, "Server=.; Database=Northwind; Integrated Security=true");

            string query = "SELECT * FROM Products";

            if ((int)cmbCategories.SelectedValue != 0)
            {
                query += " WHERE CategoryID = @ID";
                da.SelectCommand.Parameters.AddWithValue("@ID", cmbCategories.SelectedValue);
            }

            da.SelectCommand.CommandText = query;

            da.Fill(dtProducts);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            scb.ConflictOption = ConflictOption.CompareRowVersion;
            scb.SetAllValues = true;

            da.Update(dtProducts);
            MessageBox.Show("Database has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

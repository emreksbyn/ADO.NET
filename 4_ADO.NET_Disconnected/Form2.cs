using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4_ADO.NET_Disconnected
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DataSet ds;

        private void Form2_Load(object sender, EventArgs e)
        {
            ds = new DataSet("Northwind");

            DataColumn dcOgrenciID = new DataColumn();
            dcOgrenciID.AllowDBNull = false;
            dcOgrenciID.ReadOnly = true;
            dcOgrenciID.AutoIncrement = true;
            dcOgrenciID.AutoIncrementSeed = 1;
            dcOgrenciID.AutoIncrementStep = 1;
            dcOgrenciID.ColumnName = "Öğrenci No";
            dcOgrenciID.DataType = typeof(int);

            DataColumn dcAdi = new DataColumn("Adi");
            dcAdi.AllowDBNull = false;
            dcAdi.DataType = typeof(String);
            dcAdi.ReadOnly = true;

            DataColumn dcSoyadi = new DataColumn("Soyadi", typeof(String));
            dcSoyadi.AllowDBNull = false;
            dcSoyadi.ReadOnly = true;

            DataColumn dcKayitTarihi = new DataColumn("Kayit Tarihi", typeof(DateTime));
            dcKayitTarihi.AllowDBNull = true;
            dcKayitTarihi.ReadOnly = true;
            DataTable dtOgrenciler = new DataTable("Ogrenciler");


            //dtOgrenciler.Columns.Add(dcOgrenciID);
            //dtOgrenciler.Columns.Add(dcAdi);
            //dtOgrenciler.Columns.Add(dcSoyadi);
            //dtOgrenciler.Columns.Add(dcKayitTarihi);

            dtOgrenciler.Columns.AddRange(new DataColumn[] { dcOgrenciID, dcAdi, dcSoyadi, dcKayitTarihi });


            //  Primary Key birden fazla kolondan oluşabilir. (composite key). 
            dtOgrenciler.PrimaryKey = new DataColumn[] { dcOgrenciID };

            ds.Tables.Add(dtOgrenciler);

            dgvOgrenciler.DataSource = dtOgrenciler;

            dgvOgrenciler.AllowUserToAddRows = false;

            // Tüm DataColumn nesnelerinin ReadOnly özelliğini false yapmak yerine :
            dgvOgrenciler.ReadOnly = false;

            dgvOgrenciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvOgrenciler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DataRow drow = ds.Tables["Ogrenciler"].NewRow();
                     
            drow[1] = txtAdi.Text;
            drow["Soyadi"] = txtSoyadi.Text;
            drow[ds.Tables[0].Columns["Kayit Tarihi"]] = dateTimeKayit.Value;

            ds.Tables["Ogrenciler"].Rows.Add(drow);

            txtAdi.ResetText();
            txtSoyadi.ResetText();
            dateTimeKayit.Value = DateTime.Now;
            txtAdi.Focus();
        }
    }
}

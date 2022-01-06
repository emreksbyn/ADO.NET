using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _4_ADO.NET_Disconnected
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        DataTable dtOrijinal;
        DataTable dtDegisiklikler;
        SqlDataAdapter da;

        private void Form3_Load(object sender, EventArgs e)
        {
            dgvCalisanlarOrijinal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvCalisanlarDegisiklikler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCalisanlarDegisiklikler.ReadOnly = true;
            dgvCalisanlarDegisiklikler.AllowUserToAddRows = false;
        }
        
        private void btnCalisanlariDoldur_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM Employees", "Server=.; Database=Northwind; Integrated Security=true");

            dtOrijinal = new DataTable("Orijinal");

            da.Fill(dtOrijinal);

            dgvCalisanlarOrijinal.DataSource = dtOrijinal;
        }

        private void btnDegisiklikler_Click(object sender, EventArgs e)
        {
            //dgvCalisanlarDegisiklikler.DataSource = dtOrijinal.GetChanges();
                        
            dtDegisiklikler = dtOrijinal.Clone();

            dtDegisiklikler.Columns.Add("Durum");
            // Eklenen kolon SetOrdinal() metodu ile 0. sıraya alındı :
            dtDegisiklikler.Columns["Durum"].SetOrdinal(0);

            dgvCalisanlarDegisiklikler.DataSource = dtDegisiklikler;

            DegisiklikleriGoster(DataRowState.Added, DataRowVersion.Current);
            DegisiklikleriGoster(DataRowState.Deleted, DataRowVersion.Original);
            DegisiklikleriGoster(DataRowState.Modified, DataRowVersion.Current);
        }
        private void DegisiklikleriGoster(DataRowState satirDurumu, DataRowVersion satirVersiyon)
        {
            if (dtOrijinal == null || dtOrijinal.GetChanges(satirDurumu) == null)
                return;

            foreach (DataRow eskiRow in dtOrijinal.GetChanges(satirDurumu).Rows)
            {
                DataRow yeniRow = dtDegisiklikler.NewRow();

                for (int i = 1; i < dtOrijinal.Columns.Count + 1; i++)
                {
                    yeniRow[i] = eskiRow[i - 1, satirVersiyon];
                }

                string durumu = String.Empty;

                switch (satirDurumu)
                {
                    case DataRowState.Added:
                        durumu = "Eklendi";
                        break;
                    case DataRowState.Deleted:
                        durumu = "Silindi";
                        break;
                    case DataRowState.Modified:
                        durumu = "Güncellendi";
                        break;
                }

                yeniRow[0] = durumu;

                dtDegisiklikler.Rows.Add(yeniRow);

                if (satirDurumu != DataRowState.Modified)
                    continue;

                for (int i = 1; i < dtOrijinal.Columns.Count; i++)
                {
                    DataGridViewCellStyle dgvCellStyle = new DataGridViewCellStyle(dgvCalisanlarOrijinal.DefaultCellStyle);
                    dgvCellStyle.BackColor = Color.LightSeaGreen;

                    if (eskiRow[i, DataRowVersion.Original].ToString() != eskiRow[i, DataRowVersion.Current].ToString())
                    {
                        dgvCalisanlarDegisiklikler.Rows[dgvCalisanlarDegisiklikler.Rows.Count - 1].Cells[i + 1].Style = dgvCellStyle;
                        dgvCalisanlarDegisiklikler.Rows[dgvCalisanlarDegisiklikler.Rows.Count - 1].Cells[i + 1].ToolTipText = String.Format("Verinin eski hali : {0}", eskiRow[i, DataRowVersion.Original].ToString());
                    }
                }
            }
        }
        private void dgvCalisanlarDegisiklikler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCalisanlarDegisiklikler.SelectedRows.Count > 0 && dgvCalisanlarDegisiklikler.SelectedRows[0].Cells[0].Value.ToString() == "Güncellendi")
            {
                dgvCalisanlarDegisiklikler.SelectedRows[0].Selected = false;
            }
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            dtOrijinal.RejectChanges();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            dtOrijinal.AcceptChanges();
        }

        private void btnVeritabaninaKaydet_Click(object sender, EventArgs e)
        {
            da.UpdateCommand = new SqlCommand("UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Title = @Title, TitleOfCourtesy = @TitleO, BirthDate = @BirthDate, HireDate = @HireDate, Address = @Address, City = @City, Region = @Region, PostalCode = @PCode, Country = @Country, HomePhone = @Phone, Extension = @Ext, Photo = @Photo, Notes = @Notes, ReportsTo = @ReportsTo, PhotoPath = @Path WHERE EmployeeID = @ID");

            da.UpdateCommand.Connection = new SqlConnection("Server=.; Database=Northwind; Integrated Security = true");


            da.UpdateCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50, "FirstName");
            da.UpdateCommand.Parameters.Add("@LastName", SqlDbType.NVarChar, 50, "LastName");
            da.UpdateCommand.Parameters.Add("@Title", SqlDbType.NVarChar, 30, "Title");
            da.UpdateCommand.Parameters.Add("@TitleO", SqlDbType.NVarChar, 25, "TitleOfCourtesy");
            da.UpdateCommand.Parameters.Add("@BirthDate", SqlDbType.DateTime, 8, "BirthDate");
            da.UpdateCommand.Parameters.Add("@HireDate", SqlDbType.DateTime, 8, "HireDate");
            da.UpdateCommand.Parameters.Add("@Address", SqlDbType.NVarChar, 60, "Address");
            da.UpdateCommand.Parameters.Add("@City", SqlDbType.NVarChar, 15, "City");
            da.UpdateCommand.Parameters.Add("@Country", SqlDbType.NVarChar, 15, "Country");
            da.UpdateCommand.Parameters.Add("@Region", SqlDbType.NVarChar, 15, "Region");
            da.UpdateCommand.Parameters.Add("@PCode", SqlDbType.NVarChar, 10, "PostalCode");
            da.UpdateCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 24, "HomePhone");
            da.UpdateCommand.Parameters.Add("@Ext", SqlDbType.NVarChar, 4, "Extension");
            da.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NText, int.MaxValue, "Notes");
            da.UpdateCommand.Parameters.Add("@ReportsTo", SqlDbType.Int, 50, "ReportsTo");
            da.UpdateCommand.Parameters.Add("@Path", SqlDbType.NVarChar, 50, "PhotoPath");
            da.UpdateCommand.Parameters.Add("@Photo", SqlDbType.Image, int.MaxValue, "Photo");
            da.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int, 4, "EmployeeID");

            da.Fill(dtOrijinal);
            da.Update(dtOrijinal);


            da.InsertCommand = new SqlCommand("INSERT INTO Employees (LastName,FirstName) VALUES (@LastName,@FirstName)");
            da.InsertCommand.Connection = new SqlConnection("Server=.; Database=Northwind; Integrated Security = true");

            da.InsertCommand.Parameters.Add("@LastName", SqlDbType.NVarChar, 50, "LastName");
            da.InsertCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50, "FirstName");

            da.Update(dtOrijinal);

            MessageBox.Show("Tablo başarıyla veritabanına kaydedildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DataTable dt;

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT FirstName, LastName, BirthDate, HomePhone FROM Employees", "Server=.; Database=Northwind; Integrated Security=true");

            dt = new DataTable("Employees");

            da.Fill(dt);

            txtAd.DataBindings.Add("Text", dt, "FirstName");
            txtSoyad.DataBindings.Add("Text", dt, "LastName");
           
            dateTimeDogum.DataBindings.Add("Value", dt, "BirthDate", true, DataSourceUpdateMode.Never, DateTime.Now);
           
            Binding binding = new Binding("Text", dt, "HomePhone", true, DataSourceUpdateMode.Never, "Belirtilmemiş");

            txtTelefon.DataBindings.Add(binding);

            trackBar.Maximum = dt.Rows.Count - 1;

            lblSiraNo.Text = String.Format("{0}.", this.BindingContext[dt].Position + 1);

            this.BindingContext[dt].PositionChanged += new EventHandler(Form2_PositionChanged);
        }
        void Form2_PositionChanged(object sender, EventArgs e)
        {
            trackBar.Value = this.BindingContext[dt].Position;
            lblSiraNo.Text = String.Format("{0}.", this.BindingContext[dt].Position + 1);
        }

        private void btnBirinci_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt].Position = 0;
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt].Position--;
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt].Position++;
        }

        private void btnSonuncu_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt].Position = this.BindingContext[dt].Count - 1;
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.BindingContext[dt].Position = trackBar.Value;
        }
    }
}

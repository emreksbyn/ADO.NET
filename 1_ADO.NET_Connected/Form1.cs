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

namespace _1_ADO.NET_Connected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer timer;
        SqlConnection conn;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection
            {
                ConnectionString = "Server=.; Database=Northwind; Integrated Security=true"
            };

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                progressBar.Style = ProgressBarStyle.Marquee;
            }
            else if (conn.State == ConnectionState.Closed)
            {
                progressBar.Style = ProgressBarStyle.Blocks;
            }

            this.Text = conn.State.ToString();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Employees";

            cmd.CommandType = CommandType.Text;

            cmd.Connection = conn;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    MessageBox.Show(rdr[1].ToString());

                    lstboxEmployees.Items.Add(rdr[2]);
                }
            }

            rdr.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT ProductName FROM Products", conn);

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string productName = rdr.GetString(0);

                lstboxProducts.Items.Add(productName);
            }

            rdr.Close();
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Order Details]", conn);

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string order = rdr.GetInt32(0) + " - " + rdr.GetInt32(rdr.GetOrdinal("ProductID"));

                lstboxOrderDetails.Items.Add(order);
            }

            //rdr.Close();

            // SqlConnection nesnesin bağlantısı kapatıldığı an, otomatik olarak SqlDataReader da kapatılır.
            conn.Close();
        }
    }
}

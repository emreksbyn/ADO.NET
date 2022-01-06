using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_ADO.NET_AdresDefteri
{
    public partial class frmGrupEkle : Form
    {
        public frmGrupEkle()
        {
            InitializeComponent();
        }

        private void frmGrupEkle_Load(object sender, EventArgs e)
        {
            GruplariDoldur();

            cmbGruplar.DisplayMember = "GrupAdi";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Grup yeniGrup = new Grup(txtGrupAdi.Text);

            if (Grup.GrupEkle(yeniGrup))
            {
                MessageBox.Show("Grup başarıyla eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Grup eklenirken bir hata oluştu.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Grup.GrupSil(cmbGruplar.SelectedItem as Grup))
            {
                MessageBox.Show("Grup başarıyla silindi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GruplariDoldur();
            }
            else
            {
                MessageBox.Show("Grup silinirken bir hata oluştu.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GruplariDoldur()
        {
            cmbGruplar.Items.Clear();

            cmbGruplar.Items.AddRange(Grup.Gruplar());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _3_ADO.NET_AdresDefteri
{
    public partial class frmAdresDefteri : Form
    {
        public frmAdresDefteri()
        {
            InitializeComponent();
        }

        Kisi seciliKisi;

        private void frmAdresDefteri_Load(object sender, EventArgs e)
        {
            KisileriDoldur();

            GruplariDoldur();

            cmbGruplar.DisplayMember = "GrupAdi";
        }
        private void Temizle()
        {
            foreach (Control item in grpboxBilgiler.Controls)
            {
                if (item is TextBox || item is MaskedTextBox)
                {
                    item.ResetText();
                }

                pictureBox1.Image = null;
                cmbGruplar.SelectedItem = null;
                dateTimeDogum.Value = DateTime.Now;
            }
        }
        private void GruplariDoldur()
        {
            cmbGruplar.Items.Clear();

            cmbGruplar.Items.AddRange(Grup.Gruplar());
        }

        private void KisileriDoldur()
        {
            lstboxKisiler.Items.Clear();

            lstboxKisiler.Items.AddRange(Kisi.Kisiler());
        }

        private void btnYeniKisi_Click(object sender, EventArgs e)
        {
            frmKisiEkle frm = new frmKisiEkle();

            if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            KisileriDoldur();
        }

        private void btnYeniGrup_Click(object sender, EventArgs e)
        {
            frmGrupEkle frm = new frmGrupEkle();

            if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            GruplariDoldur();
        }
        private object GrupSec(int GrupID)
        {
            foreach (object item in cmbGruplar.Items)
            {
                if (((Grup)item).GrupID == GrupID)
                {
                    return item;
                }
            }

            return null;
        }

        private void lstboxKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstboxKisiler.SelectedItem == null)
                return;

            seciliKisi = lstboxKisiler.SelectedItem as Kisi;

            txtAdi.Text = seciliKisi.Adi;
            txtSoyadi.Text = seciliKisi.Soyadi;
            txtEvTel.Text = seciliKisi.EvTelefonu;
            txtCepTel.Text = seciliKisi.CepTelefonu;
            txtEPosta.Text = seciliKisi.EPostaAdresi;
            txtAdres.Text = seciliKisi.Adresi;
            dateTimeDogum.Value = seciliKisi.DogumTarihi;
            cmbGruplar.SelectedItem = GrupSec(seciliKisi.GrupID);

            if (seciliKisi.KadinMi)
                radioKadin.Checked = true;
            else
                radioErkek.Checked = true;

            pictureBox1.ImageLocation = String.Format("{0}\\..\\..\\Resimler\\{1}", Application.StartupPath, seciliKisi.ResimYolu);
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            if (seciliKisi == null)
                return;

            if (Kisi.KisiSil(seciliKisi))
            {
                Temizle();

                KisileriDoldur();

                MessageBox.Show("Kişi başarıyla silindi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string resimYolu = String.Format("{0}\\..\\..\\Resimler\\{1}", Application.StartupPath, seciliKisi.ResimYolu);

                if (File.Exists(resimYolu) && (seciliKisi.ResimYolu != "erkek.png" && seciliKisi.ResimYolu != "kadin.png"))
                    File.Delete(resimYolu);
            }
            else
            {
                MessageBox.Show("Kişi silinirken bir hata oluştu.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliKisi == null)
                return;

            frmKisiEkle frm = new frmKisiEkle(seciliKisi);

            if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            KisileriDoldur();
        }
    }
}

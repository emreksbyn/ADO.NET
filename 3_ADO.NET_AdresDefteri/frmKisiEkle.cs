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
    public partial class frmKisiEkle : Form
    {
        public frmKisiEkle()
        {
            InitializeComponent();
        }
        public frmKisiEkle(Kisi kisi)
        {
            InitializeComponent();

            guncellenecekKisi = kisi;
        }

        Kisi guncellenecekKisi;

        OpenFileDialog openFileDialog;
        FileInfo fileInfo;

        private void frmKisiEkle_Load(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Resim Seç";
            openFileDialog.Filter = "JPG Dosyaları|*.jpg|JPEG Dosyaları|*.jpeg|PNG Dosyaları|*.png";
            openFileDialog.FileName = "Resim.jpg";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            cmbGruplar.Items.AddRange(Grup.Gruplar());
            cmbGruplar.DisplayMember = "GrupAdi";

            #region Eğer Güncelleme İşlemiyse

            if (guncellenecekKisi == null)
                return;

            txtAd.Text = guncellenecekKisi.Adi;
            txtSoyad.Text = guncellenecekKisi.Soyadi;
            txtEvNo.Text = guncellenecekKisi.EvTelefonu;
            txtCepNo.Text = guncellenecekKisi.CepTelefonu;
            txtEPosta.Text = guncellenecekKisi.EPostaAdresi;
            txtAdres.Text = guncellenecekKisi.Adresi;
            dateTimeDogum.Value = guncellenecekKisi.DogumTarihi;
            radioKadin.Checked = guncellenecekKisi.KadinMi;
            cmbGruplar.SelectedItem = GrupSec(guncellenecekKisi.GrupID);

            picResim.ImageLocation = String.Format("{0}\\..\\..\\Resimler\\{1}", Application.StartupPath, guncellenecekKisi.ResimYolu);

            btnKaydet.Text = "Güncelle";
            groupBox.Text = "Kişi Bilgileri";
            #endregion
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

        private void lnklblResimSec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            picResim.ImageLocation = openFileDialog.FileName;

            fileInfo = new FileInfo(picResim.ImageLocation);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox || item is MaskedTextBox)
                {
                    if (String.IsNullOrEmpty(item.Text))
                    {
                        errorProvider1.SetError(item, "Bu alan boş geçilemez");
                        return;
                    }
                }
                else if (cmbGruplar.SelectedItem == null)
                {
                    errorProvider1.SetError(cmbGruplar, "Bir grup seçiniz");
                    return;
                }
            }

            string resimYolu = String.Empty;

            if (String.IsNullOrEmpty(picResim.ImageLocation))
            {
                if (radioErkek.Checked)
                    resimYolu = "erkek.png";
                else
                    resimYolu = "kadin.png";
            }
            else
            {
                if (fileInfo != null)
                {

                    // Globally Unique Identifier
                    Guid g = Guid.NewGuid();

                    resimYolu = g.ToString() + fileInfo.Name;
                }
            }

            Kisi yeniKisi = new Kisi()
            {
                Adi = txtAd.Text,
                Soyadi = txtSoyad.Text,
                KadinMi = radioKadin.Checked,
                DogumTarihi = dateTimeDogum.Value,
                EvTelefonu = txtEvNo.Text,
                CepTelefonu = txtCepNo.Text,
                GrupID = (cmbGruplar.SelectedItem as Grup).GrupID,
                EPostaAdresi = txtEPosta.Text,
                Adresi = txtAdres.Text,
                ResimYolu = resimYolu
            };

            if (guncellenecekKisi != null && fileInfo == null)
            {
                yeniKisi.ResimYolu = guncellenecekKisi.ResimYolu;
            }

            if (guncellenecekKisi == null)
            {
                // Insert işlemi :
                if (Kisi.KisiEkle(yeniKisi))
                {
                    if (!String.IsNullOrEmpty(picResim.ImageLocation))
                        fileInfo.CopyTo(String.Format("{0}\\..\\..\\Resimler\\{1}", Application.StartupPath, resimYolu));

                    MessageBox.Show("Yeni kişi başarıyla eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Kişi eklenirken bir hata oluştu.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Update işlemi :

                yeniKisi.KisiID = guncellenecekKisi.KisiID;

                if (Kisi.KisiGuncelle(yeniKisi))
                {
                    MessageBox.Show("Yeni kişi başarıyla güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;

                    if (fileInfo != null)
                        fileInfo.CopyTo(String.Format("{0}\\..\\..\\Resimler\\{1}", Application.StartupPath, resimYolu));

                    string silinecekResim = String.Format("{0}\\..\\..\\Resimler\\{1}", Application.StartupPath, guncellenecekKisi.ResimYolu);

                    if (File.Exists(silinecekResim) && (guncellenecekKisi.ResimYolu != "erkek.png" && guncellenecekKisi.ResimYolu != "kadin.png"))
                        File.Delete(silinecekResim);
                }
                else
                {
                    MessageBox.Show("Kişi güncellenirken bir hata oluştu.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

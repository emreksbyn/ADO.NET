namespace _3_ADO.NET_AdresDefteri
{
    partial class frmKisiEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.picResim = new System.Windows.Forms.PictureBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lnklblResimSec = new System.Windows.Forms.LinkLabel();
            this.txtEPosta = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtCepNo = new System.Windows.Forms.MaskedTextBox();
            this.txtEvNo = new System.Windows.Forms.MaskedTextBox();
            this.radioKadin = new System.Windows.Forms.RadioButton();
            this.radioErkek = new System.Windows.Forms.RadioButton();
            this.cmbGruplar = new System.Windows.Forms.ComboBox();
            this.dateTimeDogum = new System.Windows.Forms.DateTimePicker();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResim)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // picResim
            // 
            this.picResim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picResim.Location = new System.Drawing.Point(324, 26);
            this.picResim.Name = "picResim";
            this.picResim.Size = new System.Drawing.Size(124, 128);
            this.picResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResim.TabIndex = 20;
            this.picResim.TabStop = false;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(324, 234);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(124, 34);
            this.btnIptal.TabIndex = 12;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(324, 194);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(124, 34);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lnklblResimSec
            // 
            this.lnklblResimSec.AutoSize = true;
            this.lnklblResimSec.Location = new System.Drawing.Point(353, 157);
            this.lnklblResimSec.Name = "lnklblResimSec";
            this.lnklblResimSec.Size = new System.Drawing.Size(58, 13);
            this.lnklblResimSec.TabIndex = 18;
            this.lnklblResimSec.TabStop = true;
            this.lnklblResimSec.Text = "Resim Seç";
            this.lnklblResimSec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblResimSec_LinkClicked);
            // 
            // txtEPosta
            // 
            this.txtEPosta.Location = new System.Drawing.Point(96, 222);
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(196, 20);
            this.txtEPosta.TabIndex = 9;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(96, 250);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(196, 66);
            this.txtAdres.TabIndex = 10;
            // 
            // txtCepNo
            // 
            this.txtCepNo.Location = new System.Drawing.Point(96, 194);
            this.txtCepNo.Mask = "(999) 000-0000";
            this.txtCepNo.Name = "txtCepNo";
            this.txtCepNo.Size = new System.Drawing.Size(196, 20);
            this.txtCepNo.TabIndex = 8;
            // 
            // txtEvNo
            // 
            this.txtEvNo.Location = new System.Drawing.Point(96, 166);
            this.txtEvNo.Mask = "(999) 000-0000";
            this.txtEvNo.Name = "txtEvNo";
            this.txtEvNo.Size = new System.Drawing.Size(196, 20);
            this.txtEvNo.TabIndex = 6;
            // 
            // radioKadin
            // 
            this.radioKadin.AutoSize = true;
            this.radioKadin.Location = new System.Drawing.Point(164, 139);
            this.radioKadin.Name = "radioKadin";
            this.radioKadin.Size = new System.Drawing.Size(52, 17);
            this.radioKadin.TabIndex = 5;
            this.radioKadin.Text = "Kadın";
            this.radioKadin.UseVisualStyleBackColor = true;
            // 
            // radioErkek
            // 
            this.radioErkek.AutoSize = true;
            this.radioErkek.Checked = true;
            this.radioErkek.Location = new System.Drawing.Point(96, 139);
            this.radioErkek.Name = "radioErkek";
            this.radioErkek.Size = new System.Drawing.Size(53, 17);
            this.radioErkek.TabIndex = 4;
            this.radioErkek.TabStop = true;
            this.radioErkek.Text = "Erkek";
            this.radioErkek.UseVisualStyleBackColor = true;
            // 
            // cmbGruplar
            // 
            this.cmbGruplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGruplar.FormattingEnabled = true;
            this.cmbGruplar.Location = new System.Drawing.Point(96, 82);
            this.cmbGruplar.Name = "cmbGruplar";
            this.cmbGruplar.Size = new System.Drawing.Size(196, 21);
            this.cmbGruplar.TabIndex = 2;
            // 
            // dateTimeDogum
            // 
            this.dateTimeDogum.Location = new System.Drawing.Point(96, 109);
            this.dateTimeDogum.Name = "dateTimeDogum";
            this.dateTimeDogum.Size = new System.Drawing.Size(196, 20);
            this.dateTimeDogum.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(96, 54);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(196, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(96, 26);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(196, 20);
            this.txtAd.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Grup :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cep No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ev No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "E-Posta :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Adres :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cinsiyet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "D. Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad :";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.picResim);
            this.groupBox.Controls.Add(this.btnIptal);
            this.groupBox.Controls.Add(this.btnKaydet);
            this.groupBox.Controls.Add(this.lnklblResimSec);
            this.groupBox.Controls.Add(this.txtEPosta);
            this.groupBox.Controls.Add(this.txtAdres);
            this.groupBox.Controls.Add(this.txtCepNo);
            this.groupBox.Controls.Add(this.txtEvNo);
            this.groupBox.Controls.Add(this.radioKadin);
            this.groupBox.Controls.Add(this.radioErkek);
            this.groupBox.Controls.Add(this.cmbGruplar);
            this.groupBox.Controls.Add(this.dateTimeDogum);
            this.groupBox.Controls.Add(this.txtSoyad);
            this.groupBox.Controls.Add(this.txtAd);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(483, 324);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Yeni Kişi :";
            // 
            // frmKisiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 346);
            this.Controls.Add(this.groupBox);
            this.Name = "frmKisiEkle";
            this.Text = "frmKisiEkle";
            this.Load += new System.EventHandler(this.frmKisiEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResim)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PictureBox picResim;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.LinkLabel lnklblResimSec;
        private System.Windows.Forms.TextBox txtEPosta;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.MaskedTextBox txtCepNo;
        private System.Windows.Forms.MaskedTextBox txtEvNo;
        private System.Windows.Forms.RadioButton radioKadin;
        private System.Windows.Forms.RadioButton radioErkek;
        private System.Windows.Forms.ComboBox cmbGruplar;
        private System.Windows.Forms.DateTimePicker dateTimeDogum;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
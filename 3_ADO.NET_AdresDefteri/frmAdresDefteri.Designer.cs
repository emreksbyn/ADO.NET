namespace _3_ADO.NET_AdresDefteri
{
    partial class frmAdresDefteri
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
            this.btnKisiSil = new System.Windows.Forms.Button();
            this.btnKisiGuncelle = new System.Windows.Forms.Button();
            this.btnYeniKisi = new System.Windows.Forms.Button();
            this.btnYeniGrup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEPosta = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtCepTel = new System.Windows.Forms.MaskedTextBox();
            this.txtEvTel = new System.Windows.Forms.MaskedTextBox();
            this.radioKadin = new System.Windows.Forms.RadioButton();
            this.radioErkek = new System.Windows.Forms.RadioButton();
            this.cmbGruplar = new System.Windows.Forms.ComboBox();
            this.dateTimeDogum = new System.Windows.Forms.DateTimePicker();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpboxBilgiler = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstboxKisiler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpboxBilgiler.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKisiSil
            // 
            this.btnKisiSil.Location = new System.Drawing.Point(269, 282);
            this.btnKisiSil.Name = "btnKisiSil";
            this.btnKisiSil.Size = new System.Drawing.Size(124, 34);
            this.btnKisiSil.TabIndex = 18;
            this.btnKisiSil.Text = "Kişiyi Sil";
            this.btnKisiSil.UseVisualStyleBackColor = true;
            this.btnKisiSil.Click += new System.EventHandler(this.btnKisiSil_Click);
            // 
            // btnKisiGuncelle
            // 
            this.btnKisiGuncelle.Location = new System.Drawing.Point(269, 242);
            this.btnKisiGuncelle.Name = "btnKisiGuncelle";
            this.btnKisiGuncelle.Size = new System.Drawing.Size(124, 34);
            this.btnKisiGuncelle.TabIndex = 18;
            this.btnKisiGuncelle.Text = "Kişiyi Güncelle";
            this.btnKisiGuncelle.UseVisualStyleBackColor = true;
            this.btnKisiGuncelle.Click += new System.EventHandler(this.btnKisiGuncelle_Click);
            // 
            // btnYeniKisi
            // 
            this.btnYeniKisi.Location = new System.Drawing.Point(269, 203);
            this.btnYeniKisi.Name = "btnYeniKisi";
            this.btnYeniKisi.Size = new System.Drawing.Size(124, 34);
            this.btnYeniKisi.TabIndex = 18;
            this.btnYeniKisi.Text = "Yeni Kişi";
            this.btnYeniKisi.UseVisualStyleBackColor = true;
            this.btnYeniKisi.Click += new System.EventHandler(this.btnYeniKisi_Click);
            // 
            // btnYeniGrup
            // 
            this.btnYeniGrup.Location = new System.Drawing.Point(269, 163);
            this.btnYeniGrup.Name = "btnYeniGrup";
            this.btnYeniGrup.Size = new System.Drawing.Size(124, 34);
            this.btnYeniGrup.TabIndex = 18;
            this.btnYeniGrup.Text = "Grup Ekle/Sil";
            this.btnYeniGrup.UseVisualStyleBackColor = true;
            this.btnYeniGrup.Click += new System.EventHandler(this.btnYeniGrup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(269, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // txtEPosta
            // 
            this.txtEPosta.Location = new System.Drawing.Point(82, 222);
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(169, 20);
            this.txtEPosta.TabIndex = 16;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(82, 250);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(169, 66);
            this.txtAdres.TabIndex = 16;
            // 
            // txtCepTel
            // 
            this.txtCepTel.Location = new System.Drawing.Point(82, 194);
            this.txtCepTel.Mask = "(999) 000-0000";
            this.txtCepTel.Name = "txtCepTel";
            this.txtCepTel.Size = new System.Drawing.Size(169, 20);
            this.txtCepTel.TabIndex = 15;
            // 
            // txtEvTel
            // 
            this.txtEvTel.Location = new System.Drawing.Point(82, 166);
            this.txtEvTel.Mask = "(999) 000-0000";
            this.txtEvTel.Name = "txtEvTel";
            this.txtEvTel.Size = new System.Drawing.Size(169, 20);
            this.txtEvTel.TabIndex = 15;
            // 
            // radioKadin
            // 
            this.radioKadin.AutoSize = true;
            this.radioKadin.Location = new System.Drawing.Point(141, 139);
            this.radioKadin.Name = "radioKadin";
            this.radioKadin.Size = new System.Drawing.Size(52, 17);
            this.radioKadin.TabIndex = 14;
            this.radioKadin.TabStop = true;
            this.radioKadin.Text = "Kadın";
            this.radioKadin.UseVisualStyleBackColor = true;
            // 
            // radioErkek
            // 
            this.radioErkek.AutoSize = true;
            this.radioErkek.Location = new System.Drawing.Point(82, 139);
            this.radioErkek.Name = "radioErkek";
            this.radioErkek.Size = new System.Drawing.Size(53, 17);
            this.radioErkek.TabIndex = 14;
            this.radioErkek.TabStop = true;
            this.radioErkek.Text = "Erkek";
            this.radioErkek.UseVisualStyleBackColor = true;
            // 
            // cmbGruplar
            // 
            this.cmbGruplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGruplar.FormattingEnabled = true;
            this.cmbGruplar.Items.AddRange(new object[] {
            "Aile",
            "İş",
            "Arkadaş"});
            this.cmbGruplar.Location = new System.Drawing.Point(82, 82);
            this.cmbGruplar.Name = "cmbGruplar";
            this.cmbGruplar.Size = new System.Drawing.Size(169, 21);
            this.cmbGruplar.TabIndex = 13;
            // 
            // dateTimeDogum
            // 
            this.dateTimeDogum.Location = new System.Drawing.Point(82, 109);
            this.dateTimeDogum.Name = "dateTimeDogum";
            this.dateTimeDogum.Size = new System.Drawing.Size(169, 20);
            this.dateTimeDogum.TabIndex = 12;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(82, 54);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(169, 20);
            this.txtSoyadi.TabIndex = 11;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(82, 26);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(169, 20);
            this.txtAdi.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Grup :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cep No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ev No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "E-Posta :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Adres :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cinsiyet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "D. Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad :";
            // 
            // grpboxBilgiler
            // 
            this.grpboxBilgiler.Controls.Add(this.btnKisiSil);
            this.grpboxBilgiler.Controls.Add(this.btnKisiGuncelle);
            this.grpboxBilgiler.Controls.Add(this.btnYeniKisi);
            this.grpboxBilgiler.Controls.Add(this.btnYeniGrup);
            this.grpboxBilgiler.Controls.Add(this.pictureBox1);
            this.grpboxBilgiler.Controls.Add(this.txtEPosta);
            this.grpboxBilgiler.Controls.Add(this.txtAdres);
            this.grpboxBilgiler.Controls.Add(this.txtCepTel);
            this.grpboxBilgiler.Controls.Add(this.txtEvTel);
            this.grpboxBilgiler.Controls.Add(this.radioKadin);
            this.grpboxBilgiler.Controls.Add(this.radioErkek);
            this.grpboxBilgiler.Controls.Add(this.cmbGruplar);
            this.grpboxBilgiler.Controls.Add(this.dateTimeDogum);
            this.grpboxBilgiler.Controls.Add(this.txtSoyadi);
            this.grpboxBilgiler.Controls.Add(this.txtAdi);
            this.grpboxBilgiler.Controls.Add(this.label9);
            this.grpboxBilgiler.Controls.Add(this.label8);
            this.grpboxBilgiler.Controls.Add(this.label7);
            this.grpboxBilgiler.Controls.Add(this.label6);
            this.grpboxBilgiler.Controls.Add(this.label5);
            this.grpboxBilgiler.Controls.Add(this.label4);
            this.grpboxBilgiler.Controls.Add(this.label3);
            this.grpboxBilgiler.Controls.Add(this.label2);
            this.grpboxBilgiler.Controls.Add(this.label1);
            this.grpboxBilgiler.Location = new System.Drawing.Point(202, 12);
            this.grpboxBilgiler.Name = "grpboxBilgiler";
            this.grpboxBilgiler.Size = new System.Drawing.Size(414, 324);
            this.grpboxBilgiler.TabIndex = 3;
            this.grpboxBilgiler.TabStop = false;
            this.grpboxBilgiler.Text = "Kişi Bilgileri :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstboxKisiler);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 324);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişiler :";
            // 
            // lstboxKisiler
            // 
            this.lstboxKisiler.FormattingEnabled = true;
            this.lstboxKisiler.Location = new System.Drawing.Point(16, 22);
            this.lstboxKisiler.Name = "lstboxKisiler";
            this.lstboxKisiler.Size = new System.Drawing.Size(139, 290);
            this.lstboxKisiler.TabIndex = 0;
            this.lstboxKisiler.SelectedIndexChanged += new System.EventHandler(this.lstboxKisiler_SelectedIndexChanged);
            // 
            // frmAdresDefteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 340);
            this.Controls.Add(this.grpboxBilgiler);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdresDefteri";
            this.Text = "frmAdresDefteri";
            this.Load += new System.EventHandler(this.frmAdresDefteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpboxBilgiler.ResumeLayout(false);
            this.grpboxBilgiler.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKisiSil;
        private System.Windows.Forms.Button btnKisiGuncelle;
        private System.Windows.Forms.Button btnYeniKisi;
        private System.Windows.Forms.Button btnYeniGrup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEPosta;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.MaskedTextBox txtCepTel;
        private System.Windows.Forms.MaskedTextBox txtEvTel;
        private System.Windows.Forms.RadioButton radioKadin;
        private System.Windows.Forms.RadioButton radioErkek;
        private System.Windows.Forms.ComboBox cmbGruplar;
        private System.Windows.Forms.DateTimePicker dateTimeDogum;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpboxBilgiler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstboxKisiler;
    }
}
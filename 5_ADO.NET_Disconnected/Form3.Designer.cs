namespace _5_ADO.NET_Disconnected
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtYeniUrunAdi = new System.Windows.Forms.TextBox();
            this.btnUrunAdiGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFiyatKaldir = new System.Windows.Forms.Button();
            this.btnFiyatUygula = new System.Windows.Forms.Button();
            this.numMaksimum = new System.Windows.Forms.NumericUpDown();
            this.numMinimum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioKucuktenBuyuge = new System.Windows.Forms.RadioButton();
            this.radioBuyuktenKucuge = new System.Windows.Forms.RadioButton();
            this.cmbUrunlerKolonlar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbVeriler = new System.Windows.Forms.ComboBox();
            this.cmbKolonlar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaksimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimum)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayarlar :";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtYeniUrunAdi);
            this.groupBox7.Controls.Add(this.btnUrunAdiGuncelle);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Location = new System.Drawing.Point(6, 114);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(376, 46);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ürün Adı Güncelle :";
            // 
            // txtYeniUrunAdi
            // 
            this.txtYeniUrunAdi.Location = new System.Drawing.Point(77, 18);
            this.txtYeniUrunAdi.Name = "txtYeniUrunAdi";
            this.txtYeniUrunAdi.Size = new System.Drawing.Size(178, 24);
            this.txtYeniUrunAdi.TabIndex = 1;
            this.txtYeniUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdi_TextChanged);
            // 
            // btnUrunAdiGuncelle
            // 
            this.btnUrunAdiGuncelle.Location = new System.Drawing.Point(261, 16);
            this.btnUrunAdiGuncelle.Name = "btnUrunAdiGuncelle";
            this.btnUrunAdiGuncelle.Size = new System.Drawing.Size(101, 24);
            this.btnUrunAdiGuncelle.TabIndex = 3;
            this.btnUrunAdiGuncelle.Text = "Uygula";
            this.btnUrunAdiGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunAdiGuncelle.Click += new System.EventHandler(this.btnUrunAdiGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ürün Adı :";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblUrunAdi);
            this.groupBox8.Controls.Add(this.btnSil);
            this.groupBox8.Location = new System.Drawing.Point(659, 114);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(233, 46);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Seçili Ürünü Sil :";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(11, 22);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(0, 17);
            this.lblUrunAdi.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(152, 16);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 23);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Ürünü Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtUrunAdi);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(392, 114);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(261, 46);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ürün Adına Göre Ara :";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(77, 18);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(178, 24);
            this.txtUrunAdi.TabIndex = 1;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdi_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ürün Adı :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFiyatKaldir);
            this.groupBox5.Controls.Add(this.btnFiyatUygula);
            this.groupBox5.Controls.Add(this.numMaksimum);
            this.groupBox5.Controls.Add(this.numMinimum);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(540, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 88);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fiyat Aralığı Uygula :";
            // 
            // btnFiyatKaldir
            // 
            this.btnFiyatKaldir.Location = new System.Drawing.Point(141, 49);
            this.btnFiyatKaldir.Name = "btnFiyatKaldir";
            this.btnFiyatKaldir.Size = new System.Drawing.Size(119, 33);
            this.btnFiyatKaldir.TabIndex = 3;
            this.btnFiyatKaldir.Text = "Seçimi Kaldır";
            this.btnFiyatKaldir.UseVisualStyleBackColor = true;
            this.btnFiyatKaldir.Click += new System.EventHandler(this.btnFiyatKaldir_Click);
            // 
            // btnFiyatUygula
            // 
            this.btnFiyatUygula.Location = new System.Drawing.Point(12, 49);
            this.btnFiyatUygula.Name = "btnFiyatUygula";
            this.btnFiyatUygula.Size = new System.Drawing.Size(118, 33);
            this.btnFiyatUygula.TabIndex = 3;
            this.btnFiyatUygula.Text = "Uygula";
            this.btnFiyatUygula.UseVisualStyleBackColor = true;
            this.btnFiyatUygula.Click += new System.EventHandler(this.btnFiyatUygula_Click);
            // 
            // numMaksimum
            // 
            this.numMaksimum.Location = new System.Drawing.Point(197, 21);
            this.numMaksimum.Name = "numMaksimum";
            this.numMaksimum.Size = new System.Drawing.Size(63, 24);
            this.numMaksimum.TabIndex = 2;
            // 
            // numMinimum
            // 
            this.numMinimum.Location = new System.Drawing.Point(50, 21);
            this.numMinimum.Name = "numMinimum";
            this.numMinimum.Size = new System.Drawing.Size(63, 24);
            this.numMinimum.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Max :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Min :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioKucuktenBuyuge);
            this.groupBox4.Controls.Add(this.radioBuyuktenKucuge);
            this.groupBox4.Controls.Add(this.cmbUrunlerKolonlar);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(273, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 88);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sırala :";
            // 
            // radioKucuktenBuyuge
            // 
            this.radioKucuktenBuyuge.AutoSize = true;
            this.radioKucuktenBuyuge.Location = new System.Drawing.Point(63, 65);
            this.radioKucuktenBuyuge.Name = "radioKucuktenBuyuge";
            this.radioKucuktenBuyuge.Size = new System.Drawing.Size(153, 21);
            this.radioKucuktenBuyuge.TabIndex = 2;
            this.radioKucuktenBuyuge.TabStop = true;
            this.radioKucuktenBuyuge.Text = "Küçükten Büyüğe";
            this.radioKucuktenBuyuge.UseVisualStyleBackColor = true;
            this.radioKucuktenBuyuge.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioBuyuktenKucuge
            // 
            this.radioBuyuktenKucuge.AutoSize = true;
            this.radioBuyuktenKucuge.Location = new System.Drawing.Point(63, 47);
            this.radioBuyuktenKucuge.Name = "radioBuyuktenKucuge";
            this.radioBuyuktenKucuge.Size = new System.Drawing.Size(153, 21);
            this.radioBuyuktenKucuge.TabIndex = 2;
            this.radioBuyuktenKucuge.TabStop = true;
            this.radioBuyuktenKucuge.Text = "Büyükten Küçüğe";
            this.radioBuyuktenKucuge.UseVisualStyleBackColor = true;
            this.radioBuyuktenKucuge.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // cmbUrunlerKolonlar
            // 
            this.cmbUrunlerKolonlar.FormattingEnabled = true;
            this.cmbUrunlerKolonlar.Location = new System.Drawing.Point(63, 20);
            this.cmbUrunlerKolonlar.Name = "cmbUrunlerKolonlar";
            this.cmbUrunlerKolonlar.Size = new System.Drawing.Size(185, 25);
            this.cmbUrunlerKolonlar.TabIndex = 1;
            this.cmbUrunlerKolonlar.SelectedIndexChanged += new System.EventHandler(this.cmbUrunlerKolonlar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kolon :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbVeriler);
            this.groupBox2.Controls.Add(this.cmbKolonlar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 88);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrele :";
            // 
            // cmbVeriler
            // 
            this.cmbVeriler.FormattingEnabled = true;
            this.cmbVeriler.Location = new System.Drawing.Point(63, 51);
            this.cmbVeriler.Name = "cmbVeriler";
            this.cmbVeriler.Size = new System.Drawing.Size(185, 25);
            this.cmbVeriler.TabIndex = 1;
            this.cmbVeriler.SelectedIndexChanged += new System.EventHandler(this.cmbVeriler_SelectedIndexChanged);
            // 
            // cmbKolonlar
            // 
            this.cmbKolonlar.FormattingEnabled = true;
            this.cmbKolonlar.Location = new System.Drawing.Point(63, 20);
            this.cmbKolonlar.Name = "cmbKolonlar";
            this.cmbKolonlar.Size = new System.Drawing.Size(185, 25);
            this.cmbKolonlar.TabIndex = 1;
            this.cmbKolonlar.SelectedIndexChanged += new System.EventHandler(this.cmbKolonlar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Değer :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kolon :";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvProducts);
            this.groupBox3.Location = new System.Drawing.Point(15, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(911, 286);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürünler :";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(3, 20);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.Size = new System.Drawing.Size(905, 263);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 483);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaksimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimum)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbKolonlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVeriler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioKucuktenBuyuge;
        private System.Windows.Forms.RadioButton radioBuyuktenKucuge;
        private System.Windows.Forms.ComboBox cmbUrunlerKolonlar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMaksimum;
        private System.Windows.Forms.NumericUpDown numMinimum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFiyatKaldir;
        private System.Windows.Forms.Button btnFiyatUygula;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtYeniUrunAdi;
        private System.Windows.Forms.Button btnUrunAdiGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Button btnSil;
    }
}
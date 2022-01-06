namespace _4_ADO.NET_Disconnected
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
            this.dgvCalisanlarDegisiklikler = new System.Windows.Forms.DataGridView();
            this.dgvCalisanlarOrijinal = new System.Windows.Forms.DataGridView();
            this.btnVeritabaninaKaydet = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDegisiklikler = new System.Windows.Forms.Button();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.btnCalisanlariDoldur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlarDegisiklikler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlarOrijinal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCalisanlarDegisiklikler
            // 
            this.dgvCalisanlarDegisiklikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanlarDegisiklikler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalisanlarDegisiklikler.Location = new System.Drawing.Point(3, 16);
            this.dgvCalisanlarDegisiklikler.Name = "dgvCalisanlarDegisiklikler";
            this.dgvCalisanlarDegisiklikler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalisanlarDegisiklikler.Size = new System.Drawing.Size(870, 157);
            this.dgvCalisanlarDegisiklikler.TabIndex = 0;
            this.dgvCalisanlarDegisiklikler.SelectionChanged += new System.EventHandler(this.dgvCalisanlarDegisiklikler_SelectionChanged);
            // 
            // dgvCalisanlarOrijinal
            // 
            this.dgvCalisanlarOrijinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanlarOrijinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalisanlarOrijinal.Location = new System.Drawing.Point(3, 16);
            this.dgvCalisanlarOrijinal.Name = "dgvCalisanlarOrijinal";
            this.dgvCalisanlarOrijinal.Size = new System.Drawing.Size(867, 168);
            this.dgvCalisanlarOrijinal.TabIndex = 0;
            // 
            // btnVeritabaninaKaydet
            // 
            this.btnVeritabaninaKaydet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVeritabaninaKaydet.Location = new System.Drawing.Point(579, 387);
            this.btnVeritabaninaKaydet.Name = "btnVeritabaninaKaydet";
            this.btnVeritabaninaKaydet.Size = new System.Drawing.Size(135, 39);
            this.btnVeritabaninaKaydet.TabIndex = 4;
            this.btnVeritabaninaKaydet.Text = "Veritabanına Kaydet";
            this.btnVeritabaninaKaydet.UseVisualStyleBackColor = true;
            this.btnVeritabaninaKaydet.Click += new System.EventHandler(this.btnVeritabaninaKaydet_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKaydet.Location = new System.Drawing.Point(438, 387);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(135, 39);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Değişiklikleri Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDegisiklikler
            // 
            this.btnDegisiklikler.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDegisiklikler.Location = new System.Drawing.Point(156, 387);
            this.btnDegisiklikler.Name = "btnDegisiklikler";
            this.btnDegisiklikler.Size = new System.Drawing.Size(135, 39);
            this.btnDegisiklikler.TabIndex = 6;
            this.btnDegisiklikler.Text = "Değişiklikleri Göster";
            this.btnDegisiklikler.UseVisualStyleBackColor = true;
            this.btnDegisiklikler.Click += new System.EventHandler(this.btnDegisiklikler_Click);
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGeriAl.Location = new System.Drawing.Point(297, 387);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(135, 39);
            this.btnGeriAl.TabIndex = 7;
            this.btnGeriAl.Text = "Değişiklikleri Geri Al";
            this.btnGeriAl.UseVisualStyleBackColor = true;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // btnCalisanlariDoldur
            // 
            this.btnCalisanlariDoldur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCalisanlariDoldur.Location = new System.Drawing.Point(15, 387);
            this.btnCalisanlariDoldur.Name = "btnCalisanlariDoldur";
            this.btnCalisanlariDoldur.Size = new System.Drawing.Size(135, 39);
            this.btnCalisanlariDoldur.TabIndex = 8;
            this.btnCalisanlariDoldur.Text = "Çalışanları Listele";
            this.btnCalisanlariDoldur.UseVisualStyleBackColor = true;
            this.btnCalisanlariDoldur.Click += new System.EventHandler(this.btnCalisanlariDoldur_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvCalisanlarDegisiklikler);
            this.groupBox2.Location = new System.Drawing.Point(12, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 176);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çalışanlar [Değişiklikler]";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvCalisanlarOrijinal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 187);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çalışanlar [Orijinal]";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.btnVeritabaninaKaydet);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDegisiklikler);
            this.Controls.Add(this.btnGeriAl);
            this.Controls.Add(this.btnCalisanlariDoldur);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlarDegisiklikler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlarOrijinal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCalisanlarDegisiklikler;
        private System.Windows.Forms.DataGridView dgvCalisanlarOrijinal;
        private System.Windows.Forms.Button btnVeritabaninaKaydet;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDegisiklikler;
        private System.Windows.Forms.Button btnGeriAl;
        private System.Windows.Forms.Button btnCalisanlariDoldur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
namespace _4_ADO.NET_Disconnected
{
    partial class Form2
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dateTimeKayit = new System.Windows.Forms.DateTimePicker();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpboxOgrenciler = new System.Windows.Forms.GroupBox();
            this.dgvOgrenciler = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.grpboxOgrenciler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.dateTimeKayit);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 168);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Kaydı :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(77, 116);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 41);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dateTimeKayit
            // 
            this.dateTimeKayit.Location = new System.Drawing.Point(77, 89);
            this.dateTimeKayit.Name = "dateTimeKayit";
            this.dateTimeKayit.Size = new System.Drawing.Size(200, 20);
            this.dateTimeKayit.TabIndex = 2;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(77, 58);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(200, 20);
            this.txtSoyadi.TabIndex = 1;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(77, 27);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(200, 20);
            this.txtAdi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "K. Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // grpboxOgrenciler
            // 
            this.grpboxOgrenciler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxOgrenciler.Controls.Add(this.dgvOgrenciler);
            this.grpboxOgrenciler.Location = new System.Drawing.Point(12, 12);
            this.grpboxOgrenciler.Name = "grpboxOgrenciler";
            this.grpboxOgrenciler.Size = new System.Drawing.Size(529, 228);
            this.grpboxOgrenciler.TabIndex = 2;
            this.grpboxOgrenciler.TabStop = false;
            this.grpboxOgrenciler.Text = "Öğrenciler :";
            // 
            // dgvOgrenciler
            // 
            this.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOgrenciler.Location = new System.Drawing.Point(3, 16);
            this.dgvOgrenciler.Name = "dgvOgrenciler";
            this.dgvOgrenciler.Size = new System.Drawing.Size(523, 209);
            this.dgvOgrenciler.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpboxOgrenciler);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpboxOgrenciler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dateTimeKayit;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpboxOgrenciler;
        private System.Windows.Forms.DataGridView dgvOgrenciler;
    }
}
namespace XML_Giris
{
    partial class Form1
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnXmlOku = new System.Windows.Forms.Button();
            this.btnDoldur = new System.Windows.Forms.Button();
            this.btnXmlYaz = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvCustomers);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 397);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers :";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(3, 16);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(686, 378);
            this.dgvCustomers.TabIndex = 0;
            // 
            // btnXmlOku
            // 
            this.btnXmlOku.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXmlOku.Location = new System.Drawing.Point(552, 406);
            this.btnXmlOku.Name = "btnXmlOku";
            this.btnXmlOku.Size = new System.Drawing.Size(137, 43);
            this.btnXmlOku.TabIndex = 3;
            this.btnXmlOku.Text = "XML Oku";
            this.btnXmlOku.UseVisualStyleBackColor = true;
            this.btnXmlOku.Click += new System.EventHandler(this.btnXmlOku_Click);
            // 
            // btnDoldur
            // 
            this.btnDoldur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDoldur.Location = new System.Drawing.Point(283, 406);
            this.btnDoldur.Name = "btnDoldur";
            this.btnDoldur.Size = new System.Drawing.Size(137, 43);
            this.btnDoldur.TabIndex = 4;
            this.btnDoldur.Text = "Doldur";
            this.btnDoldur.UseVisualStyleBackColor = true;
            this.btnDoldur.Click += new System.EventHandler(this.btnDoldur_Click);
            // 
            // btnXmlYaz
            // 
            this.btnXmlYaz.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXmlYaz.Location = new System.Drawing.Point(27, 406);
            this.btnXmlYaz.Name = "btnXmlYaz";
            this.btnXmlYaz.Size = new System.Drawing.Size(137, 43);
            this.btnXmlYaz.TabIndex = 5;
            this.btnXmlYaz.Text = "XML Yaz";
            this.btnXmlYaz.UseVisualStyleBackColor = true;
            this.btnXmlYaz.Click += new System.EventHandler(this.btnXmlYaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXmlOku);
            this.Controls.Add(this.btnDoldur);
            this.Controls.Add(this.btnXmlYaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnXmlOku;
        private System.Windows.Forms.Button btnDoldur;
        private System.Windows.Forms.Button btnXmlYaz;
    }
}


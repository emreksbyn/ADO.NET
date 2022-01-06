namespace _5_ADO.NET_Disconnected
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
            this.dateTimeDogum = new System.Windows.Forms.DateTimePicker();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBirinci = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.lblSiraNo = new System.Windows.Forms.Label();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.btnSonuncu = new System.Windows.Forms.Button();
            this.btnOnceki = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeDogum);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 183);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çalışan Bilgileri :";
            // 
            // dateTimeDogum
            // 
            this.dateTimeDogum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDogum.Location = new System.Drawing.Point(88, 103);
            this.dateTimeDogum.Name = "dateTimeDogum";
            this.dateTimeDogum.Size = new System.Drawing.Size(180, 20);
            this.dateTimeDogum.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(88, 143);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(180, 20);
            this.txtTelefon.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(88, 65);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(180, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(88, 26);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(180, 20);
            this.txtAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefonu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "D. Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // btnBirinci
            // 
            this.btnBirinci.Location = new System.Drawing.Point(30, 33);
            this.btnBirinci.Name = "btnBirinci";
            this.btnBirinci.Size = new System.Drawing.Size(49, 31);
            this.btnBirinci.TabIndex = 4;
            this.btnBirinci.Text = "|<";
            this.btnBirinci.UseVisualStyleBackColor = true;
            this.btnBirinci.Click += new System.EventHandler(this.btnBirinci_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(30, 70);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(282, 45);
            this.trackBar.TabIndex = 10;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // lblSiraNo
            // 
            this.lblSiraNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiraNo.Location = new System.Drawing.Point(140, 33);
            this.lblSiraNo.Name = "lblSiraNo";
            this.lblSiraNo.Size = new System.Drawing.Size(62, 31);
            this.lblSiraNo.TabIndex = 9;
            this.lblSiraNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSonraki
            // 
            this.btnSonraki.Location = new System.Drawing.Point(208, 33);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(49, 31);
            this.btnSonraki.TabIndex = 5;
            this.btnSonraki.Text = ">>";
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // btnSonuncu
            // 
            this.btnSonuncu.Location = new System.Drawing.Point(263, 33);
            this.btnSonuncu.Name = "btnSonuncu";
            this.btnSonuncu.Size = new System.Drawing.Size(49, 31);
            this.btnSonuncu.TabIndex = 6;
            this.btnSonuncu.Text = ">|";
            this.btnSonuncu.UseVisualStyleBackColor = true;
            this.btnSonuncu.Click += new System.EventHandler(this.btnSonuncu_Click);
            // 
            // btnOnceki
            // 
            this.btnOnceki.Location = new System.Drawing.Point(85, 33);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(49, 31);
            this.btnOnceki.TabIndex = 7;
            this.btnOnceki.Text = "<<";
            this.btnOnceki.UseVisualStyleBackColor = true;
            this.btnOnceki.Click += new System.EventHandler(this.btnOnceki_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 338);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBirinci);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.lblSiraNo);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.btnSonuncu);
            this.Controls.Add(this.btnOnceki);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeDogum;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBirinci;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label lblSiraNo;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.Button btnSonuncu;
        private System.Windows.Forms.Button btnOnceki;
    }
}
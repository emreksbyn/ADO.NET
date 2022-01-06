namespace _2_ADO.NET_Connected
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
            this.btnGonderYeni = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.numTutar = new System.Windows.Forms.NumericUpDown();
            this.txtAlan = new System.Windows.Forms.TextBox();
            this.txtGonderen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTutar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGonderYeni);
            this.groupBox1.Controls.Add(this.btnGonder);
            this.groupBox1.Controls.Add(this.numTutar);
            this.groupBox1.Controls.Add(this.txtAlan);
            this.groupBox1.Controls.Add(this.txtGonderen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Havale İşlemi :";
            // 
            // btnGonderYeni
            // 
            this.btnGonderYeni.Location = new System.Drawing.Point(157, 152);
            this.btnGonderYeni.Name = "btnGonderYeni";
            this.btnGonderYeni.Size = new System.Drawing.Size(180, 43);
            this.btnGonderYeni.TabIndex = 10;
            this.btnGonderYeni.Text = "Gönder (Yeni)";
            this.btnGonderYeni.UseVisualStyleBackColor = true;
            this.btnGonderYeni.Click += new System.EventHandler(this.btnGonderYeni_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(157, 103);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(180, 43);
            this.btnGonder.TabIndex = 10;
            this.btnGonder.Text = "Gönder (Eski)";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // numTutar
            // 
            this.numTutar.Location = new System.Drawing.Point(157, 75);
            this.numTutar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTutar.Name = "numTutar";
            this.numTutar.Size = new System.Drawing.Size(180, 20);
            this.numTutar.TabIndex = 9;
            this.numTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlan
            // 
            this.txtAlan.Location = new System.Drawing.Point(157, 46);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(180, 20);
            this.txtAlan.TabIndex = 8;
            // 
            // txtGonderen
            // 
            this.txtGonderen.Location = new System.Drawing.Point(157, 20);
            this.txtGonderen.Name = "txtGonderen";
            this.txtGonderen.Size = new System.Drawing.Size(180, 20);
            this.txtGonderen.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tutar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alıcı Hesap No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gönderen Hesap No :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 263);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTutar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGonderYeni;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.NumericUpDown numTutar;
        private System.Windows.Forms.TextBox txtAlan;
        private System.Windows.Forms.TextBox txtGonderen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
namespace _2_ADO.NET_Connected
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.btnStockByName = new System.Windows.Forms.Button();
            this.btnStockByID = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Employee :";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(101, 97);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(192, 36);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Add New Employee";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(101, 60);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(192, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(102, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(192, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbProductName);
            this.groupBox2.Controls.Add(this.btnStockByName);
            this.groupBox2.Controls.Add(this.btnStockByID);
            this.groupBox2.Controls.Add(this.txtProductID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(24, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 184);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock :";
            // 
            // cmbProductName
            // 
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(102, 56);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(191, 21);
            this.cmbProductName.TabIndex = 3;
            // 
            // btnStockByName
            // 
            this.btnStockByName.Location = new System.Drawing.Point(102, 135);
            this.btnStockByName.Name = "btnStockByName";
            this.btnStockByName.Size = new System.Drawing.Size(191, 36);
            this.btnStockByName.TabIndex = 2;
            this.btnStockByName.Text = "Stock By Name";
            this.btnStockByName.UseVisualStyleBackColor = true;
            this.btnStockByName.Click += new System.EventHandler(this.btnStockByName_Click);
            // 
            // btnStockByID
            // 
            this.btnStockByID.Location = new System.Drawing.Point(102, 90);
            this.btnStockByID.Name = "btnStockByID";
            this.btnStockByID.Size = new System.Drawing.Size(191, 36);
            this.btnStockByID.TabIndex = 2;
            this.btnStockByID.Text = "Stock By ID";
            this.btnStockByID.UseVisualStyleBackColor = true;
            this.btnStockByID.Click += new System.EventHandler(this.btnStockByID_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(102, 24);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(191, 20);
            this.txtProductID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Product ID :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.Button btnStockByName;
        private System.Windows.Forms.Button btnStockByID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
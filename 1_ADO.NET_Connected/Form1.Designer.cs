namespace _1_ADO.NET_Connected
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
            this.lstboxOrderDetails = new System.Windows.Forms.ListBox();
            this.lstboxProducts = new System.Windows.Forms.ListBox();
            this.lstboxEmployees = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstboxOrderDetails
            // 
            this.lstboxOrderDetails.FormattingEnabled = true;
            this.lstboxOrderDetails.Location = new System.Drawing.Point(321, 193);
            this.lstboxOrderDetails.Name = "lstboxOrderDetails";
            this.lstboxOrderDetails.Size = new System.Drawing.Size(134, 277);
            this.lstboxOrderDetails.TabIndex = 9;
            // 
            // lstboxProducts
            // 
            this.lstboxProducts.FormattingEnabled = true;
            this.lstboxProducts.Location = new System.Drawing.Point(180, 193);
            this.lstboxProducts.Name = "lstboxProducts";
            this.lstboxProducts.Size = new System.Drawing.Size(134, 277);
            this.lstboxProducts.TabIndex = 10;
            // 
            // lstboxEmployees
            // 
            this.lstboxEmployees.FormattingEnabled = true;
            this.lstboxEmployees.Location = new System.Drawing.Point(39, 193);
            this.lstboxEmployees.Name = "lstboxEmployees";
            this.lstboxEmployees.Size = new System.Drawing.Size(134, 277);
            this.lstboxEmployees.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(21, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 114);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection :";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(18, 77);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(275, 23);
            this.progressBar.TabIndex = 5;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(158, 30);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(135, 40);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(17, 30);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(135, 40);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.Location = new System.Drawing.Point(320, 147);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(135, 40);
            this.btnOrderDetails.TabIndex = 6;
            this.btnOrderDetails.Text = "Order Details";
            this.btnOrderDetails.UseVisualStyleBackColor = true;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(179, 147);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(135, 40);
            this.btnProducts.TabIndex = 7;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(38, 147);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(135, 40);
            this.btnEmployees.TabIndex = 8;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 482);
            this.Controls.Add(this.lstboxOrderDetails);
            this.Controls.Add(this.lstboxProducts);
            this.Controls.Add(this.lstboxEmployees);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOrderDetails);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnEmployees);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxOrderDetails;
        private System.Windows.Forms.ListBox lstboxProducts;
        private System.Windows.Forms.ListBox lstboxEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnEmployees;
    }
}


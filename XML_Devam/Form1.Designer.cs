namespace XML_Devam
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
            this.lstviewSuppliers = new System.Windows.Forms.ListView();
            this.btnReadXML = new System.Windows.Forms.Button();
            this.btnWriteXML = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lstviewSuppliers);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 342);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suppliers :";
            // 
            // lstviewSuppliers
            // 
            this.lstviewSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstviewSuppliers.HideSelection = false;
            this.lstviewSuppliers.Location = new System.Drawing.Point(3, 16);
            this.lstviewSuppliers.Name = "lstviewSuppliers";
            this.lstviewSuppliers.Size = new System.Drawing.Size(528, 323);
            this.lstviewSuppliers.TabIndex = 0;
            this.lstviewSuppliers.UseCompatibleStateImageBehavior = false;
            this.lstviewSuppliers.View = System.Windows.Forms.View.Details;
            // 
            // btnReadXML
            // 
            this.btnReadXML.Location = new System.Drawing.Point(178, 12);
            this.btnReadXML.Name = "btnReadXML";
            this.btnReadXML.Size = new System.Drawing.Size(161, 50);
            this.btnReadXML.TabIndex = 2;
            this.btnReadXML.Text = "Products [Read XML]";
            this.btnReadXML.UseVisualStyleBackColor = true;
            this.btnReadXML.Click += new System.EventHandler(this.btnReadXML_Click);
            // 
            // btnWriteXML
            // 
            this.btnWriteXML.Location = new System.Drawing.Point(11, 12);
            this.btnWriteXML.Name = "btnWriteXML";
            this.btnWriteXML.Size = new System.Drawing.Size(161, 50);
            this.btnWriteXML.TabIndex = 3;
            this.btnWriteXML.Text = "Products [Write XML]";
            this.btnWriteXML.UseVisualStyleBackColor = true;
            this.btnWriteXML.Click += new System.EventHandler(this.btnWriteXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 423);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReadXML);
            this.Controls.Add(this.btnWriteXML);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstviewSuppliers;
        private System.Windows.Forms.Button btnReadXML;
        private System.Windows.Forms.Button btnWriteXML;
    }
}


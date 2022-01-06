namespace XML_Devam
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtProducts = new System.Windows.Forms.TextBox();
            this.txtProductsNode = new System.Windows.Forms.TextBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(24, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 413);
            this.panel1.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtProducts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtProductsNode);
            this.splitContainer1.Size = new System.Drawing.Size(512, 413);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtProducts
            // 
            this.txtProducts.BackColor = System.Drawing.SystemColors.Control;
            this.txtProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProducts.Location = new System.Drawing.Point(0, 0);
            this.txtProducts.Multiline = true;
            this.txtProducts.Name = "txtProducts";
            this.txtProducts.Size = new System.Drawing.Size(170, 413);
            this.txtProducts.TabIndex = 0;
            // 
            // txtProductsNode
            // 
            this.txtProductsNode.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductsNode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductsNode.Location = new System.Drawing.Point(0, 0);
            this.txtProductsNode.Multiline = true;
            this.txtProductsNode.Name = "txtProductsNode";
            this.txtProductsNode.Size = new System.Drawing.Size(338, 413);
            this.txtProductsNode.TabIndex = 0;
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(97, 20);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(206, 21);
            this.cmbCategories.TabIndex = 4;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 479);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtProducts;
        private System.Windows.Forms.TextBox txtProductsNode;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label label1;
    }
}
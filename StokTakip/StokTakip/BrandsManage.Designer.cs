namespace StokTakip
{
    partial class BrandsManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandsManage));
            this.lst_Brands = new System.Windows.Forms.ListBox();
            this.btnDeleteBrand = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateBrand = new System.Windows.Forms.Button();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_Brands
            // 
            resources.ApplyResources(this.lst_Brands, "lst_Brands");
            this.lst_Brands.FormattingEnabled = true;
            this.lst_Brands.Name = "lst_Brands";
            // 
            // btnDeleteBrand
            // 
            resources.ApplyResources(this.btnDeleteBrand, "btnDeleteBrand");
            this.btnDeleteBrand.Name = "btnDeleteBrand";
            this.btnDeleteBrand.UseVisualStyleBackColor = true;
            this.btnDeleteBrand.Click += new System.EventHandler(this.btnDeleteBrand_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btnCreateBrand);
            this.groupBox1.Controls.Add(this.txtBrandName);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnCreateBrand
            // 
            resources.ApplyResources(this.btnCreateBrand, "btnCreateBrand");
            this.btnCreateBrand.Name = "btnCreateBrand";
            this.btnCreateBrand.UseVisualStyleBackColor = true;
            this.btnCreateBrand.Click += new System.EventHandler(this.btnCreateBrand_Click);
            // 
            // txtBrandName
            // 
            resources.ApplyResources(this.txtBrandName, "txtBrandName");
            this.txtBrandName.Name = "txtBrandName";
            // 
            // BrandsManage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteBrand);
            this.Controls.Add(this.lst_Brands);
            this.Name = "BrandsManage";
            this.Load += new System.EventHandler(this.BrandsManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Brands;
        private System.Windows.Forms.Button btnDeleteBrand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateBrand;
        private System.Windows.Forms.TextBox txtBrandName;
    }
}
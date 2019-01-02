namespace StokTakip
{
    partial class PhonesManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhonesManage));
            this.btn_newPhone = new System.Windows.Forms.Button();
            this.btn_deletePhone = new System.Windows.Forms.Button();
            this.grid_phones = new System.Windows.Forms.DataGridView();
            this.filter_cb_brand = new System.Windows.Forms.ComboBox();
            this.filter_tb_modelcode = new System.Windows.Forms.TextBox();
            this.filter_btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_phones)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_newPhone
            // 
            resources.ApplyResources(this.btn_newPhone, "btn_newPhone");
            this.btn_newPhone.Name = "btn_newPhone";
            this.btn_newPhone.UseVisualStyleBackColor = true;
            this.btn_newPhone.Click += new System.EventHandler(this.btn_newPhone_Click);
            // 
            // btn_deletePhone
            // 
            resources.ApplyResources(this.btn_deletePhone, "btn_deletePhone");
            this.btn_deletePhone.Name = "btn_deletePhone";
            this.btn_deletePhone.UseVisualStyleBackColor = true;
            // 
            // grid_phones
            // 
            resources.ApplyResources(this.grid_phones, "grid_phones");
            this.grid_phones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_phones.Name = "grid_phones";
            // 
            // filter_cb_brand
            // 
            resources.ApplyResources(this.filter_cb_brand, "filter_cb_brand");
            this.filter_cb_brand.FormattingEnabled = true;
            this.filter_cb_brand.Name = "filter_cb_brand";
            this.filter_cb_brand.SelectedIndexChanged += new System.EventHandler(this.filter_cb_brand_SelectedIndexChanged);
            // 
            // filter_tb_modelcode
            // 
            resources.ApplyResources(this.filter_tb_modelcode, "filter_tb_modelcode");
            this.filter_tb_modelcode.Name = "filter_tb_modelcode";
            // 
            // filter_btn_search
            // 
            resources.ApplyResources(this.filter_btn_search, "filter_btn_search");
            this.filter_btn_search.Image = global::StokTakip.Properties.Resources.iconfinder_search_322497;
            this.filter_btn_search.Name = "filter_btn_search";
            this.filter_btn_search.UseVisualStyleBackColor = true;
            this.filter_btn_search.Click += new System.EventHandler(this.filter_btn_search_Click);
            // 
            // PhonesManage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filter_btn_search);
            this.Controls.Add(this.filter_tb_modelcode);
            this.Controls.Add(this.filter_cb_brand);
            this.Controls.Add(this.grid_phones);
            this.Controls.Add(this.btn_deletePhone);
            this.Controls.Add(this.btn_newPhone);
            this.Name = "PhonesManage";
            this.Load += new System.EventHandler(this.PhonesManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_phones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_newPhone;
        private System.Windows.Forms.Button btn_deletePhone;
        private System.Windows.Forms.DataGridView grid_phones;
        private System.Windows.Forms.ComboBox filter_cb_brand;
        private System.Windows.Forms.TextBox filter_tb_modelcode;
        private System.Windows.Forms.Button filter_btn_search;
    }
}
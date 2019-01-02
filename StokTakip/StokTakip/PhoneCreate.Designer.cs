namespace StokTakip
{
    partial class PhoneCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneCreate));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_brand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_modelCode = new System.Windows.Forms.TextBox();
            this.nm_price = new System.Windows.Forms.NumericUpDown();
            this.tb_IMEI1 = new System.Windows.Forms.TextBox();
            this.tb_IMEI2 = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nm_price)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cb_brand
            // 
            resources.ApplyResources(this.cb_brand, "cb_brand");
            this.cb_brand.FormattingEnabled = true;
            this.cb_brand.Name = "cb_brand";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tb_name
            // 
            resources.ApplyResources(this.tb_name, "tb_name");
            this.tb_name.Name = "tb_name";
            // 
            // tb_modelCode
            // 
            resources.ApplyResources(this.tb_modelCode, "tb_modelCode");
            this.tb_modelCode.Name = "tb_modelCode";
            // 
            // nm_price
            // 
            resources.ApplyResources(this.nm_price, "nm_price");
            this.nm_price.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.nm_price.Name = "nm_price";
            // 
            // tb_IMEI1
            // 
            resources.ApplyResources(this.tb_IMEI1, "tb_IMEI1");
            this.tb_IMEI1.Name = "tb_IMEI1";
            // 
            // tb_IMEI2
            // 
            resources.ApplyResources(this.tb_IMEI2, "tb_IMEI2");
            this.tb_IMEI2.Name = "tb_IMEI2";
            // 
            // btn_save
            // 
            resources.ApplyResources(this.btn_save, "btn_save");
            this.btn_save.Name = "btn_save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_Clear
            // 
            resources.ApplyResources(this.btn_Clear, "btn_Clear");
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // PhoneCreate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_IMEI2);
            this.Controls.Add(this.tb_IMEI1);
            this.Controls.Add(this.nm_price);
            this.Controls.Add(this.tb_modelCode);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_brand);
            this.Controls.Add(this.label1);
            this.Name = "PhoneCreate";
            this.Load += new System.EventHandler(this.PhoneCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nm_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_brand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_modelCode;
        private System.Windows.Forms.NumericUpDown nm_price;
        private System.Windows.Forms.TextBox tb_IMEI1;
        private System.Windows.Forms.TextBox tb_IMEI2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Clear;
    }
}
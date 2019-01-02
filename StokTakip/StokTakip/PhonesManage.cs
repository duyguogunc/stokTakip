using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class PhonesManage : Form
    {
        public PhonesManage()
        {
            InitializeComponent();
        }

        UnitOfWork _uw = new UnitOfWork();

        private void PhonesManage_Load(object sender, EventArgs e)
        {
            FillBrandsCombobox();
            FillPhonesGrid();
        }

        public void FillPhonesGrid()
        {
            grid_phones.DataSource = null;
            grid_phones.DataSource = _uw.Phones.GetPhonesForDisplay();
        }

        private void FillBrandsCombobox()
        {
            UIHelper.FillBrandComboBox(filter_cb_brand, Properties.Resources.AllBrands);
        }

        private void btn_newPhone_Click(object sender, EventArgs e)
        {
            new PhoneCreate().Show();
        }

        private void filter_cb_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void filter_btn_search_Click(object sender, EventArgs e)
        {
            grid_phones.DataSource = null;

            var chosenBrandId = (int)filter_cb_brand.SelectedValue;

            grid_phones.DataSource = _uw.Phones.SearchPhone(chosenBrandId, filter_tb_modelcode.Text);
        }
    }
}

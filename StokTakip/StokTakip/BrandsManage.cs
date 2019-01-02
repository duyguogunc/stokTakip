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
    public partial class BrandsManage : Form
    {
        UnitOfWork _uw = new UnitOfWork();

        public BrandsManage()
        {
            InitializeComponent();
        }
      
        private void BrandsManage_Load(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            lst_Brands.DisplayMember = "BrandName";
            lst_Brands.ValueMember = "ID";
            lst_Brands.DataSource = _uw.Brands.GetBrands();
        }

        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            _uw.Brands.DeleteBrand((int)lst_Brands.SelectedValue);
        }

        private void btnCreateBrand_Click(object sender, EventArgs e)
        {
            Brand b = new Brand() { BrandName = txtBrandName.Text };
            _uw.Brands.InsertBrand(b);
            lst_Brands.DataSource = null;
            RefreshListBox();
        }
    }
}

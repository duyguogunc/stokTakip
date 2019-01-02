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
    public partial class PhoneCreate : Form
    {
        UnitOfWork _uw = new UnitOfWork();

        public PhoneCreate()
        {
            InitializeComponent();
        }

        private void PhoneCreate_Load(object sender, EventArgs e)
        {
            UIHelper.FillBrandComboBox(cb_brand, Properties.Resources.Choose);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Phone newPhone = new Phone();
            newPhone.Brand = (Brand)cb_brand.SelectedItem;
            newPhone.IMEI1 = tb_IMEI1.Text;
            newPhone.IMEI2 = tb_IMEI2.Text;
            newPhone.Price = nm_price.Value;
            newPhone.ProductName = tb_name.Text;
            newPhone.ModelCode = tb_modelCode.Text;

            _uw.Phones.InsertPhone(newPhone);

            RefreshMainPhoneGrid();
        }

        private void RefreshMainPhoneGrid()
        {
            Form openForm = Application.OpenForms["PhonesManage"];
            PhonesManage pcForm = (PhonesManage)openForm;
            pcForm.FillPhonesGrid();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cb_brand.SelectedIndex = 0;
            tb_IMEI1.Clear();
            tb_IMEI2.Clear();
            tb_modelCode.Clear();
            tb_name.Clear();
            nm_price.Value = 0;
        }
    }
}

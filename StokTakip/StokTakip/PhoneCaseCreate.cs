using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class PhoneCaseCreate : Form
    {
        UnitOfWork _uw = new UnitOfWork();
        public PhoneCaseCreate()
        {
            InitializeComponent();
        }

        public void SelectPhoneCase(int id)
        {
            tabControl1.SelectTab(1);
            cb_cases.SelectedValue = id;
        }

        private void PhoneCaseCreate_Load(object sender, EventArgs e)
        {
            FillColorsCombo();
            FillPhoneCasesCombo();
            RefreshCurrentStock();
        }

        private void FillPhoneCasesCombo()
        {
            cb_cases.DataSource = null;
            cb_cases.DisplayMember = "ProductName"; //class prop
            cb_cases.ValueMember = "ID";
            cb_cases.DataSource = _uw.PhoneCases.GetPhoneCases();
        }

        private void FillColorsCombo()
        {
            Type T = typeof(CaseColor);

            List<string> options;
            if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "en")
            {
                //Normal değerler (inglizce)
                options = T.GetEnumNames().ToList();
                //string[] ---> List<string>
            }
            else
            {
                var attrs = T.GetFields().SelectMany(x => x.CustomAttributes);
                var attrNames = attrs.SelectMany(x => x.ConstructorArguments);
                options = attrNames.Select(x => (string)x.Value).ToList();
            }
            cb_color.DataSource = options;

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
            nm_price.Value = 0;
            nm_qty.Value = 0;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            PhoneCase p = new PhoneCase();
            p.ProductName = tb_name.Text;
            p.CaseColor = (CaseColor)cb_color.SelectedIndex;
            p.Price = nm_price.Value;
            p.StockQTY = (int)nm_qty.Value;

            _uw.PhoneCases.InsertPhoneCase(p);

            RefreshMainGrid();
            FillPhoneCasesCombo();
        }

        private void RefreshMainGrid()
        {
            PhoneCaseManage f = (PhoneCaseManage)Application.OpenForms["PhoneCaseManage"];
            if (f != null)
                f.FillGrid();
        }
        private void btn_AddStock_Click(object sender, EventArgs e)
        {
            int id = (int)cb_cases.SelectedValue;
            int qty = (int)nm_qtyAdd.Value;
            _uw.PhoneCases.AddStockToPhoneCase(id, qty);

            RefreshMainGrid();
            FillPhoneCasesCombo();
        }
        
        private void RefreshCurrentStock()
        {
            if (cb_cases.SelectedItem == null)
                return;

            string template = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "en" ? "Stock will be updated as 0 when saved." : "Kaydettiğinizde adet 0 olarak güncellenecektir.";

            var chosenCase = (PhoneCase)cb_cases.SelectedItem;
            var currentStock = chosenCase.StockQTY;
            int latest = currentStock + (int)nm_qtyAdd.Value;
            lbl_info.Text = template.Replace("0",latest.ToString());
        }

        private void cb_cases_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCurrentStock();
        }

        private void nm_qtyAdd_ValueChanged(object sender, EventArgs e)
        {
            RefreshCurrentStock();
        }

        private void nm_qtyAdd_KeyUp(object sender, KeyEventArgs e)
        {
            RefreshCurrentStock();
        }

        private void nm_qtyAdd_Scroll(object sender, ScrollEventArgs e)
        {
            RefreshCurrentStock();
        }
    }
}

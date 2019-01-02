using StokTakip.BusinessLogic;
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
    public partial class PhoneCaseManage : Form
    {
        UnitOfWork _uw = new UnitOfWork();
        public PhoneCaseManage()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _uw.PhoneCases.GetPhoneCases();
        }

        private void PhoneCaseManage_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btn_phoneCaseCreate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
                new PhoneCaseCreate().Show();
            else
            {
                int secilenId = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
                PhoneCaseCreate f = new PhoneCaseCreate();
                f.Show();
                f.SelectPhoneCase(secilenId);
            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                int id = (int)item.Cells["ID"].Value;
                _uw.PhoneCases.Delete(id);
            }
            FillGrid();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            btn_phoneCaseCreate.PerformClick();
        }
    }
}

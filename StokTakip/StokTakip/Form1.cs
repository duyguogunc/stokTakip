using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void markalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrandsManage f = new BrandsManage();
            f.MdiParent = this;
            f.Show();
        }

        private void telefonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhonesManage f = new PhonesManage();
            f.MdiParent = this;
            f.Show();
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayar.ChangeLanguage(Languages.tr);
            this.Controls.Clear();
            InitializeComponent();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayar.ChangeLanguage(Languages.en);
            this.Controls.Clear();
            InitializeComponent();
        }

        private void phoneCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhoneCaseManage f = new PhoneCaseManage();
            f.MdiParent = this;
            f.Show();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesForm f = new SalesForm();
            f.MdiParent = this;
            f.Show();
        }
    }
}

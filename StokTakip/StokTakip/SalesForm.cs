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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = SalesManager.GetProducts();
            listBox1.DisplayMember = "ProductName";

            int[] widths = { 40, 160, 120, 150, 150 };
            for (int i = 0; i < widths.Length; i++)
                dataGridView1.Columns[i].Width = widths[i];
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //çift tıklanan satırı al
            var cells = dataGridView1.SelectedRows[0].Cells;

            //satırdaki ürünün cinsini bul
            Product p;
            if (cells["IMEI1"].Value == "")
                p = new PhoneCase();
            else
                p = new Phone();

            //ürünün isim, fiyat, ID bilgilerini tut
            p.ID = (int)cells["ID"].Value;
            p.Price = (decimal)cells["Price"].Value;
            p.ProductName = cells["ProductName"].Value.ToString();

            //tutulan bilgileri listboxa aktar
            listBox1.Items.Add(p);
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (Product item in listBox1.Items)
                total += item.Price;

            label1.Text = total.ToString("C");
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SalesManager.GetProducts(tb_search.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> list = listBox1.Items.Cast<Product>().ToList();
            SalesManager.SellProducts(list);
            FillGrid();
            string message = list.Count + " ürün stoktan düşüldü:";

            decimal total = 0;
            foreach (var item in list)
            {
                message += Environment.NewLine;
                message += item.ProductName + " ("+item.Price+")";
                total += item.Price;
            }
            message += Environment.NewLine;
            message += Environment.NewLine;
            message += "Toplam: " + total;
            MessageBox.Show(message);

            listBox1.Items.Clear();
        }
    }
}

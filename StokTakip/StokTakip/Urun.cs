using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    public abstract class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int StockQTY { get; set; }
    }

    class Phone : Product
    {
        public string IMEI1 { get; set; }
        public string IMEI2 { get; set; }
        public Brand Brand { get; set; }
        public string ModelCode { get; set; }

        public Phone()
        {
            StockQTY = 1;
        }
    }

    class Brand
    {
        public int ID { get; set; }
        public string BrandName { get; set; }
    }

    class PhoneCase : Product
    {
        public CaseColor CaseColor { get; set; }

    }

    enum CaseColor {
        [Description("Siyah")]
        Black,
        [Description("Altın")]
        Gold,
        [Description("Pembe")]
        Pink
    }
}

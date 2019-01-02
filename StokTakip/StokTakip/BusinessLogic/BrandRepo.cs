using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLogic
{
    class BrandRepo
    {
        public List<Brand> GetBrands()
        {
            List<Brand> list = new List<Brand>();
            DataTable dt = Program.SqlHelper.GetTable("SELECT * FROM Brands");
            foreach (DataRow row in dt.Rows)
            {
                Brand b = new Brand();
                b.ID = (int)row["ID"]; //unboxing
                b.BrandName = row["BrandName"].ToString();
                list.Add(b);
            }
            return list;
        }

        public void InsertBrand(Brand newBrand)
        {
            Program.SqlHelper.ExecuteCommand(@"
IF NOT EXISTS(SELECT * FROM Brands WHERE BrandName = '" + newBrand.BrandName + @"')
INSERT INTO Brands (BrandName) VALUES ('" + newBrand.BrandName + "')");
        }

        public void DeleteBrand(int brandId)
        {
            Program.SqlHelper.ExecuteProc("DeleteBrand",brandId);
        }
    }
}

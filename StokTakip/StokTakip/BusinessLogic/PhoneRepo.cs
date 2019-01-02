using StokTakip.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLogic
{
    class PhoneRepo
    {
        public List<Phone> GetPhones()
        {
            List<Phone> list = new List<Phone>();
            DataTable dt = Program.SqlHelper.GetTable("exec GetPhones");
            foreach (DataRow item in dt.Rows)
            {
                Phone p = new Phone();
                p.ID = (int)item["ID"];
                p.ProductName = item["ProductName"].ToString();
                p.Price = (decimal)item["Price"];
                p.IMEI1 = item["IMEI1"].ToString();
                p.IMEI2 = item["IMEI2"].ToString();
                p.ModelCode = item["ModelCode"].ToString();
                p.Brand = new Brand(); //nullRef Hatası
                p.Brand.BrandName = item["BrandName"].ToString() ;
                p.Brand.ID = (int)item["BID"];
                list.Add(p);
            }
            return list;
        }

        public List<PhoneViewModel> GetPhonesForDisplay()
        {
            List<PhoneViewModel> list = new List<PhoneViewModel>();
            DataTable dt = Program.SqlHelper.GetTable("exec GetPhones");
            foreach (DataRow item in dt.Rows)
            {
                PhoneViewModel p = new PhoneViewModel();
                p.No = (int)item["ID"];
                p.Name = item["ProductName"].ToString();
                p.Price = ((decimal)item["Price"]).ToString("C");
                //p.IMEI1 = item["IMEI1"].ToString();
                //p.IMEI2 = item["IMEI2"].ToString();
                p.ModelCode = item["ModelCode"].ToString();
                p.Brand = item["BrandName"].ToString();
                list.Add(p);
            }
            return list;
        }

        public void InsertPhone(Phone newPhone)
        {
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "productName";
            p1.Value = newPhone.ProductName;

            SqlParameter p2 = new SqlParameter("price", newPhone.Price);

            SqlParameter p3 = new SqlParameter("IMEI1", newPhone.IMEI1);

            SqlParameter p4 = new SqlParameter("IMEI2", newPhone.IMEI2);

            SqlParameter p5 = new SqlParameter("modelCode", newPhone.ModelCode);

            SqlParameter p6 = new SqlParameter("brandId", newPhone.Brand.ID);

            Program.SqlHelper.ExecuteProc("InsertPhone", p1, p2, p3, p4, p5, p6);
        }

        public void DeletePhone(int phoneId)
        {
            Program.SqlHelper.ExecuteProc("DeletePhone", phoneId);
        }

        public List<PhoneViewModel> SearchPhone(int BrandId=0, string ModelCode = "")
        {
            List<PhoneViewModel> list = new List<PhoneViewModel>();
            //exec sp_searchPhone 0, 't123'
           var dt= Program.SqlHelper.GetTable("exec sp_searchPhone "+BrandId + ", '"+ModelCode+"'");

            foreach (DataRow item in dt.Rows)
            {
                PhoneViewModel p = new PhoneViewModel();
                p.Brand = item["BrandName"].ToString();
                p.Price = ((decimal)item["Price"]).ToString("C");
                p.No = (int)item["ID"];
                p.ModelCode = item["ModelCode"].ToString();
                p.Name = item["ProductName"].ToString();
                list.Add(p);
            }

            return list;
        }
    }
}

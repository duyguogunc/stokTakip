using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLogic
{
    class PhoneCaseRepo
    {
        public List<PhoneCase> GetPhoneCases()
        {
            List<PhoneCase> list = new List<PhoneCase>();
            DataTable dt = Program.SqlHelper.GetTable("SELECT * FROM PhoneCases");
            foreach (DataRow item in dt.Rows)
            {
                PhoneCase p = new PhoneCase();
                p.ID = (int)item["ID"];
                p.ProductName = item["ProductName"].ToString();
                p.Price = (decimal)item["Price"];
                p.StockQTY = (int)item["StockQTY"];
                p.CaseColor = (CaseColor)item["CaseColor"];
                list.Add(p);
            }
            return list;
        }

        public void InsertPhoneCase(PhoneCase newPhoneCase)
        {
            #region Ver1
            /* Program.SqlHelper.ExecuteCommand(@"INSERT INTO [dbo].[PhoneCases]
            ([ProductName]
            ,[Price]
            ,[CaseColor]
            ,[StockQTY]) VALUES ('"+newPhoneCase.ProductName+"',"+newPhoneCase.Price+","+(int)newPhoneCase.CaseColor+","+newPhoneCase.StockQTY+")");
            */
            #endregion
            #region Ver2
            //prosedürdeki parametreler
            SqlParameter p1 = new SqlParameter("name", newPhoneCase.ProductName);
            SqlParameter p2 = new SqlParameter("price", newPhoneCase.Price);
            SqlParameter p3 = new SqlParameter("color", (int)newPhoneCase.CaseColor);
            SqlParameter p4 = new SqlParameter("qty", newPhoneCase.StockQTY);
            Program.SqlHelper.ExecuteProc("sp_CreatePhoneCase", p1, p2, p3, p4);
            #endregion
        }

        public void AddStockToPhoneCase(int id, int qty)
        {
            SqlParameter p1 = new SqlParameter("id", id);
            SqlParameter p2 = new SqlParameter("qty", qty);
            Program.SqlHelper.ExecuteProc("sp_addStock", p1, p2);
        }

        public void Delete(int id) {
            Program.SqlHelper.ExecuteCommand("DELETE FROM PhoneCases WHERE ID = "+id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    class Ornek
    {
        public string TekStringYap(params string[] stringler)
        {
            string yeniString = "";
            foreach (var item in stringler)
                yeniString += item + " ";
            return yeniString;
        }

        public void cagirmaOrnek()
        {
           string sonuc = TekStringYap("bir", "iki", "üç");
            //sonuc -> "bir iki üç"
        }
    }
}

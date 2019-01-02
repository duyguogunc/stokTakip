using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    static class Program
    {
        public static SQLHelper SqlHelper = new SQLHelper();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Ayar.GetLatestLanguage();
            Application.Run(new Form1());
        }
    }
}

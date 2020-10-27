using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElektronskiPDV
{
    static class Program
    {
        public static string getConnectionString = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog=EPDV;Integrated Security=True";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formPocetna());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PersonnelApplication
{
    static class Program
    {
        static DataManager dm = new DataManager();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ApplicationForm());
            DataManager dm = new DataManager();
        }

        public static DataManager GetDataManager()
        {
            return dm;
        }
    }
}

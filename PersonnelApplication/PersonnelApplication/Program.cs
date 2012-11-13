using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PersonnelApplication.PersonnelDataSetTableAdapters;

namespace PersonnelApplication
{
    static class Program
    {
        static DataManager dm = new DataManager();
        public static PersonnelDataSetTableAdapters.PeopleTableAdapter PeopleAdapter = new PeopleTableAdapter();
        public static PersonnelDataSetTableAdapters.TypesTableAdapter TypesAdapter = new TypesTableAdapter();
        public static PersonnelDataSetTableAdapters.PeopleTypesTableAdapter PeopleTypesAdapter = new PeopleTypesTableAdapter();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            PeopleTypesAdapter.Insert(1, 1, "055-72-6469", DateTime.Now);
            PeopleTypesAdapter.Insert(1, 2, "ABEK018302301", DateTime.Now);
            PeopleTypesAdapter.Insert(1, 3, "631-235-2016", DateTime.Now);
             */

            //PeopleTypesAdapter.Insert(0, 0, "", DateTime.Now.ToString());
            //PersonnelDataSet.PeopleTypesDataTable ds = PeopleTypesAdapter.GetDataBy(1);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ApplicationForm());

            //DataManager dm = new DataManager();
        }

        public static DataManager GetDataManager()
        {
            return dm;
        }

       
    }
}

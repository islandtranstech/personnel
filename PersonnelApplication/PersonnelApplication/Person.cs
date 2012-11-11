using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonnelApplication
{

    class Person
    {
        // temporary primary key
        static int id = 0;
        
        string FirstName;
        string LastName;
        DateTime Dob;
        int Id;

        public Person(string fname, string lname, DateTime dob)
        {
            FirstName = fname;
            LastName = lname;
            Dob = dob;
        }

        public void SavePeron()
        {
            Program.GetDataManager().SavePerson(this);
        }

        public string GetFirstName()
        {
            return this.FirstName;
        }

        public string GetLastName()
        {
            return this.LastName;
        }

        public DateTime GetDob()
        {
            return this.Dob;
        }
        
    }
}

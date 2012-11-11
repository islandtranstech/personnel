using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonnelApplication
{
    class Type
    {
        string Name;
        string Description;
        DateTime Expiration;
        int Renewal;

        public Type(string name, DateTime expiration, int renewal, string description)
        {
            Name = name;
            Description = description;
            Renewal = renewal;
            Expiration = expiration;
        }

        public bool Save()
        {
            try
            {
                Program.GetDataManager().SaveType(this);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}

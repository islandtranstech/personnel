using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Data;

namespace PersonnelApplication
{
    class DataManager
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        // again 

        List<Person> people;
        List<Type> types;

        private void Initialize()
        {
            server = "localhost";
            database = "test";
            uid = "root";
            password = "azaz09**";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        public DataSet LoadContentData(string table, string searchQuery)
        {
            string query = "";
            string where = "";
            if (table.Equals("Types"))
            {
                query = "SELECT * from Types ";
                if (searchQuery != null)
                {
                    where = "WHERE name LIKE '" + searchQuery + "' OR description LIKE '" + searchQuery + "'";
                    query += where;
                }
            }
            else
            {
                query = "SELECT * from People ";
                if (searchQuery != null)
                {
                    where = "WHERE lname LIKE '" + searchQuery + "' OR fname LIKE '" + searchQuery + "'";
                    query += where;
                }
            }
            
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, connection);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            return DS;
        }


        private void TestQuery()
        {
            try
            {
                string query = "INSERT INTO People(fname, lname) VALUES('dave', 'fioretti')";
                //Open connection
                if (this.OpenConnection() == true)
                {
                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    //this.CloseConnection();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
                Thread.Sleep(20000);
            }
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        public DataManager()
        {
            Initialize();
            people = new List<Person>();
            types = new List<Type>();
        }

        public void SavePerson(Person p)
        {
           // string query = "INSERT INTO People(fname, lname) VALUES('dave', 'fioretti')";
            string saveQuery = "INSERT INTO People(fname, lname, dob) VALUES('" + p.GetFirstName()
                + "', '" + p.GetLastName() + "')";
            people.Add(p);         
        }

        public void SaveType(Type t) 
        {
            types.Add(t);
        }

        public DataSet GetAdapter()
        {
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from People", connection);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            return DS;
            //dataGridView1.DataSource = DS.Tables[0];
        }


    }
}

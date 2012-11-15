using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonnelApplication
{
    public partial class EditPersonTypeForm : Form
    {
        int Pid;
        int Tid = -1;
        int Id = -1;
        Dictionary<string, int> typeId;


        public EditPersonTypeForm(int id, int pid, int tid, string value, DateTime expiration, string name)
        {
            InitializeComponent(); 
            Configure(pid);
            int selectedIndex = 0;
            foreach (string key in typeId.Keys)
            {
                if (key.Equals(name))
                {
                    break;
                }
                selectedIndex++;
            }
            comboBox1.SelectedIndex = selectedIndex;
            dateTimePicker1.Value = expiration;
            textBox1.Text = value; 

            Tid = tid;
            Id = id;
        }

        private void Configure(int pid)
        {
            PersonnelDataSet.TypesDataTable dt = Program.TypesAdapter.GetData();
            Pid = pid;
            typeId = new Dictionary<string, int>();

            foreach (DataRow row in dt)
            {
                string type = row["name"].ToString();
                int id = (int)row["id"];
                typeId.Add(type, id);
            }

            comboBox1.DataSource = new BindingSource(typeId, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
        }
        public EditPersonTypeForm(int pid)
        {
            InitializeComponent();
            Configure(pid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tid = typeId[comboBox1.Text];
            DateTime expiration = dateTimePicker1.Value;
            string value = textBox1.Text;

            // edit
            if (Id > 0)
            {
                Program.PeopleTypesAdapter.UpdateTypeForPerson(tid, value, expiration.ToString(), Id);
            }
            else
            {
                Program.PeopleTypesAdapter.Insert(Pid, tid, value, expiration);
            }
            
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

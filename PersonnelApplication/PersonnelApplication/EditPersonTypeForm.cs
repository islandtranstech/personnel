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
        Dictionary<string, int> typeId;

        public EditPersonTypeForm(int pid)
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int tid = typeId[comboBox1.Text];
            DateTime expiration = dateTimePicker1.Value;
            string value = textBox1.Text;
            Program.PeopleTypesAdapter.Insert(Pid, tid, value, expiration);
            this.Hide();
        }
    }
}

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
    public partial class PersonnelEdit : Form
    {
        PersonnelDataSet.PeopleTypesDataTable DataTable;
        int Pid;
        public PersonnelEdit(int pid)
        {
            pid = 2;
            PersonnelDataSet.PeopleDataTable person = Program.PeopleAdapter.GetPersonById(pid);
            InitializeComponent();
            this.Size = new Size(600, 600);
            label1.Text = person.Rows[0]["fname"].ToString();
            label2.Text = person.Rows[0]["lname"].ToString();
            label4.Text = person.Rows[0]["dob"].ToString();
            Pid = pid;
            LoadData();
            
            this.Size = new Size(600, 600);
        }

        private void LoadData()
        {
            DataTable = Program.PeopleTypesAdapter.GetDataBy1(Pid);
            dataGridView1.DataSource = DataTable;
            dataGridView1.Invalidate();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // edit
            EditPersonTypeForm eptf = new EditPersonTypeForm(Pid);
            eptf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

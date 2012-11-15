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
            PersonnelDataSet.PeopleDataTable person = Program.PeopleAdapter.GetPersonById(pid);
            InitializeComponent();
            this.Size = new Size(600, 600);
            label1.Text = person.Rows[0]["fname"].ToString();
            label2.Text = person.Rows[0]["lname"].ToString();
            DateTime dob = (DateTime) person.Rows[0]["dob"];
            label4.Text = dob.ToString("d");
            Pid = pid;
            LoadData();
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].HeaderText = "Value";
            this.dataGridView1.Columns[4].HeaderText = "Expiration Date";
            this.dataGridView1.Columns[5].HeaderText = "Permit Type";
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void EditSelected(int rowIndex)
        {
            int id = (int)dataGridView1.Rows[rowIndex].Cells["id"].Value;
            int pid = (int)dataGridView1.Rows[rowIndex].Cells["pid"].Value;
            int tid = (int)dataGridView1.Rows[rowIndex].Cells["tid"].Value;
            string value = (string)dataGridView1.Rows[rowIndex].Cells["value"].Value;
            string name = (string)dataGridView1.Rows[rowIndex].Cells["name"].Value;
            DateTime expiration = (DateTime)dataGridView1.Rows[rowIndex].Cells["expiration"].Value;
            EditPersonTypeForm eptf = new EditPersonTypeForm(id, pid, tid, value, expiration, name);
            eptf.Show();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count < 1)
            {
                MessageBox.Show("Error: No values selected.");
                return;
            }
            EditSelected(dataGridView1.SelectedCells[0].RowIndex);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Error: You must have exactly one row selected.");
                return;
            }

            if (!(MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                return;
            }
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            try
            {
                int id = (int)dataGridView1.Rows[rowIndex].Cells["id"].Value;
                Program.PeopleTypesAdapter.DeleteQuery(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Unable to delete selected record, please check your selection.");
            }

       }
    }
}

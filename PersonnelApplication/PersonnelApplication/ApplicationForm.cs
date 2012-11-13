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
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
            tabControl1.TabPages[0].Text = "Explore";
            tabControl1.TabPages[1].Text = "Enter";
            tabControl1.TabPages[2].Text = "Report";
            //dataGridView1.DataSource = Program.GetDataManager().GetAdapter().Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditPersonnelForm editForm = new EditPersonnelForm();
            editForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditTypeForm editForm = new EditTypeForm();
            editForm.Show();
            
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox1.Text.Equals("Types"))
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                string name = (string)dataGridView1.Rows[e.RowIndex].Cells["name"].Value;
                string description = (string)dataGridView1.Rows[e.RowIndex].Cells["description"].Value;
                int renew = (int)dataGridView1.Rows[e.RowIndex].Cells["renewal"].Value;

                EditTypeForm etf = new EditTypeForm(id, name, description, renew);
                etf.Show();

            }
            else
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                string fname = (string)dataGridView1.Rows[e.RowIndex].Cells["fname"].Value;
                string lname = (string)dataGridView1.Rows[e.RowIndex].Cells["lname"].Value;
                DateTime dob = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["dob"].Value;

                EditPersonnelForm epf = new EditPersonnelForm(id, fname, lname, dob);
                epf.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string value = comboBox1.Text;
            string query = textBox1.Text;
            if (query == null || query.Length == 0)
            {
                query = null;
            }
            if (value.Equals("Types"))
            {
                dataGridView1.DataSource = Program.TypesAdapter.GetData();
            }
            else
            {
                dataGridView1.DataSource = Program.PeopleAdapter.GetData();
            }
            dataGridView1.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = (int)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["id"].Value;
            PersonnelEdit pe = new PersonnelEdit(index);
            pe.Show(); 
        }

    }
}

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
            tabControl1.TabPages[1].Text = "Report";
            this.Size = new Size(940, 760);
            button4.Enabled = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadData();
            comboBox1.SelectedIndex = 1;
            // don't want to enable deleting right now
            button7.Visible = false;
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

        private void EditRecord(int rowIndex)
        {
            try
            {
                if (comboBox1.Text.Equals("Types"))
                {
                    int id = (int)dataGridView1.Rows[rowIndex].Cells["id"].Value;
                    string name = (string)dataGridView1.Rows[rowIndex].Cells["name"].Value;
                    string description = (string)dataGridView1.Rows[rowIndex].Cells["description"].Value;
                    int renew = (int)dataGridView1.Rows[rowIndex].Cells["renewal"].Value;

                    EditTypeForm etf = new EditTypeForm(id, name, description, renew);
                    etf.Show();

                }
                else
                {
                    int id = (int)dataGridView1.Rows[rowIndex].Cells["id"].Value;
                    string fname = (string)dataGridView1.Rows[rowIndex].Cells["fname"].Value;
                    string lname = (string)dataGridView1.Rows[rowIndex].Cells["lname"].Value;
                    DateTime dob = (DateTime)dataGridView1.Rows[rowIndex].Cells["dob"].Value;

                    EditPersonnelForm epf = new EditPersonnelForm(id, fname, lname, dob);
                    epf.Show();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: Invalid selection, please try again.");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditRecord(e.RowIndex);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void LoadData()
        {
            string value = comboBox1.Text;
            string query = textBox1.Text;
            if (query == null || query.Length == 0)
            {
                query = null;
            }
            else
            {
                query = "%" + query + "%";
            }
            if (value.Equals("Types"))
            {
                if (query == null)
                {
                    dataGridView1.DataSource = Program.TypesAdapter.GetData();
                }
                else
                {
                    dataGridView1.DataSource = Program.TypesAdapter.GetDataWithQuery(query);
                }
                this.dataGridView1.Columns[1].HeaderText = "Type";
                this.dataGridView1.Columns[2].HeaderText = "Description";
                this.dataGridView1.Columns[3].HeaderText = "Renewal";
            }
            else
            {
                if (query == null)
                {
                    dataGridView1.DataSource = Program.PeopleAdapter.GetData();
                }
                else
                {
                    dataGridView1.DataSource = Program.PeopleAdapter.GetDataWithQuery(query);
                }
                this.dataGridView1.Columns[1].HeaderText = "First Name";
                this.dataGridView1.Columns[2].HeaderText = "Last Name";
                this.dataGridView1.Columns[3].HeaderText = "Date of Birth";
            }
            this.dataGridView1.Columns[0].Visible = false;

            string table = comboBox1.Text;
            if (table.Equals("Types"))
            {
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            int index = (int)dataGridView1.Rows[rowIndex].Cells["id"].Value;
            PersonnelEdit pe = new PersonnelEdit(index);
            pe.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count < 1)
            {
                MessageBox.Show("Error: No values selected.");
                return;
            }
            EditRecord(dataGridView1.SelectedCells[0].RowIndex);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!(MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                return;
            }
            if (dataGridView1.SelectedCells.Count < 1)
            {
                MessageBox.Show("Error: No values selected.");
                return;
            }
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            // remove the type record
            if (comboBox1.Text.Equals("Types"))
            {
                int id = (int)dataGridView1.Rows[rowIndex].Cells["id"].Value;
                Program.TypesAdapter.DeleteQueryById(id);
            }
            else
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = saveFileDialog1.FileName;
                textBox3.Text = file;
            }
        }

    }
}

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
            this.Size = new Size(940, 760);
            button4.Enabled = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.BackgroundColor = Color.White;
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
                this.dataGridView1.Columns[1].HeaderText = "Type";
                this.dataGridView1.Columns[2].HeaderText = "Description";
                this.dataGridView1.Columns[3].HeaderText = "Renewal";
            }
            else
            {
                dataGridView1.DataSource = Program.PeopleAdapter.GetData();
                this.dataGridView1.Columns[1].HeaderText = "First Name";
                this.dataGridView1.Columns[2].HeaderText = "Last Name";
                this.dataGridView1.Columns[3].HeaderText = "Date of Birth";
            }
            this.dataGridView1.Columns[0].Visible = false;
            dataGridView1.Invalidate();




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

        private void button4_Click(object sender, EventArgs e)
        {
            int index = (int)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["id"].Value;
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

    }
}

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
            dataGridView1.DataSource = Program.GetDataManager().GetAdapter().Tables[0];

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
            DataSet ds = Program.GetDataManager().LoadContentData(value, query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Invalidate();
        }

    }
}

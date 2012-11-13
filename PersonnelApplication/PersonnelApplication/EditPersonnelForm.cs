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
    public partial class EditPersonnelForm : Form
    {
        int editId = -1;

        public EditPersonnelForm(int id, string fname, string lname, DateTime dob)
        {
            InitializeComponent();

            editId = id;
            textBox1.Text = fname;
            textBox2.Text = lname;
            dateTimePicker1.Value = dob;

        }
        public EditPersonnelForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            string fname = textBox1.Text;
            string lname = textBox2.Text;
            DateTime dob = dateTimePicker1.Value;

            if (editId > 0)
            {
                Program.PeopleAdapter.UpdateQuery2(fname, lname, dob.ToString(), editId);
            }
            else
            {
                Program.PeopleAdapter.InsertQuery(fname, lname, dob.ToString());             
            }

            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}

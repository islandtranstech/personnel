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

            // TODO: add in validation for person 

            Person p = new Person(fname, lname, dob);
            DataManager dm = Program.GetDataManager();
            dm.SavePerson(p);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}

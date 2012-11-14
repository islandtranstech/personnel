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
    public partial class EditTypeForm : Form
    {
        int editId = -1;

        public EditTypeForm(int id, string name, string description, int renew)
        {
            InitializeComponent();
            textBox1.Text = name;
            textBox2.Text = renew.ToString();
            textBox3.Text = description;
            editId = id;
        }

        public EditTypeForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string type = textBox1.Text;
            string renewString = textBox2.Text;
            int renewal = 0;
            if (renewString != null)
            {
                renewal = Convert.ToInt32(renewString);
            }
            string description = textBox3.Text;

            if (editId > 0)
            {
                Program.TypesAdapter.UpdateQuery2(type, description, renewal, editId); 
            }
            else
            {
                Program.TypesAdapter.Insert(type, description, renewal);
            }
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

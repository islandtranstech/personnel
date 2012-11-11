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
        public EditTypeForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string type = textBox1.Text;
            DateTime expiration = dateTimePicker1.Value;
            int renewal = Convert.ToInt32(textBox2.Text);
            string description = textBox3.Text;

            Type t = new Type(type, expiration, renewal, description);
            Program.GetDataManager().SaveType(t);

        }
    }
}

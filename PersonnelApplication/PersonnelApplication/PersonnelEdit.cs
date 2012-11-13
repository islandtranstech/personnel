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
        public PersonnelEdit(int index)
        {
            InitializeComponent();
            dataGridView1.DataSource = Program.PeopleTypesAdapter.GetDataBy(index);
            dataGridView1.Invalidate();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDschool
{
    public partial class AddTeachersStrings : Form
    {
        public AddTeachersStrings()
        {
            InitializeComponent();
        }

        private void AddTeachearsBut_Click(object sender, EventArgs e)
        {
            BD.SchoolEntities entities = new BD.SchoolEntities();

            BD.Teachers teachers = new BD.Teachers();

            teachers.NameT = NameBox.Text;

            teachers.SurNameT = SurNameBox.Text;

            entities.Teachers.Add(teachers);

            entities.SaveChanges();

            MessageBox.Show("Add Teacher!");
        }
    }
}

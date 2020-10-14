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
    public partial class TeachearsForm : Form
    {
        public TeachearsForm()
        {
            InitializeComponent();
        }

        private void TeachearsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet3.Teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.schoolDataSet3.Teachers);

        }

        private void AddTeachearsBut_Click(object sender, EventArgs e)
        {
            AddTeachersStrings forms = new AddTeachersStrings();

            forms.Show();
        }

        private void DelTeacherBut_Click(object sender, EventArgs e)
        {

        }
    }
}

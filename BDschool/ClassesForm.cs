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
    public partial class ClassesForm : Form
    {
        public ClassesForm()
        {
            InitializeComponent();
        }

        private void ClassesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet1.Classes". При необходимости она может быть перемещена или удалена.
            this.classesTableAdapter.Fill(this.schoolDataSet1.Classes);

        }
    }
}

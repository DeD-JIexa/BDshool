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
    public partial class StudsForms : Form
    {
        public StudsForms()
        {
            InitializeComponent();
        }

        private void StudsForms_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Studs". При необходимости она может быть перемещена или удалена.
            this.studsTableAdapter.Fill(this.schoolDataSet.Studs);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudsAdd_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();

            form.Show();
        }

        private void DelStudBut_Click(object sender, EventArgs e)
        {
            var c = dataGridView1.SelectedCells;

            int indrow;

            if (c.Count == 0)
            {
                return;
            }

            indrow = c[0].RowIndex;

            var s = dataGridView1.Rows[indrow];

            var dels = (int)s.Cells[0].Value;

            BD.SchoolEntities entities = new BD.SchoolEntities();

            BD.Studs dt = entities.Studs.Find(dels);

            entities.Studs.Remove(dt);

            entities.SaveChanges();

            MessageBox.Show("Stud delited!");

        }
    }
}

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
    public partial class LessonsForm : Form
    {
        public LessonsForm()
        {
            InitializeComponent();
        }

        private void LessonsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet2.Lessons". При необходимости она может быть перемещена или удалена.
            this.lessonsTableAdapter.Fill(this.schoolDataSet2.Lessons);

        }

        private void AddLessonsBut_Click(object sender, EventArgs e)
        {
            BD.SchoolEntities entities = new BD.SchoolEntities();

            BD.Lessons lessons = new BD.Lessons();

            lessons.NameL = textBox1.Text;

            MessageBox.Show("Add lesson(does not work)");
        }

        private void DelLessonBut_Click(object sender, EventArgs e)
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

            BD.Lessons dt = entities.Lessons.Find(dels);

            entities.Lessons.Remove(dt);

            entities.SaveChanges();

            MessageBox.Show("Lesson delited!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

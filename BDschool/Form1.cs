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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NameShoolLabel_Click(object sender, EventArgs e)
        {

        }

        #region Buttons

        private void StudsBut_Click(object sender, EventArgs e)
        {
            StudsForms form = new StudsForms();

            form.Show();
        }

        private void ClassesBut_Click(object sender, EventArgs e)
        {
            ClassesForm form = new ClassesForm();

            form.Show();
        }

        private void LessonsBut_Click(object sender, EventArgs e)
        {
            LessonsForm form = new LessonsForm();

            form.Show();
        }

        private void TeachearsBut_Click(object sender, EventArgs e)
        {
            TeachearsForm form = new TeachearsForm();

            form.Show();
        }

        private void JournalBut_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

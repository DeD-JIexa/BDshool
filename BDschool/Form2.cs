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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            BD.SchoolEntities entities = new BD.SchoolEntities();

            comboBox1.DataSource = entities.Classes.ToList();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SurNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddStudsBut_Click(object sender, EventArgs e)
        {
            BD.SchoolEntities entities = new BD.SchoolEntities();

            BD.Studs studs = new BD.Studs();

            studs.NameS = NameBox.Text;

            studs.SurNameS = SurNameBox.Text;

            var cl = comboBox1.SelectedItem as BD.Classes;

            studs.IdCl = cl.IdCl;

            entities.Studs.Add(studs);

            entities.SaveChanges();

            MessageBox.Show("Stud add!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicSystem
{
    public partial class Form2 : Form
    {
        public string username;
        public string user_id;
        public Form2()
        {
            InitializeComponent();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form_student_all = new Form5();
            form_student_all.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form_register = new Form3(this);
            form_register.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome " + username + "(" + user_id + ") !";
        }

        private void courseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 form_course_list = new Form4();
            form_course_list.Show();
        }

        private void intakeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form_exam_schedule = new Form6();
            form_exam_schedule.Show();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form_exam_results = new Form7();
            form_exam_results.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form_search_student = new Form8();
            form_search_student.Show();
        }

        private void courseToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form10 form_search_course = new Form10();
            form_search_course.Show();
        }
    }
}

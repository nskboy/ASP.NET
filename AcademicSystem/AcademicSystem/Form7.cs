using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicSystem
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
                (@"Server=DESKTOP-GFB31L7\SQLEXPRESS;Database=academicWebsite;Uid=nsk;Password=nsk0220;");
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select RID, student_code, course_code, grade, gpa from result", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        protected void dgv_dv()
        {
            SqlConnection conn = new SqlConnection
                (@"Server=DESKTOP-GFB31L7\SQLEXPRESS;Database=academicWebsite;Uid=nsk;Password=nsk0220;");
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select RID, student_code, course_code, grade, gpa from result", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection
               (@"Server=DESKTOP-GFB31L7\SQLEXPRESS;Database=academicWebsite;Uid=nsk;Password=nsk0220;");
            conn.Open();

            SqlCommand cmd = new SqlCommand
                ("update result set student_code=@student_code, course_code=@course_code, grade=@grade, gpa=@gpa where RID = @RID", conn);
            cmd.Parameters.Add("@student_code", SqlDbType.VarChar, 100).Value = textBox2.Text;
            cmd.Parameters.Add("@course_code", SqlDbType.VarChar, 100).Value = textBox3.Text;
            cmd.Parameters.Add("@grade", SqlDbType.VarChar, 100).Value = textBox4.Text;
            cmd.Parameters.Add("@gpa", SqlDbType.VarChar, 100).Value = textBox5.Text;
            cmd.Parameters.Add("@RID", SqlDbType.VarChar, 100).Value = textBox1.Text;

            cmd.ExecuteNonQuery();
            cmd.Dispose();

            dgv_dv();
        }
    }
}

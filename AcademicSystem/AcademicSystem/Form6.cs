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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
                (@"Server=DESKTOP-GFB31L7\SQLEXPRESS;Database=academicWebsite;Uid=nsk;Password=nsk0220;");
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select * from exam", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        protected void dgv_dv()
        {
            SqlConnection conn = new SqlConnection
                (@"Server=DESKTOP-GFB31L7\SQLEXPRESS;Database=academicWebsite;Uid=nsk;Password=nsk0220;");
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select * from exam", conn);
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
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
               (@"Server=DESKTOP-GFB31L7\SQLEXPRESS;Database=academicWebsite;Uid=nsk;Password=nsk0220;");
            conn.Open();

            SqlCommand cmd = new SqlCommand
                ("update exam set course_code=@course_code, course_name=@course_name, exam_date=@exam_date, exam_day=@exam_day, exam_venue=@exam_venue, exam_time=@exam_time, status=@status, academic_session=@academic_session where EID = @EID", conn);
            cmd.Parameters.Add("@course_code", SqlDbType.VarChar, 100).Value = textBox2.Text;
            cmd.Parameters.Add("@course_name", SqlDbType.VarChar, 100).Value = textBox3.Text;
            cmd.Parameters.Add("@exam_date", SqlDbType.VarChar, 100).Value = textBox4.Text;
            cmd.Parameters.Add("@exam_day", SqlDbType.VarChar, 100).Value = textBox5.Text;
            cmd.Parameters.Add("@exam_venue", SqlDbType.VarChar, 100).Value = textBox6.Text;
            cmd.Parameters.Add("@exam_time", SqlDbType.VarChar, 100).Value = textBox7.Text;
            cmd.Parameters.Add("@status", SqlDbType.VarChar, 100).Value = textBox8.Text;
            cmd.Parameters.Add("@academic_session", SqlDbType.VarChar, 100).Value = textBox9.Text;
            cmd.Parameters.Add("@EID", SqlDbType.VarChar, 100).Value = textBox1.Text;

            cmd.ExecuteNonQuery();
            cmd.Dispose();

            dgv_dv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
                (@"Server=DESKTOP-GFB31L7\SQLEXPRESS;Database=academicWebsite;Uid=nsk;Password=nsk0220;");
            conn.Open();

            SqlCommand cmd = new SqlCommand
                ("insert into exam(course_code, course_name, exam_date, exam_day, exam_venue, exam_time, status, academic_session) values(@course_code, @course_name, @exam_date, @exam_day, @exam_venue, @exam_time, @status, @academic_session )", conn);
            cmd.Parameters.Add("@course_code", SqlDbType.VarChar, 100).Value = textBox2.Text;
            cmd.Parameters.Add("@course_name", SqlDbType.VarChar, 100).Value = textBox3.Text;
            cmd.Parameters.Add("@exam_date", SqlDbType.VarChar, 100).Value = textBox4.Text;
            cmd.Parameters.Add("@exam_day", SqlDbType.VarChar, 100).Value = textBox5.Text;
            cmd.Parameters.Add("@exam_venue", SqlDbType.VarChar, 100).Value = textBox6.Text;
            cmd.Parameters.Add("@exam_time", SqlDbType.VarChar, 100).Value = textBox7.Text;
            cmd.Parameters.Add("@status", SqlDbType.VarChar, 100).Value = textBox8.Text;
            cmd.Parameters.Add("@academic_session", SqlDbType.VarChar, 100).Value = textBox9.Text;


            cmd.ExecuteNonQuery();
            cmd.Dispose();

            dgv_dv();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
               (@"Server=DESKTOP-GFB31L7\SQLEXPRESS;Database=academicWebsite;Uid=nsk;Password=nsk0220;");
            conn.Open();

            SqlCommand cmd = new SqlCommand
                ("delete from exam where EID = @EID", conn);
            cmd.Parameters.Add("@EID", SqlDbType.VarChar, 100).Value = textBox1.Text;
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            dgv_dv();
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
    }
}

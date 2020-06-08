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
    public partial class Form11 : Form
    {
        public string coursecode;
        public Form11(string cc)
        {
            coursecode = cc;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
               (@"Server=DESKTOP-GFB31L7\SQLEXPRESS;Database=academicWebsite;Uid=nsk;Password=nsk0220;");
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select * from course where course_code=@course_code", conn);
            adapter.SelectCommand.Parameters.Add("@course_code", SqlDbType.VarChar, 1000).Value = coursecode;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        protected void dgv_dv()
        {
            SqlConnection conn = new SqlConnection
               (@"Server=DESKTOP-GFB31L7\SQLEXPRESS;Database=academicWebsite;Uid=nsk;Password=nsk0220;");
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select * from course where course_code=@course_code", conn);
            adapter.SelectCommand.Parameters.Add("@course_code", SqlDbType.VarChar, 1000).Value = coursecode;
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
                ("update course set course_name=@course_name, course_code=@course_code, lecturer=@lecturer, venue=@venue, timeline=@timeline, description=@description, day=@day, type=@type where CID = @CID", conn);
            cmd.Parameters.Add("@course_name", SqlDbType.VarChar, 100).Value = textBox2.Text;
            cmd.Parameters.Add("@course_code", SqlDbType.VarChar, 100).Value = textBox3.Text;
            cmd.Parameters.Add("@lecturer", SqlDbType.VarChar, 100).Value = textBox4.Text;
            cmd.Parameters.Add("@venue", SqlDbType.VarChar, 100).Value = textBox5.Text;
            cmd.Parameters.Add("@timeline", SqlDbType.VarChar, 100).Value = textBox6.Text;
            cmd.Parameters.Add("@description", SqlDbType.VarChar, 100).Value = textBox7.Text;
            cmd.Parameters.Add("@day", SqlDbType.VarChar, 100).Value = textBox8.Text;
            cmd.Parameters.Add("@type", SqlDbType.VarChar, 100).Value = textBox9.Text;
            cmd.Parameters.Add("@CID", SqlDbType.VarChar, 100).Value = textBox1.Text;

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
                ("delete from course where CID = @CID", conn);
            cmd.Parameters.Add("@CID", SqlDbType.VarChar, 100).Value = textBox1.Text;
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            dgv_dv();
        }
    }
}

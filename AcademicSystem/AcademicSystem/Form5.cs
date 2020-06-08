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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
                (@"Server=DESKTOP-GFB31L7\SQLEXPRESS;Database=academicWebsite;Uid=nsk;Password=nsk0220;");
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select * from student", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        protected void dgv_dv()
        {
            SqlConnection conn = new SqlConnection
                (@"Server=DESKTOP-GFB31L7\SQLEXPRESS;Database=academicWebsite;Uid=nsk;Password=nsk0220;");
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select * from student", conn);
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
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
                (@"Server=DESKTOP-GFB31L7\SQLEXPRESS;Database=academicWebsite;Uid=nsk;Password=nsk0220;");
            conn.Open();

            SqlCommand cmd = new SqlCommand
                ("update student set name=@name, gender=@gender, IC=@IC, student_code=@student_code, D_O_B=@D_O_B, phone_num=@phone_num, email=@email, home_add=@home_add, password=@password where SID = @SID", conn);
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = textBox2.Text;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar, 100).Value = textBox3.Text;
            cmd.Parameters.Add("@IC", SqlDbType.VarChar, 100).Value = textBox4.Text;
            cmd.Parameters.Add("@student_code", SqlDbType.VarChar, 100).Value = textBox5.Text;
            cmd.Parameters.Add("@D_O_B", SqlDbType.VarChar, 100).Value = textBox6.Text;
            cmd.Parameters.Add("@phone_num", SqlDbType.VarChar, 100).Value = textBox7.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = textBox8.Text;
            cmd.Parameters.Add("@home_add", SqlDbType.VarChar, 100).Value = textBox9.Text;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 100).Value = textBox10.Text;
            cmd.Parameters.Add("@SID", SqlDbType.VarChar, 100).Value = textBox1.Text;

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
                ("insert into student(name, gender, IC, student_code, D_O_B, phone_num, email, home_add, password) values(@name, @gender, @IC, @student_code, @D_O_B, @phone_num, @email, @home_add, @password)", conn);
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = textBox2.Text;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar, 100).Value = textBox3.Text;
            cmd.Parameters.Add("@IC", SqlDbType.VarChar, 100).Value = textBox4.Text;
            cmd.Parameters.Add("@student_code", SqlDbType.VarChar, 100).Value = textBox5.Text;
            cmd.Parameters.Add("@D_O_B", SqlDbType.VarChar, 100).Value = textBox6.Text;
            cmd.Parameters.Add("@phone_num", SqlDbType.VarChar, 100).Value = textBox7.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = textBox8.Text;
            cmd.Parameters.Add("@home_add", SqlDbType.VarChar, 100).Value = textBox9.Text;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 100).Value = textBox10.Text;


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
                ("delete from student where SID = @SID", conn);
            cmd.Parameters.Add("@SID", SqlDbType.VarChar, 100).Value = textBox1.Text;
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            dgv_dv();
        }
    }
}

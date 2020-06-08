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

    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
                (@"Server=DESKTOP-GFB31L7\SQLEXPRESS;Database=academicWebsite;Uid=nsk;Password=nsk0220;");
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "select * from student where student_code=@student_code", conn);
            cmd.Parameters.Add("@student_code", SqlDbType.VarChar, 100).Value = textBox1.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Student with Entered Student Code", "AcademicSystem");

            }
            else
            {
                Form9 Search_student_form = new Form9(textBox1.Text);
                Search_student_form.studentcode = textBox1.Text;
                Search_student_form.Show();
            }
        }


    }
}

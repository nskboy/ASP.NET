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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
                (@"Server=DESKTOP-GFB31L7\SQLEXPRESS;Database=academicWebsite;Uid=nsk;Password=nsk0220;");
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(
                "select * from users where username = '" + textBox1.Text
                + "'and password ='" + textBox2.Text + "'", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Username & Password do not match ", "AcademicSystem");

            }
            else
            {
                this.Hide();
                Form2 main_form = new Form2();
                main_form.username = textBox1.Text;
                main_form.user_id = ds.Tables[0].Rows[0][0].ToString();
                main_form.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

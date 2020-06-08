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
using System.Xml;

namespace AcademicSystem
{
    public partial class Form3 : Form
    {
        protected Form2 main_form;
        public Form3(Form2 main_form)
        {
            InitializeComponent();
            this.main_form = main_form;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            String username = main_form.username;
            //label1.Text = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dialog.DefaultExt = "*.xml";
            openFileDialog1.Filter = "XML File|*.xml|Text File|*.txt";
            openFileDialog1.ShowDialog();

            textBox1.Text = openFileDialog1.FileName;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(textBox1.Text);

            XmlNodeList list_users = doc.GetElementsByTagName("user");
            for (int i = 0; i < list_users.Count; ++i)
            {
                SqlConnection conn = new SqlConnection
                (@"Server=DESKTOP-GFB31L7\SQLEXPRESS;Database=academicWebsite;Uid=nsk;Password=nsk0220;");
                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into users(username, password, role) values(@username, @password, @role)", conn);
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 100).Value = list_users.Item(i).ChildNodes.Item(0).InnerText;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 100).Value = list_users.Item(i).ChildNodes.Item(1).InnerText;
                cmd.Parameters.Add("@role", SqlDbType.VarChar, 100).Value = list_users.Item(i).ChildNodes.Item(2).InnerText;


                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }

            MessageBox.Show("Batch Register " + list_users.Count + "Users.", "XMUMCampus");
        }
    }
}

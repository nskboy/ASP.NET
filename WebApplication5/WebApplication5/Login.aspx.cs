using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=DESKTOP-GFB31L7\SQLEXPRESS; Initial Catalog=academicWebsite;User ID=nsk;Password=nsk0220";
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand
                ("Select * from student where" +
                " student_code=@student_code and password=@password", con);
            cmd.Parameters.Add("@student_code", System.Data.SqlDbType.VarChar, 200).Value = TextBox1.Text;
            cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 200).Value = TextBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {

                Label1.Visible = true;
                Session["student_code"] = TextBox1.Text;
                Label1.Text = "LOGGED IN";
                Response.Redirect("Home.aspx");

            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Check your 'USERNAME' or 'PASSWORD'";

            }
        }
    }
}
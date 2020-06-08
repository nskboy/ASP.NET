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
    public partial class CourseRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["student_code"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            string connection = @"Data Source=DESKTOP-GFB31L7\SQLEXPRESS; Initial Catalog=academicWebsite;User ID=nsk;Password=nsk0220";
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, output="";

            sql = "Select * from dbo.enrolled_student";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                output = output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + " " + dataReader.GetValue(2) + " " + dataReader.GetValue(3) + " " + dataReader.GetValue(4);
            }            
        }

        protected void Logout()
        {
            Session["student_code"] = null;
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            string connection = @"Data Source=DESKTOP-GFB31L7\SQLEXPRESS; Initial Catalog=academicWebsite;User ID=nsk;Password=nsk0220";
            foreach(GridViewRow grow in GridView2.Rows)
            {
                var checkboxselect = grow.FindControl("CheckBox1") as CheckBox;
                if (checkboxselect.Checked)
                {
                    SqlConnection con = new SqlConnection(connection);
                    string sql = "Insert into enrolled_student(course_code,course_name,student_code,timeline,venue,day) values(@cc, @cn, @sc, @time, @ven, @day)";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@cc", (grow.FindControl("Label3") as Label).Text);
                    cmd.Parameters.AddWithValue("@cn", (grow.FindControl("Label2") as Label).Text);
                    cmd.Parameters.AddWithValue("@sc", (grow.FindControl("Label3") as Label).Text);
                    cmd.Parameters.AddWithValue("@time", (grow.FindControl("Label6") as Label).Text);
                    cmd.Parameters.AddWithValue("@lect", (grow.FindControl("Label4") as Label).Text);
                    cmd.Parameters.AddWithValue("@ven", (grow.FindControl("Label5") as Label).Text);
                    cmd.Parameters.AddWithValue("@day", (grow.FindControl("Label8") as Label).Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
            }
        }
    }
}
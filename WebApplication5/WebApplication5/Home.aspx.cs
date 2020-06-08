using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Home : System.Web.UI.Page
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
            String sql;
            string day = DateTime.Today.DayOfWeek.ToString();
            string timeline = DateTime.Now.ToString("hh:mm");
            sql = "Select * from dbo.timetable Where day=@day AND timeline>=@timeline";
            command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@day", day);
            command.Parameters.AddWithValue("@timeline", timeline);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                cn.Text = dataReader["course_name"].ToString();
                cc.Text = dataReader["course_code"].ToString();
                time.Text = dataReader["timeline"].ToString();
                lect.Text = dataReader["lecturer"].ToString();
                dy.Text = dataReader["day"].ToString();
                venue.Text = dataReader["venue"].ToString();
            }
            command.Dispose();
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void View_More(object sender, EventArgs e)
        {
            Response.Redirect("ExamResult.aspx");
        }

        protected void Logout()
        {
            Session["student_code"] = null;
        }
    }
}
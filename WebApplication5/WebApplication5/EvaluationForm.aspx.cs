using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class EvaluationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["student_code"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = RadioButtonList1.SelectedValue;

            string connection = @"Data Source=DESKTOP-GFB31L7\SQLEXPRESS; Initial Catalog=academicWebsite;User ID=nsk;Password=nsk0220";
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into dbo.feedback(student_code,course_code,Q1, Q2, Q3, Q4,Q5, Q6) values(@sc,@cc,@Q1,@Q2,@Q3,@Q4,@Q5, @Q6)", con);
            cmd.Parameters.AddWithValue("@sc", Session["student_code"]);
            cmd.Parameters.AddWithValue("@cc", Session["course_code"]);
            cmd.Parameters.AddWithValue("@Q1", RadioButtonList1.SelectedValue);
            cmd.Parameters.AddWithValue("@Q2", RadioButtonList2.SelectedValue);
            cmd.Parameters.AddWithValue("@Q3", RadioButtonList3.SelectedValue);
            cmd.Parameters.AddWithValue("@Q4", RadioButtonList4.SelectedValue);
            cmd.Parameters.AddWithValue("@Q5", RadioButtonList5.SelectedValue);
            cmd.Parameters.AddWithValue("@Q6", TextArea1.Text);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Response.Redirect("EvaluationCourses.aspx");
        }

        protected void Logout()
        {
            Session["student_code"] = null;
        }

    }
}
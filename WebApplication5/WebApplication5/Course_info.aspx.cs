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
    public partial class Course_info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["student_code"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Logout()
        {
            Session["student_code"] = null;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=DESKTOP-GFB31L7\SQLEXPRESS; Initial Catalog=academicWebsite;User ID=nsk;Password=nsk0220";
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand
                ("Select * from course where" +
                " course_name =@course_name ", con);
            cmd.Parameters.Add("@course_name", System.Data.SqlDbType.VarChar, 100).Value = DropDownList1.SelectedValue;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                ListView1.Visible = true;
                Session["course_name"] = DropDownList1.SelectedValue;
            }
            else
            {

            }
        }
    }
}
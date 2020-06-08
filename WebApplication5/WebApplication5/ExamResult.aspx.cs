using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class ExamResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["student_code"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            Panel1.Visible = true;
            Panel2.Visible = true;
            Panel3.Visible = true;
            Panel4.Visible = true;
            Panel5.Visible = true;
            Panel6.Visible = true;
            Panel7.Visible = true;
            Panel8.Visible = true;
            Panel9.Visible = true;
            Panel10.Visible = true;
            if (!IsPostBack)
            {
                latestSem();
            }
        }

        protected void latestSem()
        {
            string connection = @"Data Source=DESKTOP-GFB31L7\SQLEXPRESS; Initial Catalog=academicWebsite;User ID=nsk;Password=nsk0220";
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            sql = "Select course_code, course_name,grade,gpa,credit_hour from dbo.result where student_code='SWE1702029' AND academic_session='2019/04'";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            int i = 0;
            while (dataReader.Read())
            {
                if (i == 0)
                {
                    Label2.Text = dataReader["course_code"].ToString();
                    Label1.Text = dataReader["course_name"].ToString();
                    Label3.Text = dataReader["grade"].ToString();
                    Label4.Text = dataReader["gpa"].ToString();
                    Label5.Text = dataReader["credit_hour"].ToString();
                    i += 1;
                }
                else if (i == 1)
                {
                    Label6.Text = dataReader["course_code"].ToString();
                    Label7.Text = dataReader["course_name"].ToString();
                    Label9.Text = dataReader["grade"].ToString();
                    Label10.Text = dataReader["gpa"].ToString();
                    Label8.Text = dataReader["credit_hour"].ToString();
                    i += 1;
                }
                else if (i == 2)
                {
                    Label12.Text = dataReader["course_code"].ToString();
                    Label11.Text = dataReader["course_name"].ToString();
                    Label14.Text = dataReader["grade"].ToString();
                    Label15.Text = dataReader["gpa"].ToString();
                    Label13.Text = dataReader["credit_hour"].ToString();
                    i += 1;
                }
                else if (i == 3)
                {
                    Label17.Text = dataReader["course_code"].ToString();
                    Label16.Text = dataReader["course_name"].ToString();
                    Label19.Text = dataReader["grade"].ToString();
                    Label20.Text = dataReader["gpa"].ToString();
                    Label18.Text = dataReader["credit_hour"].ToString();
                    i += 1;
                }else if (i == 4)
                {
                    Label22.Text = dataReader["course_code"].ToString();
                    Label21.Text = dataReader["course_name"].ToString();
                    Label24.Text = dataReader["grade"].ToString();
                    Label25.Text = dataReader["gpa"].ToString();
                    Label23.Text = dataReader["credit_hour"].ToString();
                    i += 1;
                }
                
            }
            Panel6.Visible = false;
            Panel7.Visible = false;
            Panel8.Visible = false;
            Panel9.Visible = false;
            Panel10.Visible = false;

            command.Dispose();
            con.Close();
        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "2019/04")
            {
                latestSem();
            }else if(DropDownList1.SelectedValue == "2019/02")
            {
                string connection = @"Data Source=DESKTOP-GFB31L7\SQLEXPRESS; Initial Catalog=academicWebsite;User ID=nsk;Password=nsk0220";
                SqlConnection con = new SqlConnection(connection);
                con.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql, Output = "";

                sql = "Select course_code, course_name,grade,gpa,credit_hour from dbo.result where student_code='SWE1702029' AND academic_session='2019/02'";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                int i = 0;
                while (dataReader.Read())
                {
                    if (i == 0)
                    {
                        Label2.Text = dataReader["course_code"].ToString();
                        Label1.Text = dataReader["course_name"].ToString();
                        Label3.Text = dataReader["grade"].ToString();
                        Label4.Text = dataReader["gpa"].ToString();
                        Label5.Text = dataReader["credit_hour"].ToString();
                        i += 1;
                    }
                    else if (i == 1)
                    {
                        Label6.Text = dataReader["course_code"].ToString();
                        Label7.Text = dataReader["course_name"].ToString();
                        Label9.Text = dataReader["grade"].ToString();
                        Label10.Text = dataReader["gpa"].ToString();
                        Label8.Text = dataReader["credit_hour"].ToString();
                        i += 1;
                    }
                }
                Panel3.Visible = false;
                Panel4.Visible = false;
                Panel5.Visible = false;
                Panel6.Visible = false;
                Panel7.Visible = false;
                Panel8.Visible = false;
                Panel9.Visible = false;
                Panel10.Visible = false;

                command.Dispose();
                con.Close();
            }else if (DropDownList1.SelectedValue == "2018/09")
            {
                string connection = @"Data Source=DESKTOP-GFB31L7\SQLEXPRESS; Initial Catalog=academicWebsite;User ID=nsk;Password=nsk0220";
                SqlConnection con = new SqlConnection(connection);
                con.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql;

                sql = "Select course_code, course_name,grade,gpa,credit_hour from dbo.result where student_code='SWE1702029' AND academic_session='2018/09'";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                int i = 0;
                while (dataReader.Read())
                {
                    if (i == 0)
                    {
                        Label2.Text = dataReader["course_code"].ToString();
                        Label1.Text = dataReader["course_name"].ToString();
                        Label3.Text = dataReader["grade"].ToString();
                        Label4.Text = dataReader["gpa"].ToString();
                        Label5.Text = dataReader["credit_hour"].ToString();
                        i += 1;
                    }
                    else if (i == 1)
                    {
                        Label6.Text = dataReader["course_code"].ToString();
                        Label7.Text = dataReader["course_name"].ToString();
                        Label9.Text = dataReader["grade"].ToString();
                        Label10.Text = dataReader["gpa"].ToString();
                        Label8.Text = dataReader["credit_hour"].ToString();
                        i += 1;
                    }
                    else if (i == 2)
                    {
                        Label12.Text = dataReader["course_code"].ToString();
                        Label11.Text = dataReader["course_name"].ToString();
                        Label14.Text = dataReader["grade"].ToString();
                        Label15.Text = dataReader["gpa"].ToString();
                        Label13.Text = dataReader["credit_hour"].ToString();
                        i += 1;
                    }
                    else if (i == 3)
                    {
                        Label17.Text = dataReader["course_code"].ToString();
                        Label16.Text = dataReader["course_name"].ToString();
                        Label19.Text = dataReader["grade"].ToString();
                        Label20.Text = dataReader["gpa"].ToString();
                        Label18.Text = dataReader["credit_hour"].ToString();
                        i += 1;
                    }
                }
                Panel5.Visible = false;
                Panel6.Visible = false;
                Panel7.Visible = false;
                Panel8.Visible = false;
                Panel9.Visible = false;
                Panel10.Visible = false;

                command.Dispose();
                con.Close();
            }else if(DropDownList1.SelectedValue == "2018/04")
            {
                string connection = @"Data Source=DESKTOP-GFB31L7\SQLEXPRESS; Initial Catalog=academicWebsite;User ID=nsk;Password=nsk0220";
                SqlConnection con = new SqlConnection(connection);
                con.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql, Output = "";

                sql = "Select course_code, course_name,grade,gpa,credit_hour from dbo.result where student_code='SWE1702029' AND academic_session='2018/04'";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                int i = 0;
                while (dataReader.Read())
                {
                    if (i == 0)
                    {
                        Label2.Text = dataReader["course_code"].ToString();
                        Label1.Text = dataReader["course_name"].ToString();
                        Label3.Text = dataReader["grade"].ToString();
                        Label4.Text = dataReader["gpa"].ToString();
                        Label5.Text = dataReader["credit_hour"].ToString();
                        i += 1;
                    }
                    else if (i == 1)
                    {
                        Label6.Text = dataReader["course_code"].ToString();
                        Label7.Text = dataReader["course_name"].ToString();
                        Label9.Text = dataReader["grade"].ToString();
                        Label10.Text = dataReader["gpa"].ToString();
                        Label8.Text = dataReader["credit_hour"].ToString();
                        i += 1;
                    }
                    else if (i == 2)
                    {
                        Label12.Text = dataReader["course_code"].ToString();
                        Label11.Text = dataReader["course_name"].ToString();
                        Label14.Text = dataReader["grade"].ToString();
                        Label15.Text = dataReader["gpa"].ToString();
                        Label13.Text = dataReader["credit_hour"].ToString();
                        i += 1;
                    }
                    else if (i == 3)
                    {
                        Label17.Text = dataReader["course_code"].ToString();
                        Label16.Text = dataReader["course_name"].ToString();
                        Label19.Text = dataReader["grade"].ToString();
                        Label20.Text = dataReader["gpa"].ToString();
                        Label18.Text = dataReader["credit_hour"].ToString();
                        i += 1;
                    }
                    else if (i == 4)
                    {
                        Label22.Text = dataReader["course_code"].ToString();
                        Label21.Text = dataReader["course_name"].ToString();
                        Label24.Text = dataReader["grade"].ToString();
                        Label25.Text = dataReader["gpa"].ToString();
                        Label23.Text = dataReader["credit_hour"].ToString();
                        i += 1;
                    }

                }
                Panel6.Visible = false;
                Panel7.Visible = false;
                Panel8.Visible = false;
                Panel9.Visible = false;
                Panel10.Visible = false;

                command.Dispose();
                con.Close();
            }else if (DropDownList1.SelectedValue == "2018/02")
            {
                string connection = @"Data Source=DESKTOP-GFB31L7\SQLEXPRESS; Initial Catalog=academicWebsite;User ID=nsk;Password=nsk0220";
                SqlConnection con = new SqlConnection(connection);
                con.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql, Output = "";

                sql = "Select course_code, course_name,grade,gpa,credit_hour from dbo.result where student_code='SWE1702029' AND academic_session='2018/02'";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                int i = 0;
                while (dataReader.Read())
                {
                    if (i == 0)
                    {
                        Label2.Text = dataReader["course_code"].ToString();
                        Label1.Text = dataReader["course_name"].ToString();
                        Label3.Text = dataReader["grade"].ToString();
                        Label4.Text = dataReader["gpa"].ToString();
                        Label5.Text = dataReader["credit_hour"].ToString();
                        i += 1;
                    }
                    else if (i == 1)
                    {
                        Label6.Text = dataReader["course_code"].ToString();
                        Label7.Text = dataReader["course_name"].ToString();
                        Label9.Text = dataReader["grade"].ToString();
                        Label10.Text = dataReader["gpa"].ToString();
                        Label8.Text = dataReader["credit_hour"].ToString();
                        i += 1;
                    }
                    else if (i == 2)
                    {
                        Label12.Text = dataReader["course_code"].ToString();
                        Label11.Text = dataReader["course_name"].ToString();
                        Label14.Text = dataReader["grade"].ToString();
                        Label15.Text = dataReader["gpa"].ToString();
                        Label13.Text = dataReader["credit_hour"].ToString();
                        i += 1;
                    }
                }
                Panel4.Visible = false;
                Panel5.Visible = false;
                Panel6.Visible = false;
                Panel7.Visible = false;
                Panel8.Visible = false;
                Panel9.Visible = false;
                Panel10.Visible = false;
                
                command.Dispose();
                con.Close();
            }
            
        }

        protected void Logout()
        {
            Session["student_code"] = null;
        }
    }
}
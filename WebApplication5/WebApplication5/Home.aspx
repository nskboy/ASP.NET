<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication5.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .card a{
            color:black;
        }

        #schedule .card-title{
            color:white;
            background-color:darkred;
            padding: 1em 0;
        }

        html, body{
            overflow:hidden;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex flex-column" style="padding-left:20%; padding-right:10%; text-align:center;">
        <div class="d-flex flex-row">
            <div class="card mt-5" style="width:100%; box-shadow: 10px 10px 52px -16px rgba(0,0,0,0.5);">
                <h5 class="card-header text-left pt-4 pl-3 pb-4">Personal Information</h5>
                <asp:DataList ID="DataList1" runat="server" DataKeyField="student_code" DataSourceID="SqlDataSource1">
                    <ItemTemplate>
                        <div style="padding:0.5em 2em 2em 2em;" class="d-flex flex-row justify-content-between">
                            <div class="d-flex flex-column">
                                <b class="mb-2">Name</b>
                                <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />
                            </div>
                            <div class="d-flex flex-column">
                                <b class="mb-2">Gender</b>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("gender") %>' />
                            </div>
                            <div class="d-flex flex-column">
                                <b class="mb-2">IC No.</b>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("IC") %>' />
                            </div>
                            <div class="d-flex flex-column">
                                <b class="mb-2">Student ID</b>
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("student_code") %>' />
                            </div>
                            <div class="d-flex flex-column">
                                <b class="mb-2">D.O.B</b>
                                <asp:Label ID="Label5" runat="server" Text='<%# Eval("D_O_B") %>' />
                            </div>
                            <div class="d-flex flex-column">
                                <b class="mb-2">Phone No.</b>
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("phone_num") %>' />
                            </div>
                            <div class="d-flex flex-column">
                                <b class="mb-2">Email Address</b>
                                <asp:Label ID="Label6" runat="server" Text='<%# Eval("email") %>' />
                            </div>
                            <div class="d-flex flex-column">
                                <b class="mb-2">Home Address</b>
                                <asp:Label ID="Label7" runat="server" Text='<%# Eval("home_add") %>' />
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:DataList>
                <span class="card-footer" style="height:40px;"></span>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:academicWebsiteConnectionString %>" SelectCommand="SELECT * FROM [student] WHERE ([student_code] = @student_code)">
                    <SelectParameters>
                        <asp:SessionParameter DefaultValue="" Name="student_code" SessionField="student_code" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </div>
        </div>

        <div class="d-flex flex-direction-row">
            <div class="card mt-4" style="width:100%; box-shadow: 10px 10px 52px -16px rgba(0,0,0,0.5);">
                <h5 class="card-header text-left pt-4 pl-3 pb-4">Exam Result</h5>
                <div class="card-body d-flex flex-direction-row">
                    <div style="width:33%; text-align:center;">
                        <h6 class="card-text">Grade</h6>
                        <h1 class="card-title" style="color:red;">A+</h1>
                    </div>
                    <div style="width:33%; text-align:center;">
                        <h6 class="card-text">CGPA</h6>
                        <h1 class="card-title" style="color:limegreen">4.0</h1>
                    </div>
                    <div style="width:33%; text-align:center;">
                        <h6 class="card-text">GPA</h6>
                        <h1 class="card-title" style="color:limegreen">4.0</h1>
                    </div>
                 </div>
                <div class="card-footer">
                    <input type="button" name="name" value="View More" class="btn btn-primary" runat="server" onserverclick="View_More" />
                </div>
            </div>
        </div>
        
        <div class="d-flex flex-row">
            <div class="card mt-4" style="width:300px; box-shadow: 10px 10px 52px -16px rgba(0,0,0,0.5); top: 0px; left: 0px;" id="schedule">
                <h5 class="card-title mb-2"><asp:Label ID="dy" runat="server" Text='<%# Eval("day") %>'></asp:Label></h5>
                <div class="card-body">
                      <h6 class="card-subtitle mb-2"><asp:Label ID="cc" runat="server" Text='<%# Eval("course_code") %>'></asp:Label></h6>
                      <h6 class="card-subtitle mb-3 text-muted"><asp:Label ID="cn" runat="server" Text='<%# Eval("course_name") %>'></asp:Label></h6>
                      <p class="card-subtitle"><asp:Label ID="lect" runat="server" Text='<%# Eval("lecturer") %>'></asp:Label></p>
                      <p class="card-text d-flex flex-row justify-content-center align-items-center"><asp:Label ID="time" runat="server" Text='<%# Eval("timeline") %>'></asp:Label>(<asp:Label ID="venue" runat="server" Text='<%# Eval("venue") %>'></asp:Label>)</p>
                </div>
                <div class="d-flex justify-content-center card-footer">
                        <a href="Timetable.aspx" class="card-link">View More</a>
                  </div>
            </div>

            <div class="card mt-4 ml-4" style="width:100%; box-shadow: 10px 10px 52px -16px rgba(0,0,0,0.5);">
                <h5 class="card-header">Upcoming Exams</h5>
                <div class="card-body">
                    <asp:DataList ID="DataList2" runat="server" DataKeyField="EID" DataSourceID="SqlDataSource2">
                        <ItemTemplate>
                            <div style="padding:0.5em 0em 0.5em 0em;" class="d-flex flex-row justify-content-around text-left">
                                <div class="flex-row d-flex" style="width:350px;">
                                    <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("course_name") %>' />
                                    <div class="mr-3">
                                        &nbsp;(<asp:Label Text='<%# Eval("academic_session") %>' runat="server" />)
                                    </div>
                                </div>
                                <div class="d-flex flex-column mr-4">
                                    <asp:Label ID="Label8" runat="server" Text='<%# Eval("course_code") %>' />
                                </div>
                                <div class="d-flex flex-column mr-4">
                                    <asp:Label ID="Label9" runat="server" Text='<%# Eval("exam_date") %>' />
                                </div>
                                <div class="d-flex flex-column mr-4">
                                    <asp:Label ID="Label10" runat="server" Text='<%# Eval("exam_day") %>' />
                                </div>
                                <div class="d-flex flex-column mr-4">
                                    <asp:Label ID="Label11" runat="server" Text='<%# Eval("exam_time") %>' />
                                </div>
                                <div class="d-flex flex-column mr-4">
                                    <asp:Label ID="Label12" runat="server" Text='<%# Eval("exam_venue") %>' />
                                </div>
                                <div class="d-flex flex-column">
                                    <span style="color:green;"><asp:Label ID="Label13" runat="server" Text='<%# Eval("status") %>' /></span>
                                </div>
                            </div>
                        </ItemTemplate>

                    </asp:DataList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:academicWebsiteConnectionString %>" SelectCommand="SELECT * FROM [exam] WHERE ([academic_session] = @academic_session) ORDER BY [exam_date]">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="2019/09" Name="academic_session" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
            </div>

            
        </div>
        
    </div>
    
</asp:Content>

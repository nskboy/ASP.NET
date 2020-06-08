<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EvaluationCourses.aspx.cs" Inherits="WebApplication5.EvaluationCourses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding-left:20%; padding-right:10%; margin-top:5em;">
        <div class="text-center">
            <h4>Student Evaluation</h4>
        </div>
        <br />
        <br />
        <h3>Please select the  course you want to perform evaluation on</h3>
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="course_name" DataValueField="course_name"></asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:academicWebsiteConnectionString %>" SelectCommand="SELECT [course_name] FROM [course]"></asp:SqlDataSource>
    <asp:Button ID="Button1" runat="server" Text="Confirm" OnClick="Button1_Click" />
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Course_info.aspx.cs" Inherits="WebApplication5.Course_info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding-left:20%;" class="mt-3">
        <h1>Course Information</h1>
        <h3>Please select your course</h3>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="course_name" DataValueField="course_name">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:academicWebsiteConnectionString %>" SelectCommand="SELECT [course_name] FROM [course]"></asp:SqlDataSource>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirm" />
        <div class="list">
            <div class="new">
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource2" Visible="False" DataKeyNames="course_code">
        
            <AlternatingItemTemplate>
                <span style="">course_name:
                <asp:Label ID="course_nameLabel" runat="server" Text='<%# Eval("course_name") %>' />
                <br />
                course_code:
                <asp:Label ID="course_codeLabel" runat="server" Text='<%# Eval("course_code") %>' />
                <br />
                lecturer:
                <asp:Label ID="lecturerLabel" runat="server" Text='<%# Eval("lecturer") %>' />
                <br />
                venue:
                <asp:Label ID="venueLabel" runat="server" Text='<%# Eval("venue") %>' />
                <br />
                description:
                <asp:Label ID="descriptionLabel" runat="server" Text='<%# Eval("description") %>' />
                <br />
                timeline:
                <asp:Label ID="timelineLabel" runat="server" Text='<%# Eval("timeline") %>' />
                <br />
                <br />
                </span>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <span style="">course_name:
                <asp:TextBox ID="course_nameTextBox" runat="server" Text='<%# Bind("course_name") %>' />
                <br />
                course_code:
                <asp:Label ID="course_codeLabel1" runat="server" Text='<%# Eval("course_code") %>' />
                <br />
                lecturer:
                <asp:TextBox ID="lecturerTextBox" runat="server" Text='<%# Bind("lecturer") %>' />
                <br />
                venue:
                <asp:TextBox ID="venueTextBox" runat="server" Text='<%# Bind("venue") %>' />
                <br />
                description:
                <asp:TextBox ID="descriptionTextBox" runat="server" Text='<%# Bind("description") %>' />
                <br />
                timeline:
                <asp:TextBox ID="timelineTextBox" runat="server" Text='<%# Bind("timeline") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                <br />
                <br />
                </span>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <span>No data was returned.</span>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <span style="">course_name:
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("course_name") %>' />
                <br />
                course_code:
                <asp:TextBox ID="course_codeTextBox" runat="server" Text='<%# Bind("course_code") %>' />
                <br />
                lecturer:
                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("lecturer") %>' />
                <br />
                venue:
                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("venue") %>' />
                <br />
                description:
                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("description") %>' />
                <br />
                timeline:
                <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("timeline") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <asp:Button ID="Button2" runat="server" CommandName="Cancel" Text="Clear" />
                <br />
                <br />
                </span>
            </InsertItemTemplate>
            <ItemTemplate>
                <span style="">course_name:
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("course_name") %>' />
                <br />
                course_code:
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("course_code") %>' />
                <br />
                lecturer:
                <asp:Label ID="Label3" runat="server" Text='<%# Eval("lecturer") %>' />
                <br />
                venue:
                <asp:Label ID="Label4" runat="server" Text='<%# Eval("venue") %>' />
                <br />
                description:
                <asp:Label ID="Label5" runat="server" Text='<%# Eval("description") %>' />
                <br />
                timeline:
                <asp:Label ID="Label6" runat="server" Text='<%# Eval("timeline") %>' />
                <br />
                <br />
                </span>
            </ItemTemplate>
            <LayoutTemplate>
                <div style="" id="itemPlaceholderContainer" runat="server">
                    <span runat="server" id="itemPlaceholder" />
                </div>
                <div style="">
                </div>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <span style="">course_name:
                <asp:Label ID="Label7" runat="server" Text='<%# Eval("course_name") %>' />
                <br />
                course_code:
                <asp:Label ID="Label8" runat="server" Text='<%# Eval("course_code") %>' />
                <br />
                lecturer:
                <asp:Label ID="Label9" runat="server" Text='<%# Eval("lecturer") %>' />
                <br />
                venue:
                <asp:Label ID="Label10" runat="server" Text='<%# Eval("venue") %>' />
                <br />
                description:
                <asp:Label ID="Label11" runat="server" Text='<%# Eval("description") %>' />
                <br />
                timeline:
                <asp:Label ID="Label12" runat="server" Text='<%# Eval("timeline") %>' />
                <br />
                <br />
                </span>
            </SelectedItemTemplate>
        </asp:ListView>
            </div>
            </div>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:academicWebsiteConnectionString %>" SelectCommand="SELECT [course_name], [course_code], [lecturer], [venue], [description], [timeline] FROM [course] WHERE ([course_name] = @course_name)">
            <SelectParameters>
                <asp:SessionParameter Name="course_name" SessionField="course_name" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    
</asp:Content>

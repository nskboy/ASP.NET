<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Lecture_info.aspx.cs" Inherits="WebApplication5.Lecture_info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding-left:20%;">
        <h1>Information on Lecturer</h1>
        <h6>Please select your lecturer:</h6>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="lecturer_name" DataValueField="lecturer_name">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:academicWebsiteConnectionString %>" SelectCommand="SELECT [lecturer_name] FROM [lecturer]"></asp:SqlDataSource>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirm" />
        <div class="new1">
        <asp:ListView ID="ListView1" runat="server" Visible ="False" DataSourceID="SqlDataSource2">
            <AlternatingItemTemplate>
                <li style="">lecture_code:
                    <asp:Label ID="lecture_codeLabel" runat="server" Text='<%# Eval("lecture_code") %>' />
                    <br />
                    lecturer_name:
                    <asp:Label ID="lecturer_nameLabel" runat="server" Text='<%# Eval("lecturer_name") %>' />
                    <br />
                    year_of_service:
                    <asp:Label ID="year_of_serviceLabel" runat="server" Text='<%# Eval("year_of_service") %>' />
                    <br />
                    qualification:
                    <asp:Label ID="qualificationLabel" runat="server" Text='<%# Eval("qualification") %>' />
                    <br />
                </li>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <li style="">lecture_code:
                    <asp:TextBox ID="lecture_codeTextBox" runat="server" Text='<%# Bind("lecture_code") %>' />
                    <br />
                    lecturer_name:
                    <asp:TextBox ID="lecturer_nameTextBox" runat="server" Text='<%# Bind("lecturer_name") %>' />
                    <br />
                    year_of_service:
                    <asp:TextBox ID="year_of_serviceTextBox" runat="server" Text='<%# Bind("year_of_service") %>' />
                    <br />
                    qualification:
                    <asp:TextBox ID="qualificationTextBox" runat="server" Text='<%# Bind("qualification") %>' />
                    <br />
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                </li>
            </EditItemTemplate>
            <EmptyDataTemplate>
                No data was returned.
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <li style="">lecture_code:
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("lecture_code") %>' />
                    <br />lecturer_name:
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("lecturer_name") %>' />
                    <br />year_of_service:
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("year_of_service") %>' />
                    <br />qualification:
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("qualification") %>' />
                    <br />
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                    <asp:Button ID="Button2" runat="server" CommandName="Cancel" Text="Clear" />
                </li>
            </InsertItemTemplate>
            <ItemSeparatorTemplate>
            <br />
            </ItemSeparatorTemplate>
            <ItemTemplate>
                <li style="">lecture_code:
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("lecture_code") %>' />
                    <br />
                    lecturer_name:
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("lecturer_name") %>' />
                    <br />
                    year_of_service:
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("year_of_service") %>' />
                    <br />
                    qualification:
                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("qualification") %>' />
                    <br />
                </li>
            </ItemTemplate>
            <LayoutTemplate>
                <ul id="itemPlaceholderContainer" runat="server" style="">
                    <li runat="server" id="itemPlaceholder" />
                </ul>
                <div style="">
                </div>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <li style="">lecture_code:
                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("lecture_code") %>' />
                    <br />
                    lecturer_name:
                    <asp:Label ID="Label6" runat="server" Text='<%# Eval("lecturer_name") %>' />
                    <br />
                    year_of_service:
                    <asp:Label ID="Label7" runat="server" Text='<%# Eval("year_of_service") %>' />
                    <br />
                    qualification:
                    <asp:Label ID="Label8" runat="server" Text='<%# Eval("qualification") %>' />
                    <br />
                </li>
            </SelectedItemTemplate>
        </asp:ListView>
            </div>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:academicWebsiteConnectionString %>" SelectCommand="SELECT [lecture_code], [lecturer_name], [year_of_service], [qualification] FROM [lecturer] WHERE ([lecturer_name] = @lecturer_name)">
            <SelectParameters>
                <asp:SessionParameter Name="lecturer_name" SessionField="lecturer_name" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    
</asp:Content>

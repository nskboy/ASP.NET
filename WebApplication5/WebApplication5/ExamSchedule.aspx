<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ExamSchedule.aspx.cs" Inherits="WebApplication5.ExamSchedule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding-left:20%; padding-right:10%; margin-top:5em;">
        <div class="text-center">
            <h4>Academic Session</h4>
            <h1><asp:Label Text="Label" runat="server" ID="lblAS" /></h1>
        </div>
        <br />
        <br />

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:academicWebsiteConnectionString %>" SelectCommand="SELECT * FROM [exam] WHERE ([academic_session] = @academic_session) ORDER BY [exam_date]" OnSelecting="SqlDataSource1_Selecting">
            <SelectParameters>
                <asp:Parameter DefaultValue="2019/09" Name="academic_session" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:DataList ID="DataList1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataSourceID="SqlDataSource1" ForeColor="Black" DataKeyField="EID" RepeatDirection="Horizontal">
            <AlternatingItemStyle BackColor="PaleGoldenrod" Width="500px"  />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" HorizontalAlign="Center"/>
            <ItemStyle Width="500px"/>
            <ItemTemplate>
                <div class="pl-3 pr-3">
                    <div class="card-body">
                        <div class="d-flex flex-row mb-3">
                            <h5 style="color:red; padding-top:0.5em;"><asp:Label Text='<%# Eval("course_name") %>' runat="server" /></h5>
                        </div>
                        <div class="d-flex flex-column">
                            <h5 class="card-subtitle mb-2 text-muted"><asp:Label Text='<%# Eval("course_code") %>' runat="server" /></h5>
                            <p class="card-text">
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("exam_date") %>' />&nbsp;
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("exam_day") %>' />&nbsp;
                                
                            </p>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("exam_time") %>' />
                            <p class="card-text">
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("exam_venue") %>' />
                            </p>
                            <b class="card-text" style="color:green;">
                                <asp:Label ID="Label5" runat="server" Text='<%# Eval("status") %>' />
                            </b>
                        </div>
                    </div>
                </div>                
            </ItemTemplate>
            <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        </asp:DataList>
    
</asp:Content>

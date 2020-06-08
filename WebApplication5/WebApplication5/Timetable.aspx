<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Timetable.aspx.cs" Inherits="WebApplication5.Timetable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        html, body{
            overflow:hidden;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex flex-direction-row mt-3 pt-4" style="padding-left:18%; padding-right:10%; height: 3334px;">
        <div class="d-flex flex-direction-col">
            <div class="d-flex justify-content-center align-items-center mr-2" style="box-shadow: 10px 10px 52px -16px rgba(0,0,0,0.5); width:300px; height:180px; background-color:#6e030c; color:white; border-radius: 20px 20px 0 0;" draggable="auto" >
                Monday
            </div>
            
            <div class="d-flex flex-direction-col text-center mr-2" style="box-shadow: 10px 10px 52px -16px rgba(0,0,0,0.5);" id="monday">
                <asp:DataList ID="DataList1" runat="server" CellPadding="3" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" GridLines="Vertical">
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="White" ForeColor="#6e030c" BorderColor="#6e030c" />
                    <ItemTemplate>
                        <div style="border-bottom: 1px solid #6e030c; padding: 2em 0">
                            <asp:Label ID="course_codeLabel" runat="server" Text='<%# Eval("course_code") %>' />
                            <br />
                            <asp:Label ID="course_nameLabel" runat="server" Text='<%# Eval("course_name") %>' />
                            <br />
                            <asp:Label ID="lecturerLabel" runat="server" Text='<%# Eval("lecturer") %>' />
                            <br />
                            <asp:Label ID="timelineLabel" runat="server" Text='<%# Eval("timeline") %>' />
                            <br />
                            <asp:Label ID="venueLabel" runat="server" Text='<%# Eval("venue") %>' />
                        </div>
                       
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:academicWebsiteConnectionString %>" SelectCommand="SELECT [course_code], [course_name], [lecturer], [venue], [timeline] FROM [timetable] WHERE ([day] = @day) ORDER BY [timeline]">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="Monday" Name="day" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </div>
        </div>
        <div class="d-flex flex-direction-col">
            <div class="d-flex justify-content-center align-items-center mr-2" style="box-shadow: 10px 10px 52px -16px rgba(0,0,0,0.5); width:300px; height:180px; background-color:darkorange; color:white; border-radius: 20px 20px 0 0;" >
                 Tuesday
            </div>
            <div class="d-flex flex-direction-col text-center mr-2" style="box-shadow: 10px 10px 52px -16px rgba(0,0,0,0.5); width:auto;" id="tuesday">
                <asp:DataList ID="DataList2" runat="server" CellPadding="3" DataSourceID="SqlDataSource2" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" GridLines="Vertical">
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="White" ForeColor="#d98200" BorderColor="#d98200" />
                    <ItemTemplate>
                        <div style="border-bottom: 1px solid #d98200; padding: 2em 0">
                            <asp:Label ID="course_codeLabel" runat="server" Text='<%# Eval("course_code") %>' />
                            <br />
                            <asp:Label ID="course_nameLabel" runat="server" Text='<%# Eval("course_name") %>' />
                            <br />
                            <asp:Label ID="lecturerLabel" runat="server" Text='<%# Eval("lecturer") %>' />
                            <br />
                            <asp:Label ID="timelineLabel" runat="server" Text='<%# Eval("timeline") %>' />
                            <br />
                            <asp:Label ID="venueLabel" runat="server" Text='<%# Eval("venue") %>' />
                        </div>
                       
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:academicWebsiteConnectionString %>" SelectCommand="SELECT [course_code], [course_name], [lecturer], [venue], [timeline] FROM [timetable] WHERE ([day] = 'Tuesday') ORDER BY [timeline]">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="Tuesday" Name="day" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </div>
        </div>
        <div class="d-flex flex-direction-col">
            <div class="d-flex justify-content-center align-items-center mr-2" style="box-shadow: 10px 10px 52px -16px rgba(0,0,0,0.5); width:300px; height:180px; background-color:darkslategray; color:white; border-radius: 20px 20px 0 0;" >
                 Wednesday
            </div>
            <div class="d-flex flex-direction-col text-center mr-2" style="box-shadow: 10px 10px 52px -16px rgba(0,0,0,0.5); width:auto;" id="wednesday">
                <asp:DataList ID="DataList3" runat="server" CellPadding="3" DataSourceID="SqlDataSource3" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" GridLines="Vertical">
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="White" ForeColor="#2f4f4f" BorderColor="#2f4f4f" />
                    <ItemTemplate>
                        <div style="border-bottom: 1px solid #2f4f4f; padding: 2em 0">
                            <asp:Label ID="course_codeLabel" runat="server" Text='<%# Eval("course_code") %>' />
                            <br />
                            <asp:Label ID="course_nameLabel" runat="server" Text='<%# Eval("course_name") %>' />
                            <br />
                            <asp:Label ID="lecturerLabel" runat="server" Text='<%# Eval("lecturer") %>' />
                            <br />
                            <asp:Label ID="timelineLabel" runat="server" Text='<%# Eval("timeline") %>' />
                            <br />
                            <asp:Label ID="venueLabel" runat="server" Text='<%# Eval("venue") %>' />
                        </div>
                       
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:academicWebsiteConnectionString %>" SelectCommand="SELECT [course_code], [course_name], [lecturer], [venue], [timeline] FROM [timetable] WHERE ([day] = 'Wednesday') ORDER BY [timeline]">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="Wednesday" Name="day" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </div>
        </div>
        <div class="d-flex flex-direction-col">
            <div class="d-flex justify-content-center align-items-center mr-2" style="box-shadow: 10px 10px 52px -16px rgba(0,0,0,0.5); width:300px; height:180px; background-color:darkslateblue; color:white; border-radius: 20px 20px 0 0;" >
                 Thursday
            </div>
            <div class="d-flex flex-direction-col text-center mr-2" style="box-shadow: 10px 10px 52px -16px rgba(0,0,0,0.5); width:auto;" id="thursday">
                <asp:DataList ID="DataList4" runat="server" CellPadding="3" DataSourceID="SqlDataSource4" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" GridLines="Vertical">
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="White" ForeColor="#483d8b" BorderColor="#483d8b" />
                    <ItemTemplate>
                        <div style="border-bottom: 1px solid #483d8b; padding: 2em 0">
                            <asp:Label ID="course_codeLabel" runat="server" Text='<%# Eval("course_code") %>' />
                            <br />
                            <asp:Label ID="course_nameLabel" runat="server" Text='<%# Eval("course_name") %>' />
                            <br />
                            <asp:Label ID="lecturerLabel" runat="server" Text='<%# Eval("lecturer") %>' />
                            <br />
                            <asp:Label ID="timelineLabel" runat="server" Text='<%# Eval("timeline") %>' />
                            <br />
                            <asp:Label ID="venueLabel" runat="server" Text='<%# Eval("venue") %>' />
                        </div>
                       
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:academicWebsiteConnectionString %>" SelectCommand="SELECT [course_code], [course_name], [lecturer], [venue], [timeline] FROM [timetable] WHERE ([day] = 'Thursday') ORDER BY [timeline]">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="Thursday" Name="day" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </div>
        </div>
        <div class="d-flex flex-direction-col">
            <div class="d-flex justify-content-center align-items-center mr-2" style="box-shadow: 10px 10px 52px -16px rgba(0,0,0,0.5); width:300px; height:180px; background-color:blueviolet; color:white; border-radius: 20px 20px 0 0;" >
                 Friday
            </div>
            <div class="d-flex flex-direction-col text-center mr-2" style="box-shadow: 10px 10px 52px -16px rgba(0,0,0,0.5); width:auto;" id="friday">
                <asp:DataList ID="DataList5" runat="server" CellPadding="3" DataSourceID="SqlDataSource5" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" GridLines="Vertical">
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="White" ForeColor="#8a2be2" BorderColor="#8a2be2" />
                    <ItemTemplate>
                        <div style="border-bottom: 1px solid #8a2be2; padding: 2em 0">
                            <asp:Label ID="course_codeLabel" runat="server" Text='<%# Eval("course_code") %>' />
                            <br />
                            <asp:Label ID="course_nameLabel" runat="server" Text='<%# Eval("course_name") %>' />
                            <br />
                            <asp:Label ID="lecturerLabel" runat="server" Text='<%# Eval("lecturer") %>' />
                            <br />
                            <asp:Label ID="timelineLabel" runat="server" Text='<%# Eval("timeline") %>' />
                            <br />
                            <asp:Label ID="venueLabel" runat="server" Text='<%# Eval("venue") %>' />
                        </div>
                       
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:academicWebsiteConnectionString %>" SelectCommand="SELECT [course_code], [course_name], [lecturer], [venue], [timeline] FROM [timetable] WHERE ([day] = 'Friday') ORDER BY [timeline]">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="Friday" Name="day" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </div>
        </div>
    </div>
</asp:Content>
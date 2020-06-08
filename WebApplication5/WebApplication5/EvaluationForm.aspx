<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EvaluationForm.aspx.cs" Inherits="WebApplication5.EvaluationForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mt-2" style="padding-left:20%;">
        <div class="se_form">
            <h1>Student Evaluation form</h1>
            <div class="container">
                <div class="align-left">1. I was clear about what I am supposed to learn. The course was well organised in a way that helped me to achieve the learning objective</div>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="align-left" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged1" AutoPostBack="False" >
                    <asp:ListItem Text=" Strongly agree" Value="5"></asp:ListItem>
                    <asp:ListItem Text=" Agree" Value="4"></asp:ListItem>
                    <asp:ListItem Text=" Neutral" Value="3"></asp:ListItem>
                    <asp:ListItem Text=" Disagree" Value="2"></asp:ListItem>
                    <asp:ListItem Text=" Strongly disagree" Value="1"></asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <div class="align-left">2. The number/ length of assignments was reasonable with appropriate level of difficulties throughout the semester.</div>
                   <asp:RadioButtonList ID="RadioButtonList2" runat="server" CssClass="align-left" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged1" AutoPostBack="False">
                    <asp:ListItem Text=" Strongly agree" Value="5"></asp:ListItem>
                    <asp:ListItem Text=" Agree" Value="4"></asp:ListItem>
                    <asp:ListItem Text=" Neutral" Value="3"></asp:ListItem>
                    <asp:ListItem Text=" Disagree" Value="2"></asp:ListItem>
                    <asp:ListItem Text=" Strongly disagree" Value="1"></asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <div class="align-left">3. The assessment methods were appropriate to make me clear about what I have learned.</div>
                <asp:RadioButtonList ID="RadioButtonList3" runat="server" CssClass="align-left" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged1" AutoPostBack="False">
                    <asp:ListItem Text=" Strongly agree" Value="5"></asp:ListItem>
                    <asp:ListItem Text=" Agree" Value="4"></asp:ListItem>
                    <asp:ListItem Text=" Neutral" Value="3"></asp:ListItem>
                    <asp:ListItem Text=" Disagree" Value="2"></asp:ListItem>
                    <asp:ListItem Text=" Strongly disagree" Value="1"></asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <div class="align-left">4. The instructional and learning materials (PPT, Lecture Notes, supplementary reading materials, multimedia components etc.) in this course supported my studies.</div>
                <asp:RadioButtonList ID="RadioButtonList4" runat="server" CssClass="align-left" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged1" AutoPostBack="False">
                    <asp:ListItem Text=" Strongly agree" Value="5"></asp:ListItem>
                    <asp:ListItem Text=" Agree" Value="4"></asp:ListItem>
                    <asp:ListItem Text=" Neutral" Value="3"></asp:ListItem>
                    <asp:ListItem Text=" Disagree" Value="2"></asp:ListItem>
                    <asp:ListItem Text=" Strongly disagree" Value="1"></asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <div class="align-left">5. I was able to cope with the course workload.</div>
                <asp:RadioButtonList ID="RadioButtonList5" runat="server" CssClass="align-left" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged1" AutoPostBack="False">
                   <asp:ListItem Text=" Strongly agree" Value="5"></asp:ListItem>
                    <asp:ListItem Text=" Agree" Value="4"></asp:ListItem>
                    <asp:ListItem Text=" Neutral" Value="3"></asp:ListItem>
                    <asp:ListItem Text=" Disagree" Value="2"></asp:ListItem>
                    <asp:ListItem Text=" Strongly disagree" Value="1"></asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <div class="align-left">
                    6. What about the course / the teaching could be improved.<br />
    &nbsp;<asp:TextBox runat="server" ID="TextArea1" TextMode="Multiline" Columns="20" Name="S1" Rows="2" Width="70%" class="t1"></asp:TextBox><br />
                
                </div>
                <br />
                <br />
                <div class="btn_container">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" CssClass="align-right" /></div>
            </div>
        </div>
    </div>
</asp:Content>

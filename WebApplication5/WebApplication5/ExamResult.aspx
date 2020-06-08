<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ExamResult.aspx.cs" Inherits="WebApplication5.ExamResult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding-left:20%; padding-right:10%;">
        <div class="card mt-5" style="box-shadow: 10px 10px 52px -16px rgba(0,0,0,0.5); top: 0px; left: 0px; padding:2em;">
            <div class="card-body d-flex flex-direction-row">
                <div style="width:33%; text-align:center; border-right:solid 1px grey;">
                    <h5 class="card-text">Grade</h5>
                    <h1 class="card-title" style="color:red;">A+</h1>
                </div>
                <div style="width:33%; text-align:center; border-right:solid 1px grey;">
                    <h5 class="card-text">CGPA</h5>
                    <h1 class="card-title" style="color:limegreen">4.0</h1>
                </div>
                <div style="width:33%; text-align:center;">
                    <h5 class="card-text">GPA</h5>
                    <h1 class="card-title" style="color:limegreen">4.0</h1>
                </div>
             </div>
        </div>

        <div class="card mt-5 mb-5" style="box-shadow: 10px 10px 52px -16px rgba(0,0,0,0.5);">
            <div class="card-body">
                <div class="text-center pb-3 mb-3" style="border-bottom: 1px solid grey;">
                    <h3 class="card-title">Acadamic Session</h3>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1">
                        <asp:ListItem>2019/04</asp:ListItem>
                        <asp:ListItem>2019/02</asp:ListItem>
                        <asp:ListItem>2018/09</asp:ListItem>
                        <asp:ListItem>2018/04</asp:ListItem>
                        <asp:ListItem>2018/02</asp:ListItem>
                        <asp:ListItem>2017/09</asp:ListItem>
                        <asp:ListItem>2017/04</asp:ListItem>
                        <asp:ListItem>2017/02</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <asp:Panel ID="Panel1" runat="server" Visible="true">
                    <div class="d-flex flex-row mb-3" style="border-bottom:1px solid grey;">
                        <div class="d-flex flex-direction-col" style="width:70%;">
                            <h5 class="card-text"><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h5>
                        
                            <div class="card-text d-flex flex-direction-row mt-3">
                                <p class="mr-5"><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></p>
                                <p><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>&nbsp;credits</p>
                            </div>
                        </div>
                        <div style="width:30%;" class="text-center">
                            <h3 style="color:red;"><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></h3>
                            <h3 style="color:limegreen;"><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></h3>
                        </div>
                    </div>
                </asp:Panel>
                
                <asp:Panel ID="Panel2" runat="server">
                    <div class="d-flex flex-row mb-3" style="border-bottom:1px solid grey;">
                        <div class="d-flex flex-direction-col" style="width:70%;">
                            <h5 class="card-text"><asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></h5>
                        
                            <div class="card-text d-flex flex-direction-row mt-3">
                                <p class="mr-5"><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></p>
                                <p><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>&nbsp;credits</p>
                            </div>
                        </div>
                        <div style="width:30%;" class="text-center">
                            <h3 style="color:red;"><asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                            </h3>
                            <h3 style="color:limegreen;"><asp:Label ID="Label10" runat="server" Text="Label"></asp:Label></h3>
                        </div>
                    </div>
                </asp:Panel>

                <asp:Panel ID="Panel3" runat="server">
                    <div class="d-flex flex-row mb-3" style=" border-bottom:1px solid grey;">
                        <div class="d-flex flex-direction-col" style="width:70%;">
                            <h5 class="card-text"><asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></h5>
                        
                            <div class="card-text d-flex flex-direction-row mt-3">
                                <p class="mr-5"><asp:Label ID="Label12" runat="server" Text="Label"></asp:Label></p>
                                <p><asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>&nbsp;credits</p>
                            </div>
                        </div>
                        <div style="width:30%;" class="text-center">
                            <h3 style="color:red;"><asp:Label ID="Label14" runat="server" Text="Label"></asp:Label></h3>
                            <h3 style="color:limegreen;"><asp:Label ID="Label15" runat="server" Text="Label"></asp:Label></h3>
                        </div>
                    </div>
                </asp:Panel>
                
                <asp:Panel ID="Panel4" runat="server">
                    <div class="d-flex flex-row mb-3" style=" border-bottom:1px solid grey;">
                        <div class="d-flex flex-direction-col" style="width:70%;">
                            <h5 class="card-text"><asp:Label ID="Label16" runat="server" Text="Label"></asp:Label></h5>
                        
                            <div class="card-text d-flex flex-direction-row mt-3">
                                <p class="mr-5"><asp:Label ID="Label17" runat="server" Text="Label"></asp:Label></p>
                                <p><asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>&nbsp;credits</p>
                            </div>
                        </div>
                        <div style="width:30%;" class="text-center">
                            <h3 style="color:red;"><asp:Label ID="Label19" runat="server" Text="Label"></asp:Label></h3>
                            <h3 style="color:limegreen;"><asp:Label ID="Label20" runat="server" Text="Label"></asp:Label></h3>
                        </div>
                    </div>
                </asp:Panel>

                <asp:Panel ID="Panel5" runat="server">
                    <div class="d-flex flex-row mb-3" style=" border-bottom:1px solid grey;">
                        <div class="d-flex flex-direction-col" style="width:70%;">
                            <h5 class="card-text"><asp:Label ID="Label21" runat="server" Text="Label"></asp:Label></h5>
                        
                            <div class="card-text d-flex flex-direction-row mt-3">
                                <p class="mr-5"><asp:Label ID="Label22" runat="server" Text="Label"></asp:Label></p>
                                <p><asp:Label ID="Label23" runat="server" Text="Label"></asp:Label>&nbsp;credits</p>
                            </div>
                        </div>
                        <div style="width:30%;" class="text-center">
                            <h3 style="color:red;"><asp:Label ID="Label24" runat="server" Text="Label"></asp:Label></h3>
                            <h3 style="color:limegreen;"><asp:Label ID="Label25" runat="server" Text="Label"></asp:Label></h3>
                        </div>
                    </div>
                </asp:Panel>

                <asp:Panel ID="Panel6" runat="server">
                    <div class="d-flex flex-row mb-3" style=" border-bottom:1px solid grey;">
                        <div class="d-flex flex-direction-col" style="width:70%;">
                            <h5 class="card-text"><asp:Label ID="Label26" runat="server" Text="Label"></asp:Label></h5>
                        
                            <div class="card-text d-flex flex-direction-row mt-3">
                                <p class="mr-5"><asp:Label ID="Label27" runat="server" Text="Label"></asp:Label></p>
                                <p><asp:Label ID="Label28" runat="server" Text="Label"></asp:Label>&nbsp;credits</p>
                            </div>
                        </div>
                        <div style="width:30%;" class="text-center">
                            <h3 style="color:red;"><asp:Label ID="Label29" runat="server" Text="Label"></asp:Label></h3>
                            <h3 style="color:limegreen;"><asp:Label ID="Label30" runat="server" Text="Label"></asp:Label></h3>
                        </div>
                    </div>
                </asp:Panel>

                <asp:Panel ID="Panel7" runat="server">
                    <div class="d-flex flex-row mb-3" style=" border-bottom:1px solid grey;">
                        <div class="d-flex flex-direction-col" style="width:70%;">
                            <h5 class="card-text"><asp:Label ID="Label31" runat="server" Text="Label"></asp:Label></h5>
                        
                            <div class="card-text d-flex flex-direction-row mt-3">
                                <p class="mr-5"><asp:Label ID="Label32" runat="server" Text="Label"></asp:Label></p>
                                <p><asp:Label ID="Label33" runat="server" Text="Label"></asp:Label>&nbsp;credits</p>
                            </div>
                        </div>
                        <div style="width:30%;" class="text-center">
                            <h3 style="color:red;"><asp:Label ID="Label34" runat="server" Text="Label"></asp:Label></h3>
                            <h3 style="color:limegreen;"><asp:Label ID="Label35" runat="server" Text="Label"></asp:Label></h3>
                        </div>
                    </div>
                </asp:Panel>

                <asp:Panel ID="Panel8" runat="server">
                    <div class="d-flex flex-row mb-3" style=" border-bottom:1px solid grey;">
                        <div class="d-flex flex-direction-col" style="width:70%;">
                            <h5 class="card-text"><asp:Label ID="Label36" runat="server" Text="Label"></asp:Label></h5>
                        
                            <div class="card-text d-flex flex-direction-row mt-3">
                                <p class="mr-5"><asp:Label ID="Label37" runat="server" Text="Label"></asp:Label></p>
                                <p><asp:Label ID="Label38" runat="server" Text="Label"></asp:Label>&nbsp;credits</p>
                            </div>
                        </div>
                        <div style="width:30%;" class="text-center">
                            <h3 style="color:red;"><asp:Label ID="Label39" runat="server" Text="Label"></asp:Label></h3>
                            <h3 style="color:limegreen;"><asp:Label ID="Label40" runat="server" Text="Label"></asp:Label></h3>
                        </div>
                    </div>
                </asp:Panel>

                <asp:Panel ID="Panel9" runat="server">
                    <div class="d-flex flex-row mb-3" style=" border-bottom:1px solid grey;">
                        <div class="d-flex flex-direction-col" style="width:70%;">
                            <h5 class="card-text"><asp:Label ID="Label41" runat="server" Text="Label"></asp:Label></h5>
                        
                            <div class="card-text d-flex flex-direction-row mt-3">
                                <p class="mr-5"><asp:Label ID="Label42" runat="server" Text="Label"></asp:Label></p>
                                <p><asp:Label ID="Label43" runat="server" Text="Label"></asp:Label>&nbsp;credits</p>
                            </div>
                        </div>
                        <div style="width:30%;" class="text-center">
                            <h3 style="color:red;"><asp:Label ID="Label44" runat="server" Text="Label"></asp:Label></h3>
                            <h3 style="color:limegreen;"><asp:Label ID="Label45" runat="server" Text="Label"></asp:Label></h3>
                        </div>
                    </div>
                </asp:Panel>

                <asp:Panel ID="Panel10" runat="server">
                    <div class="d-flex flex-row mb-3" style=" border-bottom:1px solid grey;">
                        <div class="d-flex flex-direction-col" style="width:70%;">
                            <h5 class="card-text"><asp:Label ID="Label46" runat="server" Text="Label"></asp:Label></h5>
                        
                            <div class="card-text d-flex flex-direction-row mt-3">
                                <p class="mr-5"><asp:Label ID="Label47" runat="server" Text="Label"></asp:Label></p>
                                <p><asp:Label ID="Label48" runat="server" Text="Label"></asp:Label>&nbsp;credits</p>
                            </div>
                        </div>
                        <div style="width:30%;" class="text-center">
                            <h3 style="color:red;"><asp:Label ID="Label49" runat="server" Text="Label"></asp:Label></h3>
                            <h3 style="color:limegreen;"><asp:Label ID="Label50" runat="server" Text="Label"></asp:Label></h3>
                        </div>
                    </div>
                </asp:Panel>
                
            </div>
        </div>
    </div>
</asp:Content>

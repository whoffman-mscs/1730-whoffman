<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="whoffman2h1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-6">
            <h2>DateTime Methods</h2>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="1) DateTime.Now: "></asp:Label>
                <asp:TextBox ID="TextBox1aResult" runat="server" Enabled="False"></asp:TextBox>
                <asp:TextBox ID="TextBox1bResult" runat="server" Enabled="False"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="2) DateTime.Today: "></asp:Label>
                <asp:TextBox ID="TextBox2aResult" runat="server"></asp:TextBox>
                <asp:TextBox ID="TextBox2bResult" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="3) DateTime.Today: "></asp:Label>
                <asp:TextBox ID="TextBox3aResult" runat="server" Width="40px"></asp:TextBox>
                <asp:TextBox ID="TextBox3bResult" runat="server" Width="30px"></asp:TextBox>
                <asp:TextBox ID="TextBox3cResult" runat="server" Width="30px"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="4) DateTime.AddDays(90): "></asp:Label>
                <asp:TextBox ID="TextBox4Result" runat="server" Enabled="False"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="5) DateTime.AddMonths(3): "></asp:Label>
                <asp:TextBox ID="TextBox5Result" runat="server" Enabled="False"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="6) DateTime(y, m, d): "></asp:Label>
                <asp:TextBox ID="TextBox6a" runat="server" Width="40px"></asp:TextBox>
                <asp:TextBox ID="TextBox6b" runat="server" Width="30px"></asp:TextBox>
                <asp:TextBox ID="TextBox6c" runat="server" Width="30px"></asp:TextBox>
                <asp:TextBox ID="TextBox6Result" runat="server" Enabled="False"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="7) DateTime.Parse(): "></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                <asp:TextBox ID="TextBox7Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label8" runat="server" Text="8) DateTime.TryParse(): "></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <asp:TextBox ID="TextBox8Result" runat="server" Enabled="False"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="9) Date A - Date B: "></asp:Label>
                <asp:TextBox ID="TextBox9a" runat="server" Width="80px"></asp:TextBox>
                <asp:TextBox ID="TextBox9b" runat="server" Width="80px"></asp:TextBox>
                <asp:TextBox ID="TextBox9Result" runat="server" Enabled="False"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label10" runat="server" Text="10) Date A &gt; Date B: "></asp:Label>
                <asp:TextBox ID="TextBox10a" runat="server" Width="80px"></asp:TextBox>
                <asp:TextBox ID="TextBox10b" runat="server" Width="80px"></asp:TextBox>
                <asp:TextBox ID="TextBox10Result" runat="server" Enabled="False"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Button ID="DateCalculationButton" runat="server" Text="Date Calculations" OnClick="DateCalculationButton_Click" />
            </div>
            </div>
        <div class="col-md-6">
            <h2>String Methods</h2>
            <div class="form-group">
                <asp:Label ID="Label11" runat="server" Text="11)"></asp:Label>
                <asp:TextBox ID="TextBox11" runat="server">late</asp:TextBox>
                <asp:TextBox ID="TextBox11Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label12" runat="server" Text="12)"></asp:Label>
                <asp:TextBox ID="TextBox12" runat="server">crater</asp:TextBox>
                <asp:TextBox ID="TextBox12Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label13" runat="server" Text="13)"></asp:Label>
                <asp:TextBox ID="TextBox13" runat="server">ABBlue22</asp:TextBox>
                <asp:TextBox ID="TextBox13Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label14" runat="server" Text="14)"></asp:Label>
                <asp:TextBox ID="TextBox14" runat="server">123.45</asp:TextBox>
                <asp:TextBox ID="TextBox14Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label15" runat="server" Text="15)"></asp:Label>
                <asp:TextBox ID="TextBox15" runat="server">(651) 385-6300</asp:TextBox>
                <asp:TextBox ID="TextBox15Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label16" runat="server" Text="16)"></asp:Label>
                <asp:TextBox ID="TextBox16" runat="server">(651) 385-6300</asp:TextBox>
                <asp:TextBox ID="TextBox16Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label17" runat="server" Text="17)"></asp:Label>
                <asp:TextBox ID="TextBox17" runat="server">308 Pioneer Road</asp:TextBox>
                <asp:TextBox ID="TextBox17Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label18" runat="server" Text="18)"></asp:Label>
                <asp:TextBox ID="TextBox18" runat="server">1250 Homer Road, Winona</asp:TextBox>
                <asp:TextBox ID="TextBox18Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label19" runat="server" Text="19)"></asp:Label>
                <asp:TextBox ID="TextBox19" runat="server">111 1st St, Lake City, MN 55041</asp:TextBox>
                <asp:TextBox ID="TextBox19Result" runat="server"></asp:TextBox>
                </div>
            <div class="form-group">
                <asp:Label ID="Label20" runat="server" Text="20)"></asp:Label>
                <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                <asp:Label ID="Label20Result" runat="server" Text="Label"></asp:Label>
                </div>
            <asp:Button ID="StringCalcButton" runat="server" Text="String Calculations" OnClick="StringCalcButton_Click" />
        </div>
    </div>

</asp:Content>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminViewBookings.aspx.cs" Inherits="AdminViewBookings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
                <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Admin View Bookings</title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 326px;
            left: 724px;
            z-index: 1;
            width: 317px;
            height: 149px;
        }
        .auto-style2 {
            position: absolute;
            top: 509px;
            left: 725px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style3 {
            position: absolute;
            top: 271px;
            left: 561px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 275px;
            left: 795px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 274px;
            left: 1047px;
            z-index: 1;
            width: 113px;
        }
        .auto-style6 {
            position: absolute;
            top: 603px;
            left: 605px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 32px;
            left: 1264px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style8 {
            position: absolute;
            top: 6px;
            left: 621px;
            z-index: 1;
        }
        
        .auto-style12 {
                position:relative;
                width: 331px;
                height: 84px;
                left: 11px;
                top: -97px;
        }

                .auto-style14 {
            position: absolute;
            top: 205px;
            left: 46px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style15 {
            position: absolute;
            top: 330px;
            left: 41px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style16 {
            position: absolute;
            top: 460px;
            left: 41px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        </style>
</head>
<body>
    <header>
                <asp:Label ID="Label1" runat="server" CssClass="auto-style8" Font-Bold="True"  Text="Make a Booking"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style12" src="http://localhost:59736/Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstBooking" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Button ID="btnBook" runat="server" CssClass="auto-style2" Text="Book" OnClick="btnBook_Click" Font-Size="Large" />
        <asp:Label ID="lblDate" runat="server" CssClass="auto-style3" Text="Please Select a Date:"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" CssClass="auto-style4">25/05/2021</asp:TextBox>
        <asp:Button ID="btnGo" runat="server" CssClass="auto-style5" OnClick="btnGo_Click" Text="GO" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style6"></asp:Label>
        <asp:Button ID="btnReturn" runat="server" CssClass="auto-style7" OnClick="btnReturn_Click" Text="Return to Account" />
        <asp:Button ID="btnViewCustomer" runat="server" CssClass="auto-style14" Text="View Customers" OnClick="btnViewCustomer_Click" />
        <asp:Button ID="btnViewAdmins" runat="server" CssClass="auto-style15" Text="View Admins" OnClick="btnViewAdmins_Click" />
        <asp:Button ID="btnViewHaircuts" runat="server" CssClass="auto-style16" Text="View Haircuts" OnClick="btnViewHaircuts_Click" />
    </form>
</body>
</html>

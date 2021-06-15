<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FindBooking.aspx.cs" Inherits="AdminViewBookings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>View Bookings</title>
    <style type="text/css">

                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 359px;
            left: 796px;
            z-index: 1;
            width: 285px;
            height: 141px;
        }
        .auto-style3 {
            position: absolute;
            top: 258px;
            left: 740px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 262px;
            left: 888px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 652px;
            left: 690px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 557px;
            left: 752px;
            z-index: 1;
            width: 139px;
        }
        .auto-style8 {
            position: absolute;
            top: 558px;
            left: 1027px;
            z-index: 1;
            width: 139px;
        }
        .auto-style9 {
            position: absolute;
            top: 316px;
            left: 650px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 321px;
            left: 893px;
            z-index: 1;
            right: 458px;
        }
        .auto-style11 {
            position: absolute;
            top: 317px;
            left: 1097px;
            z-index: 1;
            width: 139px;
        }
        .auto-style12 {
            position: absolute;
            top: 45px;
            left: 1262px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style13 {
            position: absolute;
            top: 12px;
            left: 675px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 509px;
            left: 756px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: -98px;
            left: 11px;
            z-index: 1;
            width: 312px;
            height: 94px;
        }
        .auto-style16 {
            position: absolute;
            top: 239px;
            left: 64px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style17 {
            position: absolute;
            top: 382px;
            left: 63px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style18 {
            position: absolute;
            top: 534px;
            left: 63px;
            z-index: 1;
            width:200px;
            height:40px;
        }
    </style>
</head>
<body>
    <header>
                
        <asp:Label ID="lblFindBooking" runat="server" CssClass="auto-style13" Font-Size="XX-Large" Text="Find Booking"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style15" src="Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnReturn" runat="server" CssClass="auto-style12" OnClick="btnReturn_Click" Text="Return to Account" />
        <asp:ListBox ID="lstBooking" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Label ID="lblDate" runat="server" CssClass="auto-style3" Text="Todays Date:"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" CssClass="auto-style4" ReadOnly="True">25/03/2021</asp:TextBox>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style6"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style7" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style8" Text="Delete" OnClick="btnDelete_Click" />
        <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style10"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style11" OnClick="btnApply_Click" Text="Search" />
        <p>
        <asp:Label ID="lblEnterUsername" runat="server" CssClass="auto-style9" Text="Please enter Username:"></asp:Label>
        </p>
        <asp:Label ID="Label5" runat="server" CssClass="auto-style14" Text="Please select your booking from the list above:"></asp:Label>
        <asp:Button ID="btnMakeBooking" runat="server" CssClass="auto-style16" Text="Make a Booking" OnClick="btnMakeBooking_Click" />
        <asp:Button ID="btnEditAccount" runat="server" CssClass="auto-style17" Text="Edit Account" OnClick="btnEditAccount_Click" />
        <asp:Button ID="btnDeleteAccount" runat="server" CssClass="auto-style18" Text="Delete Account" OnClick="btnDeleteAccount_Click" />
    </form>
</body>
</html>

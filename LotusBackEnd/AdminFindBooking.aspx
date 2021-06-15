<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminFindBooking.aspx.cs" Inherits="AdminViewBookings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
                <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Find Bookings</title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 312px;
            left: 628px;
            z-index: 1;
            width: 437px;
            height: 141px;
        }
        .auto-style3 {
            position: absolute;
            top: 184px;
            left: 650px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 182px;
            left: 791px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 550px;
            left: 626px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 467px;
            left: 622px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style8 {
            position: absolute;
            top: 468px;
            left: 887px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style9 {
            position: absolute;
            top: 239px;
            left: 571px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 238px;
            left: 794px;
            z-index: 1;
            right: 557px;
        }
        .auto-style11 {
            position: absolute;
            top: 232px;
            left: 1001px;
            z-index: 1;
            width:150px;
            height:40px;
        }
        .auto-style12 {
            position: absolute;
            top: 44px;
            left: 1238px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 14px;
            left: 657px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 9px;
            left: 15px;
            z-index: 1;
            width: 297px;
            height: 91px;
        }
    </style>
</head>
<body>
    <p>
        <img alt="" class="auto-style14" src="http://localhost:59736/Images/Screenshot%20(38).png" /></p>
    <header>
                <asp:Label ID="Label1" runat="server" CssClass="auto-style13" Text="Find Booking"></asp:Label>
    </header>
    <nav>

    </nav>
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
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style11" OnClick="btnApply_Click" Text="Apply" />
        <p>
        <asp:Label ID="lblEnterUsername" runat="server" CssClass="auto-style9" Text="Please enter Username:"></asp:Label>
        </p>
    </form>
</body>
</html>

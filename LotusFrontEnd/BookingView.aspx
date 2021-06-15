<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookingView.aspx.cs" Inherits="AdminViewBookings" %>

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
            top: 268px;
            left: 653px;
            z-index: 1;
            width: 336px;
            height: 158px;
        }
        .auto-style2 {
            position: absolute;
            top: 510px;
            left: 724px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style3 {
            position: absolute;
            top: 163px;
            left: 655px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 201px;
            left: 654px;
            z-index: 1;
            width: 200px;
            height: 30px;
        }
        .auto-style5 {
            position: absolute;
            top: 199px;
            left: 887px;
            z-index: 1;
            width: 100px;
            height: 40px;
        }
        .auto-style6 {
            position: absolute;
            top: 588px;
            left: 659px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 32px;
            left: 1296px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 10px;
            left: 668px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 448px;
            left: 659px;
            z-index: 1;
        }
            .auto-style12 {
                position:relative;
                width: 380px;
                height: 97px;
                left: 5px;
                top: -103px;
            }

                    .auto-style17 {
            position: absolute;
            top: 273px;
            left: 64px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style18 {
            position: absolute;
            top: 451px;
            left: 63px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        </style>
</head>
<body>
    <header>
        <asp:Label ID="lblBooking" runat="server" CssClass="auto-style8" Font-Size="XX-Large" Text="Booking Page"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style12" src="Images/Screenshot%20(38).png" /></nav>
    <article>

    </article>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstBooking" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Button ID="btnBook" runat="server" CssClass="auto-style2" Text="Book" OnClick="btnBook_Click" />
        <asp:Label ID="lblDate" runat="server" CssClass="auto-style3" Text="Select a Date you would like:" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" CssClass="auto-style4">25/05/2021</asp:TextBox>
        <asp:Button ID="btnGo" runat="server" CssClass="auto-style5" OnClick="btnGo_Click" Text="GO" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style6"></asp:Label>
        <asp:Button ID="btnReturn" runat="server" CssClass="auto-style7" OnClick="btnReturn_Click" Text="Return to Account" />
        
        <asp:Label ID="Label5" runat="server" CssClass="auto-style9" Text="Please select a booking from the list above:"></asp:Label>
        <asp:Button ID="btnEditAccount" runat="server" CssClass="auto-style17" Text="Edit Account" OnClick="btnEditAccount_Click" />
        <asp:Button ID="btnDeleteAccount" runat="server" CssClass="auto-style18" Text="Delete Account" OnClick="btnDeleteAccount_Click" />
    </form>
</body>
</html>

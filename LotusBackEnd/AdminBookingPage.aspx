<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminBookingPage.aspx.cs" Inherits="AdminBookingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
                <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Admin Booking Page</title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 237px;
            left: 695px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 293px;
            left: 693px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 356px;
            left: 718px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 427px;
            left: 685px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 237px;
            left: 917px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 296px;
            left: 917px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 358px;
            left: 917px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 504px;
            left: 628px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style10 {
            position: absolute;
            top: 505px;
            left: 911px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style11 {
            position: absolute;
            top: 430px;
            left: 920px;
            z-index: 1;
            width: 170px;
            height: 19px;
        }
        .auto-style12 {
            position: absolute;
            top: 179px;
            left: 12px;
            z-index: 1;
            width: 275px;
            height: 509px;
        }
        .auto-style13 {
            position: absolute;
            top: 2px;
            left: 605px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 145px;
            left: 678px;
            z-index: 1;
            width: 368px;
        }
        </style>
</head>
<body>
    <header>
                <asp:Label ID="Label1" runat="server" CssClass="auto-style13" Text="Make a Booking"></asp:Label>
    </header>
    <nav>

    </nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDate" runat="server" CssClass="auto-style1" Text="Booking Date:"></asp:Label>
        <asp:Label ID="lblTime" runat="server" CssClass="auto-style2" Text="Booking Time:"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" CssClass="auto-style3" Text="Username:"></asp:Label>
        <asp:Label ID="lblHaircutName" runat="server" CssClass="auto-style4" Text="Haircut Name:"></asp:Label>
        <asp:TextBox ID="txtBookingDate" runat="server" CssClass="auto-style5"></asp:TextBox>
        <asp:TextBox ID="txtBookingTime" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style7"></asp:TextBox>
        <asp:DropDownList ID="ddlHaircutName" runat="server" CssClass="auto-style11">
        </asp:DropDownList>
        <asp:Button ID="btnBook" runat="server" CssClass="auto-style9" Text="Book" OnClick="btnBook_Click" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style10" OnClick="btnCancel_Click" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style12"></asp:Label>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style14" Text="Please enter the relavent information:"></asp:Label>
    </form>
</body>
</html>

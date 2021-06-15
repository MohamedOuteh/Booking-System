<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminEditBooking.aspx.cs" Inherits="AdminEditBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
                <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Admin Edit Booking</title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }

        .auto-style1 {
            position: absolute;
            top: 246px;
            left: 766px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 318px;
            left: 763px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 385px;
            left: 791px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 447px;
            left: 767px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 250px;
            left: 978px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 319px;
            left: 978px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 385px;
            left: 980px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 449px;
            left: 984px;
            z-index: 1;
            width: 170px;
            height: 21px;
        }
        .auto-style10 {
            position: absolute;
            top: 526px;
            left: 975px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style12 {
            position: absolute;
            top: 169px;
            left: 13px;
            z-index: 1;
            width: 278px;
            height: 427px;
        }
        .auto-style13 {
            position: absolute;
            top: 528px;
            left: 719px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style14 {
            position: absolute;
            top: 7px;
            left: 651px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 158px;
            left: 708px;
            z-index: 1;
            width: 505px;
        }
        .auto-style16 {
            position: absolute;
            top: 384px;
            left: 1174px;
            z-index: 1;
        }
        .auto-style17 {
            position: absolute;
            top: -96px;
            left: 16px;
            z-index: 1;
            width: 275px;
            height: 96px;
        }
    </style>
</head>
<body>
    <header>
                <asp:Label ID="Label1" runat="server" CssClass="auto-style14" Text="Edit Booking"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style17" src="http://localhost:59736/Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <asp:Label ID="lblDate" runat="server" CssClass="auto-style1" Text="Booking Date:"></asp:Label>
        <asp:Label ID="lblTime" runat="server" CssClass="auto-style2" Text="Booking Time:"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" CssClass="auto-style3" Text="Username:"></asp:Label>
        <asp:Label ID="lblHaircutName" runat="server" CssClass="auto-style4" Text="Haircut Name:"></asp:Label>
        <asp:TextBox ID="txtBookingDate" runat="server" CssClass="auto-style5"></asp:TextBox>
        <asp:TextBox ID="txtBookingTime" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style7" ReadOnly="True"></asp:TextBox>
        <asp:DropDownList ID="ddlHaircutName" runat="server" CssClass="auto-style11">
        </asp:DropDownList>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style10" OnClick="btnCancel_Click" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style12"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style13" OnClick="btnAdd_Click" Text="Update" />
        <div>
        </div>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style15" Text="Please enter the relavent information to update the booking:"></asp:Label>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style16" Text="**cannot change username**"></asp:Label>
    </form>
</body>
</html>

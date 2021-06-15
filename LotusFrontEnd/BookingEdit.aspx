<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookingEdit.aspx.cs" Inherits="AdminEditBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Edit Booking</title>
    <style type="text/css">
        body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 254px;
            left: 675px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 312px;
            left: 665px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 369px;
            left: 694px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 426px;
            left: 664px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 258px;
            left: 882px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 314px;
            left: 883px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 370px;
            left: 886px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 430px;
            left: 887px;
            z-index: 1;
            width: 170px;
            height: 21px;
        }
        .auto-style10 {
            position: absolute;
            top: 507px;
            left: 928px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style12 {
            position: absolute;
            top: 215px;
            left: 14px;
            z-index: 1;
            width: 272px;
            height: 342px;
        }
        .auto-style13 {
            position: absolute;
            top: 505px;
            left: 628px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style14 {
            position: absolute;
            top: 5px;
            left: 672px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 188px;
            left: 644px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: -94px;
            left: 12px;
            z-index: 1;
            width: 325px;
            height: 84px;
        }
    </style>
</head>
<body>
    <header>
        <asp:Label ID="lblEditBooking" runat="server" CssClass="auto-style14" Font-Size="XX-Large" Text="Edit Booking"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style16" src="Images/Screenshot%20(38).png" /></nav>
    <article>

    </article>
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
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style13" OnClick="btnUpdate_Click" Text="Update" />
        <div>
        </div>
        
        <asp:Label ID="Label5" runat="server" CssClass="auto-style15" Text="Please enter any details that you would like to update:"></asp:Label>
    </form>
</body>
</html>

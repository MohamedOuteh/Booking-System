<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookingPage.aspx.cs" Inherits="AdminBookingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Booking Page</title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 272px;
            left: 760px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 328px;
            left: 756px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 387px;
            left: 782px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 445px;
            left: 751px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 272px;
            left: 965px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 330px;
            left: 968px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 388px;
            left: 972px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 499px;
            left: 697px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style10 {
            position: absolute;
            top: 500px;
            left: 974px;
            z-index: 1;
            width: 200px;
            height: 40px;

        }
        .auto-style11 {
            position: absolute;
            top: 447px;
            left: 974px;
            z-index: 1;
            width: 170px;
            height: 19px;
        }
        .auto-style12 {
            position: absolute;
            top: 183px;
            left: 11px;
            z-index: 1;
            width: 279px;
            height: 371px;
        }
        .auto-style13 {
            position: absolute;
            top: 7px;
            left: 585px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 174px;
            left: 643px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 5px;
            left: 10px;
            z-index: 1;
            width: 290px;
            height: 92px;
        }
        </style>
</head>
<body>
    <p>
        <img alt="" class="auto-style15" src="Images/Screenshot%20(38).png" /></p>
    <header>
        <asp:Label ID="Label5" runat="server" CssClass="auto-style13" Font-Bold="True" Font-Size="XX-Large" Text="Booking Page"></asp:Label>
    </header>

    <nav>

    </nav>
    <article>

    </article>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDate" runat="server" CssClass="auto-style1" Text="Booking Date:"></asp:Label>
        <asp:Label ID="Label6" runat="server" CssClass="auto-style14" Text="Please enter your username and the haircut you would like:"></asp:Label>
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
        
    </form>
</body>
</html>

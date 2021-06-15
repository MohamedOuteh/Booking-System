<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FindAccountDelete.aspx.cs" Inherits="AdminViewCustomers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Find Account</title>
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 306px;
            left: 769px;
            z-index: 1;
            width: 260px;
            height: 196px;
        }
        .auto-style4 {
            position: absolute;
            top: 551px;
            left: 779px;
            z-index: 1;
            width: 236px;
        }
        .auto-style5 {
            position: absolute;
            top: 595px;
            left: 782px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 268px;
            left: 780px;
            z-index: 1;
            width: 236px;
        }
        .auto-style7 {
            position: absolute;
            top: 262px;
            left: 1047px;
            z-index: 1;
            width: 106px;
        }
        .auto-style9 {
            position: absolute;
            top: 220px;
            left: 771px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 511px;
            left: 777px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 29px;
            left: 1290px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 13px;
            left: 757px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: -98px;
            left: 8px;
            z-index: 1;
            width: 331px;
            height: 96px;
        }
    </style>
</head>
<body>
    <header>
        <asp:Label ID="lblDeleteAccount" runat="server" CssClass="auto-style12" Font-Size="XX-Large" Text="Delete Account"></asp:Label>

    </header>
    <nav>

        <img alt="" class="auto-style13" src="Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnReturn" runat="server" CssClass="auto-style11" OnClick="btnReturn_Click" Text="Return to Account" />
        <asp:Label ID="Label1" runat="server" CssClass="auto-style10" Text="Please select your Username:"></asp:Label>
        <asp:ListBox ID="lstCustomer" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style4" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style5"></asp:Label>
        <asp:TextBox ID="txtUsernameFilter" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style7" OnClick="btnApply_Click" Text="Search" />
        <asp:Label ID="lblEnterUsername" runat="server" CssClass="auto-style9" Text="Please Enter your Username:"></asp:Label>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FindAccount.aspx.cs" Inherits="AdminViewCustomers" %>

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
            top: 264px;
            left: 688px;
            z-index: 1;
            width: 260px;
            height: 196px;
        }
        .auto-style3 {
            position: absolute;
            top: 522px;
            left: 708px;
            z-index: 1;
            width: 225px;
        }
        .auto-style5 {
            position: absolute;
            top: 592px;
            left: 621px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 217px;
            left: 683px;
            z-index: 1;
            width: 236px;
        }
        .auto-style7 {
            position: absolute;
            top: 216px;
            left: 950px;
            z-index: 1;
            width: 106px;
        }
        .auto-style9 {
            position: absolute;
            top: 172px;
            left: 680px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 51px;
            left: 1257px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 473px;
            left: 694px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 24px;
            left: 654px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: -94px;
            left: 21px;
            z-index: 1;
            width: 288px;
            height: 82px;
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
            top: 350px;
            left: 62px;
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
                <asp:Label ID="lblEditAccount" runat="server" CssClass="auto-style12" Font-Size="X-Large" Text="Edit Account"></asp:Label>
        
    </header>
    <nav>

        <img alt="" class="auto-style13" src="Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnReturn" runat="server" CssClass="auto-style10" OnClick="btnReturn_Click" Text="Return to Account" />
        <asp:ListBox ID="lstCustomer" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style5"></asp:Label>
        <p>
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style3" Text="Edit" OnClick="btnEdit_Click" />
        </p>
        <asp:TextBox ID="txtUsernameFilter" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style7" OnClick="btnApply_Click" Text="Search" />
        <asp:Label ID="lblEnterUsername" runat="server" CssClass="auto-style9" Text="Please Enter the Username:"></asp:Label>
        <asp:Label ID="lblSelect" runat="server" CssClass="auto-style11" Text="Select your Username to edit:"></asp:Label>
        <asp:Button ID="btnMakeBooking" runat="server" CssClass="auto-style16" Text="Make a Booking" OnClick="btnMakeBooking_Click" />
        <asp:Button ID="btnEditAccount" runat="server" CssClass="auto-style17" Text="Edit Account" OnClick="btnEditAccount_Click" />
        <asp:Button ID="btnDeleteAccount" runat="server" CssClass="auto-style18" Text="Delete Account" OnClick="btnDeleteAccount_Click" />
    </form>
</body>
</html>

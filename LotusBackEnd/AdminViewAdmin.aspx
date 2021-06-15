<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminViewAdmin.aspx.cs" Inherits="AdminViewAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
            <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>View Admins</title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 253px;
            left: 710px;
            z-index: 1;
            width: 305px;
            height: 196px;
        }
        .auto-style2 {
            position: absolute;
            top: 526px;
            left: 545px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style4 {
            position: absolute;
            top: 530px;
            left: 1232px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style5 {
            position: absolute;
            top: 667px;
            left: 558px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 528px;
            left: 883px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style6 {
            position: absolute;
            top: 200px;
            left: 739px;
            z-index: 1;
            width: 236px;
        }
        .auto-style7 {
            position: absolute;
            top: 194px;
            left: 1038px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style8 {
            position: absolute;
            top: 195px;
            left: 1284px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style9 {
            position: absolute;
            top: 194px;
            left: 358px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 36px;
            left: 1262px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style11 {
            position: absolute;
            top: 11px;
            left: 615px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 466px;
            left: 715px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 9px;
            left: 27px;
            z-index: 1;
            width: 280px;
            height: 89px;
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
    <p>
        <img alt="" class="auto-style13" src="http://localhost:59736/Images/Screenshot%20(38).png" /></p>
    <header>
                <asp:Label ID="Label1" runat="server" CssClass="auto-style11" Font-Bold="True" Font-Size="XX-Large" Text="View Admins"></asp:Label>
    </header>
    <nav>

    </nav>
    <form id="form1" runat="server">
        <div>
        <asp:ListBox ID="lstAdmin" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style2" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style4" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style5"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style3" Text="Edit" OnClick="btnEdit_Click" />
        <asp:TextBox ID="txtUsernameFilter" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style7" OnClick="btnApply_Click" Text="Search" />
        <asp:Button ID="btnDisplayAll" runat="server" CssClass="auto-style8" OnClick="btnDisplayAll_Click" Text="Display All Admins" />
        <asp:Label ID="lblEnterUsername" runat="server" CssClass="auto-style9" Text="Please Enter the your Admin Username:"></asp:Label>
        </div>
        <asp:Button ID="btnReturn" runat="server" CssClass="auto-style10" OnClick="btnReturn_Click" Text="Return to Account" />
        <asp:Label ID="Label2" runat="server" CssClass="auto-style12" Text="Please select an admin:"></asp:Label>
        <asp:Button ID="btnViewCustomer" runat="server" CssClass="auto-style14" Text="View Customers" OnClick="btnViewCustomer_Click" />
        <asp:Button ID="btnViewBooking" runat="server" CssClass="auto-style15" Text="View Bookings" OnClick="btnViewBooking_Click" />
        <asp:Button ID="btnViewHaircuts" runat="server" CssClass="auto-style16" Text="View Haircuts" OnClick="btnViewHaircuts_Click" />
    </form>
</body>
</html>

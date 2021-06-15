<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminViewCustomers.aspx.cs" Inherits="AdminViewCustomers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
            <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>View Customers</title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 258px;
            left: 710px;
            z-index: 1;
            width: 310px;
            height: 196px;
        }
        .auto-style2 {
            position: absolute;
            top: 559px;
            left: 500px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style3 {
            position: absolute;
            top: 558px;
            left: 785px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style4 {
            position: absolute;
            top: 560px;
            left: 1055px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style5 {
            position: absolute;
            top: 657px;
            left: 543px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 220px;
            left: 746px;
            z-index: 1;
            width: 236px;
        }
        .auto-style7 {
            position: absolute;
            top: 215px;
            left: 1036px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style8 {
            position: absolute;
            top: 308px;
            left: 1043px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style9 {
            position: absolute;
            top: 219px;
            left: 433px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 38px;
            left: 1265px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style11 {
            position: absolute;
            top: 8px;
            left: 612px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 481px;
            left: 778px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: -100px;
            left: 22px;
            z-index: 1;
            width: 265px;
            height: 93px;
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
    <header>
                <asp:Label ID="Label1" runat="server" CssClass="auto-style11" Font-Bold="True" Font-Size="XX-Large" Text="View Customers"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style13" src="http://localhost:59736/Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style12" Text="Please select a user:"></asp:Label>
        <asp:ListBox ID="lstCustomer" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style2" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style4" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style5"></asp:Label>
        <p>
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style3" Text="Edit" OnClick="btnEdit_Click" />
        </p>
        <asp:TextBox ID="txtUsernameFilter" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style7" OnClick="btnApply_Click" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" CssClass="auto-style8" OnClick="btnDisplayAll_Click" Text="Display All Customers" />
        <asp:Label ID="lblEnterUsername" runat="server" CssClass="auto-style9" Text="Please Enter the Username:"></asp:Label>
        <asp:Button ID="btnReturn" runat="server" CssClass="auto-style10" OnClick="btnReturn_Click" Text="Return to Account" />
        <asp:Button ID="btnViewAdmins" runat="server" CssClass="auto-style14" Text="View Admins" OnClick="btnViewAdmins_Click" />
        <asp:Button ID="btnViewBooking" runat="server" CssClass="auto-style15" Text="View Bookings" OnClick="btnViewBooking_Click" />
        <asp:Button ID="btnViewHaircuts" runat="server" CssClass="auto-style16" Text="View Haircuts" OnClick="btnViewHaircuts_Click" />
    </form>
</body>
</html>

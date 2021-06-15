<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminViewHaircuts.aspx.cs" Inherits="AdminViewHaircuts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Haircuts</title>
                <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 247px;
            left: 747px;
            z-index: 1;
            width: 260px;
            height: 196px;
        }
        .auto-style2 {
            position: absolute;
            top: 573px;
            left: 504px;
            z-index: 1;
            width: 94px;
            right: 815px;
            width:200px;
            height:40px;
        }
        .auto-style5 {
            position: absolute;
            top: 639px;
            left: 596px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 571px;
            left: 780px;
            z-index: 1;
            width: 92px;
            width:200px;
            height:40px;
        }
        .auto-style6 {
            position: absolute;
            top: 205px;
            left: 752px;
            z-index: 1;
            width: 236px;
        }
        .auto-style7 {
            position: absolute;
            top: 201px;
            left: 1021px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style8 {
            position: absolute;
            top: 298px;
            left: 1024px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style9 {
            position: absolute;
            top: 205px;
            left: 485px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 570px;
            left: 1044px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style11 {
            position: absolute;
            top: 38px;
            left: 1278px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style12 {
            position: absolute;
            top: 476px;
            left: 790px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 7px;
            left: 642px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 12px;
            left: 21px;
            z-index: 1;
            width: 274px;
            height: 83px;
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
        .auto-style17 {
            position: absolute;
            top: 13px;
            left: 18px;
            z-index: 1;
            width: 295px;
            height: 82px;
        }
    </style>
</head>
<body>
    <p>
        <img alt="" class="auto-style17" src="http://localhost:59736/Images/Screenshot%20(38).png" /></p>
    <header>
                <asp:Label ID="Label2" runat="server" CssClass="auto-style13" Font-Bold="True" Text="View Haircuts"></asp:Label>
    </header>
    <nav>

    </nav>
    <form id="form1" runat="server">
        <div>
        <asp:ListBox ID="lstHaircuts" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style2" OnClick="btnAdd_Click" Text="Add" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style5"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style3" Text="Edit" OnClick="btnEdit_Click" />
        <asp:TextBox ID="txtHaircutFilter" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style7" OnClick="btnApply_Click" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" CssClass="auto-style8" OnClick="btnDisplayAll_Click" Text="Display All Haircuts" />
        <asp:Label ID="lblEnterHaircut" runat="server" CssClass="auto-style9" Text="Please Enter the Haircut:"></asp:Label>
        </div>
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style10" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Button ID="btnReturn" runat="server" CssClass="auto-style11" OnClick="btnReturn_Click" Text="Return to Account" />
        <asp:Label ID="Label1" runat="server" CssClass="auto-style12" Text="Please select a Haircut"></asp:Label>
        <asp:Button ID="btnViewCustomer" runat="server" CssClass="auto-style14" Text="View Customers" />
        <asp:Button ID="btnViewBooking" runat="server" CssClass="auto-style15" Text="View Bookings" />
        <asp:Button ID="btnViewAdmins" runat="server" CssClass="auto-style16" Text="View Admins" />
    </form>
</body>
</html>

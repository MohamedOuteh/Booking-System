<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminAccountPage.aspx.cs" Inherits="AdminAccountPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
            <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Admin Account Page</title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 319px;
            left: 929px;
            z-index: 1;
            width: 210px;
            height: 40px;
        }
        .auto-style2 {
            position: absolute;
            top: 394px;
            left: 926px;
            z-index: 1;
            width: 210px;
            height: 40px;
        }
        .auto-style3 {
            position: absolute;
            top: 221px;
            left: 924px;
            z-index: 1;
            width: 210px;
            height: 40px;
        }
        .auto-style4 {
            position: absolute;
            top: 222px;
            left: 564px;
            z-index: 1;
            width: 210px;
            height: 40px;
        }
        .auto-style5 {
            position: absolute;
            top: 315px;
            left: 564px;
            z-index: 1;
            width: 210px;
            height: 40px;
        }
        .auto-style6 {
            position: absolute;
            top: 17px;
            left: 617px;
            z-index: 1;
            width: 279px;
            height: 53px;
        }
        .auto-style7 {
            position: absolute;
            top: 397px;
            left: 564px;
            z-index: 1;
            width: 210px;
            height: 40px;
        }
        .auto-style8 {
            position: absolute;
            top: 476px;
            left: 932px;
            z-index: 1;
            width: 210px;
            height: 40px;
        }
        .auto-style9 {
            position: absolute;
            top: 28px;
            left: 1254px;
            z-index: 1;
            width: 210px;
            height: 40px;
        }
        .auto-style10 {
            position: absolute;
            top: 475px;
            left: 569px;
            z-index: 1;
            width: 210px;
            height: 40px;
        }
            .auto-style12 {
                position:relative;
                width: 351px;
                height: 89px;
                left: 10px;
                top: -97px;
            }
        </style>
</head>
<body>
    <header>
                <asp:Label ID="lblAdminAccount" runat="server" CssClass="auto-style6" Text="Admin Account"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style12" src="http://localhost:59736/Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnViewHaricuts" runat="server" CssClass="auto-style1" OnClick="btnViewHaricuts_Click" Text="View Haircuts" />
        <asp:Button ID="btnViewCustomers" runat="server" CssClass="auto-style3" OnClick="btnViewCustomers_Click" Text="View Customers" />
        <asp:Button ID="btnViewAdmins" runat="server" CssClass="auto-style2" OnClick="btnViewAdmins_Click" Text="View Admins" />
        <asp:Button ID="btnAddHaircut" runat="server" CssClass="auto-style4" OnClick="btnAddHaircut_Click" Text="Add Haircut" />
        <asp:Button ID="btnCustomer" runat="server" CssClass="auto-style5" Text="Add Customer" OnClick="btnCustomer_Click" />
        <asp:Button ID="btnMakeBooking" runat="server" CssClass="auto-style7" OnClick="btnMakeBooking_Click" Text="Make A Booking" />
        <asp:Button ID="btnEditDelete" runat="server" CssClass="auto-style8" OnClick="btnEditDelete_Click" Text="Edit/Delete Booking" />
        <asp:Button ID="btnLogout" runat="server" CssClass="auto-style9" Text="Log Out" OnClick="btnLogout_Click" />
        <asp:Button ID="btnChangePassword" runat="server" CssClass="auto-style10" Text="Change Password" OnClick="btnChangePassword_Click" />
    </form>
</body>
</html>

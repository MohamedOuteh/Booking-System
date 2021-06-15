<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AccountPage.aspx.cs" Inherits="AccountPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Account Page</title>
    <style type="text/css">
        body
        {
            background-color:lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 134px;
            left: 737px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 272px;
            left: 544px;
            z-index: 1;
            width: 224px;
            height: 41px;
            width:200px;
            height:40px;
        }
        .auto-style3 {
            position: absolute;
            top: 386px;
            left: 545px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style4 {
            position: absolute;
            top: 275px;
            left: 924px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style5 {
            position: absolute;
            top: 384px;
            left: 922px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style6 {
            position: absolute;
            top: 498px;
            left: 748px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style7 {
            position: absolute;
            top: 5px;
            left: 596px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 36px;
            left: 1271px;
            z-index: 1;
            width:200px;
            height:40px;
        }
            .auto-style12 {
                position:relative;
                width: 380px;
                height: 97px;
                left: 5px;
                top: -100px;
            }
        </style>
</head>
<body>
    <header>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style7" Text="Welcome to Lotus Cutz" Font-Size="XX-Large"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style12" src="Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblAccount" runat="server" CssClass="auto-style1" Text="My Account" Font-Size="X-Large"></asp:Label>
            <asp:Button ID="btnSignOut" runat="server" CssClass="auto-style8" OnClick="btnSignOut_Click" Text="Sign Out" />
        </div>
        <asp:Button ID="btnBookHaircut" runat="server" CssClass="auto-style2" OnClick="btnBookHaircut_Click" Text="Book a Haircut" />
        <asp:Button ID="btnEditDelete" runat="server" CssClass="auto-style3" OnClick="btnEditDelete_Click" Text="Edit/Delete Booking" />
        <asp:Button ID="btnEditAccount" runat="server" CssClass="auto-style4" OnClick="btnEditAccount_Click" Text="Edit Account" />
        <asp:Button ID="btnDeleteAccount" runat="server" CssClass="auto-style5" Text="Delete Account" OnClick="btnDeleteAccount_Click" />
        <asp:Button ID="btnChangePassword" runat="server" CssClass="auto-style6" Text="Change Password" OnClick="btnChangePassword_Click" />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditAccount.aspx.cs" Inherits="EditAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Edit Account</title>
    <style type="text/css">

        body
        {
            background-color:lightblue;
        }
        .auto-style2 {
            position: absolute;
            top: 180px;
            left: 761px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 257px;
            left: 763px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 399px;
            left: 776px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 323px;
            left: 735px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 473px;
            left: 778px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 179px;
            left: 911px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 252px;
            left: 912px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 323px;
            left: 913px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 397px;
            left: 914px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 470px;
            left: 918px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 157px;
            left: 18px;
            z-index: 1;
            width: 258px;
            height: 428px;
        }
        .auto-style15 {
            position: absolute;
            top: 534px;
            left: 727px;
            z-index: 1;
            width: 150px;
            height:40px;
        }
        .auto-style16 {
            position: absolute;
            top: 537px;
            left: 957px;
            z-index: 1;
            width: 150px;
            height:40px;
        }
        .auto-style20 {
            position: absolute;
            top: 7px;
            left: 720px;
            z-index: 1;
        }
        .auto-style21 {
            position: absolute;
            top: 468px;
            left: 1132px;
            z-index: 1;
        }
        .auto-style22 {
            position: absolute;
            top: 129px;
            left: 745px;
            z-index: 1;
        }
        .auto-style23 {
            position: absolute;
            top: -97px;
            left: 10px;
            z-index: 1;
            width: 317px;
            height: 93px;
        }
        </style>
</head>
<body>
    <header>
                <asp:Label ID="lblEdit" runat="server" CssClass="auto-style20" Text="Edit Account Details" Font-Size="XX-Large"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style23" src="Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblFirstName" runat="server" CssClass="auto-style2" Text="First Name:"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" CssClass="auto-style3" Text="Last Name:"></asp:Label>
        <asp:Label ID="lblPhoneNo" runat="server" CssClass="auto-style4" Text="Phone No:"></asp:Label>
        <asp:Label ID="lblEmailAddress" runat="server" CssClass="auto-style5" Text="Email Address:"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" CssClass="auto-style6" Text="Username:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style8"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" CssClass="auto-style9"></asp:TextBox>
        <asp:TextBox ID="txtEmailAddress" runat="server" CssClass="auto-style10"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNo" runat="server" CssClass="auto-style11"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style12" ReadOnly="True"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style14"></asp:Label>
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style15" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style16" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
        <asp:Label ID="lblCantChange" runat="server" CssClass="auto-style21" Text="*Cannot change username*"></asp:Label>
        <asp:Label ID="Label5" runat="server" CssClass="auto-style22" Text="Please update any of the following details:"></asp:Label>
    </form>
</body>
</html>

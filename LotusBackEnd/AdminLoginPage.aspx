<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLoginPage.aspx.cs" Inherits="AdminLoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
                <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Admin Log In</title>
    <style type="text/css">
        body{
            background-color: lightblue;
        }
        .auto-style5 {
            position: absolute;
            top: 263px;
            left: 659px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 324px;
            left: 662px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 263px;
            left: 852px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 322px;
            left: 854px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 379px;
            left: 844px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style15 {
            position: absolute;
            top: 459px;
            left: 571px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 377px;
            left: 549px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style1 {
            position: absolute;
            top: 3px;
            left: 682px;
            z-index: 1;
            font-size: xx-large;
        }
        .auto-style17 {
            position: absolute;
            top: 318px;
            left: 1083px;
            z-index: 1;
            width: 153px;
        }
        .auto-style18 {
            position: absolute;
            top: -103px;
            left: 22px;
            z-index: 1;
            width: 291px;
            height: 95px;
        }
        </style>
</head>
<body>
    <header>
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Text="Admin Log In"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style18" src="http://localhost:59736/Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblUsername" runat="server" CssClass="auto-style5" Text="Username:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" CssClass="auto-style6" Text="Password:"></asp:Label>
            <asp:Button ID="btnLogin" runat="server" CssClass="auto-style16" OnClick="btnLogin_Click" Text="Log In" />
        <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style11"></asp:TextBox>
            <asp:Button ID="btnForgotPassword" runat="server" CssClass="auto-style17" Font-Italic="True" OnClick="btnForgotPassword_Click" Text="(Forgot Password)" />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="auto-style12"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style14" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style15"></asp:Label>
        </div>

    


    </form>
</body>
</html>

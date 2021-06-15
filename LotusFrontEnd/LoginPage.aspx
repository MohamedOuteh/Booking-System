<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Log In</title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 250px;
            left: 930px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 307px;
            left: 927px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 248px;
            left: 731px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 306px;
            left: 740px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 364px;
            left: 644px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style6 {
            position: absolute;
            top: 448px;
            left: 811px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 216px;
            left: 44px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style8 {
            position: absolute;
            top: 365px;
            left: 938px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style9 {
            position: absolute;
            top: 10px;
            left: 708px;
            z-index: 1;
        }
            .auto-style12 {
                position:relative;
                width: 380px;
                height: 97px;
                left: 9px;
                top: -98px;
            }
        .auto-style13 {
            position: absolute;
            top: 373px;
            left: 46px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        </style>
</head>
<body>
    <header>
                <asp:Label ID="Label1" runat="server" CssClass="auto-style9" Font-Size="XX-Large" Text="Log In"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style12" src="Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style1"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="auto-style2"></asp:TextBox>
        <asp:Label ID="lblUsername" runat="server" CssClass="auto-style3" Text="Username:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" CssClass="auto-style4" Text="Password:"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" CssClass="auto-style5" OnClick="btnLogin_Click" Text="Log In" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style6"></asp:Label>
        <asp:Button ID="btnForgotPassword" runat="server" CssClass="auto-style7" Font-Italic="True" Text="(Forgot Password)" OnClick="btnForgotPassword_Click" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style8" OnClick="btnCancel_Click" Text="Cancel" />

        <asp:Button ID="Button1" runat="server" CssClass="auto-style13" OnClick="Button1_Click" Text="Sign Up" />

    </form>
</body>
</html>

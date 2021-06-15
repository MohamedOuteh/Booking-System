<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminHomePage.aspx.cs" Inherits="AdminHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
                <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Admin Home Page</title>
    <style type="text/css">
        body{
            background-color:lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 315px;
            left: 500px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style2 {
            position: absolute;
            top: 314px;
            left: 882px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style3 {
            position: absolute;
            top: 7px;
            left: 637px;
            z-index: 1;
        }
            .auto-style12 {
                position:relative;
                width: 523px;
                height: 127px;
                left: 540px;
                top: 24px;
            }
        </style>
</head>
<body>
    <header>
                <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Font-Bold="True" Text="Admin Home"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style12" src="http://localhost:59736/Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnSignUp" runat="server" CssClass="auto-style1" OnClick="btnSignUp_Click" Text="Sign Up" Font-Size="Large" />
        <asp:Button ID="btnLogin" runat="server" CssClass="auto-style2" OnClick="btnLogin_Click" Text="Log In" Font-Size="Large" />
    </form>
</body>
</html>

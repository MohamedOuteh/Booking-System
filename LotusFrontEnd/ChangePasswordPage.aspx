<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePasswordPage.aspx.cs" Inherits="ChangePasswordPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Change Password</title>
    <style type="text/css">
        body
        {
            background-color:lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 223px;
            left: 683px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 288px;
            left: 649px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 349px;
            left: 626px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 416px;
            left: 647px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 226px;
            left: 885px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 290px;
            left: 884px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 352px;
            left: 888px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 419px;
            left: 891px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 204px;
            left: 12px;
            z-index: 1;
            width: 265px;
            height: 294px;
        }
        .auto-style10 {
            position: absolute;
            top: 473px;
            left: 599px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style11 {
            position: absolute;
            top: 477px;
            left: 885px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style12 {
            position: absolute;
            top: 32px;
            left: 1293px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 12px;
            left: 645px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 143px;
            left: 692px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: -101px;
            left: 5px;
            z-index: 1;
            width: 342px;
            height: 93px;
        }
    </style>
</head>
<body>
    <header>
                <asp:Label ID="lblChangePassword" runat="server" CssClass="auto-style13" Font-Size="X-Large" Text="Change Password"></asp:Label>
           
    </header>
    <nav>

        <img alt="" class="auto-style15" src="Images/Screenshot%20(38).png" /></nav>
    <article>

    </article>
    <form id="form1" runat="server">
        <div>
        </div>
             <asp:Button ID="btnReturn" runat="server" CssClass="auto-style12" OnClick="btnReturn_Click" Text="Return to Account" />
        <asp:Label ID="lblUsername" runat="server" CssClass="auto-style1" Text="Username:"></asp:Label>
        <asp:Label ID="lblNewPassword" runat="server" CssClass="auto-style2" Text="New Password:"></asp:Label>
        <asp:Label ID="lblConfirmPassword" runat="server" CssClass="auto-style3" Text="Confirm Password:"></asp:Label>
        <asp:Label ID="lblSecret" runat="server" CssClass="auto-style4" Text="Secret Password:"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style5"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="auto-style7"></asp:TextBox>
        <asp:TextBox ID="txtSecretPassword" runat="server" CssClass="auto-style8"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style9"></asp:Label>
        <asp:Button ID="btnConfirm" runat="server" CssClass="auto-style10" OnClick="btnConfirm_Click" Text="Confirm" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style11" OnClick="btnCancel_Click" Text="Cancel" />
        <asp:Label ID="Label5" runat="server" CssClass="auto-style14" Text="Please enter the following details:"></asp:Label>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ForgotPassword.aspx.cs" Inherits="ChangePasswordPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Forgot Password</title>
    <style type="text/css">
        body
        {
            background-color:lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 190px;
            left: 667px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 250px;
            left: 620px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 306px;
            left: 596px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 368px;
            left: 606px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 190px;
            left: 841px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 247px;
            left: 843px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 305px;
            left: 845px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 365px;
            left: 845px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 178px;
            left: 24px;
            z-index: 1;
            width: 263px;
            height: 359px;
        }
        .auto-style10 {
            position: absolute;
            top: 430px;
            left: 552px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style11 {
            position: absolute;
            top: 430px;
            left: 840px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style12 {
            position: absolute;
            top: 3px;
            left: 664px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 146px;
            left: 672px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: -99px;
            left: 13px;
            z-index: 1;
            width: 312px;
            height: 93px;
        }
        </style>
</head>
<body>
    <header>
                <asp:Label ID="Label1" runat="server" CssClass="auto-style12" Font-Size="XX-Large" Text="Forgot Password"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style14" src="Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
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

        <asp:Label ID="Label5" runat="server" CssClass="auto-style13" Text="Please enter the following details:"></asp:Label>
    </form>
</body>
</html>

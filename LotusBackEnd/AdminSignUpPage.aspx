<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminSignUpPage.aspx.cs" Inherits="AdminSignUpPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
                <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Admin Sign Up</title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style2 {
            position: absolute;
            top: 198px;
            left: 747px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 255px;
            left: 750px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 309px;
            left: 759px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 366px;
            left: 752px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 416px;
            left: 759px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 202px;
            left: 974px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 257px;
            left: 979px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 311px;
            left: 978px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 365px;
            left: 981px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 418px;
            left: 980px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 571px;
            left: 957px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style15 {
            position: absolute;
            top: 262px;
            left: 12px;
            z-index: 1;
            width: 282px;
            height: 476px;
        }
        .auto-style16 {
            position: absolute;
            top: 570px;
            left: 662px;
            z-index: 1;
            right: 657px;
            width:200px;
            height:40px;
        }
        .auto-style18 {
            position: absolute;
            top: 464px;
            left: 691px;
            z-index: 1;
        }
        .auto-style17 {
            position: absolute;
            top: 466px;
            left: 978px;
            z-index: 1;
        }
        .auto-style21 {
            position: absolute;
            top: 519px;
            left: 705px;
            z-index: 1;
        }
        .auto-style22 {
            position: absolute;
            top: 520px;
            left: 979px;
            z-index: 1;
        }
        .auto-style23 {
            position: absolute;
            top: 6px;
            left: 673px;
            z-index: 1;
        }
        .auto-style24 {
            position: absolute;
            top: 129px;
            left: 9px;
            z-index: 1;
            width: 269px;
        }
        .auto-style25 {
            position: absolute;
            top: 14px;
            left: 21px;
            z-index: 1;
            width: 280px;
            height: 81px;
        }
        </style>
</head>
<body>
    <p>
        <img alt="" class="auto-style25" src="http://localhost:59736/Images/Screenshot%20(38).png" /></p>
    <header>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style23" Font-Bold="True" Font-Size="XX-Large" Text="Admin Sign Up"></asp:Label>
    </header>
    <nav>

    </nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblFirstName" runat="server" CssClass="auto-style2" Text="First Name:"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" CssClass="auto-style3" Text="Last Name:"></asp:Label>
        <asp:Label ID="lblPhoneNo" runat="server" CssClass="auto-style4" Text="Phone No:"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" CssClass="auto-style5" Text="Username:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" CssClass="auto-style6" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style8"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" CssClass="auto-style9"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNo" runat="server" CssClass="auto-style10"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style11"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="auto-style12"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style14" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style15" ForeColor="Black"></asp:Label>
        <asp:Button ID="btnSignUp" runat="server" CssClass="auto-style16" OnClick="btnSignUp_Click" Text="Sign Up" />
        <asp:Label ID="lblConfirmPassword" runat="server" TextMode="Password" CssClass="auto-style18" Text="Confirm Password:"></asp:Label>
        <asp:TextBox ID="txtPasswordConfirm" runat="server" TextMode="Password" CssClass="auto-style17"></asp:TextBox>
        <asp:Label ID="lblSecretPassword" runat="server" CssClass="auto-style21" Text="Secret Password:"></asp:Label>
        <asp:TextBox ID="txtSecret" runat="server" CssClass="auto-style22"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style24" Text="Please enter the relavent information to create an account"></asp:Label>
    </form>
</body>
</html>

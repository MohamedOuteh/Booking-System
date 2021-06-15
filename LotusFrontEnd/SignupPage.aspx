<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignupPage.aspx.cs" Inherits="SignupPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Sign Up</title>
    <style type="text/css">
                body{
            background-color: lightblue;
        }

        .auto-style2 {
            position: absolute;
            top: 236px;
            left: 763px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 294px;
            left: 772px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 409px;
            left: 780px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 351px;
            left: 736px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 463px;
            left: 776px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 515px;
            left: 779px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 237px;
            left: 926px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 294px;
            left: 924px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 353px;
            left: 928px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 411px;
            left: 931px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 464px;
            left: 934px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 517px;
            left: 936px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 398px;
            left: 19px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 664px;
            left: 940px;
            z-index: 1;
            width: 150px;
            height:40px;
        }
        .auto-style17 {
            position: absolute;
            top: 566px;
            left: 936px;
            z-index: 1;
        }
        .auto-style18 {
            position: absolute;
            top: 563px;
            left: 708px;
            z-index: 1;
        }
        .auto-style19 {
            position: absolute;
            top: 666px;
            left: 667px;
            z-index: 1;
            width: 150px;
            height:40px;
        }
        .auto-style1 {
            position: absolute;
            top: 0px;
            left: 641px;
            z-index: 1;
            font-size: xx-large;
        }
        .auto-style20 {
            position: absolute;
            top: 140px;
            left: 829px;
            z-index: 1;
        }
        .auto-style21 {
            position: absolute;
            top: 610px;
            left: 718px;
            z-index: 1;
        }
        .auto-style22 {
            position: absolute;
            top: 613px;
            left: 937px;
            z-index: 1;
        }
        .auto-style23 {
            position: absolute;
            top: 142px;
            left: 24px;
            z-index: 1;
            right: 1242px;
            height: 115px;
        }
        .auto-style24 {
            position: absolute;
            top: 500px;
            left: 1138px;
            z-index: 1;
            width: 260px;
        }
        .auto-style25 {
            position: absolute;
            top: 10px;
            left: 15px;
            z-index: 1;
            width: 307px;
            height: 79px;
        }
        .auto-style26 {
            position: absolute;
            top: 605px;
            left: 1126px;
            z-index: 1;
            width: 385px;
        }
        </style>
</head>
<body style="height: 25px">
    <form id="form1" runat="server">
        <nav>

        </nav>
        <header>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style1" ForeColor="#0000CC" Text="Welcome to Lotus Cutz"></asp:Label>
        </header>
        <div>

        </div>
        <asp:Label ID="lblFirstName" runat="server" CssClass="auto-style2" Text="First Name"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" CssClass="auto-style3" Text="Last Name"></asp:Label>
        <asp:Label ID="lblPhoneNo" runat="server" CssClass="auto-style4" Text="Phone No"></asp:Label>
        <asp:Label ID="lblEmailAddress" runat="server" CssClass="auto-style5" Text="Email Address"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" CssClass="auto-style6" Text="Username"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" CssClass="auto-style7" Text="Password"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style8"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" CssClass="auto-style9"></asp:TextBox>
        <asp:TextBox ID="txtEmailAddress" runat="server" CssClass="auto-style10"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNo" runat="server" CssClass="auto-style11"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style12"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="auto-style13" OnTextChanged="txtPassword_TextChanged"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style14" ForeColor="Red"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style16" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblConfirmPassword" runat="server" CssClass="auto-style18" Text="Confirm Password"></asp:Label>
        <asp:TextBox ID="txtPasswordConfirm" runat="server" TextMode="Password" CssClass="auto-style17"></asp:TextBox>
        <asp:Button ID="btnSignUp" runat="server" CssClass="auto-style19" OnClick="btnSignUp_Click" Text="Sign Up" />
        <asp:Label ID="Label2" runat="server" CssClass="auto-style20" Text="Sign Up" Font-Size="X-Large"></asp:Label>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style21" Text="Secret Password"></asp:Label>
        <asp:TextBox ID="txtSecret" runat="server" CssClass="auto-style22"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" CssClass="auto-style23" Text="Please enter the following details to sign up to the barber booking system:"></asp:Label>
        <asp:Label ID="Label5" runat="server" CssClass="auto-style24" Text="**note: The password must contain at least 7 character and contain one number"></asp:Label>
    <p>

        <img alt="" class="auto-style25" src="Images/Screenshot%20(38).png" /></p>
        <asp:Label ID="Label6" runat="server" CssClass="auto-style26" Text="** Secret Password would be used if you forgot or want to change your password"></asp:Label>
    </form>
    </body>
</html>

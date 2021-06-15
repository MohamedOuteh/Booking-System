<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminAddCustomer.aspx.cs" Inherits="SignupPage" %>

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
            top: 170px;
            left: 795px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 241px;
            left: 801px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 366px;
            left: 815px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 307px;
            left: 769px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 433px;
            left: 815px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 497px;
            left: 818px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 168px;
            left: 959px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 240px;
            left: 960px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 307px;
            left: 961px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 366px;
            left: 963px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 434px;
            left: 966px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 495px;
            left: 966px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 177px;
            left: 357px;
            z-index: 1;
            width: 395px;
            height: 452px;
        }
        .auto-style16 {
            position: absolute;
            top: 660px;
            left: 961px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style17 {
            position: absolute;
            top: 552px;
            left: 965px;
            z-index: 1;
        }
        .auto-style18 {
            position: absolute;
            top: 551px;
            left: 755px;
            z-index: 1;
        }
        .auto-style19 {
            position: absolute;
            top: 660px;
            left: 729px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style20 {
            position: absolute;
            top: 15px;
            left: 760px;
            z-index: 1;
        }
        .auto-style21 {
            position: absolute;
            top: 605px;
            left: 765px;
            z-index: 1;
        }
        .auto-style22 {
            position: absolute;
            top: 605px;
            left: 969px;
            z-index: 1;
        }
        .auto-style23 {
            position: absolute;
            top: 156px;
            left: 10px;
            z-index: 1;
            width: 282px;
        }
        .auto-style24 {
            position: absolute;
            top: 324px;
            left: 9px;
            z-index: 1;
            width: 275px;
        }
        .auto-style25 {
            position: absolute;
            top: -100px;
            left: 5px;
            z-index: 1;
            width: 277px;
            height: 89px;
        }
        </style>
</head>
<body style="height: 25px">
    <header>
                <asp:Label ID="lblAddCustomer" runat="server" CssClass="auto-style20" Text="Add Customer"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style25" src="http://localhost:59736/Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblFirstName" runat="server" CssClass="auto-style2" Text="First Name:"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" CssClass="auto-style3" Text="Last Name:"></asp:Label>
        <asp:Label ID="lblPhoneNo" runat="server" CssClass="auto-style4" Text="Phone No:"></asp:Label>
        <asp:Label ID="lblEmailAddress" runat="server" CssClass="auto-style5" Text="Email Address:"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" CssClass="auto-style6" Text="Username:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" CssClass="auto-style7" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style8"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" CssClass="auto-style9"></asp:TextBox>
        <asp:TextBox ID="txtEmailAddress" runat="server" CssClass="auto-style10"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNo" runat="server" CssClass="auto-style11"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style12"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="auto-style13"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style14"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style16" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblConfirmPassword" runat="server" TextMode="Password" CssClass="auto-style18" Text="Confirm Password:"></asp:Label>
        <asp:TextBox ID="txtPasswordConfirm" runat="server" TextMode="Password" CssClass="auto-style17"></asp:TextBox>
        <asp:Button ID="btnSignUp" runat="server" CssClass="auto-style19" OnClick="btnSignUp_Click" Text="Add Customer" />
        <asp:Label ID="lblSecret" runat="server" CssClass="auto-style21" Text="Secret Password:"></asp:Label>
        <asp:TextBox ID="txtSecret" runat="server" CssClass="auto-style22"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style23" Text="Please enter the relavent information"></asp:Label>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style24" Text="**note: The password has to be at least 7 character and contain 1 number"></asp:Label>
    </form>
</body>
</html>

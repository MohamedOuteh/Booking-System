<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminEditDetails.aspx.cs" Inherits="AdminSignUpPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
                <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Admin Edit Details</title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style2 {
            position: absolute;
            top: 283px;
            left: 748px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 343px;
            left: 752px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 403px;
            left: 759px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 471px;
            left: 752px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 283px;
            left: 957px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 346px;
            left: 958px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 406px;
            left: 960px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 472px;
            left: 963px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 539px;
            left: 673px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style14 {
            position: absolute;
            top: 540px;
            left: 954px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style15 {
            position: absolute;
            top: 174px;
            left: 14px;
            z-index: 1;
            width: 270px;
            height: 425px;
        }
        .auto-style16 {
            position: absolute;
            top: 7px;
            left: 647px;
            z-index: 1;
        }
        .auto-style17 {
            position: absolute;
            top: 209px;
            left: 742px;
            z-index: 1;
            width: 425px;
        }
        .auto-style18 {
            position: absolute;
            top: 471px;
            left: 1158px;
            z-index: 1;
        }
            .auto-style12 {
                position:relative;
                width: 355px;
                height: 86px;
                left: 12px;
                top: -95px;
            }
        </style>
</head>
<body>
    <header>
                <asp:Label ID="Label1" runat="server" CssClass="auto-style16" Font-Size="XX-Large" Text="Admin Edit Details"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style12" src="http://localhost:59736/Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblFirstName" runat="server" CssClass="auto-style2" Text="First Name:"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" CssClass="auto-style3" Text="Last Name:"></asp:Label>
        <asp:Label ID="lblPhoneNo" runat="server" CssClass="auto-style4" Text="Phone No:"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" CssClass="auto-style5" Text="Username:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style8"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" CssClass="auto-style9"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNo" runat="server" CssClass="auto-style10"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style11" ReadOnly="True"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style13" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style14" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style15"></asp:Label>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style17" Text="Please enter the relavent information to update"></asp:Label>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style18" Text="**cannot change username**"></asp:Label>
    </form>
</body>
</html>

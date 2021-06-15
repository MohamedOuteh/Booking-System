<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditCustomerPage.aspx.cs" Inherits="EditCustomerPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
                <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Edit Customer</title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style2 {
            position: absolute;
            top: 224px;
            left: 750px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 277px;
            left: 755px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 384px;
            left: 768px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 329px;
            left: 725px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 438px;
            left: 763px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 222px;
            left: 961px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 277px;
            left: 964px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 329px;
            left: 967px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 385px;
            left: 969px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 440px;
            left: 969px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 277px;
            left: 10px;
            z-index: 1;
            width: 286px;
            height: 409px;
        }
        .auto-style15 {
            position: absolute;
            top: 487px;
            left: 668px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style16 {
            position: absolute;
            top: 487px;
            left: 952px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style17 {
            position: absolute;
            top: 11px;
            left: 569px;
            z-index: 1;
        }
        .auto-style18 {
            position: absolute;
            top: 130px;
            left: 10px;
            z-index: 1;
            width: 264px;
        }
        .auto-style19 {
            position: absolute;
            top: 12px;
            left: 26px;
            z-index: 1;
            width: 267px;
            height: 89px;
        }
        </style>
</head>
<body>
    <p>
        <img alt="" class="auto-style19" src="http://localhost:59736/Images/Screenshot%20(38).png" /></p>
    <header>
                <asp:Label ID="Label1" runat="server" CssClass="auto-style17" Font-Bold="True" Font-Size="XX-Large" Text="Edit Customer Details"></asp:Label>
    </header>
    <nav>

    </nav>
    <form id="form1" runat="server">
        <div>
        </div>
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
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style15" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style16" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style14"></asp:Label>
        </p>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style18" Text="Please enter the relevant information that needs to be updated"></asp:Label>
    </form>
</body>
</html>

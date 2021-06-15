<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminCustomerDeletePage.aspx.cs" Inherits="AdminCustomerDeletePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
                <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title></title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 275px;
            left: 542px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 354px;
            left: 937px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style4 {
            position: absolute;
            top: 352px;
            left: 577px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style5 {
            position: absolute;
            top: 3px;
            left: 641px;
            z-index: 1;
        }
            .auto-style12 {
                position:relative;
                width: 335px;
                height: 79px;
                left: 19px;
                top: -89px;
            }
        </style>
</head>
<body>
    <header>
                <asp:Label ID="Label1" runat="server" CssClass="auto-style5" Text="Delete Customer"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style12" src="http://localhost:59736/Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblAreYouSure" runat="server" CssClass="auto-style1" Text="Are you sure you want to delete this customer?" Font-Size="X-Large"></asp:Label>
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style3" Text="NO" OnClick="btnNo_Click" />
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style4" OnClick="btnYes_Click" Text="YES" />
    </form>
</body>
</html>

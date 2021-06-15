<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteAccount.aspx.cs" Inherits="AdminCustomerDeletePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Delete Account</title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 254px;
            left: 522px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 337px;
            left: 910px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style4 {
            position: absolute;
            top: 336px;
            left: 556px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style5 {
            position: absolute;
            top: 9px;
            left: 607px;
            z-index: 1;
        }
            .auto-style12 {
                position:relative;
                width: 380px;
                height: 97px;
                left: 5px;
                top: -103px;
            }
        </style>
</head>
<body>
    <header>
        <asp:Label ID="lblDeleteBooking" runat="server" CssClass="auto-style5" Font-Size="XX-Large" Text="Delete Account"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style12" src="Images/Screenshot%20(38).png" /></nav>
    
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblAreYouSure" runat="server" CssClass="auto-style1" Text="Are you sure you want to delete this account?" Font-Size="X-Large"></asp:Label>
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style3" Text="NO" OnClick="btnNo_Click" />
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style4" OnClick="btnYes_Click" Text="YES" />
        
    </form>
</body>
</html>

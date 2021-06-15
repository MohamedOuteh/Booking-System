<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminDeletePage.aspx.cs" Inherits="AdminDeletePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Delete Admin</title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 268px;
            left: 507px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 343px;
            left: 526px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style3 {
            position: absolute;
            top: 343px;
            left: 879px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style4 {
            position: absolute;
            top: 3px;
            left: 665px;
            z-index: 1;
        }
            .auto-style12 {
                position:relative;
                width: 338px;
                height: 78px;
                left: 15px;
                top: -91px;
            }
        </style>
</head>
<body>
    <header>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style4" Text="Delete Admin"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style12" src="http://localhost:59736/Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblAre" runat="server" CssClass="auto-style1" Text="Are you sure you want to delete this admin?" Font-Size="X-Large"></asp:Label>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style2" Text="YES" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style3" OnClick="btnNo_Click" Text="NO" />
        
    </form>
</body>
</html>

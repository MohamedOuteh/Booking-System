<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminBookingDelete.aspx.cs" Inherits="AdminBookingDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
                <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Delete Booking</title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 264px;
            left: 474px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 337px;
            left: 480px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style3 {
            position: absolute;
            top: 340px;
            left: 804px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style4 {
            position: absolute;
            top: 5px;
            left: 638px;
            z-index: 1;
        }
            .auto-style12 {
                position:relative;
                width: 329px;
                height: 83px;
                left: 9px;
                top: -95px;
            }
        </style>
</head>
<body>
    <header>
                <asp:Label ID="Label2" runat="server" CssClass="auto-style4" Text="Delete Booking"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style12" src="http://localhost:59736/Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Text="Are you sure you want to delete this booking?" Font-Size="X-Large"></asp:Label>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style2" OnClick="btnYes_Click" Text="YES" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style3" OnClick="btnNo_Click" Text="NO" />
    </form>
</body>
</html>

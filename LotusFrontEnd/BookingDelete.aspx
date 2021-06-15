<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookingDelete.aspx.cs" Inherits="AdminBookingDelete" %>

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
            top: 223px;
            left: 564px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 297px;
            left: 520px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style3 {
            position: absolute;
            top: 301px;
            left: 867px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style4 {
            position: absolute;
            top: 12px;
            left: 583px;
            z-index: 1;
        }
            .auto-style12 {
                position:relative;
                width: 380px;
                height: 97px;
                left: 7px;
                top: -102px;
            }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <header>
            <asp:Label ID="lblDeleteBooking" runat="server" CssClass="auto-style4" Font-Size="XX-Large" Text="DELETE BOOKING" Font-Bold="True" Font-Names="Sitka Heading"></asp:Label>
        </header>
        <nav>

        <img alt="" class="auto-style12" src="Images/Screenshot%20(38).png" /></nav>

        <article>

        </article>
        <asp:Label ID="lblYouSure" runat="server" CssClass="auto-style1" Text="Are you sure you want to delete this booking?" Font-Size="Large"></asp:Label>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style2" OnClick="btnYes_Click" Text="YES" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style3" OnClick="btnNo_Click" Text="NO" />
        
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookingSuccess.aspx.cs" Inherits="BookingSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Booking Confirmation</title>
    <style type="text/css">
        body
        {
            background-color:lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 263px;
            left: 533px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 344px;
            left: 654px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style3 {
            position: absolute;
            top: 6px;
            left: 534px;
            z-index: 1;
        }
            .auto-style12 {
                position:relative;
                width: 380px;
                height: 97px;
                left: 3px;
                top: -99px;
            }
        </style>
</head>
<body>
    <header>
        <asp:Label ID="lblBookingConfirmation" runat="server" CssClass="auto-style3" Text="Booking Confirmation"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style12" src="Images/Screenshot%20(38).png" /></nav>
    <article>

    </article>
    <form id="form1" runat="server">
        <div>
        </div>
        
        <asp:Label ID="lblSuccess" runat="server" CssClass="auto-style1" Text="You have successfully made a booking" Font-Size="X-Large"></asp:Label>
        <asp:Button ID="btnReturn" runat="server" CssClass="auto-style2" OnClick="btnReturn_Click" Text="Return to Account" />
    </form>
</body>
</html>

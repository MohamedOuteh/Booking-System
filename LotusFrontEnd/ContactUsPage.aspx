<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactUsPage.aspx.cs" Inherits="ContactUsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Contact Us</title>
        <style type="text/css">
            .auto-style1 {
                position: absolute;
                top: 6px;
                left: 644px;
                z-index: 1;
            }
            .auto-style2 {
                position: absolute;
                top: 251px;
                left: 64px;
                z-index: 1;
                width:200px;
                height:40px;
            }
            .auto-style3 {
                position: absolute;
                top: 401px;
                left: 66px;
                z-index: 1;
                width:200px;
                height:40px;
            }
            .auto-style4 {
                position: absolute;
                top: 209px;
                left: 459px;
                z-index: 1;
            }
            .auto-style5 {
                position: absolute;
                top: 262px;
                left: 462px;
                z-index: 1;
                width: 756px;
            }
            .auto-style6 {
                position: absolute;
                top: 492px;
                left: 467px;
                z-index: 1;
            }
            .auto-style7 {
                position: absolute;
                top: 562px;
                left: 469px;
                z-index: 1;
            }
            .auto-style8 {
                position: absolute;
                top: 438px;
                left: 469px;
                z-index: 1;
            }
            .auto-style9 {
                position: absolute;
                top: 36px;
                left: 1023px;
                z-index: 1;
                width:200px;
                height:40px;
            }
            .auto-style10 {
                position: absolute;
                top: 34px;
                left: 1285px;
                z-index: 1;
                width:200px;
                height:40px;
            }
            .auto-style12 {
                position:absolute;
                width: 380px;
                height: 97px;
                left: -5px;
                top: 6px;
                z-index: 1;
            }
            .auto-style13 {
                width: 250px;
                height: 250px;
                position: relative;
                left: 1110px;
                top: 227px;
            }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <header>
            <asp:Label ID="lblContact" runat="server" CssClass="auto-style1" Text="Contact Us"></asp:Label>
        <img alt="" class="auto-style12" src="Images/Screenshot%20(38).png" /></header>
        <nav>

        </nav>
        <footer>
            @Copyright Lotus Cutz 2021
        </footer>
        
        &nbsp;<asp:Button ID="btnHome" runat="server" CssClass="auto-style2" OnClick="btnHome_Click" Text="Home Page" />
        <asp:Button ID="btnService" runat="server" CssClass="auto-style3" OnClick="btnService_Click" Text="Service Page" />
        
        <asp:Label ID="lblPara1" runat="server" CssClass="auto-style4" Font-Bold="True" Font-Size="Large" Text="YOUR OPPORTUNITY TO WORK IN THE BEST FAMILY BARBER SHOP BRAND IN THE UK"></asp:Label>
        <asp:Button ID="Button2" runat="server" CssClass="auto-style10" Text="Log In" OnClick="Button2_Click" />
        &nbsp;<asp:Label ID="Label1" runat="server" CssClass="auto-style5" Text="We’re looking for the most talented barbers to join our growing team as we expand our barber shops across the East of England. If you’ve got a passion for creating clean, precision cuts, providing excellent customer service and keeping up to date with the latest trends in men’s hair styling, we would love to hear from you."></asp:Label>
        
        <asp:Label ID="Label2" runat="server" CssClass="auto-style6" Text="General Enquiries: help@lotuscutz.co.uk"></asp:Label>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style7" Text="Jobs: careers@lotuscutz.co.uk"></asp:Label>
        <asp:Label ID="Label4" runat="server" CssClass="auto-style8" Font-Bold="True" Text="Contact Details for:"></asp:Label>
        
        <asp:Button ID="Button1" runat="server" CssClass="auto-style9" Text="Sign Up" OnClick="Button1_Click" />
        
    </form>
    <p>
        <img alt="" class="auto-style13" src="Images/download.jpg" /></p>
</body>
</html>

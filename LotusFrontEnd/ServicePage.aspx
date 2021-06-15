<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ServicePage.aspx.cs" Inherits="ServicePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Services</title>
        <style type="text/css">

            .auto-style12 {
                position:relative;
                width: 380px;
                height: 97px;
                left: 4px;
                top: -103px;
            }
            .auto-style13 {
                position: absolute;
                top: 6px;
                left: 691px;
                z-index: 1;
            }
            .auto-style14 {
                position: absolute;
                top: 253px;
                left: 54px;
                z-index: 1;
                width:200px;
                height:40px;
            }
            .auto-style15 {
                position: absolute;
                top: 411px;
                left: 54px;
                z-index: 1;
                width:200px;
                height:40px;
            }
            .auto-style16 {
                position: absolute;
                top: 33px;
                left: 1065px;
                z-index: 1;
                width:200px;
                height:40px;
            }
            .auto-style17 {
                position: absolute;
                top: 36px;
                left: 1294px;
                z-index: 1;
                width:200px;
                height:40px;
            }
            .auto-style18 {
                position: absolute;
                top: 163px;
                left: 332px;
                z-index: 1;
            }
            .auto-style19 {
                position: absolute;
                top: 206px;
                left: 336px;
                z-index: 1;
                width: 827px;
            }
            .auto-style20 {
                position: absolute;
                top: 348px;
                left: 337px;
                z-index: 1;
            }
            .auto-style21 {
                position: absolute;
                top: 398px;
                left: 337px;
                z-index: 1;
                width: 691px;
            }
            .auto-style22 {
                position: absolute;
                top: 505px;
                left: 329px;
                z-index: 1;
            }
            .auto-style23 {
                width: 250px;
                height: 250px;
                position: relative;
                left: 1212px;
                top: 206px;
            }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <header>
            <asp:Label ID="lblService" runat="server" CssClass="auto-style13" Text="Service Page"></asp:Label>
        </header>
        <nav>

        <img alt="" class="auto-style12" src="Images/Screenshot%20(38).png" />

        </nav>
        <footer>
            @Copyright Lotus Cutz 2021
        </footer>
        
        <asp:Button ID="btnHome" runat="server" CssClass="auto-style14" OnClick="btnHome_Click" Text="Home Page" />
        <asp:Button ID="btnContact" runat="server" CssClass="auto-style15" OnClick="btnContact_Click" Text="Contact Page" />
        <asp:Button ID="btnSignup" runat="server" CssClass="auto-style16" OnClick="btnSignup_Click" Text="Sign Up" />
        <asp:Button ID="btnLogin" runat="server" CssClass="auto-style17" OnClick="btnLogin_Click" Text="Log In" />
        
        <asp:Label ID="Label1" runat="server" CssClass="auto-style18" Font-Bold="True" Font-Size="Large" Text=" EVERYMAN CLEAN AND CONDITIONED HAIRCUT | 30 MINS - £25"></asp:Label>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style19" Text="During the haircut, your hair and scalp will be cleansed and prepared using an invigorating 
            professional product specifically to suit the hair type, we will then add cream Treatment which is a conditioning,styling and finishing tool– leaving you with nourished, manageable and smooth hair with each use."></asp:Label>
        
        <asp:Label ID="Label3" runat="server" CssClass="auto-style20" Font-Bold="True" Font-Size="Large" Text="Standard Haircuts"></asp:Label>
        <asp:Label ID="Label4" runat="server" CssClass="auto-style21" Text="Over here at Lotus Cutz we do offer standard haircuts as well. These include: Fade, Skin Fade, Taper Fade, Clean cut, Comb Over Fade etc"></asp:Label>
        
        
        <asp:Label ID="Label5" runat="server" CssClass="auto-style22" Font-Bold="True" Font-Size="Large" Text="SIGN UP OR LOG IN TO MAKE YOUR BOOKING NOW"></asp:Label>
        
        
    </form>
    <p>
        <img alt="" class="auto-style23" src="Images/10-boys-side-part-hairstyle.jpg" /></p>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LotusHome.aspx.cs" Inherits="LotusHome" Theme="" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Home Page</title>
    <style type="text/css">
        body
        {
            background-color:lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 22px;
            left: 537px;
            z-index: 1;
            font-size: xx-large;
        }
        .auto-style2 {
            position: absolute;
            top: 35px;
            left: 1074px;
            z-index: 1;
            width: 159px;
            height: 46px;
        }
        .auto-style3 {
            position: absolute;
            top: 37px;
            left: 1271px;
            z-index: 1;
            height: 44px;
            width: 144px;
        }

        .auto-style4 {
            position: absolute;
            top: 199px;
            left: 357px;
            z-index: 1;
            width: 1103px;
        }
        .auto-style5 {
            width: 250px;
            height: 250px;
            position: absolute;
            left: 326px;
            top: 409px;
            z-index: 5;
        }
        .auto-style6 {
            width: 250px;
            height: 250px;
            position: absolute;
            left: 623px;
            top: 409px;
            z-index: 4;
        }
        .auto-style7 {
            position: absolute;
            top: 169px;
            left: 39px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style8 {
            position: absolute;
            top: 321px;
            left: 40px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style9 {
            position: absolute;
            top: 141px;
            left: 765px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 274px;
            left: 793px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 322px;
            left: 633px;
            z-index: 1;
        }
            .auto-style12 {
                position:absolute;
                width: 380px;
                height: 97px;
            left: 5px;
            top: 6px;
            z-index: 1;
        }
        .auto-style13 {
            width: 250px;
            height: 250px;
            position: absolute;
            left: 903px;
            top: 404px;
            z-index: 2;
        }
        .auto-style14 {
            width: 250px;
            height: 250px;
            position: absolute;
            left: 1219px;
            top: 406px;
            z-index: 3;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <header>
            <asp:Label ID="Label2" runat="server" CssClass="auto-style1" ForeColor="#0000CC" Text="Welcome to Lotus Cutz"></asp:Label>
        </header>
        <nav>
                    <asp:Button ID="btnContact" runat="server" CssClass="auto-style7" Text="Contact Us" OnClick="btnContact_Click" />
                    <asp:Button ID="btnService" runat="server" CssClass="auto-style8" Text="Services" OnClick="btnService_Click" />
        </nav>
                <footer>
            @Copyright Lotus Cutz 2021
        </footer>
        <article>

        </article>
        <asp:Button ID="btnSignup" runat="server" CssClass="auto-style2" OnClick="btnSignup_Click" Text="Sign Up" />
        <asp:Button ID="btnLogin" runat="server" CssClass="auto-style3" OnClick="btnLogin_Click" Text="Log In" />
        <asp:Label ID="Label3" runat="server" CssClass="auto-style9" Font-Bold="True" Font-Names="Sitka Heading" Font-Size="X-Large" Text="About Us"></asp:Label>
        <asp:Label ID="lblFirstPara" runat="server" CssClass="auto-style4" Text="We are the best barbershop in leicester. Lotus Cutz offers consistent, quality haircuts operating on a walk in or appointment service. Professional, family owned and operated barbers offering a traditional barber shop experience" Font-Names="Sitka Subheading"></asp:Label>
        <img class="auto-style5" src="Images/0_GettyImages-626416292.jpg" /><img alt="" class="auto-style6" src="Images/1_RH_CJA_090520Barber_1.jpg" /><asp:Label ID="Label5" runat="server" CssClass="auto-style11" Font-Names="Sitka Subheading" Text="Here are some of our best cutz during the year of 2020"></asp:Label>
        <asp:Label ID="Label4" runat="server" CssClass="auto-style10" Font-Bold="True" Font-Names="Sitka Subheading" Font-Size="X-Large" Text="Gallery"></asp:Label>
&nbsp;</form>
        <p>
        <img alt="" class="auto-style12" src="Images/Screenshot%20(38).png" /></p>
        <p>
            <img alt="" class="auto-style13" src="Images/Waves-With-Sharp-Shape-Up.jpg" /><img alt="" class="auto-style14" src="Images/ad31abdda06801b7951c34ea61127a92.jpg" /></p>
        </body>
</html>

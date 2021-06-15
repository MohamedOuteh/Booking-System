<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUpSuccess.aspx.cs" Inherits="SignUpSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
                <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Sign up Confirmation
    </title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 276px;
            left: 458px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 367px;
            left: 716px;
            z-index: 1;
            width: 200px;
            height: 40px;
        }
        .auto-style3 {
            position: absolute;
            top: 13px;
            left: 626px;
            z-index: 1;
        }
            .auto-style12 {
                position:relative;
                width: 380px;
                height: 97px;
                left: 13px;
                top: -104px;
            }
        </style>
</head>
<body>
    <header>
                <asp:Label ID="Label2" runat="server" CssClass="auto-style3" Text="Sign Up Confirmation"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style12" src="http://localhost:59736/Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Text="You have successfully signed up to the barber" Font-Size="XX-Large"></asp:Label>
        <asp:Button ID="btnAccount" runat="server" CssClass="auto-style2" OnClick="btnAccount_Click" Text="Go to Account" />
    </form>
</body>
</html>

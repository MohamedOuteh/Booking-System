<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditSuccess.aspx.cs" Inherits="EditSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Update Confirmation</title>
    <style type="text/css">
        body
        {
            background-color:lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 266px;
            left: 554px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 359px;
            left: 701px;
            z-index: 1;
            width: 282px;
            height: 40px;
        }
        .auto-style3 {
            position: absolute;
            top: 5px;
            left: 646px;
            z-index: 1;
        }
            .auto-style12 {
                position:relative;
                width: 380px;
                height: 97px;
                left: 5px;
                top: -100px;
            }
        </style>
</head>
<body>
    <nav>

        <img alt="" class="auto-style12" src="Images/Screenshot%20(38).png" /></nav>
    <header>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Text="Update Confirmation"></asp:Label>
    </header>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSuccess" runat="server" CssClass="auto-style1" Text="You have successfully updated the information" Font-Size="X-Large"></asp:Label>
        <asp:Button ID="btnReturn" runat="server" CssClass="auto-style2" OnClick="btnReturn_Click" Text="Return to Account" Font-Size="X-Large" />
        
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddHaircut.aspx.cs" Inherits="AddHaircut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Add Haircut</title>
    <style type="text/css">
        body
        {
            background-color:lightblue;
        }
        .auto-style2 {
            position: absolute;
            top: 290px;
            left: 665px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 345px;
            left: 670px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 289px;
            left: 898px;
            z-index: 1;
            width: 173px;
        }
        .auto-style6 {
            position: absolute;
            top: 357px;
            left: 897px;
            z-index: 1;
            width: 173px;
        }
        .auto-style7 {
            position: absolute;
            top: 406px;
            left: 615px;
            z-index: 1;
            width: 200px;
            height:40px;
        }
        .auto-style8 {
            position: absolute;
            top: 404px;
            left: 888px;
            z-index: 1;
            width: 200px;
            height:40px;
        }
        .auto-style9 {
            position: absolute;
            top: 213px;
            left: 15px;
            z-index: 1;
            width: 261px;
            height: 304px;
        }
        .auto-style10 {
            position: absolute;
            top: 21px;
            left: 677px;
            z-index: 1;
        }
            .auto-style12 {
                position:relative;
                width: 380px;
                height: 97px;
                left: 10px;
                top: -81px;
            }
        </style>
</head>
<body>
    <header>
                <asp:Label ID="lblAddHaircut" runat="server" CssClass="auto-style10" Text="Add Haircut"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style12" src="http://localhost:59736/Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblHaircutName" runat="server" CssClass="auto-style2" Text="Haircut Name:"></asp:Label>
        <asp:Label ID="lblHaircutPrice" runat="server" CssClass="auto-style3" Text="Haircut Price:"></asp:Label>
        <asp:TextBox ID="txtHaircutName" runat="server" CssClass="auto-style5"></asp:TextBox>
        <asp:TextBox ID="txtHaircutPrice" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style7" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style8" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style9"></asp:Label>
    </form>
</body>
</html>

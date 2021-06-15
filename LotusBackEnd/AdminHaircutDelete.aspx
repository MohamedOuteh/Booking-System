<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminHaircutDelete.aspx.cs" Inherits="AdminHaircutDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
                <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Delete Haircut</title>
    <style type="text/css">
                body
        {
            background-color: lightblue;
        }
        .auto-style1 {
            position: absolute;
            top: 292px;
            left: 534px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 368px;
            left: 546px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style3 {
            position: absolute;
            top: 369px;
            left: 850px;
            z-index: 1;
            width:200px;
            height:40px;
        }
        .auto-style4 {
            position: absolute;
            top: 8px;
            left: 644px;
            z-index: 1;
        }
            .auto-style12 {
                position:relative;
                width: 318px;
                height: 81px;
                left: 10px;
                top: -91px;
            }
        </style>
</head>
<body>
    <header>
                <asp:Label ID="Label2" runat="server" CssClass="auto-style4" Text="Delete Haircut"></asp:Label>
    </header>
    <nav>

        <img alt="" class="auto-style12" src="http://localhost:59736/Images/Screenshot%20(38).png" /></nav>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Text="Are you sure you want to delete this haircut?" Font-Size="X-Large"></asp:Label>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style2" OnClick="btnYes_Click" Text="YES" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style3" OnClick="btnNo_Click" Text="NO" />
    </form>
</body>
</html>

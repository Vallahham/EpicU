<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaChallangeCode_01.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Image ID="Image1" runat="server" Height="180px" Width="180px" />
        <asp:Image ID="Image2" runat="server" Height="180px" Width="180px" />
        <asp:Image ID="Image3" runat="server" Height="180px" Width="180px" />
        <br />
        <br />
        Your Bet:
        <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="leverButton" runat="server" Text="Pull The Lever!" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="moneyLabel" runat="server"></asp:Label>
        <br />
        <br />
        Rules:<br />
        1 Cherry - x2 Your Bet<br />
        2 Cherry - x3 Your Bet<br />
        3 Cherry - x4 Your Bet<br />
        3 7&#39;s - Jackpot - x100 Your Bet<br />
        HOWEVER.... if there is even one BAR, you win nothing</div>
    </form>
</body>
</html>

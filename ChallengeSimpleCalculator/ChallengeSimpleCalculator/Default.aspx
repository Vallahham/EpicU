<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            font-family: Cambria;
        }
        .auto-style2 {
            font-family: Arial;
            font-size: small;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <span class="auto-style1"><strong>Simple Calculator</strong></span><br />
        <br />
        <span class="auto-style2">First Number:</span>
        <asp:TextBox ID="firstNumberTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <span class="auto-style2">Second Number:</span>
        <asp:TextBox ID="secondNumberTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="multiplication_Button" runat="server" OnClick="multiplication_Button_Click" style="width: 19px" Text="*" />
        <asp:Button ID="division_Button" runat="server" OnClick="division_Button_Click" Text="/" />
        <asp:Button ID="addition_Button" runat="server" Text="+" OnClick="addition_Button_Click" />
        <asp:Button ID="subtraction_Button" runat="server" Text="-" OnClick="subtraction_Button_Click" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" style="font-weight: 700; background-color: #99FF66"></asp:Label>
    
    </div>
    </form>
</body>
</html>

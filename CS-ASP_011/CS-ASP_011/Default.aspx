<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_011.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Is
        <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
&nbsp;equal to
        <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
        ?<br />
        <br />
        <br />
        <asp:CheckBox ID="coolCheckBox" runat="server" Text="Are you cool?" />
        <br />
        <br />
        If you could only eat one food for the rest of your life, what would you choose?<br />
        <asp:RadioButton ID="pizzaRadioButton" runat="server" Checked="True" GroupName="foodGroup" Text="Pizza" />
        <br />
        <asp:RadioButton ID="RamenRadioButton" runat="server" GroupName="foodGroup" Text="Ramen" />
        <br />
        <asp:RadioButton ID="pbjRadioButton" runat="server" GroupName="foodGroup" Text="PB &amp; J" />
        <br />
        <br />
        <asp:Button ID="OK_ClickButton" runat="server" OnClick="OK_ClickButton_Click" Text="OK" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>

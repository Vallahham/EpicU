<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_009.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Button ID="OK_ClickButton" runat="server" OnClick="OK_ClickButton_Click" Text="Click Here" />
        <br />
    
    </div>
        <asp:Label ID="resultLabel" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>

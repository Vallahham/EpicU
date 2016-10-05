<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeHeroMonsterClasses.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        Opponents<br />
        <br />
    
        <asp:Label ID="opponent1Label" runat="server"></asp:Label>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; V.S.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="opponent2Label" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="fightButton" runat="server" OnClick="fightButton_Click" Text="Fight!" />
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpies.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" Width="129px" />
        <br />
        <br />
        <strong><span class="auto-style1">Spy New Assignment Form</span><br class="auto-style1" />
        </strong>
        <br />
        Spy Code Name:
        <asp:TextBox ID="spyNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        New Assignment Name:
        <asp:TextBox ID="assignmentNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        End Date of Previous Assignment<asp:Calendar ID="previousEndCalendar" runat="server"></asp:Calendar>
        <br />
        <br />
        Start Date of New Assignment<asp:Calendar ID="startCalendar" runat="server"></asp:Calendar>
        <br />
        <br />
        Projected End Date of New Assignment<asp:Calendar ID="endCalendar" runat="server"></asp:Calendar>
        <br />
        <br />
        <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>

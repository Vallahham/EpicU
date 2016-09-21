<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpies.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            font-size: large;
        }
        .auto-style4 {
            background-color: #CCFF99;
            font-size: small;
        }
        .auto-style5 {
            font-size: small;
        }
        .auto-style6 {
            background-color: #FFFFFF;
            font-size: small;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div class="auto-style2">
    
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
        </div>
        <div class="auto-style2">
            <br />
            <br />
            &nbsp;&nbsp;<span class="auto-style5"> </span><span class="auto-style4">End Date of Previous Assignment</span><span class="auto-style3"><br />
            </span>
        </div>
&nbsp;<div style="width:100%; margin: 0 auto;" class="auto-style2">
         <asp:Calendar ID="previousEndCalendar" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" DayNameFormat="Full" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" style="text-align: center; margin-left: 0px" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
            <div class="auto-style2">
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style4">Start Date of New Assignment</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>
            <asp:Calendar ID="startCalendar" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" DayNameFormat="Full" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
            <div class="auto-style2">
                <br />
                <span class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span><span class="auto-style4">Projected End Date of New Assignment<br />
                <br />
                </span>
            </div>
            <asp:Calendar ID="endCalendar" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" DayNameFormat="Full" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
            <div class="auto-style2">
                <br />
                <br />
        <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" style="text-align: center" />
        <br />
            </div>
    
    </div>
        <p style="text-align: center">
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
        </p>
    </form>
</body>
</html>

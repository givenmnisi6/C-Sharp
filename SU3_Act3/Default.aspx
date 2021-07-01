<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SU3_Act3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 145px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            height: 32px;
        }
        .auto-style5 {
            height: 41px;
        }
        .auto-style6 {
            height: 30px;
        }
        .auto-style7 {
            height: 66px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Names="Arial Black" Font-Size="20pt" Text="Concert Booking"></asp:Label>
            <br />
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Name and Surname:"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="InputTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2">
                        <asp:Label ID="Label3" runat="server" Text="Number of tickets:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="2">
                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="tickets" OnCheckedChanged="RadioButton1_CheckedChanged" Text="1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="tickets" OnCheckedChanged="RadioButton1_CheckedChanged" Text="2" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="tickets" OnCheckedChanged="RadioButton1_CheckedChanged" Text="3" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="2">
                        <asp:Label ID="Label4" runat="server" Text="Select show time:"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="2">
                        <asp:Button ID="Button11" runat="server" Height="22px" OnClick="Button11_Click" Text="11:00" Width="45px" />
&nbsp;
                        <asp:Button ID="Button14" runat="server" Height="22px" OnClick="Button14_Click" Text="14:00" Width="45px" />
&nbsp;
                        <asp:Button ID="Button17" runat="server" Height="22px" OnClick="Button17_Click" Text="17:00" Width="45px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7" colspan="2"></td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:Button ID="BookButton" runat="server" Height="38px" OnClick="BookButton_Click" Text="Book" Width="154px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:Label ID="DisplayLabel" runat="server" Text="lblDisplay"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

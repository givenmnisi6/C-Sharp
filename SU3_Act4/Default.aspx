<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SU3_Act4.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #00FFFF">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style9 {
            height: 23px;
        }
        .auto-style10 {
            height: 23px;
            width: 221px;
        }
        .auto-style12 {
            text-align: center;
            height: 22px;
        }
        .auto-style13 {
            text-align: center;
            height: 28px;
        }
        .auto-style14 {
            text-align: left;
            height: 23px;
        }
        .auto-style17 {
            height: 23px;
            width: 595px;
            text-align: left;
        }
        .auto-style19 {
            height: 23px;
            width: 340px;
        }
        .auto-style20 {
            height: 23px;
            width: 340px;
            text-align: left;
        }
        .auto-style21 {
            height: 23px;
            width: 481px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Font-Names="Arial Black" Font-Size="23pt" Text="Study Scheduler"></asp:Label>
            <br />
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style13" colspan="5">Module:&nbsp;&nbsp;
                        <asp:TextBox ID="InputTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style14" colspan="5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12" colspan="5">Select the date from the calendar for when you plan to study for a module </td>
                </tr>
                <tr>
                    <td class="auto-style21">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style19">
                        <asp:Calendar ID="Calendar" runat="server" OnSelectionChanged="Calendar_SelectionChanged"></asp:Calendar>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="auto-style17">
                        <asp:Label ID="DisplayLabel" runat="server" Font-Italic="True" ForeColor="#FF0066" Text="[Display]" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21">&nbsp;</td>
                    <td class="auto-style9" colspan="4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style21">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style20">
                        <asp:ListBox ID="OutputListBox" runat="server" Height="144px" Width="263px"></asp:ListBox>
                    </td>
                    <td class="auto-style17">
                        &nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9" colspan="4">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

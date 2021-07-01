<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SU3_Act1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #000000">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 231px;
        }
        .auto-style2 {
            width: 486px;
        }
        .auto-style4 {
            width: 100%;
        }
        .auto-style5 {
            width: 269px;
        }
        .auto-style6 {
            width: 269px;
            height: 23px;
            text-align: right;
        }
        .auto-style7 {
            height: 23px;
            text-align: left;
        }
        .auto-style9 {
            height: 23px;
            width: 208px;
            text-align: center;
        }
        .auto-style10 {
            width: 208px;
        }
        .auto-style11 {
            width: 269px;
            text-align: right;
        }
        .auto-style12 {
            width: 208px;
            text-align: center;
        }
        .auto-style13 {
            text-align: left;
        }
        .auto-style14 {
            font-size: xx-large;
        }
        .auto-style15 {
            font-size: large;
        }
        .auto-style16 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style13" style="background-color: #FFFFFF">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style16" colspan="3">
                        <asp:Label ID="Label9" runat="server" CssClass="auto-style14" Text="GROCERY LIST CREATOR"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="Label10" runat="server" CssClass="auto-style15" Text="Enter your name to create your own personalised grocery list:"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <br />
                        <br />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <table class="auto-style4">
                <tr>
                    <td class="auto-style11">
                        <asp:Label ID="Label11" runat="server" Text="Name:"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="Nametxt" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label12" runat="server" Text="Items:"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="Itemstxt" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style7">
                        <asp:Button ID="AddButton" runat="server" Font-Names="Arial" OnClick="AddButton_Click" Text="Add To List" Width="102px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label13" runat="server" Text="GROCERY LIST"></asp:Label>
                        <br />
                        <br />
                    </td>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            <asp:ListBox ID="ListBox" runat="server" Height="190px" Width="316px" OnSelectedIndexChanged="ListBox_SelectedIndexChanged"></asp:ListBox>
        </div>
        <asp:Label ID="MessageLabel" runat="server" ForeColor="White" Text="MESSAGE"></asp:Label>
    </form>
</body>
</html>

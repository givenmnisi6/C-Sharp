<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SU3_Act6.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #00FFFF">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 329px;
        }
        .auto-style2 {
            width: 205px;
        }
        .auto-style5 {
            height: 60px;
        }
        .auto-style8 {
            height: 27px;
            width: 205px;
        }
        .auto-style9 {
            width: 205px;
            height: 45px;
        }
        .auto-style10 {
            height: 45px;
        }
        .auto-style11 {
            width: 205px;
            height: 35px;
        }
        .auto-style12 {
            height: 35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style5" colspan="3">
                        <asp:Label ID="Label1" runat="server" Font-Size="20pt" ForeColor="#CC0066" Text="Happy Pet Kennel"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" rowspan="7">
                        <asp:GridView ID="GridView" runat="server" BackColor="#00CC00" ForeColor="White" Height="320px" Width="315px">
                        </asp:GridView>
                    </td>
                    <td class="auto-style8">
                        <asp:Button ID="AllPetsButton" runat="server" Font-Bold="True" OnClick="AllPetsButton_Click" Text="Show all pets" Width="172px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Button ID="LargePetsButton" runat="server" Font-Bold="True" OnClick="LargePetsButton_Click" Text="Show all large pets" Width="195px" />
                    </td>
                    <td class="auto-style10"></td>
                </tr>
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="OutputLabel" runat="server" Font-Size="20pt" ForeColor="#CC0066" Text="[lblError]"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

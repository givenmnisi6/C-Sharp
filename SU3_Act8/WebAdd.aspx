<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebAdd.aspx.cs" Inherits="SU3_Act8.WebAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label5" runat="server" CssClass="auto-style1" Text="Info"></asp:Label>
            <table class="auto-style2">
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text="[Display1]"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="EmailLabel" runat="server" Text="[Display2]"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Back</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

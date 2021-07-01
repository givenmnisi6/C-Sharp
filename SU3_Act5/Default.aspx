<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SU3_Act5.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            height: 131px;
        }
        .auto-style4 {
            height: 192px;
        }
        .auto-style6 {
            height: 131px;
            width: 265px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label1" runat="server" Font-Names="Arial Black" Font-Size="21pt" Text="Speedy Delivery"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Image ID="Image1" runat="server" Height="128px" ImageUrl="~/speedy.jpg" Width="138px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2"><strong>
                        <asp:Label ID="Label2" runat="server" Font-Names="Arial Black" Text="Select the dropoff date:"></asp:Label>
                        </strong></td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2">
                        <asp:Calendar ID="Calendar" runat="server" OnSelectionChanged="Calendar_SelectionChanged"></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td colspan="2"><strong>
                        <asp:Label ID="OutputLabel" runat="server" Font-Names="Arial Black" Text="The item will be delivered:"></asp:Label>
                        </strong></td>
                </tr>
                <tr>
                    <td colspan="2"><strong>
                        <asp:Label ID="DisplayLabel" runat="server" Font-Names="Arial Black" Text="[Output]"></asp:Label>
                        </strong></td>
                </tr>
            </table>
            <br />
            <br />
        </div>
    </form>
</body>
</html>

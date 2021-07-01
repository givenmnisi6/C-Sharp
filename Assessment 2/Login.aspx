<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assessment_2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
        .auto-style2 {
            height: 22px;
        }
        .auto-style3 {
            width: 124px;
        }
        .auto-style4 {
            width: 168px;
            text-align: center;
        }
        .auto-style5 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Text="Welcome to login screen"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="Username:"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="Usernametxt2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="Passwordtxt2" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:CheckBox ID="CheckBox" runat="server" Text="Remember me" OnCheckedChanged="CheckBox_CheckedChanged" />
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="Loginbtn" runat="server" Text="Login" OnClick="Loginbtn_Click" />
                    </td>
                    <td>
                        <asp:Label ID="Displaylbl" runat="server" Text="???????????????" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="3">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">Click here to register...</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

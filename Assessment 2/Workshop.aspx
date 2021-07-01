<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Workshop.aspx.cs" Inherits="Assessment_2.Workshop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            font-size: xx-large;
        }
        .auto-style5 {
            font-size: large;
        }
        .auto-style7 {
            height: 28px;
        }
        .auto-style8 {
            width: 396px;
        }
        .auto-style9 {
            width: 125px;
        }
        .auto-style10 {
            font-size: x-large;
        }
        .auto-style11 {
            height: 15px;
        }
        .auto-style14 {
            height: 21px;
        }
        .auto-style15 {
            height: 18px;
        }
        .auto-style16 {
            width: 254px;
            height: 169px;
        }
        .auto-style17 {
            height: 169px;
        }
        .auto-style18 {
            height: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Text="Welcome"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Usernamelbl" runat="server" CssClass="auto-style3" Text="USERNAME"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>
                        <asp:Label ID="Label3" runat="server" CssClass="auto-style5" Text=" "></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7" colspan="2">
                        <asp:Label ID="Label2" runat="server" CssClass="auto-style10" Text="Please indicate your preferred date for a programming workshop below."></asp:Label>
                    </td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style7" colspan="2">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style18" colspan="2">
                        <asp:Label ID="Label4" runat="server" CssClass="auto-style5" Text="Here is your current date and selected programming language (if any):"></asp:Label>
                    </td>
                    <td class="auto-style18"></td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2"></td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style7" colspan="2">
                        <asp:GridView ID="GridView" runat="server" Width="372px">
                        </asp:GridView>
                    </td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style14" colspan="2"></td>
                    <td class="auto-style14"></td>
                </tr>
                <tr>
                    <td class="auto-style14" colspan="2">
                        <asp:Label ID="Label5" runat="server" CssClass="auto-style5" Text="To indicate a new preferred date, choose one on the calendar below:"></asp:Label>
                    </td>
                    <td class="auto-style14">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15" colspan="2"></td>
                    <td class="auto-style15">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15" colspan="2">
                        <table style="width:100%;">
                            <tr>
                                <td class="auto-style16">
                                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                                </td>
                                <td class="auto-style17">
                                    <asp:RadioButtonList ID="RadioButtonList" runat="server" Height="114px" AutoPostBack="True">
                                        <asp:ListItem>Java</asp:ListItem>
                                        <asp:ListItem>C#</asp:ListItem>
                                        <asp:ListItem>C++</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td class="auto-style15">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15" colspan="2">&nbsp;</td>
                    <td class="auto-style15">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15" colspan="2">
                        <asp:Button ID="Confirmbtn" runat="server" OnClick="Confirmbtn_Click" Text="Confirm date" Width="89px" />
                    </td>
                    <td class="auto-style15">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

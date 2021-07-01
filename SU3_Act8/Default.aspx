<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SU3_Act8.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 95px;
        }
        .auto-style3 {
            font-size: xx-large;
        }
        .auto-style4 {
            width: 95px;
            height: 18px;
        }
        .auto-style5 {
            height: 18px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            height: 22px;
        }
        .auto-style8 {
            height: 51px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label5" runat="server" CssClass="auto-style3" Text="University Info"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7" colspan="2">
                        <asp:Label ID="Label2" runat="server" Text="Please enter your details"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label3" runat="server" Text="Name:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NameTextBox" ErrorMessage="Required!"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailTextBox" ErrorMessage="Invalid Email!" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8" colspan="2">
                        <asp:Panel ID="Panel1" runat="server">
                        </asp:Panel>
                        <asp:Panel ID="Panel" runat="server" GroupingText="Universities" Height="150px" Width="235px">
                            <asp:RadioButtonList ID="RadioButtonList" runat="server" AutoPostBack="True" Width="232px">
                                <asp:ListItem Value="North West University">NWU</asp:ListItem>
                                <asp:ListItem Value="University of Johannesburg">UJ</asp:ListItem>
                                <asp:ListItem Value="University of Cape Town">UCT</asp:ListItem>
                                <asp:ListItem Value="University of Pretoria">UP</asp:ListItem>
                                <asp:ListItem Value="University of Free State">UOFS</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

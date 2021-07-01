<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SU3_Act2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
            height: 102px;
        }
        .auto-style7 {
            text-align: left;
            width: 584px;
            height: 27px;
        }
        .auto-style22 {
            width: 584px;
            height: 33px;
            text-align: left;
        }
        .auto-style24 {
            width: 128px;
            text-align: left;
            height: 33px;
        }
        .auto-style26 {
            width: 128px;
            text-align: left;
            height: 27px;
        }
        .auto-style27 {
            width: 318px;
            text-align: left;
            height: 27px;
        }
        .auto-style28 {
            width: 318px;
            text-align: left;
            height: 33px;
        }
        .auto-style30 {
            height: 43px;
        }
        .auto-style32 {
            width: 252px;
            text-align: left;
            height: 27px;
        }
        .auto-style33 {
            width: 252px;
            text-align: left;
            height: 43px;
        }
        .auto-style34 {
            font-size: xx-large;
        }
        .auto-style35 {
            width: 252px;
            text-align: left;
            height: 22px;
        }
        .auto-style36 {
            width: 318px;
            text-align: left;
            height: 22px;
        }
        .auto-style37 {
            width: 128px;
            text-align: left;
            height: 22px;
        }
        .auto-style38 {
            text-align: left;
            width: 584px;
            height: 22px;
        }
        .auto-style39 {
            height: 28px;
            text-align: left;
        }
        .auto-style40 {
            height: 25px;
            text-align: left;
        }
        .auto-style41 {
            height: 22px;
            text-align: left;
        }
        .auto-style42 {
            width: 252px;
            text-align: left;
            height: 33px;
        }
        .auto-style43 {
            height: 18px;
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <asp:Label ID="Label14" runat="server" CssClass="auto-style34" Text="Art Club Pen Order Form"></asp:Label>
            <br />
            <br />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style32">
                        <asp:Label ID="Label15" runat="server" Text="First Name:"></asp:Label>
                    </td>
                    <td class="auto-style27">
                        <asp:TextBox ID="Firstttxt" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style26">
                        <asp:Label ID="Label19" runat="server" Text="Last Name:"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="Lasttxt" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Lasttxt" ErrorMessage="Required!"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style42">
                        <asp:Label ID="Label16" runat="server" Text="Phone Number:"></asp:Label>
                    </td>
                    <td class="auto-style28">
                        <asp:TextBox ID="Numbertxt" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style24">
                        <asp:Label ID="Label20" runat="server" Text="Email Address:"></asp:Label>
                    </td>
                    <td class="auto-style22">
                        <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailTextBox" ErrorMessage="Invalid email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style33">
                        <asp:Label ID="Label17" runat="server" Text="Pen Selection for orders:"></asp:Label>
                    </td>
                    <td class="auto-style30" colspan="3">
                        <asp:Button ID="Placebtn" runat="server" OnClick="Placebtn_Click" Text="Place order" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style35">
                        <asp:Label ID="Label18" runat="server" Text="Colours:"></asp:Label>
                    </td>
                    <td class="auto-style36">
                        <asp:DropDownList ID="DropDownList" runat="server" Height="28px" Width="103px">
                            <asp:ListItem>Red</asp:ListItem>
                            <asp:ListItem>Black</asp:ListItem>
                            <asp:ListItem>Blue</asp:ListItem>
                            <asp:ListItem>Rainbow</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style37">
                        <asp:Label ID="Label21" runat="server" Text="Amount:"></asp:Label>
                    </td>
                    <td class="auto-style38">
                        <asp:TextBox ID="Amounttxt" runat="server" Width="74px"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Amounttxt" ErrorMessage="Amount not valid" MaximumValue="101" MinimumValue="9" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style39" colspan="4">
                        <asp:Label ID="Resultlbl" runat="server" Text="[Result]"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style40" colspan="4">
                        <asp:Label ID="Amountlbl" runat="server" Text="[Amount]"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style41" colspan="4">
                        <asp:Label ID="Taxlbl" runat="server" Text="[Tax]"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style43" colspan="4">
                        <asp:Label ID="Totallb" runat="server" Text="[Total]"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

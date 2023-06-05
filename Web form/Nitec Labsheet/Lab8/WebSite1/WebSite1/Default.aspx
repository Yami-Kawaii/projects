<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 112px;
            text-decoration: underline;
        }
        .auto-style4 {
            width: 112px;
        }
        .auto-style5 {
            width: 112px;
            height: 23px;
        }
        .auto-style6 {
            margin-right: 0px;
        }
        .auto-style7 {
            height: 23px;
            width: 162px;
        }
        .auto-style8 {
            width: 162px;
        }
        .auto-style9 {
            width: 112px;
            height: 22px;
        }
        .auto-style10 {
            width: 162px;
            height: 22px;
        }
        .auto-style11 {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Ordering Form</td>
                <td class="auto-style7"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style4">Main Course:</td>
                <td class="auto-style8">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Chicken Chop ($5.00)</asp:ListItem>
                        <asp:ListItem>Balls ($4.00)</asp:ListItem>
                        <asp:ListItem>Spaghetti ($4.50)</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Side Dish</td>
                <td class="auto-style8">
                    <asp:ListBox ID="ListBox1" runat="server" CssClass="auto-style6" Height="46px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
                        <asp:ListItem>Salad ($2.00)</asp:ListItem>
                        <asp:ListItem>Fries ($1.50)</asp:ListItem>
                    </asp:ListBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Dessert:</td>
                <td class="auto-style8">
                    <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Ice-Cream($1.20)" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Cake ($1.80)" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Drink:</td>
                <td class="auto-style8">
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Orange Juice ($1.00)" />
                </td>
                <td>
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="Apple Juice ($1.30)" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Drink Quantity:</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">Total Price:</td>
                <td class="auto-style10">
                    <asp:Label ID="lblTotal" runat="server"></asp:Label>
                </td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style4">Tax:</td>
                <td class="auto-style8">
                    <asp:Label ID="lblTax" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Grand Total Price:</td>
                <td class="auto-style7">
                    <asp:Label ID="lblGrand" runat="server"></asp:Label>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                </td>
                <td class="auto-style7">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Clear" />
                </td>
                <td class="auto-style2"></td>
            </tr>
        </table>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 257px;
            margin-bottom: 0px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style7 {
            width: 184px;
            height: 32px;
        }
        .auto-style8 {
            height: 23px;
            width: 184px;
        }
        .auto-style9 {
            height: 23px;
            width: 116px;
        }
        .auto-style10 {
            width: 116px;
            height: 32px;
        }
        .auto-style11 {
            height: 23px;
            width: 184px;
            text-align: center;
        }
        .auto-style12 {
            height: 32px;
        }
        .auto-style13 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td id="lbl_name" class="auto-style9">Name</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td id="lbl_class" class="auto-style10">Class</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txt_class" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td id="lbl_feedback" class="auto-style9">Feedback Rating</td>
                <td class="auto-style8">
                    <asp:DropDownList ID="DropDownList1" runat="server" style="height: 22px; width: 101px">
                        <asp:ListItem>A - Excellent</asp:ListItem>
                        <asp:ListItem>B - Good</asp:ListItem>
                        <asp:ListItem>C - Average</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td id="lbl_year" class="auto-style9">Year of Study</td>
                <td class="auto-style11">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" Height="16px" RepeatDirection="Horizontal" Width="225px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                        <asp:ListItem>1st Year</asp:ListItem>
                        <asp:ListItem>2nd Year</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="I would like to register my intrest on this interest group" OnCheckedChanged="CheckBox2_CheckedChanged" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="3">
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="I will recommend this interest group to my friend" />
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Button ID="Submit" runat="server" Text="Submit Feedback" Width="114px" OnClick="Submit_Click" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Cancel" runat="server" Text="Cancel" OnClick="Cancel_Click" />
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style12" colspan="3">
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3" class="auto-style13">
                    <asp:Label ID="lblResult2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

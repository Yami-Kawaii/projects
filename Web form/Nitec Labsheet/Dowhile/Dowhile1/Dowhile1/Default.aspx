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
            height: 11px;
        }
        .auto-style3 {
            height: 11px;
            width: 202px;
            text-align: left;
        }
        .auto-style4 {
            width: 202px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:ListBox ID="ListBox1" runat="server" Height="16px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Visible="False" Width="192px"></asp:ListBox>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generate 1 to 10" Width="162px" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Generate 10 to 1" Width="162px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Generate 10 to 1 but even" Width="162px" />
                    </td>
                    <td>
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Generate 12 to 1" Width="162px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

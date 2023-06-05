<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <div>
        <br />
        <p style="font-size: xx-large; color: floralwhite">
            <span style="color: #333333; text-decoration: underline;">
                <em>Order</em></span>
        </p>
        <table class="nav-justified" style="height: 2065px">
            <tr>
                <td style="width: 2282px; height: 605px;">
                    <img src="/image/1.jpg" width="400" height="500" class="shadow" /><br />
                    <asp:Label ID="AirJordan" runat="server" Text="Air Jordan 1"></asp:Label>
                    <br />
                    $219.00<br />
                    <p>
                        Quantity:
                        <asp:TextBox ID="Jord" runat="server" Height="22px" Width="128px"></asp:TextBox>
                    </p>
                    <asp:Button ID="aJord" runat="server" OnClick="Button1_Click" Text="Add to Cart" />
                    <br />
                </td>
                <td style="height: 605px;">
                    <img src="/image/2.jpg" width="400" class="shadow" /><br />
                    <asp:Label ID="AirMax" runat="server" Text="Air Max 90"></asp:Label>
                    <br />
                    $219.00<br />
                    <p>
                        Quantity:
                        <asp:TextBox ID="Max" runat="server"></asp:TextBox>
                    </p>
                    <div>
                        <asp:Button ID="aMax" runat="server" OnClick="Button2_Click" Text="Add to Cart" />
                    </div>
                </td>
            </tr>
            <tr>
                <td style="width: 2282px; height: 486px;">
                    <img src="/image/3.jpg" width="400" class="shadow" /><br />
                    <asp:Label ID="AirZoom" runat="server" Text="Nike Air Zoom Pegasus 388"></asp:Label>
                    <br />
                    $199.00<br />
                    <p>
                        Quantity:
                        <asp:TextBox ID="Zoom" runat="server"></asp:TextBox>
                    </p>
                    <div>
                        <asp:Button ID="aZoom" runat="server" OnClick="Button3_Click" Text="Add to Cart" />
                    </div>
                </td>
                <td style="height: 486px; ">
                    <img src="/image/4.jpg" width="400" class="shadow" /><br />
                    <asp:Label ID="AirLeBron" runat="server" Text="Air LeBron 19"></asp:Label>
                    <br />
                    $279.00<br />
                    <p>
                        Quantity:
                        <asp:TextBox ID="LeBron" runat="server"></asp:TextBox>
                    </p>
                    <div>
                        <asp:Button ID="aLeBron" runat="server" OnClick="Button4_Click" Text="Add to Cart" />
                    </div>
                </td>
                <td class="text-center" rowspan="2"></td>
            </tr>
            <tr>
                <td colspan="2" style="height: 486px">
                    <div class="rect1 shadow" runat="server" id="rect1" style="width: 939px; height: 469px">
                        <br />
                        <em>
                            <asp:Label ID="Label2" runat="server" Style="font-size: xx-large; text-decoration: underline;" Text="Shipping Details"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <span style="font-size: xx-large"><span style="text-decoration: underline">Delivery </span></span></em>
                        <span style="font-size: xx-large; text-decoration: underline;"><em>Option</em></span><br />
                        <table class="nav-justified">
                            <tr>
                                <td style="width: 447px">
                                    <em>&nbsp;<br />
                                        Name:<br />
                                        <asp:TextBox ID="name" runat="server" Height="18px" Width="300px" Style="margin-left: 0px"></asp:TextBox>
                                        &nbsp;<br />
                                        <asp:RequiredFieldValidator ID="vldName" runat="server" ControlToValidate="name" ErrorMessage="*enter your name." Style="color: #FF0000"></asp:RequiredFieldValidator>
                                        <br />
                                        Email:<br />
                                        <asp:TextBox ID="email" runat="server" Height="18px" Width="300px" Style="margin-left: 0px"></asp:TextBox>
                                        &nbsp;<br />
                                        <strong>
                                            <asp:CheckBox ID="tickNoti" runat="server" Text="enable notifcation for updates." />
                                        </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                                        <asp:RegularExpressionValidator ID="vldMail" runat="server" ControlToValidate="email" ErrorMessage="*enter a valid email." ValidationExpression=".+@.+" Style="color: #FF0000"></asp:RegularExpressionValidator>
                                        <br />
                                    Confirm
                                        Email:<br />
                                        <asp:TextBox ID="email0" runat="server" Height="18px" Width="300px" Style="margin-left: 0px"></asp:TextBox>
                                        &nbsp;<br />
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="email" ControlToValidate="email0" ErrorMessage="*email are not matching." style="color: #FF0000"></asp:CompareValidator>
                                    <br />
                                    Contact number:<br />
                                        <asp:TextBox ID="contact" runat="server" Height="18px" Width="300px" Style="margin-left: 0px"></asp:TextBox>
                                        <br />
                                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="contact" EnableClientScript="False" ErrorMessage="*enter a valid phone number." ForeColor="Red" MaximumValue="99999999" MinimumValue="10000000"></asp:RangeValidator>
                                        <br />
                                        Address:<br />
                                        <asp:TextBox ID="addy" runat="server" Height="18px" Width="300px" Style="margin-left: 0px"></asp:TextBox>
                                        &nbsp;<br />
                                        <asp:RequiredFieldValidator ID="vldAddy" runat="server" ControlToValidate="addy" ErrorMessage="*enter your address" Style="color: #FF0000"></asp:RequiredFieldValidator>
                                        <br />
                                        <br />
                                        <br />
                                    </em>
                                    <br />
                                    &nbsp;&nbsp;&nbsp;
                    <br />
                                </td>
                                <td>
                                    R<em>egion:<br />
                                        <asp:DropDownList ID="region" runat="server" Height="30px" Width="120px">
                                            <asp:ListItem>West</asp:ListItem>
                                            <asp:ListItem>East</asp:ListItem>
                                            <asp:ListItem>North</asp:ListItem>
                                            <asp:ListItem>South</asp:ListItem>
                                            <asp:ListItem>Central</asp:ListItem>
                                        </asp:DropDownList>
                                        <br />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="region" ErrorMessage="*select a region." style="color: #FF0000"></asp:RequiredFieldValidator>
                                        <br />
                                        Delivery Day:<br />
                                        <asp:ListBox ID="dday" runat="server" Height="25px" Width="130px">
                                            <asp:ListItem>Monday</asp:ListItem>
                                            <asp:ListItem>Tuesday</asp:ListItem>
                                            <asp:ListItem>Wednesday</asp:ListItem>
                                            <asp:ListItem>Thursday</asp:ListItem>
                                            <asp:ListItem>Friday</asp:ListItem>
                                            <asp:ListItem>Saturday</asp:ListItem>
                                            <asp:ListItem>Sunday</asp:ListItem>
                                        </asp:ListBox>
                                        <br />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="dday" ErrorMessage="*select a delivery day." style="color: #FF0000"></asp:RequiredFieldValidator>
                                        <br />
                                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                            <asp:ListItem>Standard Shipping (+$0.00)</asp:ListItem>
                                            <asp:ListItem>Express Shipping (+$1.00)</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </em>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="*Select an option" Style="color: #FF0000"></asp:RequiredFieldValidator>
                                    <br />
                                    <asp:Button ID="save" runat="server" Text="Save" Width="185px" OnClick="save_Click" />
                                    <br />
                                    <br />
                                    <br />
                                </td>
                            </tr>
                        </table>
                        <br />
                    </div>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 486px">
                    <div class="rect1 shadow" runat="server" id="Div1" style="width: 939px; height: 443px">
                        <br />
                        <em>
                        <asp:Label ID="Label3" runat="server" Style="font-size: xx-large; text-decoration: underline;" Text="Checkout"></asp:Label>
                        </em>
                        <br />
                        <br />
                        <table class="nav-justified">
                            <tr>
                                <td>
                                    <asp:Label ID="sohai" runat="server"></asp:Label>
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <asp:Label ID="total" runat="server" Text="Total: $0"></asp:Label>
                                    <br />
                                    <asp:Label ID="GST" runat="server" Text="GST (7%): $0 "></asp:Label>
                                    <br />
                                    <asp:Label ID="shipping" runat="server" Text="Shipping Fees: $0.00"></asp:Label>
                                    <br />
                                    <asp:Label ID="grand" runat="server" Text="Grand Total: $0.00"></asp:Label>
                                    <br />
                                    <br />
                                    <asp:Label ID="prompt" runat="server"></asp:Label>
                                    <br />
                                    <asp:Button ID="Button1" runat="server" Text="Purchase" Width="90px" OnClick="purchase_Click" />
                                    &nbsp;<asp:Button ID="Button2" runat="server" Text="Clear" Width="90px" OnClick="clear_Click" Style="height: 26px" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
                <td class="text-center rect1 shadow">
                    <br />
                    <span style="font-size: xx-large; text-decoration: underline;"><em>Summary</em></span><br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="lblName" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="lblAddy" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="lblMail" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="lblNotis" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="lblRegion" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="lblDday" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="lblShip" runat="server"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>


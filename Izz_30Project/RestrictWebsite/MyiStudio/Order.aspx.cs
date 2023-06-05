using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Order : System.Web.UI.Page
{
    public static double Total = 0;
    public static double Grand = 0;
    public static double Ship = 0;
    public static int width = 400;
    public static bool flag = false;

    public static string[] product = { "Air Jordan 1", "Air Max 90", "Nike Air Zoom Pegasus 388", "Air LeBron 19" };
    public static double[] productTot = { 0, 0, 0, 0 };
    public static int[] productQuant = { 0, 0, 0, 0 };

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void clear_Click(object sender, EventArgs e)
    {
        Jord.Text = "";
        Max.Text = "";
        Zoom.Text = "";
        LeBron.Text = "";
        total.Text = "Total: $0";
        prompt.Text = "";
        GST.Text = "GST (7%): $0";
        shipping.Text = "Shipping Fees: $0.00";
        grand.Text = "Grand Total: $0.00";
        Total = 0;
        Grand = 0;
        Ship = 0;
        flag = false;
        width = 400;
        Array.Clear(productTot, 0, productTot.Length);
        Array.Clear(productQuant, 0, productQuant.Length);
        sohai.Text = "";
        rect1.Attributes.CssStyle.Add("height", "400px");
    }

    public void function(string Model, string shoe, double price)
    {
        try
        {
            sohai.Text = "";
            Total += price * Convert.ToDouble(shoe);
            total.Text = $"Total: ${Total}.00";
            prompt.Text = "";
            GST.Text = $"GST (7%): ${Total * 0.07}";

            int index = Array.IndexOf(product, Model);
            productTot[index] = Total;
            productQuant[index] += Convert.ToInt32(shoe);
            for (int i = 0; i < product.Length; i++)
            {
                if (productQuant[i] > 0 && productTot[i] > 0)
                {
                    width += 75;
                    rect1.Attributes.CssStyle.Add("height",$"{width}px");
                    sohai.Text += $"<div class=rect3 style=height:100px><table class=nav-justified> <tr> <td style=width:110px> <img src =/image/{i+1}.jpg width=100px></td> <td> <b>{product[i]}</b><br/> Qty:{productQuant[i]} <br/> Subtotal:${productTot[i]} <br/> </td> </tr > </table> </div>";
                }
            }
            if (RadioButtonList1.SelectedIndex == 0)
            {
                Ship = 0.00;
                shipping.Text = $"Shipping Fees: $0.00";
                Grand = Total + (Total * 0.07);
            }
            if (RadioButtonList1.SelectedIndex == 1)
            {
                Ship = 1.00;
                shipping.Text = $"Shipping Fees: $1.00";
                Grand = Total + (Total * 0.07) + 1.00;
            }
            grand.Text = $"Grand Total: ${Total + (Total * 0.07) + Ship}";
        }
        catch (Exception)
        {
            prompt.Text = "Please enter a valid input.";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        function(AirJordan.Text, Jord.Text, 219.00);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        function(AirMax.Text, Max.Text, 219.00);
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        function(AirZoom.Text, Zoom.Text, 199.00);
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        function(AirLeBron.Text, LeBron.Text, 279.00);
    }

    protected void purchase_Click(object sender, EventArgs e)
    {
        if (flag == false)
        {
            if (Total > 0)
            {
                if (RadioButtonList1.SelectedIndex == 0)
                {
                    prompt.Text = $"Dear {name.Text}, the total cost is ${Grand} with Standard Shipping. An Invoice to {email.Text} has been send. Thank you shopping with us.";
                }
                else if (RadioButtonList1.SelectedIndex == 1)
                {
                    prompt.Text = $"Dear {name.Text}, the total cost is ${Grand} with Express Shipping. An Invoice to {email.Text} has been send. Thank you shopping with us.";
                }
                flag = true;
            }
            else
            {
                prompt.Text = "Add an item to the Cart.";
            }
        }
        else
        {
            prompt.Text = "You have already purchased your items. If you wish to shop for more, click on the Clear button.";
        }
    }

    protected void notfication_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void save_Click(object sender, EventArgs e)
    {
        lblAddy.Text = $"Address: {addy.Text}";
        lblDday.Text = $"Delivery Day: {dday.SelectedItem}";
        lblMail.Text = $"Email: {email.Text}";
        lblName.Text = $"Name: {name.Text}";
        if (tickNoti.Checked)
        {
            lblNotis.Text = "Notification enabled: Yes";
        }
        else
        {
            lblNotis.Text = "Notification enabled: No";
        }
        lblRegion.Text = $"Reigion: {region.SelectedItem}";
        if (RadioButtonList1.SelectedIndex == 0)
        {
            lblShip.Text = "Expedited shipping: Express";
        }
        else
        {
            lblShip.Text = "Expedited shipping: Standard";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double total = 0;
        double tax = 0;
        double grand = 0;
        double drinks = 0;

        if (DropDownList1.SelectedIndex == 0)
        {
            total += 5;
        }
        else if (DropDownList1.SelectedIndex == 1)
        {
            total += 4;
        }
        else
        {
            total += 4.5;
        }

        if (ListBox1.SelectedIndex == 0)
        {
            total += 1.2;
        }
        if (ListBox1.SelectedIndex == 1)
        {
            total += 1.8;
        }

        if (CheckBox1.Checked)
        {
            total += 1.2;
        }
        if (CheckBox2.Checked)
        {
            total += 1.8;
        }

        if (RadioButton1.Checked)
        {
            drinks += 1;
        }
        if (RadioButton2.Checked)
        {
            drinks += 1.3;
        }
        total += Convert.ToInt32(TextBox1.Text) * drinks; 

        tax = 0.1 * total;
        grand = total + tax;
        lblTotal.Text = $"${total.ToString("0.00")}";
        lblTax.Text = $"${Convert.ToString(tax)}";
        lblGrand.Text = $"${Convert.ToString(grand)}";
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        lblTotal.Text = "";
        lblTax.Text = "";
        lblGrand.Text = "";
        TextBox1.Text = "";
        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        CheckBox1.Checked = false;
        CheckBox2.Checked = false;

    }
}
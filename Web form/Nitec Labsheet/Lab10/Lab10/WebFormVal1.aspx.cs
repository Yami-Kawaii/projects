using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebFormVal1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (Page.IsValid)
        {
            Label1.Text = "This is a valid form";
           
        }
        else
        {
            Label1.Text = "This is not a valid form";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Label1.Text = "";
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";

        RegularExpressionValidator1.ErrorMessage = "";
        RequiredFieldValidator1.ErrorMessage = "";
        RequiredFieldValidator2.ErrorMessage = "";
        CompareValidator1.ErrorMessage = "";
        RangeValidator1.ErrorMessage = "";
    }
}
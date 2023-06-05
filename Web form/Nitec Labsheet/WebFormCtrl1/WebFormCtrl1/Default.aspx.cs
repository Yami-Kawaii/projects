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

    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void Cancel_Click(object sender, EventArgs e)
    {
        lblResult2.Text = "";
        lblResult.Text = "";
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        lblResult.Text = $"Hello {txt_name.Text}. You are from {txt_class.Text}. Goodbye.";
        lblResult2.Text = $"Hello {txt_name.Text}<br>You are from {txt_class.Text}.<br>Goodbye.";
    }
}
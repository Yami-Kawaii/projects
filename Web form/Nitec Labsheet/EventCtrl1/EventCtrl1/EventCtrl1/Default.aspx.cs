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

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label4.Text = "Your name is " + TextBox1.Text + "." + "Your class is "  + TextBox2.Text;
        Label5.Text = "Your hobbies: ";
        if (CheckBox1.Checked == true)
        { Label5.Text = Label5.Text + " " + CheckBox1.Text; }
        if (CheckBox2.Checked == true)
        { Label5.Text = Label5.Text + " " + CheckBox2.Text; }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        Label4.Text = "";
        Label5.Text = "";
        CheckBox1.Checked = false;
        CheckBox2.Checked = false;
    }
}
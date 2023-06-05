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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        long add1;
        long add2;
        long sum1;
        add2 = Convert.ToInt64(TextBox2.Text);
        add1 = Convert.ToInt64(TextBox1.Text);
        sum1 = add1 + add2;
        Label1.Text = Convert.ToString(sum1);
    }

    protected void Button2_Click1(object sender, EventArgs e)
    {
        long add1;
        long add2;
        long sum1;
        add2 = Convert.ToInt64(TextBox2.Text);
        add1 = Convert.ToInt64(TextBox1.Text);
        sum1 = add1 * add2;
        Label1.Text = Convert.ToString(sum1);
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        long add1;
        long add2;
        long sum1;
        add2 = Convert.ToInt64(TextBox2.Text);
        add1 = Convert.ToInt64(TextBox1.Text);
        sum1 = add1 / add2;
        Label1.Text = Convert.ToString(sum1);
    }
}
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

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        int total = 0;
        int[] number = new int[5];
        number[0] = Convert.ToInt32(TextBox1.Text);
        number[1] = Convert.ToInt32(TextBox2.Text);
        number[2] = Convert.ToInt32(TextBox3.Text);
        number[3] = Convert.ToInt32(TextBox4.Text);
        number[4] = Convert.ToInt32(TextBox5.Text);

        for (int i=0; i<5; i++)
        {
            total = total + number[i];
        }

        Label1.Text = Convert.ToString(total);
    }
}
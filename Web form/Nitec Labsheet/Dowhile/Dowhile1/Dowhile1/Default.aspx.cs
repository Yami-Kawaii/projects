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

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        for (int i = 1; i <= 10; i++)
        {
            String str = Convert.ToString(i);
            ListBox1.Items.Add(str);
        }
        ListBox1.Height = 228;
        ListBox1.Width = 192;
        ListBox1.Visible = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        for (int i = 10; i > 0; i--)
        {
            String str = Convert.ToString(i);
            ListBox1.Items.Add(str);
        }
        ListBox1.Height = 228;
        ListBox1.Width = 192;
        ListBox1.Visible = true;
    }



    protected void Button3_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        for (int i = 10; i > 0; i--)
        {
            if (i % 2 == 0)
            {
                String str = Convert.ToString(i);
                ListBox1.Items.Add(str);
            }
        }
        ListBox1.Height = 228;
        ListBox1.Width = 192;
        ListBox1.Visible = true;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        for (int i = 12; i > 0; i--)
        {
            if (i % 2 == 0)
            {
                String str = Convert.ToString(i);
                ListBox1.Items.Add(str);
            }
        }
        ListBox1.Height = 228;
        ListBox1.Width = 192;
        ListBox1.Visible = true;
    }
}
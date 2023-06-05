using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        double v = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            if (textBox1.Text.Contains('√'))
            {
                string save = textBox1.Text.Remove(0, 1);
                v = Math.Sqrt(Convert.ToDouble(dt.Compute(save, "")));
                textBox1.Text += $"={v}";

            }
            else
            {
                var v = Convert.ToDouble(dt.Compute(textBox1.Text, ""));
                textBox1.Text += $"={v}";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            textBox1.Text += "%";
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            textBox1.Text = "√"+ textBox1.Text;
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}

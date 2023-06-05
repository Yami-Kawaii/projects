using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AscendingOrd
{
    public partial class Form1 : Form
    {
        int i = 1;
        int[] list = new int[5];
        bool state = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            list[i - 1] = Convert.ToInt32(textBox1.Text);

            if (i >= 5)
            {
                for (int z = 0; z < list.Length; z++)
                {
                    if (list[z] != list[list.Length - 1])
                    {
                        if (list[z] > list[z+1])
                        {
                            state = true;
                        }
                    }
                    else
                    {
                        if (list[z] < list[z - 1])
                        {
                            state = true;
                        }
                    }
                }

                {
                    MessageBox.Show("Wrong");
                }

                else
                {
                    MessageBox.Show("Correct");
                }
                System.Environment.Exit(1);
            }
            else
            {
                list[i - 1] = Convert.ToInt32(textBox1.Text);
            }
            i++;
            label1.Text = $"Enter your #{i}: ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

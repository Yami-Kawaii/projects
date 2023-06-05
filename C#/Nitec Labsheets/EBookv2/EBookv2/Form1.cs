using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookv2
{
    public partial class Form1 : Form
    {
        Ebook[] myLib = new Ebook[2];

        public Form1()
        {
            InitializeComponent();
            myLib[0] = new Ebook("Harry Potter", 500, 1, "Available");
            myLib[1] = new Ebook("The Lord of the Rings", 899, 20, "Available");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (var i in myLib) {
                if (textBox1.Text.ToLower() == i.Title.ToLower())
                {
                    label8.Text = "";

                    label2.Text = "Title";
                    label4.Text = "Number of Pages";
                    label6.Text = "Current Pages";
                    label9.Text = $"Status";

                    label3.Text = $"{i.Title}";
                    label5.Text = $"{i.noPage}";
                    label7.Text = $"{i.cPage}";
                    label10.Text = $"{i.Status}";
                    MessageBox.Show($"{textBox1.Text} is found");
                    break;
                }
                else if (myLib[myLib.Length - 1] == i && textBox1.Text.ToLower() != i.Title.ToLower())
                {
                    MessageBox.Show($"{textBox1.Text} is not found");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = "Enter a Book Title";

            label2.Text = "";
            label4.Text = "";
            label6.Text = "";

            label3.Text = "";
            label5.Text = "";
            label7.Text = "";
            label9.Text = "";
            label10.Text = "";

            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                foreach (var i in myLib)
                {
                    if (i.Title.ToLower() == textBox1.Text.ToLower() && i.Status == "Available")
                    {
                        i.Status = "On-Loan";
                        MessageBox.Show($"Loaning {i.Title}");
                        break;
                    }
                    else if(i.Title.ToLower() == textBox1.Text.ToLower() && i.Status == "On-Loan")
                    {
                        MessageBox.Show($"{textBox1.Text} can't be loan.");
                        break;
                    }
                    else if (myLib[myLib.Length - 1] == i && textBox1.Text.ToLower() != i.Title.ToLower())
                    {
                        MessageBox.Show($"{textBox1.Text} cannot be found");
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {

        int counter = 0;

        public static bool validateUser(string userID, string password)
        {
            string username = "Monday";
            string pwd = "H0meWork1";
            {
                if (username == userID && pwd == password)
                {
 
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter >= 3)
            {
                MessageBox.Show("You have exceeded the maximum attempt");

            }
            else if (validateUser(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show($"Welcome, {textBox1.Text}");
            }
            else if (validateUser(textBox1.Text, textBox2.Text) == false)
            {
                MessageBox.Show("Invalid User - Try again");
            }
            counter++;
        }
    }
}

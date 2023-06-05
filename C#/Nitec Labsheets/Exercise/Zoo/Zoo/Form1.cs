using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class Form1 : Form
    {
        Zoo[] zy = new Zoo[99];
        int counter = 2;
        string kuy = "";
        public Form1()
        {
            zy[0] = new Zoo("Ants", 12, 112);
            zy[1] = new Zoo("Quadro", 31, 41);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zy[counter] = new Zoo(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            MessageBox.Show($"{zy[counter].Name} was added to the list.");
            counter++;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int _ = Convert.ToInt32(textBox4.Text);
                kuy = zy[_].Name;
                zy = zy.Where((source, index) => index != _).ToArray();
                MessageBox.Show($"{kuy}, index {_}, has been removed from the list.");
                counter--;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input..");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}

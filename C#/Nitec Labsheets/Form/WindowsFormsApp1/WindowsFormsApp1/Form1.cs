using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem.ToString() == "Yes")
            {
                MessageBox.Show("Bring umbrella.");
            }
            else if (comboBox.SelectedItem.ToString() == "No")
            {
                MessageBox.Show("Don't bring umbrella.");

            }
            else
            {
                MessageBox.Show("Please enter a valid input...");
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

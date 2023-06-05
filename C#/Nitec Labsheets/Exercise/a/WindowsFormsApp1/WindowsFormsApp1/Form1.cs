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
        string error = "";
        string gender = "";
        string devices = "";
        string tution = "";
        string religion = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text.Any(char.IsDigit))
            {
                error += "\nName";
            }
            if (textBox2.Text == "" || textBox2.Text.Any(char.IsLetter))
            {
                error+="\nAge";
            }
            if (comboBox1.Text == "")
            {
                error += "\nClass";
            }
            if (comboBox2.Text == "")
            {
                comboBox2.Text = "No";
            }

            if (radioButton1.Checked)
            {
                gender = "Female";
            }
            if (radioButton2.Checked)
            {
                gender = "Male";
            }
            if (!(radioButton1.Checked || radioButton2.Checked))
            {
                error += "\nGender";
            }

            if (textBox3.Text == "") {
                religion = "No";
            }
            else
            {
                religion = textBox3.Text;
            }

            devices = "";
            if (checkBox1.Checked)
            {
                devices += $"\t\t{checkBox1.Text}\n";
            }
            if (checkBox2.Checked)
            {
                devices += $"\t\t{checkBox2.Text}\n";
            }
            if (checkBox3.Checked)
            {
                devices += $"\t\t{checkBox3.Text}\n";
            }
            if (!(checkBox1.Checked || checkBox2.Checked || checkBox3.Checked))
            {
                devices = "\t\tNo\n";
            }

            tution = "";
            if (listBox3.Text == "")
            {
                tution = "No";
            }
            else
            {
                foreach (var item in listBox3.SelectedItems)
                {
                    tution += $"\t\t{item.ToString()}\n";
                }
            }
            if (error != "")
            {
                MessageBox.Show($"Please enter a valid: \n{error}");
                error = "";
            }
            else
            {
                MessageBox.Show($"Name: {textBox1.Text}\tAge: {textBox2.Text}\nClass: {comboBox1.Text}\tVaccinated: {comboBox2.Text}\nGender: {gender}\tReligion: {religion}\n\nDevices:{devices}\nLessons:{tution}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            comboBox1.Text = "";
            comboBox2.Text = "";
            listBox3.ClearSelected();


        }
    }
}

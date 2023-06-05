using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redo_Lab10
{
    public partial class formDataEntry : Form
    {
        public formDataEntry()
        {
            InitializeComponent();
        }

        private void formDataEntry_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            {
                String name = textBoxName.Text + "\n";
                String cardApplication = String.Empty;
                if (checkBoxCreditCard.Checked)
                {
                    cardApplication += checkBoxCreditCard.Text + "\n";
                }
                if (checkBoxDebitCard.Checked)
                {
                    cardApplication += checkBoxDebitCard.Text + "\n";
                }

                string status = comboBoxStatus.SelectedItem.ToString();
                String gender = String.Empty;

                if (radioButtonMale.Checked)
                {
                    gender = radioButtonMale.Text + "\n";
                }

                else
                {
                    gender = radioButtonFemale.Text + "\n";
                }
                string qualification = String.Empty;
                foreach (string selectedQualification in listBoxQualification.SelectedItems)
                {
                    qualification += selectedQualification + "\n";
                }
                String data = name + cardApplication + status + gender + qualification;
                MessageBox.Show(data);
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
            }
            else if (!Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Are you sure your name has number ?");
            }
        }
    }
}

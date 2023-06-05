using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project30_Izz
{
    public partial class account : Form
    {
        string message = "Are you sure you want to change your password?";
        string title = "Change password";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

        public account()
        {

            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            page x = new page();
            x.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == Info.getPassword(login.user[0].Name))
            {
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Info.changePass(login.user[0].Name, txtNewPass.Text);
                    MessageBox.Show("You have successfully change your password!");
                }
            }
            else
            {
                MessageBox.Show("Enter the correct details...");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to change your address?";
            string title = "Change address";
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Info.changeAddy(login.user[0].Name, txtAddy.Text);
                MessageBox.Show("You have successfully change your address!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to change your username?";
            string title = "Change username";
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (login.user[0].Name == txtName.Text)
            {
                MessageBox.Show("You are currently using this name.");
            }
            else if (Info.checkUser(txtName.Text) != txtName.Text)
            {
                MessageBox.Show(Info.checkUser(txtName.Text));
            }
            else
            {
                if (result == DialogResult.Yes)
                {
                    Info.changeName(txtName.Text, login.user[0].Name);
                    login.user[0].Name = txtName.Text;
                    MessageBox.Show("You have successfully change your username!");
                }
            }
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to change your contact?";
            string title = "Change contact";
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Info.changeCont(login.user[0].Name, txtAddy.Text);
                MessageBox.Show("You have successfully change your contact!");
            }
        }

        private void account_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

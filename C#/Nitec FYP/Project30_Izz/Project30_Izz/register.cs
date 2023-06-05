using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Project30_Izz
{
    public partial class register : Form
    {
        string errors = "";
        string gender = "";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Info.s + "\\Database1.mdf;Integrated Security=True");

        public register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Empty Username, Password, Address.
            if (txtUser.Text == "")
            {
                errors += "empty username\n";
            }
            if(Info.checkUser(txtUser.Text) != txtUser.Text)
            {
                errors += "username unavailable\n";
            }
            if (txtPass.Text == "" && txtPass1.Text=="")
            {
                errors += "empty password\n";
            }
            else if (txtPass.Text != txtPass1.Text)
            {
                errors += "same password\n";
            }
            if (txtAddy.Text == "")
            {
                errors += "empty address\n";
            }

            //Empty number, Length of Number.
            try
            {
                if (txtPhone.Text.Length!=8)
                {
                    errors += "invalid phone number\n";
                }
                else
                {
                    Convert.ToInt32(txtPhone.Text);
                }
            }
            catch (Exception)
            {
                errors = "invalid phone number\n";
            }

            //Gender Check
            if (rbFemale.Checked)
            {
                gender = "Female";
            }
            else if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbMale.Checked != true && rbFemale.Checked != true)
            {
                errors += "empty gender";
            }
                if (errors != "")
            {
                MessageBox.Show("Please enter the following correctly:\n" + errors);
                errors = "";
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"insert into userdata values ('{txtUser.Text}','{txtPass.Text}',{txtPhone.Text},'{gender}','{txtAddy.Text}')";
                cmd.ExecuteNonQuery();
                con.Close();

                main x = new main();
                x.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            main x = new main();
            x.Show();
            this.Hide();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPass1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAddy_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}

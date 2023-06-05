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
    public partial class login : Form
    {
        public static Info[] user = new Info[1];
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Info.s + "\\Database1.mdf;Integrated Security=True");

        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == Info.getPassword(txtUser.Text))
            {
                user[0] = new Info(txtUser.Text);
                MessageBox.Show($"Login Successfull!\nWelcome {txtUser.Text}.");
                page x = new page();
                x.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            main x = new main();
            x.Show();
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}

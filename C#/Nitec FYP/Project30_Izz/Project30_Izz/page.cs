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
    public partial class page : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Info.s + "\\Database1.mdf;Integrated Security=True");

        public page()
        {
            InitializeComponent();
            welcome.Text = $"Welcome, {login.user[0].Name}.";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search x = new search();
            x.Show();
            this.Hide();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            account x = new account();
            x.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            main x = new main();
            x.Show();
            this.Hide();
        }

        private void welcome_Click(object sender, EventArgs e)
        {
            
        }

        private void page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

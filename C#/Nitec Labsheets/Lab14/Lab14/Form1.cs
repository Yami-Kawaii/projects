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
namespace Lab14
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Users\65936\Desktop\bak\Projects\C#\Lab14\Lab14\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Customer values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')";

            cmd.ExecuteNonQuery();
            con.Close();

            display_data();
            MessageBox.Show("Record insert successfully!");
        }

        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customer";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            display_data();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Customer where Mobile='"+textBox3.Text+"'";

            cmd.ExecuteNonQuery();
            con.Close();

            display_data();
            MessageBox.Show("Record delete successfully!");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Customer set Mobile='"+textBox4.Text+"' Where Mobile ='"+textBox3.Text+"'";

            cmd.ExecuteNonQuery();
            con.Close();

            display_data();
            MessageBox.Show("Record update successfully!");
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            display_data();
        }
    }
}

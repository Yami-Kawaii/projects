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
    public partial class search : Form
    {
        int uid = Info.getUID(login.user[0].Name);
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Info.s + "\\Database1.mdf;Integrated Security=True");

        public search()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            page x = new page();
            x.Show();
            this.Hide();
        }

        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select ID,Title,available from history";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void search_Load(object sender, EventArgs e)
        {
            if (uid != 1)
            {
                btnInsert.Visible = false;
                btnDelete.Visible = false;
                btnEdit.Visible = false;

                btnInsert.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
            else
            {
                btnInsert.Visible = true;
                btnDelete.Visible = true;
                btnEdit.Visible = true;

                btnInsert.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
            display_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (uid == 1)
                {
                    if (txtID.Text.All(char.IsDigit))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = $"update history set title='{txtItem.Text}' where ID='{txtID.Text}'";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        display_data();
                        MessageBox.Show($"{txtID.Text} has been updated to {txtItem.Text}.");
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid id.");
                    }
                }
                else
                {
                    MessageBox.Show("Warning: Unauthorized User.", "Warning");
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid input");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (uid == 1)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = $"insert into history values('0','{txtItem.Text}','Yes')";
                cmd.ExecuteNonQuery();
                con.Close();
                display_data();
            }
            else
            {
                MessageBox.Show("Warning: Unauthorized User.", "Warning");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (uid == 1)
            {
                string output = "";
                string message = "Are you sure you want to delete your data?";
                string title = "Delete data";
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = $"select * from history where id={txtID.Text}";
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            con.Close();

                            con.Open();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = $"delete from history where id={txtID.Text}";
                            cmd.ExecuteNonQuery();
                            output = "ID has been deleted.";
                            con.Close();
                        }
                    }
                    catch (Exception)
                    {
                        output = "Could not find ID in the table.";
                    }
                    MessageBox.Show(output);
                    con.Close();
                }
                display_data();
            }

            else
            {
                MessageBox.Show("Warning: Unauthorized User.", "Warning");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from history where id='{txtID.Text}' or title='{txtItem.Text}'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    con.Close();

                    con.Open();
                    MessageBox.Show("Data found.");
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Data not found.");
                    con.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input.");
                con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display_data();
            txtID.Clear();
            txtItem.Clear();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from history where title='{txtItem.Text}' and id='{txtID.Text}' and available='Yes'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    con.Close();
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"update history set available='No',UID='{uid}' where title='{txtItem.Text}' and id='{txtID.Text}' and available='Yes'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"{txtItem.Text} has been successfully booked.");
                    con.Close();
                    display_data();
                }
                else if (txtID.Text == String.Empty)
                {
                    MessageBox.Show("Please enter a value.");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Unavailable");
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid id.");
                con.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from history where title='{txtItem.Text}' and id='{txtID.Text}' and available='No'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    con.Close();
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"update history set available='Yes',UID='{uid}' where title='{txtItem.Text}' and id='{txtID.Text}' and available='No'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"{txtItem.Text} has been successfully been returned.");
                    con.Close();
                    display_data();
                }
                else if (txtID.Text == String.Empty)
                {
                    MessageBox.Show("Please enter a value.");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Unavailable");
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid id.");
                con.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from history where uid='{uid}' and available='No'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                con.Close();

                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("You did borrowed any books", "Warning");
            }
        }
    }
}

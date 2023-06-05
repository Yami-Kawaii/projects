using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace Project30_Izz
{
    public class Info
    {
        public static string s = $"{Directory.GetParent($"{Directory.GetParent(Directory.GetCurrentDirectory())}")}";
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + s + "\\Database1.mdf;Integrated Security=True");
        private string name;
        private static string output;

        public Info(string name_)
        {
            this.Name = name_;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public static string getPassword(string user)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from userdata where username='{user}'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                output = Convert.ToString(reader["password"]);
                con.Close();
            }
            else
            {
                output = "HAHAH";
                con.Close();
            }
            return output;
        }

        public static void changePass(string user, string newpass)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update userdata set password='{newpass}' where username='{user}'";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void changeAddy(string user, string addy)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update userdata set address='{addy}' where username='{user}'";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void changeCont(string user, string cont)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update userdata set contact='{cont}' where username='{user}'";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static string checkUser(string user)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from userdata where username='{user}'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                output = $"{user} has been taken.";
                con.Close();
            }
            else
            {
                output = user;
                con.Close();
            }
            return (output);
        }

        public static void changeName(string newuser, string olduser)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update userdata set username='{newuser}' where username='{olduser}'";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static int getUID(string user)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from userdata where username='{user}'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                output = Convert.ToString(reader["uid"]);
                con.Close();
            }
            return (Convert.ToInt32(output));
        }
    }
}

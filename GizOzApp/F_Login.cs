using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace GizOzApp
{
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
        }

        connection conn = new connection();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public static string uName;
        public static string uname
        {
            get { return uName; }
            set { uName = value; }
        }
        public static string pass { get; set; }
        public static string userID;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUsername.Text) &&
                !string.IsNullOrEmpty(tbPassword.Text))
            {
                try
                {
                    NpgsqlConnection Conn = conn.GetCon();
                    Conn.Open();
                    string queryString = @"select * from st_login(:_username, :_password)";
                    NpgsqlCommand command = new NpgsqlCommand(queryString, Conn);

                    command.Parameters.AddWithValue("_username", tbUsername.Text);
                    command.Parameters.AddWithValue("_password", tbPassword.Text);

                    int result = (int)command.ExecuteScalar();
                    if (result == 1)
                    {
                        MessageBox.Show("Login success!");
                        uname = tbUsername.Text;
                        this.Hide();
                        F_Dashboard dash = new F_Dashboard();
                        dash.Show();
                        /*using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //MessageBox.Show(String.Format("{0}, {1}", reader[1], reader[2]));
                                F_Login.uname = reader[0].ToString();
                                F_Login.pass = reader[0].ToString();
                                this.Hide();
                                F_Dashboard dash = new F_Dashboard();
                                dash.Show();
                                Conn.Close();
                            }*/
                    }
                    else
                    {
                        MessageBox.Show("The Username or Password is Incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        tbUsername.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Username or Password field is empty", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            F_RegularUser register = new F_RegularUser();
            register.Show();
            this.Hide();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }
    }
}

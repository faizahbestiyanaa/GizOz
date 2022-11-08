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

        public static string uName { get; set; }
        public static string pass { get; set; }
        public static string userID;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUsername.Text) &&
                !string.IsNullOrEmpty(tbPassword.Text))
            {
                try
                {

                    string queryString = @"select * from tb_users where username = '" + tbUsername.Text + "' AND password = '" + tbPassword.Text + "'";
                    using (NpgsqlConnection Conn = conn.GetCon())
                    {
                        NpgsqlCommand command = new NpgsqlCommand(queryString, Conn);
                        Conn.Open();
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //MessageBox.Show(String.Format("{0}, {1}", reader[1], reader[2]));
                                F_Login.uName = (reader[1]).ToString();
                                F_Login.pass = (reader[2]).ToString();
                                F_Login.userID = reader[0].ToString();
                                this.Hide();
                                F_Dashboard dash = new F_Dashboard();
                                dash.Show();
                            }
                            else
                            {
                                MessageBox.Show("The Username or Password is Incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                tbUsername.Focus();
                            }

                        }
                    }

                    //string query = "SELECT * FROM UserData WHERE Username = '" + tbUsername.Text.Trim() + "' AND Password ='" + tbPassword.Text.Trim() + "'";

                    //SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                    //DataTable UserData = new DataTable();

                    //adapter.Fill(UserData);

                    //if (UserData.Rows.Count > 0)
                    //{
                    //    //MessageBox.Show("Login Successful!");
                    //    this.Hide();
                    //    MainForm mf = new MainForm();
                    //    mf.Show();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("The Username or Password is Incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //    tbUsername.Focus();
                    //}
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

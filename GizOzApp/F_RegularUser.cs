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
    public partial class F_RegularUser : Form
    {
        public F_RegularUser()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        public static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=hujanbadai;Database=gizoz";
        private string sql = null;
        public static NpgsqlCommand cmd;

        public static string uname;
        public string nameprof;

        private void label10_Click(object sender, EventArgs e)
        {
            F_Login log = new F_Login();
            log.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
                tbConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
                tbConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            tbUsername.Focus();
        }

        void Clear()
        {
            tbUsername.Text = tbPassword.Text = tbConfirmPassword.Text = tbName.Text = tbAge.Text = cbGender.Text = tbProfession.Text = "";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
                MessageBox.Show("Username or Password field is empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("The Password does not match, please re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
                tbPassword.Focus();
            }
            else
            {
                try
                {
                    conn = new NpgsqlConnection(connectionString);
                    conn.Open();
                    sql = @"select * from st_insert(:_username, :_password, :_name, :_age, :_gender, :_profession)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_username", tbUsername.Text);
                    cmd.Parameters.AddWithValue("_password", tbPassword.Text);
                    cmd.Parameters.AddWithValue("_name", tbName.Text);
                    cmd.Parameters.AddWithValue("_age", int.Parse(tbAge.Text));
                    cmd.Parameters.AddWithValue("_gender", cbGender.Text);
                    cmd.Parameters.AddWithValue("_profession", tbProfession.Text);


                    Clear();

                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Your account has been successfully created!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error:" + ex.Message, "Register failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }

    }
}

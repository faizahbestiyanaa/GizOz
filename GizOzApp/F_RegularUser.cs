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

        connection Conn = new connection();

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
            tbUsername.Text = tbPassword.Text = tbConfirmPassword.Text = tbName.Text = tbAge.Text = "";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
                MessageBox.Show("Username or Password field is empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            /*else if (tbName.Text == "" || tbAge.Text == "" ||tbGender.Text == ""|| tbProfession.Text == ""||tbAllergy.Text == ""|| tbHeight.Text == "" || tbWeight.Text == "")
                MessageBox.Show("Please complete your data", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            else if (tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("The Password does not match, please re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
                tbPassword.Focus();
            }
            else
            {
                using (NpgsqlConnection conn = Conn.GetCon())
                {
                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = conn;
                    conn.Open();
                    command.CommandText = @"select * from st_insert(:_username, :_password, :_name, :_age, :_gender, :_profession) " +
                    "VALUES(@param1,@param2,@param3,@param4,@param5,@param6)";
                    command.Parameters.AddWithValue("@param1", tbUsername.Text);
                    command.Parameters.AddWithValue("@param2", tbPassword.Text);
                    command.Parameters.AddWithValue("@param3", tbName.Text);
                    command.Parameters.AddWithValue("@param4", tbAge.Text);
                    command.Parameters.AddWithValue("@param5", tbGender.Text);
                    command.Parameters.AddWithValue("@param6", tbProfession.Text);

                    command.ExecuteNonQueryAsync();


                    conn.Close();
                    Clear();

                    //RUN coba
                    //coba username sama name aja

                    MessageBox.Show("Your account has been successfully created!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void F_RegularUser_Load(object sender, EventArgs e)
        {

        }
    }
}

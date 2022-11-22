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
    public partial class F_Profile_Edit : Form
    {
        public F_Profile_Edit()
        {
            InitializeComponent();
        }

        connection sqlconn = new connection();
        F_Profile showData = new F_Profile();

        public void showCurrentData()
        {
            NpgsqlConnection Conn = sqlconn.GetCon();
            string username = F_Login.uname;

            Conn.Open();
            string sql = "Select * from tb_users where username= '" + username + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, Conn);
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    tbNewName.Text = reader[2].ToString();
                    tbNewAge.Text = reader[3].ToString();
                    cbNewGender.Text = reader[4].ToString();
                    tbNewProfession.Text = reader[5].ToString();
                }
            }
            Conn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Profile prof = new F_Profile();
            prof.Show();
        }

        private void F_Profile_Edit_Load(object sender, EventArgs e)
        {
            showCurrentData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbNewName.Text) ||
                string.IsNullOrEmpty(tbNewAge.Text) ||
                string.IsNullOrEmpty(cbNewGender.Text) ||
                string.IsNullOrEmpty(tbNewProfession.Text))
            {
                MessageBox.Show("There is cannot be an empty data");
            }
            else
            {
                {
                    NpgsqlConnection sqlCon = sqlconn.GetCon();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = sqlCon;
                    cmd.CommandText = "UPDATE tb_users SET name = '" + tbNewName.Text + "', age = '" + tbNewAge.Text + "'," +
                        "gender = '" + cbNewGender.Text + "', profession = '" + tbNewProfession.Text + "' WHERE username = '" + F_Login.uname + "'";
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has been successfully updated!");
                    sqlCon.Close();
                }

                this.Close();
                F_Profile prof = new F_Profile();
                prof.Show();
            }
        }
    }
}   

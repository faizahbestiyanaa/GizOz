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
    public partial class F_Profile : Form
    {
        public F_Profile()
        {
            InitializeComponent();
        }

        connection sqlconn = new connection();
        //DataTable dt;
        public void showData()
        {
            NpgsqlConnection Conn = sqlconn.GetCon();
            string username = F_Login.uname;
            lblUser.Text = username;

            Conn.Open();
            string sql = "Select * from tb_users where username= '" + username + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, Conn);
            /*cmd.Parameters.AddWithValue("_username", username);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);

            lblName.Text = dt.Rows[0]["_name"].ToString();
            lblAge.Text = dt.Rows[0]["_age"].ToString();
            lblGender.Text = dt.Rows[0]["_gender"].ToString();
            lblProfession.Text = dt.Rows[0]["_name"].ToString();*/
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    /* if (F_Login.uName == reader[0].ToString() && F_Login.pass == reader[1].ToString())
                     {*/
                    lblName.Text = reader[2].ToString();
                    lblAge.Text = reader[3].ToString();
                    lblGender.Text = reader[4].ToString();
                    lblProfession.Text = reader[5].ToString();
                    //}
                }
            }
            Conn.Close();
        }

        private void F_Profile_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void bt_dashboard_Click(object sender, EventArgs e)
        {
            F_Dashboard dash = new F_Dashboard();
            dash.Show();
            this.Hide();
        }

        private void bt_recommendation_Click(object sender, EventArgs e)
        {
            F_Recommendation rec = new F_Recommendation();
            rec.Show();
            this.Hide();
        }

        private void bt_editprofile_Click(object sender, EventArgs e)
        {
            F_Profile_Edit editprof = new F_Profile_Edit();
            editprof.Show();
            this.Hide();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            F_Logout log = new F_Logout();
            log.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            F_Profile_Edit ed = new F_Profile_Edit();
            ed.Show();
            this.Hide();
        }

    }
}

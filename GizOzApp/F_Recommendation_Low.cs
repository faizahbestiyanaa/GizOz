﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizOzApp
{
    public partial class F_Recommendation_Low : Form
    {
        public F_Recommendation_Low()
        {
            InitializeComponent();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            F_Logout log = new F_Logout();
            log.Show();
            this.Hide();
        }

        private void bt_dashboard_Click(object sender, EventArgs e)
        {
            F_Dashboard dash = new F_Dashboard();
            dash.Show();
            this.Hide();
        }

        private void bt_profile_Click(object sender, EventArgs e)
        {
            F_Profile profile = new F_Profile();
            profile.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F_Recommendation_Medium rec_medium = new F_Recommendation_Medium();
            rec_medium.Show();
            this.Hide();
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            F_Recommendation_High rec_high = new F_Recommendation_High();
            rec_high.Show();
            this.Hide();
        }

        private void F_Recommendation_Low_Load(object sender, EventArgs e)
        {

        }
    }
}

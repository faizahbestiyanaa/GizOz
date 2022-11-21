using System;
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
    public partial class F_Logout : Form
    {
        public F_Logout()
        {
            InitializeComponent();
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

        private void bt_recommendation_Click(object sender, EventArgs e)
        {
            F_Recommendation_Low rec = new F_Recommendation_Low();
            rec.Show();
            this.Hide();
        }

        private void bt_editprofile_Click(object sender, EventArgs e)
        {
            F_Profile_Edit editprof = new F_Profile_Edit();
            editprof.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            F_Login log = new F_Login();
            log.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            F_Dashboard dash = new F_Dashboard();
            dash.Show();
            this.Hide();
        }
    }
}

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
    public partial class F_Recommendation_High : Form
    {
        public F_Recommendation_High()
        {
            InitializeComponent();
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            F_Recommendation_Low rec_low = new F_Recommendation_Low();
            rec_low.Show();
            this.Hide();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            F_Recommendation_Medium rec_medium = new F_Recommendation_Medium();
            rec_medium.Show();
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

        private void bt_logout_Click(object sender, EventArgs e)
        {
            F_Logout log = new F_Logout();
            log.Show();
            this.Hide();
        }
    }
}

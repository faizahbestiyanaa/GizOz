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
    public partial class F_Profile : Form
    {
        public F_Profile()
        {
            InitializeComponent();
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

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}

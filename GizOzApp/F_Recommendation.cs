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
    public partial class F_Recommendation : Form
    {
        public F_Recommendation()
        {
            InitializeComponent();
        }

        private void lblBMI_Click(object sender, EventArgs e)
        {
        }

        private void btnCalcBMI_Click(object sender, EventArgs e)
        {
            double bmi = ((Convert.ToDouble(tbWeight.Text)) / Math.Pow(Convert.ToDouble(tbHeight.Text), 2)) * 10000;
            lblBMI.Text = Convert.ToString(string.Format("{0:F1}", bmi));
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

        private void F_Recommendation_Load(object sender, EventArgs e)
        {

        }

        private void btnShowRecomm_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(lblBMI.Text) < 18.5)
            {
                F_Recommendation_High rechigh = new F_Recommendation_High();
                rechigh.Show();
                this.Hide();
            }
            else if (Convert.ToDouble(lblBMI.Text) >= 18.5 && Convert.ToDouble(lblBMI.Text) <= 23)
            {
                F_Recommendation_Medium recmed = new F_Recommendation_Medium();
                recmed.Show();
                this.Hide();
            }
            else if (Convert.ToDouble(lblBMI.Text) > 23)
            {
                F_Recommendation_Low reclow = new F_Recommendation_Low();
                reclow.Show();
                this.Hide();
            }
        }
    }
}

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
    public partial class F_Dashboard : Form
    {
        public F_Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_recommendation_Click(object sender, EventArgs e)
        {
            F_Recommendation_Low rec = new F_Recommendation_Low();
            rec.Show();
            this.Hide();
        }

        private void bt_profile_Click_1(object sender, EventArgs e)
        {
            F_Profile profile = new F_Profile();
            profile.Show();
            this.Hide();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Logout log = new F_Logout();
            log.Show();
        }

    }
}

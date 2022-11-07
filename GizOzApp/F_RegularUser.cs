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
    public partial class F_RegularUser : Form
    {
        public F_RegularUser()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            F_Login log = new F_Login();
            log.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

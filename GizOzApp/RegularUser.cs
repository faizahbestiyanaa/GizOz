using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GizOzApp
{
    class RegularUser : User
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string profession { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public string allergy { get; set; }

        public RegularUser(string email, string password, bool loginStatus)
        {
            this.Email = email;
            this.Password = password;
            this.LoginStatus = loginStatus;
        }

        public override void register()
        {

        }
        public override void login()
        {

        }

        public void updateProfile()
        {

        }

        public void updateData()
        {

        }
    }
}

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
        protected string profession { get; set; }
        protected double height { get; set; }
        protected double weight { get; set; }
        protected string allergy { get; set; }

        public RegularUser(string email, string password, bool loginStatus)
        {
            this.Email = email;
            this.Password = password;
            this.LoginStatus = loginStatus;
        }

        public void register()
        {

        }
        public void loginn()
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

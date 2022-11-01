using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GizOzApp
{
    class User
    {
        private string _email;
        private string _username;
        private string _password;
        private bool _loginStatus;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public bool LoginStatus
        {
            get { return _loginStatus; }
            set { _loginStatus = value; }
        }

        public bool Login(string Username, string Password)
        {
            if(Username == "GizOzGroup" & Password == "pastibisa")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GizOzApp
{
    public abstract class User
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

        public User() { }

        public User(string userName, string password)
        {
            Username = userName;
            Password = password;
        }
        public abstract void register();
        public bool login()
        {
            if(Username == "GizOzGroup" & Password == "GizOzpastibisa")
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

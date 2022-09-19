using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GizOzApp
{
    public abstract class User
    {
        public string email { get; set; }
        public string password { get; set; }
        public bool loginStatus { get; set; }

        public abstract void register();
        public abstract void login();
    }
}

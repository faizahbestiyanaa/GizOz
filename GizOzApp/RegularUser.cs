using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GizOzApp
{
    class RegularUser : User
    {
        private string username;
        private string name;
        private int age;
        private string gender;
        private string profession;


      

        public string userName
        {
            get { return username; }
            set { username = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public RegularUser( string username  /*string name, int age, string gender, string profession*/ )
        {
            userName = username;
            /*Name = name;
            Age = age;
            Gender = gender;
            Profession = profession;*/ 
            
        }
    }
}

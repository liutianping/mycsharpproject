using System;
using System.Collections.Generic;
using System.Text;

namespace Threetries.model
{
    public class User
    {
        string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        
       
        string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private int _userid;

        public int Userid
        {
            get { return _userid; }
            set { _userid = value; }
        }
    }
}

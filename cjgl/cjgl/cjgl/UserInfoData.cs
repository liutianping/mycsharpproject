using System;
using System.Collections.Generic;
using System.Text;

namespace cjgl
{
    class UserInfoData
    {
        private string _userid = "";

        public string Userid
        {
            get { return _userid; }
            set { _userid = value; }
        }
        private string _userpwd = "";

        public string Userpwd
        {
            get { return _userpwd; }
            set { _userpwd = value; }
        }
        private string _userlevel = "";

        public string Userlevel
        {
            get { return _userlevel; }
            set { _userlevel = value; }
        }
    }
}

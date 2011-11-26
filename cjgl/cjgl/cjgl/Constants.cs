using System;
using System.Collections.Generic;
using System.Text;

namespace cjgl
{
    class Constants
    {

        private static string username = "";

        public static string Username
        {
            get { return Constants.username; }
            set { Constants.username = value; }
        }
        private static string userlevel = "";

        public static string Userlevel
        {
            get { return Constants.userlevel; }
            set { Constants.userlevel = value; }
        }
       
    }
}

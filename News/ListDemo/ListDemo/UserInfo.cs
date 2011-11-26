using System;
using System.Collections.Generic;
using System.Text;

namespace ListDemo
{
    /// /////////////////////
    /// 作者:刘天平 
    /// 时间:2011-4-27
    /// ////////////////////
   public class UserInfo
    {
        private string _userId;//快捷键:ctrl + r,ctrl + e

        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _userPassword;

        public string UserPassword
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }
    }
}

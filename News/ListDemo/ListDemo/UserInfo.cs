using System;
using System.Collections.Generic;
using System.Text;

namespace ListDemo
{
    /// /////////////////////
    /// ����:����ƽ 
    /// ʱ��:2011-4-27
    /// ////////////////////
   public class UserInfo
    {
        private string _userId;//��ݼ�:ctrl + r,ctrl + e

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

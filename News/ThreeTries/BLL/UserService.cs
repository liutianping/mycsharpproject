using System;
using System.Collections.Generic;
using System.Text;
using Threetires.DAO;
using Threetries.model;

namespace Threetires.BLL
{
    public class UserService
    {
        DBHelp db = new DBHelp();
        public bool IsLogin(string username,string password)
        {
            int result = 0;
            if (username.Trim() != null && username.Trim() != "" && password.Trim() != null && password.Trim() != "")
            {
                string strSql = "SELECT COUNT(*) FROM tb_user WEHRE username='" + username + "' and password='" + password + "'";
                result= db.Login(strSql);
            }
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsLogin(User user)
        {
            int result = 0;
            string strSql = "SELECT COUNT(*) FROM tb_user WEHRE username='" + user.Username + "' and password='" + user.Password + "'";
            result = db.Login(strSql);
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsRegister(User user)
        {
            string strSql = "insert into tb_user values('"+user.Userid+"','"+user.Username+"','"+user.Password+"')";
            int result = db.RegisterUser(strSql);
            if (1 == result)
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

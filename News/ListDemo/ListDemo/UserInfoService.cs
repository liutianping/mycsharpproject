using System;
using System.Collections.Generic;
using System.Text;

namespace ListDemo
{
    ////////////////////////////
    //����:����ƽ
    //����޸�ʱ��:2011-4-27
    /// ////////////////////////
    
    public class UserInfoService
    {
        DBHelp db = new DBHelp();
        public List<UserInfo> GetUserInfo()
        {
            return db.GetUserInfo("select * from tb_user");
        }
    }
}

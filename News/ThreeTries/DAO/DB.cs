using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Threetires.DAO
{
    class DB
    {
        SqlCommand cmd;

        ConnectionFacade facade = new ConnectionFacade();



        /// <summary>
        /// ExucuteNonQuery方法 执行增删改语句
        /// </summary>
        /// <param name="strSql">SQL语句，只允许增删改</param>
        /// <returns>返回受影响的行数</returns>
        //public int ExucuteNonQuery(string strSql)
        //{
        //    cmd = new SqlCommand(strSql, facade.GetConn());
        //    int result = cmd.
        //       facade.CloseConn();
        //    cmd.Clone();
        //    return result;
        //}


    }
}

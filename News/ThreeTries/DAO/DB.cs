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
        /// ExucuteNonQuery���� ִ����ɾ�����
        /// </summary>
        /// <param name="strSql">SQL��䣬ֻ������ɾ��</param>
        /// <returns>������Ӱ�������</returns>
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

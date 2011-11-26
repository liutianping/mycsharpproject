using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Threetires.DAO
{
    class ConnectionFacade
    {
        public SqlConnection GetConn()
        {
            return ConnectionFactory.OpenConn();
        }
        public void CloseConn()
        {
            ConnectionFactory.CloseConn();
        }
    }
}

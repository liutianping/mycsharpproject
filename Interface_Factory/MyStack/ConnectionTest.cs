using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Data.SqlClient;

namespace MyStack
{
    [TestFixture]
    public class ConnectionTest
    {
        [Test]
        public void TestGetConnection()
        {
            SqlConnection cn = Connection.GetConnection();
            Assert.IsNotNull(cn);
            
        }
    }
}

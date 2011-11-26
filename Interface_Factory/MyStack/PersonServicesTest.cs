using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Data.SqlClient;
using System.Data;

namespace MyStack
{
    [TestFixture]
    public class PersonServicesTest
    {
        PersonServices ps = null;
        Persons p;
        [SetUp]
        public void Init()
        {
            ps = new PersonServices();
            p = new Persons();
        }

        [Test]
        public void TestInsertAndDelete()
        {
            p.Username = "liutp";
            p.Password = "liutp";
            p.Age = 22;
            int result = ps.Insert(p);
            Assert.AreEqual(1, result);
            p.Id = GetMaxIdForDelete();
            int result2 = ps.Delete(p);
            Assert.AreEqual(result2, 1);
           
        }



        //////////////////////////////////////////////////////////////////////

        private void InsertPerson()
        {
            p.Username = "liutp";
            p.Password = "liutp";
            p.Age = 22;
            ps.Insert(p);

        }

        private void DeletePerson()
        {
            Persons delete_persons = new Persons();
            delete_persons.Id = GetMaxIdForDelete();
            ps.Delete(delete_persons);
        }
        ////////////////////////////////////////////////////////////////////




        [Test]
        public void TestUpdate()
        {
            InsertPerson();

            Persons updatePerson = new Persons();
            updatePerson.Id = GetMaxIdForDelete();
            updatePerson.Username = "liutpTest";
            updatePerson.Password = "liutpTest";
            updatePerson.Age = 22;
            int result = ps.Update(updatePerson);
            Assert.AreEqual(1, result);//如果通过，表明更新成功

            //还要测试下更新的数据，是我们上面的测试数据
            Persons checkPerson = new Persons();

            checkPerson = ps.QueryPerson(updatePerson.Id);

            DeletePerson();
        }

        [Test]
        public void TestQuery()
        {
            Persons org = new Persons();
            org.Age = 20;
            org.Username = "aa";
            org.Password = "aa";
            ps.Insert(org);
            org.Id = GetMaxIdForDelete();
            Persons checkPerson = ps.QueryPerson(GetMaxIdForDelete());
            this.Compare(org, checkPerson);
            DeletePerson();
        }

        private void Compare(Persons p1, Persons p2)
        {
            Assert.AreEqual(p1.Id, p2.Id);
            Assert.AreEqual(p1.Username, p2.Username);
            Assert.AreEqual(p1.Password, p2.Password);
            Assert.AreEqual(p1.Age, p2.Age);
        }

        private int GetMaxIdForDelete()
        {
            int result = 0;
            string strSql = "select max(id) from person";
            SqlConnection cn = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand(strSql, cn);
            result = int.Parse(cmd.ExecuteScalar().ToString());
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MyStack
{
    public class Persons
    {
        public Persons()
        { }
        public Persons(SqlDataReader dr)
        {
            if (dr != null)
            {
                this.Id =Convert.ToInt32(dr["id"]);
                this.Username = dr["username"].ToString();
                this.Password = dr["password"].ToString();
                this.Age =Convert.ToInt32(dr["age"]);
            }
        }

        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}

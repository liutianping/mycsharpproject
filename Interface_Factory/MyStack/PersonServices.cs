using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace MyStack
{
    public class PersonServices
    {
        SqlConnection cn = null; 
        SqlCommand cmd = null;

        private SqlCommand CommandArgus(SqlCommand cmd, Persons p,SqlConnection cn)
        {
            cmd = new SqlCommand();
            cmd.Parameters.Add("@username", SqlDbType.VarChar);
            cmd.Parameters.Add("@password", SqlDbType.VarChar);
            cmd.Parameters.Add("@age", SqlDbType.Int);
            cmd.Parameters.Add("@id",SqlDbType.Int);

            cmd.Parameters["@username"].Value = p.Username;
            cmd.Parameters["@password"].Value = p.Password;
            cmd.Parameters["@age"].Value = p.Age;
            cmd.Parameters["@id"].Value = p.Id;
            cmd.Connection = cn;

            return cmd;
        }
        private SqlCommand CommandArgus(SqlCommand cmd, int p, SqlConnection cn)
        {
            cmd = new SqlCommand();
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = p;
            cmd.Connection = cn;
            return cmd;
        }
        public int Insert(Persons p)
        {
            int result = -1;
            string strSql = "Insert into Person(username,password,age)values(@username,@password,@age)";
            cn = Connection.GetConnection();
            cmd = CommandArgus(cmd, p, cn);
            cmd.CommandText = strSql;
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                cn.Close();
            }
            return result;
        }

        public int Update(Persons p)
        {
            int result=0;
            string strSql = "update person set username=@username,password=@password,age=@age where id=@id";
            cn = Connection.GetConnection();
            cmd = CommandArgus(cmd, p, cn);
            cmd.CommandText = strSql;
            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                cn.Close();
            }
            return result;
        }

        public int Delete(Persons p)
        {
            int result = -1;
            string strSql = "delete person where id=@id";
            cn = Connection.GetConnection();
            cmd = CommandArgus(cmd, p.Id, cn);
            cmd.CommandText = strSql;

            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                cn.Close();
            }
            return result;
        }

        public Persons QueryPerson(int id)
        {
            Persons result = null;
            string strSql = "select * from person where id=@id";
            cn=Connection.GetConnection();
            cmd = CommandArgus(cmd, id, cn);
            cmd.CommandText = strSql;

            try
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result = new Persons(dr);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                cn.Close();
            }
            return result;
        }
    }
}

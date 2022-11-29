using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Queries
{
    public class Read
    {
        Connect c = new Connect();
        public User authentical(string uname, string pwd)
        {
            try
            {
                string qry = "SELECT id, rank, ban, uname, pwd FROM user WHERE uname=@uname AND pwd=@pwd;";
                MySqlCommand cmd = new MySqlCommand(qry);
                cmd.Connection = c.connect;
                cmd.Parameters.AddWithValue("@uname", uname);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                cmd.CommandText = qry;
                User user = new User();

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    user.Id = dr.GetInt32("id");
                    user.rank = dr.GetInt32("rank");
                    user.ban = dr.GetBoolean("ban");
                }

                return user;
            }
            catch (Exception)
            {
                User user = new User();
                user.Id = 0;
                return user;
            }
        }
    }
}
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Queries
{
    public class Select
    {
        Connect c = new Connect();
        public User getUser(string id)
        {
            try
            {
                string qry = "SELECT * FROM `user` WHERE id=@id;";
                MySqlCommand cmd=new MySqlCommand();
                cmd.Connection = c.connect;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandText=qry;
                MySqlDataReader dr=cmd.ExecuteReader();
                dr.Read();

                User u=new User();
                u.Id = dr.GetInt32("Id");
                u.fullname=dr.GetString("fullame");

                return u;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
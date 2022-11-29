using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;

namespace Login.Queries
{
    public class Create
    {
        Connect c = new Connect();

        [Obsolete]
        public int regUser(User user)
        {
            try
            {
                string hostname = Dns.GetHostName();
                string myIP = Dns.GetHostByName(hostname).AddressList[0].ToString();

                string qry = "INSERT INTO `user`(`uname`, `email`, `pwd`, `fullname`,  `ipadd`) VALUES (@uname, @email, @pwd, @fullname,  @ipadd);";

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = c.connect;
                cmd.Parameters.AddWithValue("@uname", user.uname);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@pwd", user.pwd);
                cmd.Parameters.AddWithValue("@fullname", user.fullname);
                cmd.Parameters.AddWithValue("@ipadd", myIP);
                cmd.CommandText = qry;
               
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
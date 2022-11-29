using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Queries
{
    public class Update
    {
        Connect c=new Connect();
        public int modifyUser(User user)
        {
            try
            {
                string qry = "UPDATE `user` SET `uname`=@uname,`email`=@email,`pwd`=@pwd,`fullname`=@fullname,`active`=@active,`rank`=@rank,`ban`=@ban WHERE id=@id;";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = c.connect;
                cmd.Parameters.AddWithValue("@uname", user.uname);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@pwd", user.pwd);
                cmd.Parameters.AddWithValue("@fullname", user.fullname);
                cmd.Parameters.AddWithValue("@active", user.active);
                cmd.Parameters.AddWithValue("@rank", user.rank);
                cmd.Parameters.AddWithValue("@ban", user.ban);
                cmd.Parameters.AddWithValue("@id", user.Id);
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
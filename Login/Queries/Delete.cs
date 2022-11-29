using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Login.Queries
{
    public class Delete
    {
        Connect c = new Connect();
        public int deleteUser(User user)
        {
            try
            {
                string qry = "DELETE FROM user WHERE id=@id;";
                MySqlCommand cmd= new MySqlCommand();
                cmd.Connection=c.connect;
                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.CommandText=qry;


                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
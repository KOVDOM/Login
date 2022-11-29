using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Login;
using MySql.Data.MySqlClient;
using Login.Queries;

namespace Login
{
    public class Service1 : IService1
    {
        public User regCheck(User user)
        {
            Read r = new Read();
            return r.authentical(user.uname, user.pwd);
        }

        public string registration(User user)
        {
            Create cr = new Create();
            if (cr.regUser(user) > 0)
                return "Sikeres regisztráció!";
            else
                return "Hiba a regisztráció során!";
        }
    }
}

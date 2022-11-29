using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows;
using MySql.Data.MySqlClient;

namespace Login
{
    public class Connect
    {
        public MySqlConnection connect;
        private string server;
        private string database;
        private string user;
        private string password;
        private string connectionstring;

        public Connect()
        {
            server = "localhost";
            database = "backenddb";
            user = "root";
            password = "";

            connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";" + "SslMode=None;";
            connect = new MySqlConnection(connectionstring);

            try
            {
                connect.Open();
                Console.WriteLine("Sikeres csatlakozás!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
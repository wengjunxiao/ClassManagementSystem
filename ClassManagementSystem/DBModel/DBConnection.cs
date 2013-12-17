using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ClassManagementSystem.DBModel
{
    public class DBConnection
    {
        private static SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionStr"]);

        public static SqlConnection Conn
        {
            get 
            { 
                return DBConnection.conn;
            }
            set 
            { 
                DBConnection.conn = value;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ClassManagementSystem.DBModel
{
    public class DeleteCommand
    {
        /// <summary>
        /// 执行删除语句
        /// </summary>
        /// <param name="sql">完整的sql语句</param>
        /// <returns></returns>
        public static bool delete(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, DBConnection.Conn);
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                DBConnection.Conn.Close();
            }
        }
    }
}

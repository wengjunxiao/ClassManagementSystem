using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ClassManagementSystem.DBModel
{
    public class SelectCommand
    {
        /// <summary>
        /// 返回符合相关记录的条数，如select count(*)，如果异常则返回-1
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int getCount(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, DBConnection.Conn);
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {
                return -1;
            }
            finally
            {
                DBConnection.Conn.Close();
            }
        }

        /// <summary>
        /// 返回select的结果，结果为DataTable对象,如无结果返回null
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable getTable(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, DBConnection.Conn);
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                DataTable table = new DataTable();
                SqlDataAdapter thisAdapter = new SqlDataAdapter(cmd);
                thisAdapter.Fill(table);
                return table;
            }
            catch
            {
                return null;
            }
            finally
            {
                DBConnection.Conn.Close();
            }
        }


        /// <summary>
        /// 返回一个string的Array对象，用于收集下拉列表内容
        /// </summary>
        /// <param name="sql">Select语句必须是对单目标列的投影，如select age from...</param>
        /// <returns></returns>
        public static object [] getStringItems(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, DBConnection.Conn);
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                List<string> list = new List<string>();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    list.Add(sdr[0].ToString());
                }
                return list.ToArray();
            }
            catch
            {
                return null;
            }
            finally
            {
                DBConnection.Conn.Close();
            }
        }

        /// <summary>
        /// 返回某个单元的string值
        /// </summary>
        /// <param name="sql">需要确保记录唯一且SQL语句只有一列投影</param>
        /// <returns></returns>
        public static string getValue(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, DBConnection.Conn);
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                return sdr[0].ToString();
            }
            catch
            {
                return null;
            }
            finally
            {
                DBConnection.Conn.Close();
            }
        }

        /// <summary>
        /// 返回某个单元的byte[]数组
        /// </summary>
        /// <param name="sql">需要确保记录唯一且SQL语句只有一列投影</param>
        /// <returns></returns>
        public static byte[] getBytesValue(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, DBConnection.Conn);
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                return (byte[])sdr[0];
            }
            catch
            {
                return null;
            }
            finally
            {
                DBConnection.Conn.Close();
            }
        }

    }
}

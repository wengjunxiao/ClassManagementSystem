using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ClassManagementSystem.DBModel
{
    public class UpdateCommand
    {
        /// <summary>
        /// 执行更新语句
        /// </summary>
        /// <param name="sql">完整的sql语句</param>
        /// <returns></returns>
        public static bool update(string sql)
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

        //重载更新方法
        public static bool update(string sno,string photoname,byte[] photo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnection.Conn;
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                cmd.CommandText = "update Students set PhotoName = @photoname,Photo = @photo where Sno = @sno";
                SqlParameter par1 = new SqlParameter("@photoname", SqlDbType.VarChar);
                par1.Value = photoname;
                cmd.Parameters.Add(par1);
                SqlParameter par2 = new SqlParameter("@photo", SqlDbType.Image);
                par2.Value = photo;
                cmd.Parameters.Add(par2);
                SqlParameter par3 = new SqlParameter("@sno", SqlDbType.VarChar);
                par3.Value = sno;
                cmd.Parameters.Add(par3);
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

        //重载更新方法
        public static bool updateApx(string sno, string appendixname, byte[] appendix)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnection.Conn;
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                cmd.CommandText = "update Students_Reward set AppendixName = @appendixname,RewardAppendix = @appendix where Sno = @sno";
                SqlParameter par1 = new SqlParameter("@appendixname", SqlDbType.VarChar);
                par1.Value = appendixname;
                cmd.Parameters.Add(par1);
                SqlParameter par2 = new SqlParameter("@appendix", SqlDbType.Image);
                par2.Value = appendix;
                cmd.Parameters.Add(par2);
                SqlParameter par3 = new SqlParameter("@sno", SqlDbType.VarChar);
                par3.Value = sno;
                cmd.Parameters.Add(par3);
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

        public static bool updateApxPenalty(string sno, string appendixname, byte[] appendix)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnection.Conn;
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                cmd.CommandText = "update Students_Penalty set AppendixName = @appendixname,PenaltyAppendix = @appendix where Sno = @sno";
                SqlParameter par1 = new SqlParameter("@appendixname", SqlDbType.VarChar);
                par1.Value = appendixname;
                cmd.Parameters.Add(par1);
                SqlParameter par2 = new SqlParameter("@appendix", SqlDbType.Image);
                par2.Value = appendix;
                cmd.Parameters.Add(par2);
                SqlParameter par3 = new SqlParameter("@sno", SqlDbType.VarChar);
                par3.Value = sno;
                cmd.Parameters.Add(par3);
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

        public static bool updatePlanAppendix(int planid, string appendixname, byte[] appendix)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnection.Conn;
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                cmd.CommandText = "update ClassPlan set AppendixName = @appendixname,PlanAppendix = @appendix where PlanID = @planid";
                SqlParameter par1 = new SqlParameter("@appendixname", SqlDbType.VarChar);
                par1.Value = appendixname;
                cmd.Parameters.Add(par1);
                SqlParameter par2 = new SqlParameter("@appendix", SqlDbType.Image);
                par2.Value = appendix;
                cmd.Parameters.Add(par2);
                SqlParameter par3 = new SqlParameter("@planid", SqlDbType.Int);
                par3.Value = planid;
                cmd.Parameters.Add(par3);
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

        public static bool updateFileAppendix(int fileid, string appendixname, byte[] appendix)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnection.Conn;
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                cmd.CommandText = "update ClassFile set AppendixName = @appendixname,FileAppendix = @appendix where FileID = @fileid";
                SqlParameter par1 = new SqlParameter("@appendixname", SqlDbType.VarChar);
                par1.Value = appendixname;
                cmd.Parameters.Add(par1);
                SqlParameter par2 = new SqlParameter("@appendix", SqlDbType.Image);
                par2.Value = appendix;
                cmd.Parameters.Add(par2);
                SqlParameter par3 = new SqlParameter("@fileid", SqlDbType.Int);
                par3.Value = fileid;
                cmd.Parameters.Add(par3);
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

        public static bool updateActiAppendix(int acid, string appendixname, byte[] appendix)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnection.Conn;
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                cmd.CommandText = "update ClassActivity set AppendixName = @appendixname,Appendix = @appendix where ActivityID = @acid";
                SqlParameter par1 = new SqlParameter("@appendixname", SqlDbType.VarChar);
                par1.Value = appendixname;
                cmd.Parameters.Add(par1);
                SqlParameter par2 = new SqlParameter("@appendix", SqlDbType.Image);
                par2.Value = appendix;
                cmd.Parameters.Add(par2);
                SqlParameter par3 = new SqlParameter("@acid", SqlDbType.Int);
                par3.Value = acid;
                cmd.Parameters.Add(par3);
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

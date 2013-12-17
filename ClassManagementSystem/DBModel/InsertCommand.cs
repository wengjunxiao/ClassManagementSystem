using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ClassManagementSystem.DBModel
{
    public class InsertCommand
    {
        /// <summary>
        /// 执行插入语句
        /// </summary>
        /// <param name="sql">完整的sql语句</param>
        /// <returns></returns>
        public static bool insert(string sql)
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

        //重载插入方法
        public static bool insert(string sno,string sname,string sex,DateTime birth,string cla,string specialty,string photoname,byte[] photo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnection.Conn;
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                cmd.CommandText = "insert into Students(Sno,Sname,Sex,BirthDate,Class,Specialty,PhotoName,Photo) values(@sno,@sname,@sex,@birth,@cla,@specialty,@photoname,@photo)";
                SqlParameter par1 = new SqlParameter("@sno", SqlDbType.VarChar);
                par1.Value = sno;
                cmd.Parameters.Add(par1);
                SqlParameter par2 = new SqlParameter("@sname", SqlDbType.VarChar);
                par2.Value = sname;
                cmd.Parameters.Add(par2);
                SqlParameter par3 = new SqlParameter("@sex", SqlDbType.VarChar);
                par3.Value = sex;
                cmd.Parameters.Add(par3);
                SqlParameter par4 = new SqlParameter("@birth", SqlDbType.DateTime);
                par4.Value = birth;
                cmd.Parameters.Add(par4);
                SqlParameter par5 = new SqlParameter("@cla", SqlDbType.VarChar);
                par5.Value = cla;
                cmd.Parameters.Add(par5);
                SqlParameter par6 = new SqlParameter("@specialty", SqlDbType.VarChar);
                par6.Value = specialty;
                cmd.Parameters.Add(par6);
                SqlParameter par7 = new SqlParameter("@photoname", SqlDbType.VarChar);
                par7.Value = photoname;
                cmd.Parameters.Add(par7);
                SqlParameter par8 = new SqlParameter("@photo", SqlDbType.Image);
                par8.Value = photo;
                cmd.Parameters.Add(par8);
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

        //重载插入方法
        public static bool insert(string sno, int rwdid, DateTime rwdtime, string appendixname, byte[] appendix)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnection.Conn;
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                cmd.CommandText = "insert into Students_Reward(Sno,ItemID,RewardDate,AppendixName,RewardAppendix) values(@sno,@rwdid,@rwdtime,@appendixname,@appendix)";
                SqlParameter par1 = new SqlParameter("@sno", SqlDbType.VarChar);
                par1.Value = sno;
                cmd.Parameters.Add(par1);
                SqlParameter par2 = new SqlParameter("@rwdid", SqlDbType.Int);
                par2.Value = rwdid;
                cmd.Parameters.Add(par2);
                SqlParameter par3 = new SqlParameter("@rwdtime", SqlDbType.DateTime);
                par3.Value = rwdtime;
                cmd.Parameters.Add(par3);
                SqlParameter par4 = new SqlParameter("@appendixname", SqlDbType.VarChar);
                par4.Value = appendixname;
                cmd.Parameters.Add(par4);
                SqlParameter par5 = new SqlParameter("@appendix", SqlDbType.Image);
                par5.Value = appendix;
                cmd.Parameters.Add(par5);
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

        //重载插入方法
        public static bool insertPenalty(string sno, int penaltyid, DateTime ptytime, string appendixname, byte[] appendix)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnection.Conn;
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                cmd.CommandText = "insert into Students_Penalty(Sno,ItemID,PenaltyDate,AppendixName,PenaltyAppendix) values(@sno,@penaltyid,@ptytime,@appendixname,@appendix)";
                SqlParameter par1 = new SqlParameter("@sno", SqlDbType.VarChar);
                par1.Value = sno;
                cmd.Parameters.Add(par1);
                SqlParameter par2 = new SqlParameter("@penaltyid", SqlDbType.Int);
                par2.Value = penaltyid;
                cmd.Parameters.Add(par2);
                SqlParameter par3 = new SqlParameter("@ptytime", SqlDbType.DateTime);
                par3.Value = ptytime;
                cmd.Parameters.Add(par3);
                SqlParameter par4 = new SqlParameter("@appendixname", SqlDbType.VarChar);
                par4.Value = appendixname;
                cmd.Parameters.Add(par4);
                SqlParameter par5 = new SqlParameter("@appendix", SqlDbType.Image);
                par5.Value = appendix;
                cmd.Parameters.Add(par5);
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

        //重载插入方法
        public static bool insert(string plan, string appendixname, byte[] appendix)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnection.Conn;
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                cmd.CommandText = "insert into ClassPlan(PlanName,AppendixName,PlanAppendix) values(@plan,@appendixname,@appendix)";
                SqlParameter par1 = new SqlParameter("@plan", SqlDbType.VarChar);
                par1.Value = plan;
                cmd.Parameters.Add(par1);
                SqlParameter par4 = new SqlParameter("@appendixname", SqlDbType.VarChar);
                par4.Value = appendixname;
                cmd.Parameters.Add(par4);
                SqlParameter par5 = new SqlParameter("@appendix", SqlDbType.Image);
                par5.Value = appendix;
                cmd.Parameters.Add(par5);
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

        //重载插入方法
        public static bool insert(string acname,DateTime actime, string appendixname, byte[] appendix)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnection.Conn;
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                cmd.CommandText = "insert into ClassActivity(ActivityName,ActivityDate,AppendixName,Appendix) values(@acname,@actime,@appendixname,@appendix)";
                SqlParameter par1 = new SqlParameter("@acname", SqlDbType.VarChar);
                par1.Value = acname;
                cmd.Parameters.Add(par1);
                SqlParameter par2 = new SqlParameter("@actime", SqlDbType.DateTime);
                par2.Value = actime;
                cmd.Parameters.Add(par2);
                SqlParameter par4 = new SqlParameter("@appendixname", SqlDbType.VarChar);
                par4.Value = appendixname;
                cmd.Parameters.Add(par4);
                SqlParameter par5 = new SqlParameter("@appendix", SqlDbType.Image);
                par5.Value = appendix;
                cmd.Parameters.Add(par5);
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

        public static bool insertFile(string theme, string appendixname, byte[] appendix)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnection.Conn;
            if (DBConnection.Conn.State == ConnectionState.Closed)
            {
                DBConnection.Conn.Open();
            }
            try
            {
                cmd.CommandText = "insert into ClassFile(FileTheme,AppendixName,FileAppendix) values(@theme,@appendixname,@appendix)";
                SqlParameter par1 = new SqlParameter("@theme", SqlDbType.VarChar);
                par1.Value = theme;
                cmd.Parameters.Add(par1);
                SqlParameter par4 = new SqlParameter("@appendixname", SqlDbType.VarChar);
                par4.Value = appendixname;
                cmd.Parameters.Add(par4);
                SqlParameter par5 = new SqlParameter("@appendix", SqlDbType.Image);
                par5.Value = appendix;
                cmd.Parameters.Add(par5);
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
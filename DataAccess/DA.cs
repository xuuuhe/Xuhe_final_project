using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataAccess
{
    public static class DA
    {
        static SqlConnection myConn = null;
        static SqlCommand cmd = null;
        static SqlDataAdapter sda = null;
        static DA()
        {
            myConn = new SqlConnection();
            myConn.ConnectionString = ConfigurationManager.ConnectionStrings["ShopString"].ConnectionString;
            cmd = new SqlCommand();
            cmd.Connection = myConn;
            sda = new SqlDataAdapter(cmd);
        }
        /// <summary>
        /// 返回单一结果值
        /// </summary>
        /// <param name="sqlText">执行的Sql语句或存储过程名</param>
        /// <param name="cmdType">命令的执行方式</param>
        /// <param name="paraNames">执行的语句中的参数列表</param>
        /// <param name="paraValues">执行的语句中的参数值</param>
        /// <returns>返回的单一结果值</returns>
        public static object GetOneData(string sqlText,CommandType cmdType,string[] paraNames,object[] paraValues)
        {
            object res = null;
            cmd.CommandText = sqlText;
            cmd.CommandType = cmdType;
            if (myConn.State != ConnectionState.Open)
                myConn.Open();
            if (paraNames != null)
            {
                for (int i = 0; i < paraNames.Length; i++)
                {
                    cmd.Parameters.AddWithValue(paraNames[i], paraValues[i]);
                }
            }
            res = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            myConn.Close(); 
            return res;
        }
        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="sqlText">执行的Sql语句或存储过程名</param>
        /// <param name="cmdType">命令的执行方式</param>
        /// <param name="paraNames">执行的语句中的参数列表</param>
        /// <param name="paraValues">执行的语句中的参数值</param>
        /// <returns>返回的受影响的行数</returns>
        public static int ExecuteSql(string sqlText, CommandType cmdType, string[] paraNames, object[] paraValues)
        {
            int res = 0;
            cmd.CommandText = sqlText;
            cmd.CommandType = cmdType;
            if (myConn.State != ConnectionState.Open)
                myConn.Open();
            if (paraNames != null)
            {
                for (int i = 0; i < paraNames.Length; i++)
                {
                    cmd.Parameters.AddWithValue(paraNames[i], paraValues[i]);
                }
            }
            res = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            myConn.Close();
            return res;
        }
        /// <summary>
        /// 返回多行多列的结果集
        /// </summary>
        /// <param name="sqlText">执行的Sql语句或存储过程名</param>
        /// <param name="cmdType">命令的执行方式</param>
        /// <param name="paraNames">执行的语句中的参数列表</param>
        /// <param name="paraValues">执行的语句中的参数值</param>
        /// <returns>返回的结果值</returns>
        public static DataTable GetDataTable(string sqlText, CommandType cmdType, string[] paraNames, object[] paraValues)
        {
            DataTable dt = new DataTable();//建立数据表
            cmd.CommandText = sqlText;
            cmd.CommandType = cmdType;
            if (myConn.State != ConnectionState.Open)
                myConn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);//填充数据表
            if (paraNames != null)
            {
                for (int i = 0; i < paraNames.Length; i++)
                {
                    cmd.Parameters.AddWithValue(paraNames[i], paraValues[i]);
                }
            }
            sda.Fill(dt);
            cmd.Parameters.Clear();
            myConn.Close();
            return dt;
        }
        public static void ExecuteSql(string sqlText, CommandType commandType, string[] paraNames, object[] paraValues, out object outParam, SqlDbType dbType)
        {
            if (myConn.State != ConnectionState.Open)
                myConn.Open();
            cmd.CommandType = commandType;
            cmd.CommandText = sqlText;
            if (paraNames != null)
            {
                for (int i = 0; i < paraNames.Length; i++)
                    cmd.Parameters.AddWithValue(paraNames[i], paraValues[i]);
                cmd.Parameters.Add("@result", dbType);
                cmd.Parameters["@result"].Direction = ParameterDirection.Output;
            }
            cmd.ExecuteNonQuery();
            outParam = cmd.Parameters["@result"].Value;
            cmd.Parameters.Clear();
            myConn.Close();

        }
    }
	
}

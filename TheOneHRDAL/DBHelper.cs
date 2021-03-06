﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TheOneHRDAL
{
    public class DBHelper
    {
        private static SqlConnection conn;// = new SqlConnection("server=.;database=HR;uid=sa;pwd=;");
        
        public static SqlConnection Conn
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                if(conn == null)
                {
                    conn = new SqlConnection(connectionString);
                    conn.Open();
                } else if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                } else if(conn.State == ConnectionState.Broken)
                {
                    conn.Close();
                    conn.Open();
                }
                return conn;
            }
        }

        /// <summary>
        /// Encap sqlcommond object
        /// </summary>
        /// <param name="sql">insert, update, delete</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            SqlCommand command = new SqlCommand(sql, Conn);
            try
            {
                int rows = command.ExecuteNonQuery();
                Conn.Close();
                return rows;
            }
            catch
            {
                throw;
            }
            finally
            {
                Conn.Close();
            }
            
        }

        public static int ExecuteCommand(string sql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.Parameters.AddRange(values);
            return cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>return dataset object</returns>
        public static DataSet GetDataSet(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Conn);
            DataSet dataSet = new DataSet();
            try
            {
                adapter.Fill(dataSet);
                return dataSet;
            }
            catch
            {
                throw;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>return dataTable</returns>
        public static DataTable GetDataTable(string sql)
        {
            DataSet dataSet = GetDataSet(sql);
            if(dataSet != null)
            {
                return dataSet.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetDataTable(string sql, params SqlParameter[] values)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.Parameters.AddRange(values);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }

        /// <summary>
        /// return first row first column
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetScalar(string sql)
        {
        
            SqlCommand command = new SqlCommand(sql, Conn);
            try
            {
                int rows = command.ExecuteNonQuery();
                Conn.Close();
                return rows;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                Conn.Close();
            }
        }

        public static int GetScalar(string sql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.Parameters.AddRange(values);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }

        public static SqlDataReader GetReader(string sql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.Parameters.AddRange(values);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static object GetValueByWhetherNull(object obj)
        {
            try
            {
                return obj == null ? (object)DBNull.Value : obj;
            }
            catch
            {
                return null;
            }
        }
    }
}

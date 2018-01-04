//============================================================
// Producnt name:		DAL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-2-18 13:30:24
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using TheOneHRModels;

namespace TheOneHRDAL
{
	public static partial class Config_postService
	{
        public static Config_post AddConfig_post(Config_post config_post)
		{
            string sql =
				"INSERT Config_post (Post_name)" +
				"VALUES (@Post_name)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Post_name", DBHelper.GetValueByWhetherNull(config_post.Post_name))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetConfig_postById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteConfig_post(Config_post config_post)
		{
			DeleteConfig_postById( config_post.Id );
		}

        public static void DeleteConfig_postById(int id)
		{
            string sql = "DELETE Config_post WHERE Id = @Id";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", id)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void DeleteConfig_postByPost_name(string post_name)
		{
            string sql = "DELETE Config_post WHERE Post_name = @Post_name";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Post_name", post_name)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyConfig_post(Config_post config_post)
        {
            string sql =
                "UPDATE Config_post " +
                "SET " +
	                "Post_name = @Post_name " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", config_post.Id),
					new SqlParameter("@Post_name", DBHelper.GetValueByWhetherNull(config_post.Post_name))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<Config_post> GetAllConfig_posts()
        {
            string sqlAll = "SELECT * FROM Config_post";
			return GetConfig_postsBySql( sqlAll );
        }
		
        public static Config_post GetConfig_postById(int id)
        {
            string sql = "SELECT * FROM Config_post WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    Config_post config_post = new Config_post();

					try{
					config_post.Id = (int)reader["Id"];
					}catch
					{}
					try{
					config_post.Post_name = (string)reader["Post_name"];
					}catch
					{}

                    reader.Close();
					
                    return config_post;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
		
        public static Config_post GetConfig_postByPost_name(string post_name)
        {
            string sql = "SELECT * FROM Config_post WHERE Post_name = @Post_name";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Post_name", post_name));
                if (reader.Read())
                {
                    Config_post config_post = new Config_post();

					try{
					config_post.Id = (int)reader["Id"];
					}catch
					{}
					
					try{
					config_post.Post_name = (string)reader["Post_name"];
					}catch
					{}
					

                    reader.Close();

                    return config_post;
                }
                else
                {
					reader.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
		
		
		
		
        private static IList<Config_post> GetConfig_postsBySql( string safeSql )
        {
            List<Config_post> list = new List<Config_post>();

			try
			{
				DataTable table = DBHelper.GetDataTable( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					Config_post config_post = new Config_post();
					
					try{
					config_post.Id = (int)row["Id"];
					}catch
					{}
					try{
					config_post.Post_name = (string)row["Post_name"];
					}catch
					{}
	
					list.Add(config_post);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<Config_post> GetConfig_postsBySql( string sql, params SqlParameter[] values )
        {
            List<Config_post> list = new List<Config_post>();

			try
			{
				DataTable table = DBHelper.GetDataTable( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					Config_post config_post = new Config_post();
					
					try{
					config_post.Id = (int)row["Id"];
					}catch
					{}
					try{
					config_post.Post_name = (string)row["Post_name"];
					}catch
					{}
	
					list.Add(config_post);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
			
        }
		
	}
}

//============================================================
// Producnt name:		DAL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-2-18 13:30:21
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using TheOneHRModels;

namespace TheOneHRDAL
{
	public static partial class Config_educated_degreeService
	{
        public static Config_educated_degree AddConfig_educated_degree(Config_educated_degree config_educated_degree)
		{
            string sql =
				"INSERT Config_educated_degree (Educated_degree_name)" +
				"VALUES (@Educated_degree_name)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Educated_degree_name", DBHelper.GetValueByWhetherNull(config_educated_degree.Educated_degree_name))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetConfig_educated_degreeById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteConfig_educated_degree(Config_educated_degree config_educated_degree)
		{
			DeleteConfig_educated_degreeById( config_educated_degree.Id );
		}

        public static void DeleteConfig_educated_degreeById(int id)
		{
            string sql = "DELETE Config_educated_degree WHERE Id = @Id";

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
		
        public static void DeleteConfig_educated_degreeByEducated_degree_name(string educated_degree_name)
		{
            string sql = "DELETE Config_educated_degree WHERE Educated_degree_name = @Educated_degree_name";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Educated_degree_name", educated_degree_name)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyConfig_educated_degree(Config_educated_degree config_educated_degree)
        {
            string sql =
                "UPDATE Config_educated_degree " +
                "SET " +
	                "Educated_degree_name = @Educated_degree_name " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", config_educated_degree.Id),
					new SqlParameter("@Educated_degree_name", DBHelper.GetValueByWhetherNull(config_educated_degree.Educated_degree_name))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<Config_educated_degree> GetAllConfig_educated_degrees()
        {
            string sqlAll = "SELECT * FROM Config_educated_degree";
			return GetConfig_educated_degreesBySql( sqlAll );
        }
		
        public static Config_educated_degree GetConfig_educated_degreeById(int id)
        {
            string sql = "SELECT * FROM Config_educated_degree WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    Config_educated_degree config_educated_degree = new Config_educated_degree();

					try{
					config_educated_degree.Id = (int)reader["Id"];
					}catch
					{}
					try{
					config_educated_degree.Educated_degree_name = (string)reader["Educated_degree_name"];
					}catch
					{}

                    reader.Close();
					
                    return config_educated_degree;
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
		
        public static Config_educated_degree GetConfig_educated_degreeByEducated_degree_name(string educated_degree_name)
        {
            string sql = "SELECT * FROM Config_educated_degree WHERE Educated_degree_name = @Educated_degree_name";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Educated_degree_name", educated_degree_name));
                if (reader.Read())
                {
                    Config_educated_degree config_educated_degree = new Config_educated_degree();

					try{
					config_educated_degree.Id = (int)reader["Id"];
					}catch
					{}
					
					try{
					config_educated_degree.Educated_degree_name = (string)reader["Educated_degree_name"];
					}catch
					{}
					

                    reader.Close();

                    return config_educated_degree;
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
		
		
		
		
        private static IList<Config_educated_degree> GetConfig_educated_degreesBySql( string safeSql )
        {
            List<Config_educated_degree> list = new List<Config_educated_degree>();

			try
			{
				DataTable table = DBHelper.GetDataTable( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					Config_educated_degree config_educated_degree = new Config_educated_degree();
					
					try{
					config_educated_degree.Id = (int)row["Id"];
					}catch
					{}
					try{
					config_educated_degree.Educated_degree_name = (string)row["Educated_degree_name"];
					}catch
					{}
	
					list.Add(config_educated_degree);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<Config_educated_degree> GetConfig_educated_degreesBySql( string sql, params SqlParameter[] values )
        {
            List<Config_educated_degree> list = new List<Config_educated_degree>();

			try
			{
				DataTable table = DBHelper.GetDataTable( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					Config_educated_degree config_educated_degree = new Config_educated_degree();
					
					try{
					config_educated_degree.Id = (int)row["Id"];
					}catch
					{}
					try{
					config_educated_degree.Educated_degree_name = (string)row["Educated_degree_name"];
					}catch
					{}
	
					list.Add(config_educated_degree);
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

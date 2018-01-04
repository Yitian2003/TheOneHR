//============================================================
// Producnt name:		DAL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-2-18 13:30:23
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using TheOneHRModels;

namespace TheOneHRDAL
{
	public static partial class Config_nationService
	{
        public static Config_nation AddConfig_nation(Config_nation config_nation)
		{
            string sql =
				"INSERT Config_nation (Nation_name)" +
				"VALUES (@Nation_name)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Nation_name", DBHelper.GetValueByWhetherNull(config_nation.Nation_name))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetConfig_nationById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteConfig_nation(Config_nation config_nation)
		{
			DeleteConfig_nationById( config_nation.Id );
		}

        public static void DeleteConfig_nationById(int id)
		{
            string sql = "DELETE Config_nation WHERE Id = @Id";

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
		
        public static void DeleteConfig_nationByNation_name(string nation_name)
		{
            string sql = "DELETE Config_nation WHERE Nation_name = @Nation_name";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Nation_name", nation_name)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyConfig_nation(Config_nation config_nation)
        {
            string sql =
                "UPDATE Config_nation " +
                "SET " +
	                "Nation_name = @Nation_name " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", config_nation.Id),
					new SqlParameter("@Nation_name", DBHelper.GetValueByWhetherNull(config_nation.Nation_name))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<Config_nation> GetAllConfig_nations()
        {
            string sqlAll = "SELECT * FROM Config_nation";
			return GetConfig_nationsBySql( sqlAll );
        }
		
        public static Config_nation GetConfig_nationById(int id)
        {
            string sql = "SELECT * FROM Config_nation WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    Config_nation config_nation = new Config_nation();

					try{
					config_nation.Id = (int)reader["Id"];
					}catch
					{}
					try{
					config_nation.Nation_name = (string)reader["Nation_name"];
					}catch
					{}

                    reader.Close();
					
                    return config_nation;
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
		
        public static Config_nation GetConfig_nationByNation_name(string nation_name)
        {
            string sql = "SELECT * FROM Config_nation WHERE Nation_name = @Nation_name";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Nation_name", nation_name));
                if (reader.Read())
                {
                    Config_nation config_nation = new Config_nation();

					try{
					config_nation.Id = (int)reader["Id"];
					}catch
					{}
					
					try{
					config_nation.Nation_name = (string)reader["Nation_name"];
					}catch
					{}
					

                    reader.Close();

                    return config_nation;
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
		
		
		
		
        private static IList<Config_nation> GetConfig_nationsBySql( string safeSql )
        {
            List<Config_nation> list = new List<Config_nation>();

			try
			{
				DataTable table = DBHelper.GetDataTable( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					Config_nation config_nation = new Config_nation();
					
					try{
					config_nation.Id = (int)row["Id"];
					}catch
					{}
					try{
					config_nation.Nation_name = (string)row["Nation_name"];
					}catch
					{}
	
					list.Add(config_nation);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<Config_nation> GetConfig_nationsBySql( string sql, params SqlParameter[] values )
        {
            List<Config_nation> list = new List<Config_nation>();

			try
			{
				DataTable table = DBHelper.GetDataTable( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					Config_nation config_nation = new Config_nation();
					
					try{
					config_nation.Id = (int)row["Id"];
					}catch
					{}
					try{
					config_nation.Nation_name = (string)row["Nation_name"];
					}catch
					{}
	
					list.Add(config_nation);
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

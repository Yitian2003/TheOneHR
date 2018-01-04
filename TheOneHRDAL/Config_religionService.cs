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
	public static partial class Config_religionService
	{
        public static Config_religion AddConfig_religion(Config_religion config_religion)
		{
            string sql =
				"INSERT Config_religion (Religion_name)" +
				"VALUES (@Religion_name)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Religion_name", DBHelper.GetValueByWhetherNull(config_religion.Religion_name))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetConfig_religionById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteConfig_religion(Config_religion config_religion)
		{
			DeleteConfig_religionById( config_religion.Id );
		}

        public static void DeleteConfig_religionById(int id)
		{
            string sql = "DELETE Config_religion WHERE Id = @Id";

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
		
        public static void DeleteConfig_religionByReligion_name(string religion_name)
		{
            string sql = "DELETE Config_religion WHERE Religion_name = @Religion_name";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Religion_name", religion_name)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyConfig_religion(Config_religion config_religion)
        {
            string sql =
                "UPDATE Config_religion " +
                "SET " +
	                "Religion_name = @Religion_name " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", config_religion.Id),
					new SqlParameter("@Religion_name", DBHelper.GetValueByWhetherNull(config_religion.Religion_name))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<Config_religion> GetAllConfig_religions()
        {
            string sqlAll = "SELECT * FROM Config_religion";
			return GetConfig_religionsBySql( sqlAll );
        }
		
        public static Config_religion GetConfig_religionById(int id)
        {
            string sql = "SELECT * FROM Config_religion WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    Config_religion config_religion = new Config_religion();

					try{
					config_religion.Id = (int)reader["Id"];
					}catch
					{}
					try{
					config_religion.Religion_name = (string)reader["Religion_name"];
					}catch
					{}

                    reader.Close();
					
                    return config_religion;
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
		
        public static Config_religion GetConfig_religionByReligion_name(string religion_name)
        {
            string sql = "SELECT * FROM Config_religion WHERE Religion_name = @Religion_name";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Religion_name", religion_name));
                if (reader.Read())
                {
                    Config_religion config_religion = new Config_religion();

					try{
					config_religion.Id = (int)reader["Id"];
					}catch
					{}
					
					try{
					config_religion.Religion_name = (string)reader["Religion_name"];
					}catch
					{}
					

                    reader.Close();

                    return config_religion;
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
		
		
		
		
        private static IList<Config_religion> GetConfig_religionsBySql( string safeSql )
        {
            List<Config_religion> list = new List<Config_religion>();

			try
			{
				DataTable table = DBHelper.GetDataTable( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					Config_religion config_religion = new Config_religion();
					
					try{
					config_religion.Id = (int)row["Id"];
					}catch
					{}
					try{
					config_religion.Religion_name = (string)row["Religion_name"];
					}catch
					{}
	
					list.Add(config_religion);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<Config_religion> GetConfig_religionsBySql( string sql, params SqlParameter[] values )
        {
            List<Config_religion> list = new List<Config_religion>();

			try
			{
				DataTable table = DBHelper.GetDataTable( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					Config_religion config_religion = new Config_religion();
					
					try{
					config_religion.Id = (int)row["Id"];
					}catch
					{}
					try{
					config_religion.Religion_name = (string)row["Religion_name"];
					}catch
					{}
	
					list.Add(config_religion);
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

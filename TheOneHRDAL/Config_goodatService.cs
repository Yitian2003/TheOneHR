//============================================================
// Producnt name:		DAL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-2-18 13:30:22
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using TheOneHRModels;

namespace TheOneHRDAL
{
	public static partial class Config_goodatService
	{
        public static Config_goodat AddConfig_goodat(Config_goodat config_goodat)
		{
            string sql =
				"INSERT Config_goodat (Goodat_name)" +
				"VALUES (@Goodat_name)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Goodat_name", DBHelper.GetValueByWhetherNull(config_goodat.Goodat_name))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetConfig_goodatById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteConfig_goodat(Config_goodat config_goodat)
		{
			DeleteConfig_goodatById( config_goodat.Id );
		}

        public static void DeleteConfig_goodatById(int id)
		{
            string sql = "DELETE Config_goodat WHERE Id = @Id";

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
		
        public static void DeleteConfig_goodatByGoodat_name(string goodat_name)
		{
            string sql = "DELETE Config_goodat WHERE Goodat_name = @Goodat_name";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Goodat_name", goodat_name)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyConfig_goodat(Config_goodat config_goodat)
        {
            string sql =
                "UPDATE Config_goodat " +
                "SET " +
	                "Goodat_name = @Goodat_name " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", config_goodat.Id),
					new SqlParameter("@Goodat_name", DBHelper.GetValueByWhetherNull(config_goodat.Goodat_name))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<Config_goodat> GetAllConfig_goodats()
        {
            string sqlAll = "SELECT * FROM Config_goodat";
			return GetConfig_goodatsBySql( sqlAll );
        }
		
        public static Config_goodat GetConfig_goodatById(int id)
        {
            string sql = "SELECT * FROM Config_goodat WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    Config_goodat config_goodat = new Config_goodat();

					try{
					config_goodat.Id = (int)reader["Id"];
					}catch
					{}
					try{
					config_goodat.Goodat_name = (string)reader["Goodat_name"];
					}catch
					{}

                    reader.Close();
					
                    return config_goodat;
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
		
        public static Config_goodat GetConfig_goodatByGoodat_name(string goodat_name)
        {
            string sql = "SELECT * FROM Config_goodat WHERE Goodat_name = @Goodat_name";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Goodat_name", goodat_name));
                if (reader.Read())
                {
                    Config_goodat config_goodat = new Config_goodat();

					try{
					config_goodat.Id = (int)reader["Id"];
					}catch
					{}
					
					try{
					config_goodat.Goodat_name = (string)reader["Goodat_name"];
					}catch
					{}
					

                    reader.Close();

                    return config_goodat;
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
		
		
		
		
        private static IList<Config_goodat> GetConfig_goodatsBySql( string safeSql )
        {
            List<Config_goodat> list = new List<Config_goodat>();

			try
			{
				DataTable table = DBHelper.GetDataTable( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					Config_goodat config_goodat = new Config_goodat();
					
					try{
					config_goodat.Id = (int)row["Id"];
					}catch
					{}
					try{
					config_goodat.Goodat_name = (string)row["Goodat_name"];
					}catch
					{}
	
					list.Add(config_goodat);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<Config_goodat> GetConfig_goodatsBySql( string sql, params SqlParameter[] values )
        {
            List<Config_goodat> list = new List<Config_goodat>();

			try
			{
				DataTable table = DBHelper.GetDataTable( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					Config_goodat config_goodat = new Config_goodat();
					
					try{
					config_goodat.Id = (int)row["Id"];
					}catch
					{}
					try{
					config_goodat.Goodat_name = (string)row["Goodat_name"];
					}catch
					{}
	
					list.Add(config_goodat);
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

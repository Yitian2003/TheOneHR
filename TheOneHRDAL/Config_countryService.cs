//============================================================
// Producnt name:		DAL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-2-18 13:30:19
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using TheOneHRModels;

namespace TheOneHRDAL
{
	public static partial class Config_countryService
	{
        public static Config_country AddConfig_country(Config_country config_country)
		{
            string sql =
				"INSERT Config_country (Country_name)" +
				"VALUES (@Country_name)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Country_name", DBHelper.GetValueByWhetherNull(config_country.Country_name))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetConfig_countryById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteConfig_country(Config_country config_country)
		{
			DeleteConfig_countryById( config_country.Id );
		}

        public static void DeleteConfig_countryById(int id)
		{
            string sql = "DELETE Config_country WHERE Id = @Id";

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
		
        public static void DeleteConfig_countryByCountry_name(string country_name)
		{
            string sql = "DELETE Config_country WHERE Country_name = @Country_name";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Country_name", country_name)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyConfig_country(Config_country config_country)
        {
            string sql =
                "UPDATE Config_country " +
                "SET " +
	                "Country_name = @Country_name " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", config_country.Id),
					new SqlParameter("@Country_name", DBHelper.GetValueByWhetherNull(config_country.Country_name))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<Config_country> GetAllConfig_countries()
        {
            string sqlAll = "SELECT * FROM Config_country";
			return GetConfig_countriesBySql( sqlAll );
        }
		
        public static Config_country GetConfig_countryById(int id)
        {
            string sql = "SELECT * FROM Config_country WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    Config_country config_country = new Config_country();

					try{
					config_country.Id = (int)reader["Id"];
					}catch
					{}
					try{
					config_country.Country_name = (string)reader["Country_name"];
					}catch
					{}

                    reader.Close();
					
                    return config_country;
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
		
        public static Config_country GetConfig_countryByCountry_name(string country_name)
        {
            string sql = "SELECT * FROM Config_country WHERE Country_name = @Country_name";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Country_name", country_name));
                if (reader.Read())
                {
                    Config_country config_country = new Config_country();

					try{
					config_country.Id = (int)reader["Id"];
					}catch
					{}
					
					try{
					config_country.Country_name = (string)reader["Country_name"];
					}catch
					{}
					

                    reader.Close();

                    return config_country;
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
		
		
		
		
        private static IList<Config_country> GetConfig_countriesBySql( string safeSql )
        {
            List<Config_country> list = new List<Config_country>();

			try
			{
				DataTable table = DBHelper.GetDataTable( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					Config_country config_country = new Config_country();
					
					try{
					config_country.Id = (int)row["Id"];
					}catch
					{}
					try{
					config_country.Country_name = (string)row["Country_name"];
					}catch
					{}
	
					list.Add(config_country);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<Config_country> GetConfig_countriesBySql( string sql, params SqlParameter[] values )
        {
            List<Config_country> list = new List<Config_country>();

			try
			{
				DataTable table = DBHelper.GetDataTable( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					Config_country config_country = new Config_country();
					
					try{
					config_country.Id = (int)row["Id"];
					}catch
					{}
					try{
					config_country.Country_name = (string)row["Country_name"];
					}catch
					{}
	
					list.Add(config_country);
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

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
	public static partial class Config_specialityService
	{
        public static Config_speciality AddConfig_speciality(Config_speciality config_speciality)
		{
            string sql =
				"INSERT Config_speciality (Speciality_name)" +
				"VALUES (@Speciality_name)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Speciality_name", DBHelper.GetValueByWhetherNull(config_speciality.Speciality_name))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetConfig_specialityById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteConfig_speciality(Config_speciality config_speciality)
		{
			DeleteConfig_specialityById( config_speciality.Id );
		}

        public static void DeleteConfig_specialityById(int id)
		{
            string sql = "DELETE Config_speciality WHERE Id = @Id";

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
		
        public static void DeleteConfig_specialityBySpeciality_name(string speciality_name)
		{
            string sql = "DELETE Config_speciality WHERE Speciality_name = @Speciality_name";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Speciality_name", speciality_name)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyConfig_speciality(Config_speciality config_speciality)
        {
            string sql =
                "UPDATE Config_speciality " +
                "SET " +
	                "Speciality_name = @Speciality_name " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", config_speciality.Id),
					new SqlParameter("@Speciality_name", DBHelper.GetValueByWhetherNull(config_speciality.Speciality_name))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<Config_speciality> GetAllConfig_specialities()
        {
            string sqlAll = "SELECT * FROM Config_speciality";
			return GetConfig_specialitiesBySql( sqlAll );
        }
		
        public static Config_speciality GetConfig_specialityById(int id)
        {
            string sql = "SELECT * FROM Config_speciality WHERE Id = @Id";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    Config_speciality config_speciality = new Config_speciality();

					try{
					config_speciality.Id = (int)reader["Id"];
					}catch
					{}
					try{
					config_speciality.Speciality_name = (string)reader["Speciality_name"];
					}catch
					{}

                    reader.Close();
					
                    return config_speciality;
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
		
        public static Config_speciality GetConfig_specialityBySpeciality_name(string speciality_name)
        {
            string sql = "SELECT * FROM Config_speciality WHERE Speciality_name = @Speciality_name";

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Speciality_name", speciality_name));
                if (reader.Read())
                {
                    Config_speciality config_speciality = new Config_speciality();

					try{
					config_speciality.Id = (int)reader["Id"];
					}catch
					{}
					
					try{
					config_speciality.Speciality_name = (string)reader["Speciality_name"];
					}catch
					{}
					

                    reader.Close();

                    return config_speciality;
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
		
		
		
		
        private static IList<Config_speciality> GetConfig_specialitiesBySql( string safeSql )
        {
            List<Config_speciality> list = new List<Config_speciality>();

			try
			{
				DataTable table = DBHelper.GetDataTable( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					Config_speciality config_speciality = new Config_speciality();
					
					try{
					config_speciality.Id = (int)row["Id"];
					}catch
					{}
					try{
					config_speciality.Speciality_name = (string)row["Speciality_name"];
					}catch
					{}
	
					list.Add(config_speciality);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<Config_speciality> GetConfig_specialitiesBySql( string sql, params SqlParameter[] values )
        {
            List<Config_speciality> list = new List<Config_speciality>();

			try
			{
				DataTable table = DBHelper.GetDataTable( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					Config_speciality config_speciality = new Config_speciality();
					
					try{
					config_speciality.Id = (int)row["Id"];
					}catch
					{}
					try{
					config_speciality.Speciality_name = (string)row["Speciality_name"];
					}catch
					{}
	
					list.Add(config_speciality);
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

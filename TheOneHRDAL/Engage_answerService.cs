//============================================================
// Producnt name:		DAL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-10-6 2:46:02
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using TheOneHRModels;

namespace TheOneHRDAL
{
	public static partial class Engage_answerService
	{
        public static Engage_answer AddEngage_answer(Engage_answer engage_answer)
		{
            string sql =
				"INSERT Engage_answer (Answer_number, Ee_no, Er_no, Use_time, Total_point)" +
				"VALUES (@Answer_number, @Ee_no, @Er_no, @Use_time, @Total_point)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Ee_no", DBHelper.GetValueByWhetherNull(engage_answer.Ee_no.Id)), //FK
					new SqlParameter("@Er_no", DBHelper.GetValueByWhetherNull(engage_answer.Er_no.Id)), //FK
					new SqlParameter("@Answer_number", DBHelper.GetValueByWhetherNull(engage_answer.Answer_number)),
					new SqlParameter("@Use_time", DBHelper.GetValueByWhetherNull(engage_answer.Use_time)),
					new SqlParameter("@Total_point", DBHelper.GetValueByWhetherNull(engage_answer.Total_point))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetEngage_answerById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteEngage_answer(Engage_answer engage_answer)
		{
			DeleteEngage_answerById( engage_answer.Id );
		}

        public static void DeleteEngage_answerById(int id)
		{
            string sql = "DELETE Engage_answer WHERE Id = @Id";

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
		
        public static void ModifyEngage_answer(Engage_answer engage_answer)
        {
            string sql =
                "UPDATE Engage_answer " +
                "SET " +
	                "Ee_no = @Ee_no, " + //FK
	                "Er_no = @Er_no, " + //FK
	                "Answer_number = @Answer_number, " +
	                "Use_time = @Use_time, " +
	                "Total_point = @Total_point " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", engage_answer.Id),
					new SqlParameter("@Ee_no", DBHelper.GetValueByWhetherNull(engage_answer.Ee_no.Id)), //FK
					new SqlParameter("@Er_no", DBHelper.GetValueByWhetherNull(engage_answer.Er_no.Id)), //FK
					new SqlParameter("@Answer_number", DBHelper.GetValueByWhetherNull(engage_answer.Answer_number)),
					new SqlParameter("@Use_time", DBHelper.GetValueByWhetherNull(engage_answer.Use_time)),
					new SqlParameter("@Total_point", DBHelper.GetValueByWhetherNull(engage_answer.Total_point))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<Engage_answer> GetAllEngage_answers()
        {
            string sqlAll = "SELECT * FROM Engage_answer";
			return GetEngage_answersBySql( sqlAll );
        }
		
        public static Engage_answer GetEngage_answerById(int id)
        {
            string sql = "SELECT * FROM Engage_answer WHERE Id = @Id";

			int ee_no;
			int er_no;

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    Engage_answer engage_answer = new Engage_answer();

					try{
					engage_answer.Id = (int)reader["Id"];
					}catch
					{}
					try{
					engage_answer.Answer_number = (string)reader["Answer_number"];
					}catch
					{}
					try{
					engage_answer.Use_time = (int)reader["Use_time"];
					}catch
					{}
					try{
					engage_answer.Total_point = (decimal)reader["Total_point"];
					}catch
					{}
					ee_no = (int)reader["Ee_no"]; //FK
					er_no = (int)reader["Er_no"]; //FK

                    reader.Close();

					engage_answer.Ee_no = Engage_examService.GetEngage_examById(ee_no);
					engage_answer.Er_no = Engage_resumeService.GetEngage_resumeById(er_no);
					
                    return engage_answer;
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
		
		
		
		
        private static IList<Engage_answer> GetEngage_answersBySql( string safeSql )
        {
            List<Engage_answer> list = new List<Engage_answer>();

			try
			{
				DataTable table = DBHelper.GetDataTable( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					Engage_answer engage_answer = new Engage_answer();
					
					try{
					engage_answer.Id = (int)row["Id"];
					}catch
					{}
					try{
					engage_answer.Answer_number = (string)row["Answer_number"];
					}catch
					{}
					try{
					engage_answer.Use_time = (int)row["Use_time"];
					}catch
					{}
					try{
					engage_answer.Total_point = (decimal)row["Total_point"];
					}catch
					{}
					engage_answer.Ee_no = Engage_examService.GetEngage_examById((int)row["Ee_no"]); //FK
					engage_answer.Er_no = Engage_resumeService.GetEngage_resumeById((int)row["Er_no"]); //FK
	
					list.Add(engage_answer);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<Engage_answer> GetEngage_answersBySql( string sql, params SqlParameter[] values )
        {
            List<Engage_answer> list = new List<Engage_answer>();

			try
			{
				DataTable table = DBHelper.GetDataTable( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					Engage_answer engage_answer = new Engage_answer();
					
					try{
					engage_answer.Id = (int)row["Id"];
					}catch
					{}
					try{
					engage_answer.Answer_number = (string)row["Answer_number"];
					}catch
					{}
					try{
					engage_answer.Use_time = (int)row["Use_time"];
					}catch
					{}
					try{
					engage_answer.Total_point = (decimal)row["Total_point"];
					}catch
					{}
					engage_answer.Ee_no = Engage_examService.GetEngage_examById((int)row["Ee_no"]); //FK
					engage_answer.Er_no = Engage_resumeService.GetEngage_resumeById((int)row["Er_no"]); //FK
	
					list.Add(engage_answer);
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

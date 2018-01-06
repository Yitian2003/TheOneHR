//============================================================
// Producnt name:		DAL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-10-6 2:46:03
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using TheOneHRModels;

namespace TheOneHRDAL
{
	public static partial class Engage_examService
	{
        public static Engage_exam AddEngage_exam(Engage_exam engage_exam)
		{
            string sql =
				"INSERT Engage_exam (Exam_number, Emr_no, Register_users_no, Regist_time, Limite_time)" +
				"VALUES (@Exam_number, @Emr_no, @Register_users_no, @Regist_time, @Limite_time)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Emr_no", DBHelper.GetValueByWhetherNull(engage_exam.Emr_no.Id)), //FK
					new SqlParameter("@Exam_number", DBHelper.GetValueByWhetherNull(engage_exam.Exam_number)),
					new SqlParameter("@Register_users_no", DBHelper.GetValueByWhetherNull(engage_exam.Register_users_no)),
					new SqlParameter("@Regist_time", DBHelper.GetValueByWhetherNull(engage_exam.Regist_time)),
					new SqlParameter("@Limite_time", DBHelper.GetValueByWhetherNull(engage_exam.Limite_time))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetEngage_examById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteEngage_exam(Engage_exam engage_exam)
		{
			DeleteEngage_examById( engage_exam.Id );
		}

        public static void DeleteEngage_examById(int id)
		{
            string sql = "DELETE Engage_exam WHERE Id = @Id";

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
		
        public static void DeleteEngage_examByExam_number(string exam_number)
		{
            string sql = "DELETE Engage_exam WHERE Exam_number = @Exam_number";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Exam_number", exam_number)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyEngage_exam(Engage_exam engage_exam)
        {
            string sql =
                "UPDATE Engage_exam " +
                "SET " +
	                "Emr_no = @Emr_no, " + //FK
	                "Exam_number = @Exam_number, " +
	                "Register_users_no = @Register_users_no, " +
	                "Regist_time = @Regist_time, " +
	                "Limite_time = @Limite_time " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", engage_exam.Id),
					new SqlParameter("@Emr_no", DBHelper.GetValueByWhetherNull(engage_exam.Emr_no.Id)), //FK
					new SqlParameter("@Exam_number", DBHelper.GetValueByWhetherNull(engage_exam.Exam_number)),
					new SqlParameter("@Register_users_no", DBHelper.GetValueByWhetherNull(engage_exam.Register_users_no)),
					new SqlParameter("@Regist_time", DBHelper.GetValueByWhetherNull(engage_exam.Regist_time)),
					new SqlParameter("@Limite_time", DBHelper.GetValueByWhetherNull(engage_exam.Limite_time))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<Engage_exam> GetAllEngage_exams()
        {
            string sqlAll = "SELECT * FROM Engage_exam";
			return GetEngage_examsBySql( sqlAll );
        }
		
        public static Engage_exam GetEngage_examById(int id)
        {
            string sql = "SELECT * FROM Engage_exam WHERE Id = @Id";

			int emr_no;

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    Engage_exam engage_exam = new Engage_exam();

					try{
					engage_exam.Id = (int)reader["Id"];
					}catch
					{}
					try{
					engage_exam.Exam_number = (string)reader["Exam_number"];
					}catch
					{}
					try{
					engage_exam.Register_users_no = (int)reader["Register_users_no"];
					}catch
					{}
					try{
					engage_exam.Regist_time = (DateTime)reader["Regist_time"];
					}catch
					{}
					try{
					engage_exam.Limite_time = (int)reader["Limite_time"];
					}catch
					{}
					emr_no = (int)reader["Emr_no"]; //FK

                    reader.Close();

					engage_exam.Emr_no = Engage_major_releaseService.GetEngage_major_releaseById(emr_no);
					
                    return engage_exam;
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
		
        public static Engage_exam GetEngage_examByExam_number(string exam_number)
        {
            string sql = "SELECT * FROM Engage_exam WHERE Exam_number = @Exam_number";

			int emr_no;

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Exam_number", exam_number));
                if (reader.Read())
                {
                    Engage_exam engage_exam = new Engage_exam();

					try{
					engage_exam.Id = (int)reader["Id"];
					}catch
					{}
					
					try{
					engage_exam.Exam_number = (string)reader["Exam_number"];
					}catch
					{}
					
					try{
					engage_exam.Register_users_no = (int)reader["Register_users_no"];
					}catch
					{}
					
					try{
					engage_exam.Regist_time = (DateTime)reader["Regist_time"];
					}catch
					{}
					
					try{
					engage_exam.Limite_time = (int)reader["Limite_time"];
					}catch
					{}
					
					emr_no = (int)reader["Emr_no"]; //FK

                    reader.Close();
		
					engage_exam.Emr_no = Engage_major_releaseService.GetEngage_major_releaseById(emr_no);

                    return engage_exam;
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
		
		
		
		
        private static IList<Engage_exam> GetEngage_examsBySql( string safeSql )
        {
            List<Engage_exam> list = new List<Engage_exam>();

			try
			{
				DataTable table = DBHelper.GetDataTable( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					Engage_exam engage_exam = new Engage_exam();
					
					try{
					engage_exam.Id = (int)row["Id"];
					}catch
					{}
					try{
					engage_exam.Exam_number = (string)row["Exam_number"];
					}catch
					{}
					try{
					engage_exam.Register_users_no = (int)row["Register_users_no"];
					}catch
					{}
					try{
					engage_exam.Regist_time = (DateTime)row["Regist_time"];
					}catch
					{}
					try{
					engage_exam.Limite_time = (int)row["Limite_time"];
					}catch
					{}
					engage_exam.Emr_no = Engage_major_releaseService.GetEngage_major_releaseById((int)row["Emr_no"]); //FK
	
					list.Add(engage_exam);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<Engage_exam> GetEngage_examsBySql( string sql, params SqlParameter[] values )
        {
            List<Engage_exam> list = new List<Engage_exam>();

			try
			{
				DataTable table = DBHelper.GetDataTable( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					Engage_exam engage_exam = new Engage_exam();
					
					try{
					engage_exam.Id = (int)row["Id"];
					}catch
					{}
					try{
					engage_exam.Exam_number = (string)row["Exam_number"];
					}catch
					{}
					try{
					engage_exam.Register_users_no = (int)row["Register_users_no"];
					}catch
					{}
					try{
					engage_exam.Regist_time = (DateTime)row["Regist_time"];
					}catch
					{}
					try{
					engage_exam.Limite_time = (int)row["Limite_time"];
					}catch
					{}
					engage_exam.Emr_no = Engage_major_releaseService.GetEngage_major_releaseById((int)row["Emr_no"]); //FK
	
					list.Add(engage_exam);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
			
        }
		
        public static DataTable GetEngageExamList()
        {
            string sql = "select * from V_ExamList";
            return DBHelper.GetDataTable(sql);
        }
	}
}

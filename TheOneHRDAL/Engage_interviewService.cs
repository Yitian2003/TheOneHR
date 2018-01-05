//============================================================
// Producnt name:		DAL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-10-3 21:06:51
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using TheOneHRModels;

namespace TheOneHRDAL
{
	public static partial class Engage_interviewService
	{
        public static Engage_interview AddEngage_interview(Engage_interview engage_interview)
		{
            string sql =
				"INSERT Engage_interview (Interview_amount, Image_degree, Native_language_degree, Foreign_language_degree, Response_speed_degree, EQ_degree, IQ_degree, Multi_quality_degree, Register_users_no, Checker_users_no, Regist_time, Check_time, Er_no, Result, Interview_comment, Check_comment, Check_status)" +
				"VALUES (@Interview_amount, @Image_degree, @Native_language_degree, @Foreign_language_degree, @Response_speed_degree, @EQ_degree, @IQ_degree, @Multi_quality_degree, @Register_users_no, @Checker_users_no, @Regist_time, @Check_time, @Er_no, @Result, @Interview_comment, @Check_comment, @Check_status)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Er_no", DBHelper.GetValueByWhetherNull(engage_interview.Er_no.Id)), //FK
					new SqlParameter("@Interview_amount", DBHelper.GetValueByWhetherNull(engage_interview.Interview_amount)),
					new SqlParameter("@Image_degree", DBHelper.GetValueByWhetherNull(engage_interview.Image_degree)),
					new SqlParameter("@Native_language_degree", DBHelper.GetValueByWhetherNull(engage_interview.Native_language_degree)),
					new SqlParameter("@Foreign_language_degree", DBHelper.GetValueByWhetherNull(engage_interview.Foreign_language_degree)),
					new SqlParameter("@Response_speed_degree", DBHelper.GetValueByWhetherNull(engage_interview.Response_speed_degree)),
					new SqlParameter("@EQ_degree", DBHelper.GetValueByWhetherNull(engage_interview.EQ_degree)),
					new SqlParameter("@IQ_degree", DBHelper.GetValueByWhetherNull(engage_interview.IQ_degree)),
					new SqlParameter("@Multi_quality_degree", DBHelper.GetValueByWhetherNull(engage_interview.Multi_quality_degree)),
					new SqlParameter("@Register_users_no", DBHelper.GetValueByWhetherNull(engage_interview.Register_users_no)),
					new SqlParameter("@Checker_users_no", DBHelper.GetValueByWhetherNull(engage_interview.Checker_users_no)),
					new SqlParameter("@Regist_time", DBHelper.GetValueByWhetherNull(engage_interview.Regist_time)),
					new SqlParameter("@Check_time", DBHelper.GetValueByWhetherNull(engage_interview.Check_time)),
					new SqlParameter("@Result", DBHelper.GetValueByWhetherNull(engage_interview.Result)),
					new SqlParameter("@Interview_comment", DBHelper.GetValueByWhetherNull(engage_interview.Interview_comment)),
					new SqlParameter("@Check_comment", DBHelper.GetValueByWhetherNull(engage_interview.Check_comment)),
					new SqlParameter("@Check_status", DBHelper.GetValueByWhetherNull(engage_interview.Check_status))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetEngage_interviewById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteEngage_interview(Engage_interview engage_interview)
		{
			DeleteEngage_interviewById( engage_interview.Id );
		}

        public static void DeleteEngage_interviewById(int id)
		{
            string sql = "DELETE Engage_interview WHERE Id = @Id";

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
		
        public static void ModifyEngage_interview(Engage_interview engage_interview)
        {
            string sql =
                "UPDATE Engage_interview " +
                "SET " +
	                "Er_no = @Er_no, " + //FK
	                "Interview_amount = @Interview_amount, " +
	                "Image_degree = @Image_degree, " +
	                "Native_language_degree = @Native_language_degree, " +
	                "Foreign_language_degree = @Foreign_language_degree, " +
	                "Response_speed_degree = @Response_speed_degree, " +
	                "EQ_degree = @EQ_degree, " +
	                "IQ_degree = @IQ_degree, " +
	                "Multi_quality_degree = @Multi_quality_degree, " +
	                "Register_users_no = @Register_users_no, " +
	                "Checker_users_no = @Checker_users_no, " +
	                "Regist_time = @Regist_time, " +
	                "Check_time = @Check_time, " +
	                "Result = @Result, " +
	                "Interview_comment = @Interview_comment, " +
	                "Check_comment = @Check_comment, " +
	                "Check_status = @Check_status " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", engage_interview.Id),
					new SqlParameter("@Er_no", DBHelper.GetValueByWhetherNull(engage_interview.Er_no.Id)), //FK
					new SqlParameter("@Interview_amount", DBHelper.GetValueByWhetherNull(engage_interview.Interview_amount)),
					new SqlParameter("@Image_degree", DBHelper.GetValueByWhetherNull(engage_interview.Image_degree)),
					new SqlParameter("@Native_language_degree", DBHelper.GetValueByWhetherNull(engage_interview.Native_language_degree)),
					new SqlParameter("@Foreign_language_degree", DBHelper.GetValueByWhetherNull(engage_interview.Foreign_language_degree)),
					new SqlParameter("@Response_speed_degree", DBHelper.GetValueByWhetherNull(engage_interview.Response_speed_degree)),
					new SqlParameter("@EQ_degree", DBHelper.GetValueByWhetherNull(engage_interview.EQ_degree)),
					new SqlParameter("@IQ_degree", DBHelper.GetValueByWhetherNull(engage_interview.IQ_degree)),
					new SqlParameter("@Multi_quality_degree", DBHelper.GetValueByWhetherNull(engage_interview.Multi_quality_degree)),
					new SqlParameter("@Register_users_no", DBHelper.GetValueByWhetherNull(engage_interview.Register_users_no)),
					new SqlParameter("@Checker_users_no", DBHelper.GetValueByWhetherNull(engage_interview.Checker_users_no)),
					new SqlParameter("@Regist_time", DBHelper.GetValueByWhetherNull(engage_interview.Regist_time)),
					new SqlParameter("@Check_time", DBHelper.GetValueByWhetherNull(engage_interview.Check_time)),
					new SqlParameter("@Result", DBHelper.GetValueByWhetherNull(engage_interview.Result)),
					new SqlParameter("@Interview_comment", DBHelper.GetValueByWhetherNull(engage_interview.Interview_comment)),
					new SqlParameter("@Check_comment", DBHelper.GetValueByWhetherNull(engage_interview.Check_comment)),
					new SqlParameter("@Check_status", DBHelper.GetValueByWhetherNull(engage_interview.Check_status))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<Engage_interview> GetAllEngage_interviews()
        {
            string sqlAll = "SELECT * FROM Engage_interview";
			return GetEngage_interviewsBySql( sqlAll );
        }
		
        public static Engage_interview GetEngage_interviewById(int id)
        {
            string sql = "SELECT * FROM Engage_interview WHERE Id = @Id";

			int er_no;

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    Engage_interview engage_interview = new Engage_interview();

					try{
					engage_interview.Id = (int)reader["Id"];
					}catch
					{}
					try{
					engage_interview.Interview_amount = (int)reader["Interview_amount"];
					}catch
					{}
					try{
					engage_interview.Image_degree = (string)reader["Image_degree"];
					}catch
					{}
					try{
					engage_interview.Native_language_degree = (string)reader["Native_language_degree"];
					}catch
					{}
					try{
					engage_interview.Foreign_language_degree = (string)reader["Foreign_language_degree"];
					}catch
					{}
					try{
					engage_interview.Response_speed_degree = (string)reader["Response_speed_degree"];
					}catch
					{}
					try{
					engage_interview.EQ_degree = (string)reader["EQ_degree"];
					}catch
					{}
					try{
					engage_interview.IQ_degree = (string)reader["IQ_degree"];
					}catch
					{}
					try{
					engage_interview.Multi_quality_degree = (string)reader["Multi_quality_degree"];
					}catch
					{}
					try{
					engage_interview.Register_users_no = (int)reader["Register_users_no"];
					}catch
					{}
					try{
					engage_interview.Checker_users_no = (int)reader["Checker_users_no"];
					}catch
					{}
					try{
					engage_interview.Regist_time = (DateTime)reader["Regist_time"];
					}catch
					{}
					try{
					engage_interview.Check_time = (DateTime)reader["Check_time"];
					}catch
					{}
					try{
					engage_interview.Result = (string)reader["Result"];
					}catch
					{}
					try{
					engage_interview.Interview_comment = (string)reader["Interview_comment"];
					}catch
					{}
					try{
					engage_interview.Check_comment = (string)reader["Check_comment"];
					}catch
					{}
					try{
					engage_interview.Check_status = (int)reader["Check_status"];
					}catch
					{}
					er_no = (int)reader["Er_no"]; //FK

                    reader.Close();

					engage_interview.Er_no = Engage_resumeService.GetEngage_resumeById(er_no);
					
                    return engage_interview;
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
		
		
		
		
        private static IList<Engage_interview> GetEngage_interviewsBySql( string safeSql )
        {
            List<Engage_interview> list = new List<Engage_interview>();

			try
			{
				DataTable table = DBHelper.GetDataTable( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					Engage_interview engage_interview = new Engage_interview();
					
					try{
					engage_interview.Id = (int)row["Id"];
					}catch
					{}
					try{
					engage_interview.Interview_amount = (int)row["Interview_amount"];
					}catch
					{}
					try{
					engage_interview.Image_degree = (string)row["Image_degree"];
					}catch
					{}
					try{
					engage_interview.Native_language_degree = (string)row["Native_language_degree"];
					}catch
					{}
					try{
					engage_interview.Foreign_language_degree = (string)row["Foreign_language_degree"];
					}catch
					{}
					try{
					engage_interview.Response_speed_degree = (string)row["Response_speed_degree"];
					}catch
					{}
					try{
					engage_interview.EQ_degree = (string)row["EQ_degree"];
					}catch
					{}
					try{
					engage_interview.IQ_degree = (string)row["IQ_degree"];
					}catch
					{}
					try{
					engage_interview.Multi_quality_degree = (string)row["Multi_quality_degree"];
					}catch
					{}
					try{
					engage_interview.Register_users_no = (int)row["Register_users_no"];
					}catch
					{}
					try{
					engage_interview.Checker_users_no = (int)row["Checker_users_no"];
					}catch
					{}
					try{
					engage_interview.Regist_time = (DateTime)row["Regist_time"];
					}catch
					{}
					try{
					engage_interview.Check_time = (DateTime)row["Check_time"];
					}catch
					{}
					try{
					engage_interview.Result = (string)row["Result"];
					}catch
					{}
					try{
					engage_interview.Interview_comment = (string)row["Interview_comment"];
					}catch
					{}
					try{
					engage_interview.Check_comment = (string)row["Check_comment"];
					}catch
					{}
					try{
					engage_interview.Check_status = (int)row["Check_status"];
					}catch
					{}
					engage_interview.Er_no = Engage_resumeService.GetEngage_resumeById((int)row["Er_no"]); //FK
	
					list.Add(engage_interview);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<Engage_interview> GetEngage_interviewsBySql( string sql, params SqlParameter[] values )
        {
            List<Engage_interview> list = new List<Engage_interview>();

			try
			{
				DataTable table = DBHelper.GetDataTable( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					Engage_interview engage_interview = new Engage_interview();
					
					try{
					engage_interview.Id = (int)row["Id"];
					}catch
					{}
					try{
					engage_interview.Interview_amount = (int)row["Interview_amount"];
					}catch
					{}
					try{
					engage_interview.Image_degree = (string)row["Image_degree"];
					}catch
					{}
					try{
					engage_interview.Native_language_degree = (string)row["Native_language_degree"];
					}catch
					{}
					try{
					engage_interview.Foreign_language_degree = (string)row["Foreign_language_degree"];
					}catch
					{}
					try{
					engage_interview.Response_speed_degree = (string)row["Response_speed_degree"];
					}catch
					{}
					try{
					engage_interview.EQ_degree = (string)row["EQ_degree"];
					}catch
					{}
					try{
					engage_interview.IQ_degree = (string)row["IQ_degree"];
					}catch
					{}
					try{
					engage_interview.Multi_quality_degree = (string)row["Multi_quality_degree"];
					}catch
					{}
					try{
					engage_interview.Register_users_no = (int)row["Register_users_no"];
					}catch
					{}
					try{
					engage_interview.Checker_users_no = (int)row["Checker_users_no"];
					}catch
					{}
					try{
					engage_interview.Regist_time = (DateTime)row["Regist_time"];
					}catch
					{}
					try{
					engage_interview.Check_time = (DateTime)row["Check_time"];
					}catch
					{}
					try{
					engage_interview.Result = (string)row["Result"];
					}catch
					{}
					try{
					engage_interview.Interview_comment = (string)row["Interview_comment"];
					}catch
					{}
					try{
					engage_interview.Check_comment = (string)row["Check_comment"];
					}catch
					{}
					try{
					engage_interview.Check_status = (int)row["Check_status"];
					}catch
					{}
					engage_interview.Er_no = Engage_resumeService.GetEngage_resumeById((int)row["Er_no"]); //FK
	
					list.Add(engage_interview);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
			
        }

        public static IList<Engage_interview> Engage_interviewAdvSearch(int majorId, int resumeStatusId, string key, string startTime, string endTime)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" 1=1 ");
            if(majorId != -1)
            {
                sb.Append(" and majorId=" + majorId);
            }

            if(resumeStatusId != -1)
            {
                sb.Append(" and Check_status=" + resumeStatusId);
            }

            if (!string.IsNullOrEmpty(key))
            {
                sb.AppendFormat(" and Human_name like '%{0}%'", key.Trim());
            }

            if (!string.IsNullOrEmpty(startTime))
            {
                if (!string.IsNullOrEmpty(endTime))
                {
                    sb.Append(string.Format(" and Regist_time between '{0}' and '{1}'", startTime + " 00:00:00", endTime + " 23:59:59"));

                }
                else
                {
                    sb.Append(string.Format(" and Regist_time < '{0}'", startTime + " 00:00:00"));
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(endTime))
                {
                    sb.AppendFormat(" and Regist_time < '{0}'", endTime + " 23:59:59");
                }
            }

            string sql = "select Id, Interview_amount, Image_degree, Native_language_degree, Foreign_language_degree, Response_speed_degree, EQ_degree, IQ_degree, Multi_quality_degree, Register_users_no, Checker_users_no, Regist_time, Check_time, Er_no, Result, Interview_comment, Check_comment, Check_status, Human_name, majorId, Major_name from V_EngageInterview where " + sb.ToString();
            return GetEngage_interviewsBySql(sql);
        }
		
	}
}

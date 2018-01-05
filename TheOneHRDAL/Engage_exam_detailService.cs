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
	public static partial class Engage_exam_detailService
	{
        public static Engage_exam_detail AddEngage_exam_detail(Engage_exam_detail engage_exam_detail)
		{
            string sql =
				"INSERT Engage_exam_detail (Ee_no, Cqsk_no, Question_amount)" +
				"VALUES (@Ee_no, @Cqsk_no, @Question_amount)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Cqsk_no", DBHelper.GetValueByWhetherNull(engage_exam_detail.Cqsk_no.Id)), //FK
					new SqlParameter("@Ee_no", DBHelper.GetValueByWhetherNull(engage_exam_detail.Ee_no.Id)), //FK
					new SqlParameter("@Question_amount", DBHelper.GetValueByWhetherNull(engage_exam_detail.Question_amount))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetEngage_exam_detailById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteEngage_exam_detail(Engage_exam_detail engage_exam_detail)
		{
			DeleteEngage_exam_detailById( engage_exam_detail.Id );
		}

        public static void DeleteEngage_exam_detailById(int id)
		{
            string sql = "DELETE Engage_exam_detail WHERE Id = @Id";

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
		
        public static void ModifyEngage_exam_detail(Engage_exam_detail engage_exam_detail)
        {
            string sql =
                "UPDATE Engage_exam_detail " +
                "SET " +
	                "Cqsk_no = @Cqsk_no, " + //FK
	                "Ee_no = @Ee_no, " + //FK
	                "Question_amount = @Question_amount " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", engage_exam_detail.Id),
					new SqlParameter("@Cqsk_no", DBHelper.GetValueByWhetherNull(engage_exam_detail.Cqsk_no.Id)), //FK
					new SqlParameter("@Ee_no", DBHelper.GetValueByWhetherNull(engage_exam_detail.Ee_no.Id)), //FK
					new SqlParameter("@Question_amount", DBHelper.GetValueByWhetherNull(engage_exam_detail.Question_amount))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<Engage_exam_detail> GetAllEngage_exam_details()
        {
            string sqlAll = "SELECT * FROM Engage_exam_detail";
			return GetEngage_exam_detailsBySql( sqlAll );
        }
		
        public static Engage_exam_detail GetEngage_exam_detailById(int id)
        {
            string sql = "SELECT * FROM Engage_exam_detail WHERE Id = @Id";

			int cqsk_no;
			int ee_no;

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    Engage_exam_detail engage_exam_detail = new Engage_exam_detail();

					try{
					engage_exam_detail.Id = (int)reader["Id"];
					}catch
					{}
					try{
					engage_exam_detail.Question_amount = (int)reader["Question_amount"];
					}catch
					{}
					cqsk_no = (int)reader["Cqsk_no"]; //FK
					ee_no = (int)reader["Ee_no"]; //FK

                    reader.Close();

					engage_exam_detail.Cqsk_no = Config_question_second_kindService.GetConfig_question_second_kindById(cqsk_no);
					engage_exam_detail.Ee_no = Engage_examService.GetEngage_examById(ee_no);
					
                    return engage_exam_detail;
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
		
		
		
		
        private static IList<Engage_exam_detail> GetEngage_exam_detailsBySql( string safeSql )
        {
            List<Engage_exam_detail> list = new List<Engage_exam_detail>();

			try
			{
				DataTable table = DBHelper.GetDataTable( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					Engage_exam_detail engage_exam_detail = new Engage_exam_detail();
					
					try{
					engage_exam_detail.Id = (int)row["Id"];
					}catch
					{}
					try{
					engage_exam_detail.Question_amount = (int)row["Question_amount"];
					}catch
					{}
					engage_exam_detail.Cqsk_no = Config_question_second_kindService.GetConfig_question_second_kindById((int)row["Cqsk_no"]); //FK
					engage_exam_detail.Ee_no = Engage_examService.GetEngage_examById((int)row["Ee_no"]); //FK
	
					list.Add(engage_exam_detail);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<Engage_exam_detail> GetEngage_exam_detailsBySql( string sql, params SqlParameter[] values )
        {
            List<Engage_exam_detail> list = new List<Engage_exam_detail>();

			try
			{
				DataTable table = DBHelper.GetDataTable( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					Engage_exam_detail engage_exam_detail = new Engage_exam_detail();
					
					try{
					engage_exam_detail.Id = (int)row["Id"];
					}catch
					{}
					try{
					engage_exam_detail.Question_amount = (int)row["Question_amount"];
					}catch
					{}
					engage_exam_detail.Cqsk_no = Config_question_second_kindService.GetConfig_question_second_kindById((int)row["Cqsk_no"]); //FK
					engage_exam_detail.Ee_no = Engage_examService.GetEngage_examById((int)row["Ee_no"]); //FK
	
					list.Add(engage_exam_detail);
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

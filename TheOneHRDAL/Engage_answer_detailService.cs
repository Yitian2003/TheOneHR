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
	public static partial class Engage_answer_detailService
	{
        public static Engage_answer_detail AddEngage_answer_detail(Engage_answer_detail engage_answer_detail)
		{
            string sql =
				"INSERT Engage_answer_detail (Ea_no, Answer_details_number, Es_no, Answer)" +
				"VALUES (@Ea_no, @Answer_details_number, @Es_no, @Answer)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Ea_no", DBHelper.GetValueByWhetherNull(engage_answer_detail.Ea_no.Id)), //FK
					new SqlParameter("@Es_no", DBHelper.GetValueByWhetherNull(engage_answer_detail.Es_no.Id)), //FK
					new SqlParameter("@Answer_details_number", DBHelper.GetValueByWhetherNull(engage_answer_detail.Answer_details_number)),
					new SqlParameter("@Answer", DBHelper.GetValueByWhetherNull(engage_answer_detail.Answer))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetEngage_answer_detailById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteEngage_answer_detail(Engage_answer_detail engage_answer_detail)
		{
			DeleteEngage_answer_detailById( engage_answer_detail.Id );
		}

        public static void DeleteEngage_answer_detailById(int id)
		{
            string sql = "DELETE Engage_answer_detail WHERE Id = @Id";

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
		
        public static void ModifyEngage_answer_detail(Engage_answer_detail engage_answer_detail)
        {
            string sql =
                "UPDATE Engage_answer_detail " +
                "SET " +
	                "Ea_no = @Ea_no, " + //FK
	                "Es_no = @Es_no, " + //FK
	                "Answer_details_number = @Answer_details_number, " +
	                "Answer = @Answer " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", engage_answer_detail.Id),
					new SqlParameter("@Ea_no", DBHelper.GetValueByWhetherNull(engage_answer_detail.Ea_no.Id)), //FK
					new SqlParameter("@Es_no", DBHelper.GetValueByWhetherNull(engage_answer_detail.Es_no.Id)), //FK
					new SqlParameter("@Answer_details_number", DBHelper.GetValueByWhetherNull(engage_answer_detail.Answer_details_number)),
					new SqlParameter("@Answer", DBHelper.GetValueByWhetherNull(engage_answer_detail.Answer))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<Engage_answer_detail> GetAllEngage_answer_details()
        {
            string sqlAll = "SELECT * FROM Engage_answer_detail";
			return GetEngage_answer_detailsBySql( sqlAll );
        }
		
        public static Engage_answer_detail GetEngage_answer_detailById(int id)
        {
            string sql = "SELECT * FROM Engage_answer_detail WHERE Id = @Id";

			int ea_no;
			int es_no;

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    Engage_answer_detail engage_answer_detail = new Engage_answer_detail();

					try{
					engage_answer_detail.Id = (int)reader["Id"];
					}catch
					{}
					try{
					engage_answer_detail.Answer_details_number = (string)reader["Answer_details_number"];
					}catch
					{}
					try{
					engage_answer_detail.Answer = (string)reader["Answer"];
					}catch
					{}
					ea_no = (int)reader["Ea_no"]; //FK
					es_no = (int)reader["Es_no"]; //FK

                    reader.Close();

					engage_answer_detail.Ea_no = Engage_answerService.GetEngage_answerById(ea_no);
					engage_answer_detail.Es_no = Engage_subjectService.GetEngage_subjectById(es_no);
					
                    return engage_answer_detail;
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
		
		
		
		
        private static IList<Engage_answer_detail> GetEngage_answer_detailsBySql( string safeSql )
        {
            List<Engage_answer_detail> list = new List<Engage_answer_detail>();

			try
			{
				DataTable table = DBHelper.GetDataTable( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					Engage_answer_detail engage_answer_detail = new Engage_answer_detail();
					
					try{
					engage_answer_detail.Id = (int)row["Id"];
					}catch
					{}
					try{
					engage_answer_detail.Answer_details_number = (string)row["Answer_details_number"];
					}catch
					{}
					try{
					engage_answer_detail.Answer = (string)row["Answer"];
					}catch
					{}
					engage_answer_detail.Ea_no = Engage_answerService.GetEngage_answerById((int)row["Ea_no"]); //FK
					engage_answer_detail.Es_no = Engage_subjectService.GetEngage_subjectById((int)row["Es_no"]); //FK
	
					list.Add(engage_answer_detail);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<Engage_answer_detail> GetEngage_answer_detailsBySql( string sql, params SqlParameter[] values )
        {
            List<Engage_answer_detail> list = new List<Engage_answer_detail>();

			try
			{
				DataTable table = DBHelper.GetDataTable( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					Engage_answer_detail engage_answer_detail = new Engage_answer_detail();
					
					try{
					engage_answer_detail.Id = (int)row["Id"];
					}catch
					{}
					try{
					engage_answer_detail.Answer_details_number = (string)row["Answer_details_number"];
					}catch
					{}
					try{
					engage_answer_detail.Answer = (string)row["Answer"];
					}catch
					{}
					engage_answer_detail.Ea_no = Engage_answerService.GetEngage_answerById((int)row["Ea_no"]); //FK
					engage_answer_detail.Es_no = Engage_subjectService.GetEngage_subjectById((int)row["Es_no"]); //FK
	
					list.Add(engage_answer_detail);
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

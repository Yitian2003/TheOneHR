//============================================================
// Producnt name:		DAL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2010-3-30 14:06:48
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using TheOneHRModels;

namespace TheOneHRDAL
{
	public static partial class Engage_resumeService
	{
        public static Engage_resume AddEngage_resume(Engage_resume engage_resume)
		{
            string sql =
				"INSERT Engage_resume (Human_name, Engage_type, Human_address, Human_postcode, Emr_no, Human_telephone, Human_homephone, Human_mobilephone, Human_email, Human_hobby, Cg_no, Human_sex, Cn_no, Cr_no, Human_party, Cc_no, Human_birthday, Human_age, Ced_no, Human_educated_year, Cs_no, Human_college, Human_id_card, Human_birthplace, Demand_salary_standard, Human_history_record, Remark, Recomandation, Human_picture, Attachment_name, Check_status, Register_users_no, Checker_users_no, Regist_time, Check_time, Interview_status, Interview_amount, Total_point, Test_amount, Test_checker_users_no, Test_check_time, Pass_register_users_no, Pass_regist_time, Pass_checker_users_no, Pass_check_time, Pass_check_status, Pass_checkComment, Pass_passComment)" +
				"VALUES (@Human_name, @Engage_type, @Human_address, @Human_postcode, @Emr_no, @Human_telephone, @Human_homephone, @Human_mobilephone, @Human_email, @Human_hobby, @Cg_no, @Human_sex, @Cn_no, @Cr_no, @Human_party, @Cc_no, @Human_birthday, @Human_age, @Ced_no, @Human_educated_year, @Cs_no, @Human_college, @Human_id_card, @Human_birthplace, @Demand_salary_standard, @Human_history_record, @Remark, @Recomandation, @Human_picture, @Attachment_name, @Check_status, @Register_users_no, @Checker_users_no, @Regist_time, @Check_time, @Interview_status, @Interview_amount, @Total_point, @Test_amount, @Test_checker_users_no, @Test_check_time, @Pass_register_users_no, @Pass_regist_time, @Pass_checker_users_no, @Pass_check_time, @Pass_check_status, @Pass_checkComment, @Pass_passComment)";
				
			sql += " ; SELECT @@IDENTITY";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Cc_no", DBHelper.GetValueByWhetherNull(engage_resume.Cc_no.Id)), //FK
					new SqlParameter("@Ced_no", DBHelper.GetValueByWhetherNull(engage_resume.Ced_no.Id)), //FK
					new SqlParameter("@Cg_no", DBHelper.GetValueByWhetherNull(engage_resume.Cg_no.Id)), //FK
					new SqlParameter("@Cn_no", DBHelper.GetValueByWhetherNull(engage_resume.Cn_no.Id)), //FK
					new SqlParameter("@Cr_no", DBHelper.GetValueByWhetherNull(engage_resume.Cr_no.Id)), //FK
					new SqlParameter("@Cs_no", DBHelper.GetValueByWhetherNull(engage_resume.Cs_no.Id)), //FK
					new SqlParameter("@Emr_no", DBHelper.GetValueByWhetherNull(engage_resume.Emr_no.Id)), //FK
					new SqlParameter("@Human_name", DBHelper.GetValueByWhetherNull(engage_resume.Human_name)),
					new SqlParameter("@Engage_type", DBHelper.GetValueByWhetherNull(engage_resume.Engage_type)),
					new SqlParameter("@Human_address", DBHelper.GetValueByWhetherNull(engage_resume.Human_address)),
					new SqlParameter("@Human_postcode", DBHelper.GetValueByWhetherNull(engage_resume.Human_postcode)),
					new SqlParameter("@Human_telephone", DBHelper.GetValueByWhetherNull(engage_resume.Human_telephone)),
					new SqlParameter("@Human_homephone", DBHelper.GetValueByWhetherNull(engage_resume.Human_homephone)),
					new SqlParameter("@Human_mobilephone", DBHelper.GetValueByWhetherNull(engage_resume.Human_mobilephone)),
					new SqlParameter("@Human_email", DBHelper.GetValueByWhetherNull(engage_resume.Human_email)),
					new SqlParameter("@Human_hobby", DBHelper.GetValueByWhetherNull(engage_resume.Human_hobby)),
					new SqlParameter("@Human_sex", DBHelper.GetValueByWhetherNull(engage_resume.Human_sex)),
					new SqlParameter("@Human_party", DBHelper.GetValueByWhetherNull(engage_resume.Human_party)),
					new SqlParameter("@Human_birthday", DBHelper.GetValueByWhetherNull(engage_resume.Human_birthday)),
					new SqlParameter("@Human_age", DBHelper.GetValueByWhetherNull(engage_resume.Human_age)),
					new SqlParameter("@Human_educated_year", DBHelper.GetValueByWhetherNull(engage_resume.Human_educated_year)),
					new SqlParameter("@Human_college", DBHelper.GetValueByWhetherNull(engage_resume.Human_college)),
					new SqlParameter("@Human_id_card", DBHelper.GetValueByWhetherNull(engage_resume.Human_id_card)),
					new SqlParameter("@Human_birthplace", DBHelper.GetValueByWhetherNull(engage_resume.Human_birthplace)),
					new SqlParameter("@Demand_salary_standard", DBHelper.GetValueByWhetherNull(engage_resume.Demand_salary_standard)),
					new SqlParameter("@Human_history_record", DBHelper.GetValueByWhetherNull(engage_resume.Human_history_record)),
					new SqlParameter("@Remark", DBHelper.GetValueByWhetherNull(engage_resume.Remark)),
					new SqlParameter("@Recomandation", DBHelper.GetValueByWhetherNull(engage_resume.Recomandation)),
					new SqlParameter("@Human_picture", DBHelper.GetValueByWhetherNull(engage_resume.Human_picture)),
					new SqlParameter("@Attachment_name", DBHelper.GetValueByWhetherNull(engage_resume.Attachment_name)),
					new SqlParameter("@Check_status", DBHelper.GetValueByWhetherNull(engage_resume.Check_status)),
					new SqlParameter("@Register_users_no", DBHelper.GetValueByWhetherNull(engage_resume.Register_users_no)),
					new SqlParameter("@Checker_users_no", DBHelper.GetValueByWhetherNull(engage_resume.Checker_users_no)),
					new SqlParameter("@Regist_time", DBHelper.GetValueByWhetherNull(engage_resume.Regist_time)),
					new SqlParameter("@Check_time", DBHelper.GetValueByWhetherNull(engage_resume.Check_time)),
					new SqlParameter("@Interview_status", DBHelper.GetValueByWhetherNull(engage_resume.Interview_status)),
					new SqlParameter("@Interview_amount", DBHelper.GetValueByWhetherNull(engage_resume.Interview_amount)),
					new SqlParameter("@Total_point", DBHelper.GetValueByWhetherNull(engage_resume.Total_point)),
					new SqlParameter("@Test_amount", DBHelper.GetValueByWhetherNull(engage_resume.Test_amount)),
					new SqlParameter("@Test_checker_users_no", DBHelper.GetValueByWhetherNull(engage_resume.Test_checker_users_no)),
					new SqlParameter("@Test_check_time", DBHelper.GetValueByWhetherNull(engage_resume.Test_check_time)),
					new SqlParameter("@Pass_register_users_no", DBHelper.GetValueByWhetherNull(engage_resume.Pass_register_users_no)),
					new SqlParameter("@Pass_regist_time", DBHelper.GetValueByWhetherNull(engage_resume.Pass_regist_time)),
					new SqlParameter("@Pass_checker_users_no", DBHelper.GetValueByWhetherNull(engage_resume.Pass_checker_users_no)),
					new SqlParameter("@Pass_check_time", DBHelper.GetValueByWhetherNull(engage_resume.Pass_check_time)),
					new SqlParameter("@Pass_check_status", DBHelper.GetValueByWhetherNull(engage_resume.Pass_check_status)),
					new SqlParameter("@Pass_checkComment", DBHelper.GetValueByWhetherNull(engage_resume.Pass_checkComment)),
					new SqlParameter("@Pass_passComment", DBHelper.GetValueByWhetherNull(engage_resume.Pass_passComment))
				};
				
                int newId = DBHelper.GetScalar(sql, para);
				return GetEngage_resumeById(newId);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
                throw e;
            }
		}
		
        public static void DeleteEngage_resume(Engage_resume engage_resume)
		{
			DeleteEngage_resumeById( engage_resume.Id );
		}

        public static void DeleteEngage_resumeById(int id)
		{
            string sql = "DELETE Engage_resume WHERE Id = @Id";

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
		
        public static void DeleteEngage_resumeByHuman_id_card(string human_id_card)
		{
            string sql = "DELETE Engage_resume WHERE Human_id_card = @Human_id_card";

            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Human_id_card", human_id_card)
				};
			
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
				Console.WriteLine(e.Message);
				throw e;
            }
		}
		
        public static void ModifyEngage_resume(Engage_resume engage_resume)
        {
            string sql =
                "UPDATE Engage_resume " +
                "SET " +
	                "Cc_no = @Cc_no, " + //FK
	                "Ced_no = @Ced_no, " + //FK
	                "Cg_no = @Cg_no, " + //FK
	                "Cn_no = @Cn_no, " + //FK
	                "Cr_no = @Cr_no, " + //FK
	                "Cs_no = @Cs_no, " + //FK
	                "Emr_no = @Emr_no, " + //FK
	                "Human_name = @Human_name, " +
	                "Engage_type = @Engage_type, " +
	                "Human_address = @Human_address, " +
	                "Human_postcode = @Human_postcode, " +
	                "Human_telephone = @Human_telephone, " +
	                "Human_homephone = @Human_homephone, " +
	                "Human_mobilephone = @Human_mobilephone, " +
	                "Human_email = @Human_email, " +
	                "Human_hobby = @Human_hobby, " +
	                "Human_sex = @Human_sex, " +
	                "Human_party = @Human_party, " +
	                "Human_birthday = @Human_birthday, " +
	                "Human_age = @Human_age, " +
	                "Human_educated_year = @Human_educated_year, " +
	                "Human_college = @Human_college, " +
	                "Human_id_card = @Human_id_card, " +
	                "Human_birthplace = @Human_birthplace, " +
	                "Demand_salary_standard = @Demand_salary_standard, " +
	                "Human_history_record = @Human_history_record, " +
	                "Remark = @Remark, " +
	                "Recomandation = @Recomandation, " +
	                "Human_picture = @Human_picture, " +
	                "Attachment_name = @Attachment_name, " +
	                "Check_status = @Check_status, " +
	                "Register_users_no = @Register_users_no, " +
	                "Checker_users_no = @Checker_users_no, " +
	                "Regist_time = @Regist_time, " +
	                "Check_time = @Check_time, " +
	                "Interview_status = @Interview_status, " +
	                "Interview_amount = @Interview_amount, " +
	                "Total_point = @Total_point, " +
	                "Test_amount = @Test_amount, " +
	                "Test_checker_users_no = @Test_checker_users_no, " +
	                "Test_check_time = @Test_check_time, " +
	                "Pass_register_users_no = @Pass_register_users_no, " +
	                "Pass_regist_time = @Pass_regist_time, " +
	                "Pass_checker_users_no = @Pass_checker_users_no, " +
	                "Pass_check_time = @Pass_check_time, " +
	                "Pass_check_status = @Pass_check_status, " +
	                "Pass_checkComment = @Pass_checkComment, " +
	                "Pass_passComment = @Pass_passComment " +
                "WHERE Id = @Id";


            try
            {
				SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", engage_resume.Id),
					new SqlParameter("@Cc_no", DBHelper.GetValueByWhetherNull(engage_resume.Cc_no.Id)), //FK
					new SqlParameter("@Ced_no", DBHelper.GetValueByWhetherNull(engage_resume.Ced_no.Id)), //FK
					new SqlParameter("@Cg_no", DBHelper.GetValueByWhetherNull(engage_resume.Cg_no.Id)), //FK
					new SqlParameter("@Cn_no", DBHelper.GetValueByWhetherNull(engage_resume.Cn_no.Id)), //FK
					new SqlParameter("@Cr_no", DBHelper.GetValueByWhetherNull(engage_resume.Cr_no.Id)), //FK
					new SqlParameter("@Cs_no", DBHelper.GetValueByWhetherNull(engage_resume.Cs_no.Id)), //FK
					new SqlParameter("@Emr_no", DBHelper.GetValueByWhetherNull(engage_resume.Emr_no.Id)), //FK
					new SqlParameter("@Human_name", DBHelper.GetValueByWhetherNull(engage_resume.Human_name)),
					new SqlParameter("@Engage_type", DBHelper.GetValueByWhetherNull(engage_resume.Engage_type)),
					new SqlParameter("@Human_address", DBHelper.GetValueByWhetherNull(engage_resume.Human_address)),
					new SqlParameter("@Human_postcode", DBHelper.GetValueByWhetherNull(engage_resume.Human_postcode)),
					new SqlParameter("@Human_telephone", DBHelper.GetValueByWhetherNull(engage_resume.Human_telephone)),
					new SqlParameter("@Human_homephone", DBHelper.GetValueByWhetherNull(engage_resume.Human_homephone)),
					new SqlParameter("@Human_mobilephone", DBHelper.GetValueByWhetherNull(engage_resume.Human_mobilephone)),
					new SqlParameter("@Human_email", DBHelper.GetValueByWhetherNull(engage_resume.Human_email)),
					new SqlParameter("@Human_hobby", DBHelper.GetValueByWhetherNull(engage_resume.Human_hobby)),
					new SqlParameter("@Human_sex", DBHelper.GetValueByWhetherNull(engage_resume.Human_sex)),
					new SqlParameter("@Human_party", DBHelper.GetValueByWhetherNull(engage_resume.Human_party)),
					new SqlParameter("@Human_birthday", DBHelper.GetValueByWhetherNull(engage_resume.Human_birthday)),
					new SqlParameter("@Human_age", DBHelper.GetValueByWhetherNull(engage_resume.Human_age)),
					new SqlParameter("@Human_educated_year", DBHelper.GetValueByWhetherNull(engage_resume.Human_educated_year)),
					new SqlParameter("@Human_college", DBHelper.GetValueByWhetherNull(engage_resume.Human_college)),
					new SqlParameter("@Human_id_card", DBHelper.GetValueByWhetherNull(engage_resume.Human_id_card)),
					new SqlParameter("@Human_birthplace", DBHelper.GetValueByWhetherNull(engage_resume.Human_birthplace)),
					new SqlParameter("@Demand_salary_standard", DBHelper.GetValueByWhetherNull(engage_resume.Demand_salary_standard)),
					new SqlParameter("@Human_history_record", DBHelper.GetValueByWhetherNull(engage_resume.Human_history_record)),
					new SqlParameter("@Remark", DBHelper.GetValueByWhetherNull(engage_resume.Remark)),
					new SqlParameter("@Recomandation", DBHelper.GetValueByWhetherNull(engage_resume.Recomandation)),
					new SqlParameter("@Human_picture", DBHelper.GetValueByWhetherNull(engage_resume.Human_picture)),
					new SqlParameter("@Attachment_name", DBHelper.GetValueByWhetherNull(engage_resume.Attachment_name)),
					new SqlParameter("@Check_status", DBHelper.GetValueByWhetherNull(engage_resume.Check_status)),
					new SqlParameter("@Register_users_no", DBHelper.GetValueByWhetherNull(engage_resume.Register_users_no)),
					new SqlParameter("@Checker_users_no", DBHelper.GetValueByWhetherNull(engage_resume.Checker_users_no)),
					new SqlParameter("@Regist_time", DBHelper.GetValueByWhetherNull(engage_resume.Regist_time)),
					new SqlParameter("@Check_time", DBHelper.GetValueByWhetherNull(engage_resume.Check_time)),
					new SqlParameter("@Interview_status", DBHelper.GetValueByWhetherNull(engage_resume.Interview_status)),
					new SqlParameter("@Interview_amount", DBHelper.GetValueByWhetherNull(engage_resume.Interview_amount)),
					new SqlParameter("@Total_point", DBHelper.GetValueByWhetherNull(engage_resume.Total_point)),
					new SqlParameter("@Test_amount", DBHelper.GetValueByWhetherNull(engage_resume.Test_amount)),
					new SqlParameter("@Test_checker_users_no", DBHelper.GetValueByWhetherNull(engage_resume.Test_checker_users_no)),
					new SqlParameter("@Test_check_time", DBHelper.GetValueByWhetherNull(engage_resume.Test_check_time)),
					new SqlParameter("@Pass_register_users_no", DBHelper.GetValueByWhetherNull(engage_resume.Pass_register_users_no)),
					new SqlParameter("@Pass_regist_time", DBHelper.GetValueByWhetherNull(engage_resume.Pass_regist_time)),
					new SqlParameter("@Pass_checker_users_no", DBHelper.GetValueByWhetherNull(engage_resume.Pass_checker_users_no)),
					new SqlParameter("@Pass_check_time", DBHelper.GetValueByWhetherNull(engage_resume.Pass_check_time)),
					new SqlParameter("@Pass_check_status", DBHelper.GetValueByWhetherNull(engage_resume.Pass_check_status)),
					new SqlParameter("@Pass_checkComment", DBHelper.GetValueByWhetherNull(engage_resume.Pass_checkComment)),
					new SqlParameter("@Pass_passComment", DBHelper.GetValueByWhetherNull(engage_resume.Pass_passComment))
				};

				DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
				throw e;
            }

        }		

        public static IList<Engage_resume> GetAllEngage_resumes()
        {
            string sqlAll = "SELECT * FROM Engage_resume";
			return GetEngage_resumesBySql( sqlAll );
        }
		
        public static Engage_resume GetEngage_resumeById(int id)
        {
            string sql = "SELECT * FROM Engage_resume WHERE Id = @Id";

			int cc_no;
			int ced_no;
			int cg_no;
			int cn_no;
			int cr_no;
			int cs_no;
			int emr_no;

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Id", id));
                if (reader.Read())
                {
					
                    Engage_resume engage_resume = new Engage_resume();

					try{
					engage_resume.Id = (int)reader["Id"];
					}catch
					{}
					try{
					engage_resume.Human_name = (string)reader["Human_name"];
					}catch
					{}
					try{
					engage_resume.Engage_type = (string)reader["Engage_type"];
					}catch
					{}
					try{
					engage_resume.Human_address = (string)reader["Human_address"];
					}catch
					{}
					try{
					engage_resume.Human_postcode = (string)reader["Human_postcode"];
					}catch
					{}
					try{
					engage_resume.Human_telephone = (string)reader["Human_telephone"];
					}catch
					{}
					try{
					engage_resume.Human_homephone = (string)reader["Human_homephone"];
					}catch
					{}
					try{
					engage_resume.Human_mobilephone = (string)reader["Human_mobilephone"];
					}catch
					{}
					try{
					engage_resume.Human_email = (string)reader["Human_email"];
					}catch
					{}
					try{
					engage_resume.Human_hobby = (string)reader["Human_hobby"];
					}catch
					{}
					try{
					engage_resume.Human_sex = (string)reader["Human_sex"];
					}catch
					{}
					try{
					engage_resume.Human_party = (string)reader["Human_party"];
					}catch
					{}
					try{
					engage_resume.Human_birthday = (DateTime)reader["Human_birthday"];
					}catch
					{}
					try{
					engage_resume.Human_age = (int)reader["Human_age"];
					}catch
					{}
					try{
					engage_resume.Human_educated_year = (int)reader["Human_educated_year"];
					}catch
					{}
					try{
					engage_resume.Human_college = (string)reader["Human_college"];
					}catch
					{}
					try{
					engage_resume.Human_id_card = (string)reader["Human_id_card"];
					}catch
					{}
					try{
					engage_resume.Human_birthplace = (string)reader["Human_birthplace"];
					}catch
					{}
					try{
					engage_resume.Demand_salary_standard = (decimal)reader["Demand_salary_standard"];
					}catch
					{}
					try{
					engage_resume.Human_history_record = (string)reader["Human_history_record"];
					}catch
					{}
					try{
					engage_resume.Remark = (string)reader["Remark"];
					}catch
					{}
					try{
					engage_resume.Recomandation = (string)reader["Recomandation"];
					}catch
					{}
					try{
					engage_resume.Human_picture = (string)reader["Human_picture"];
					}catch
					{}
					try{
					engage_resume.Attachment_name = (string)reader["Attachment_name"];
					}catch
					{}
					try{
					engage_resume.Check_status = (int)reader["Check_status"];
					}catch
					{}
					try{
					engage_resume.Register_users_no = (int)reader["Register_users_no"];
					}catch
					{}
					try{
					engage_resume.Checker_users_no = (int)reader["Checker_users_no"];
					}catch
					{}
					try{
					engage_resume.Regist_time = (DateTime)reader["Regist_time"];
					}catch
					{}
					try{
					engage_resume.Check_time = (DateTime)reader["Check_time"];
					}catch
					{}
					try{
					engage_resume.Interview_status = (int)reader["Interview_status"];
					}catch
					{}
					try{
					engage_resume.Interview_amount = (int)reader["Interview_amount"];
					}catch
					{}
					try{
					engage_resume.Total_point = (double)reader["Total_point"];
					}catch
					{}
					try{
					engage_resume.Test_amount = (int)reader["Test_amount"];
					}catch
					{}
					try{
					engage_resume.Test_checker_users_no = (int)reader["Test_checker_users_no"];
					}catch
					{}
					try{
					engage_resume.Test_check_time = (DateTime)reader["Test_check_time"];
					}catch
					{}
					try{
					engage_resume.Pass_register_users_no = (int)reader["Pass_register_users_no"];
					}catch
					{}
					try{
					engage_resume.Pass_regist_time = (DateTime)reader["Pass_regist_time"];
					}catch
					{}
					try{
					engage_resume.Pass_checker_users_no = (int)reader["Pass_checker_users_no"];
					}catch
					{}
					try{
					engage_resume.Pass_check_time = (DateTime)reader["Pass_check_time"];
					}catch
					{}
					try{
					engage_resume.Pass_check_status = (int)reader["Pass_check_status"];
					}catch
					{}
					try{
					engage_resume.Pass_checkComment = (string)reader["Pass_checkComment"];
					}catch
					{}
					try{
					engage_resume.Pass_passComment = (string)reader["Pass_passComment"];
					}catch
					{}
					cc_no = (int)reader["Cc_no"]; //FK
					ced_no = (int)reader["Ced_no"]; //FK
					cg_no = (int)reader["Cg_no"]; //FK
					cn_no = (int)reader["Cn_no"]; //FK
					cr_no = (int)reader["Cr_no"]; //FK
					cs_no = (int)reader["Cs_no"]; //FK
					emr_no = (int)reader["Emr_no"]; //FK

                    reader.Close();

					engage_resume.Cc_no = Config_countryService.GetConfig_countryById(cc_no);
					engage_resume.Ced_no = Config_educated_degreeService.GetConfig_educated_degreeById(ced_no);
					engage_resume.Cg_no = Config_goodatService.GetConfig_goodatById(cg_no);
					engage_resume.Cn_no = Config_nationService.GetConfig_nationById(cn_no);
					engage_resume.Cr_no = Config_religionService.GetConfig_religionById(cr_no);
					engage_resume.Cs_no = Config_specialityService.GetConfig_specialityById(cs_no);
					engage_resume.Emr_no = Engage_major_releaseService.GetEngage_major_releaseById(emr_no);
					
                    return engage_resume;
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
		
        public static Engage_resume GetEngage_resumeByHuman_id_card(string human_id_card)
        {
            string sql = "SELECT * FROM Engage_resume WHERE Human_id_card = @Human_id_card";

			int cc_no;
			int ced_no;
			int cg_no;
			int cn_no;
			int cr_no;
			int cs_no;
			int emr_no;

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Human_id_card", human_id_card));
                if (reader.Read())
                {
                    Engage_resume engage_resume = new Engage_resume();

					try{
					engage_resume.Id = (int)reader["Id"];
					}catch
					{}
					
					try{
					engage_resume.Human_name = (string)reader["Human_name"];
					}catch
					{}
					
					try{
					engage_resume.Engage_type = (string)reader["Engage_type"];
					}catch
					{}
					
					try{
					engage_resume.Human_address = (string)reader["Human_address"];
					}catch
					{}
					
					try{
					engage_resume.Human_postcode = (string)reader["Human_postcode"];
					}catch
					{}
					
					try{
					engage_resume.Human_telephone = (string)reader["Human_telephone"];
					}catch
					{}
					
					try{
					engage_resume.Human_homephone = (string)reader["Human_homephone"];
					}catch
					{}
					
					try{
					engage_resume.Human_mobilephone = (string)reader["Human_mobilephone"];
					}catch
					{}
					
					try{
					engage_resume.Human_email = (string)reader["Human_email"];
					}catch
					{}
					
					try{
					engage_resume.Human_hobby = (string)reader["Human_hobby"];
					}catch
					{}
					
					try{
					engage_resume.Human_sex = (string)reader["Human_sex"];
					}catch
					{}
					
					try{
					engage_resume.Human_party = (string)reader["Human_party"];
					}catch
					{}
					
					try{
					engage_resume.Human_birthday = (DateTime)reader["Human_birthday"];
					}catch
					{}
					
					try{
					engage_resume.Human_age = (int)reader["Human_age"];
					}catch
					{}
					
					try{
					engage_resume.Human_educated_year = (int)reader["Human_educated_year"];
					}catch
					{}
					
					try{
					engage_resume.Human_college = (string)reader["Human_college"];
					}catch
					{}
					
					try{
					engage_resume.Human_id_card = (string)reader["Human_id_card"];
					}catch
					{}
					
					try{
					engage_resume.Human_birthplace = (string)reader["Human_birthplace"];
					}catch
					{}
					
					try{
					engage_resume.Demand_salary_standard = (decimal)reader["Demand_salary_standard"];
					}catch
					{}
					
					try{
					engage_resume.Human_history_record = (string)reader["Human_history_record"];
					}catch
					{}
					
					try{
					engage_resume.Remark = (string)reader["Remark"];
					}catch
					{}
					
					try{
					engage_resume.Recomandation = (string)reader["Recomandation"];
					}catch
					{}
					
					try{
					engage_resume.Human_picture = (string)reader["Human_picture"];
					}catch
					{}
					
					try{
					engage_resume.Attachment_name = (string)reader["Attachment_name"];
					}catch
					{}
					
					try{
					engage_resume.Check_status = (int)reader["Check_status"];
					}catch
					{}
					
					try{
					engage_resume.Register_users_no = (int)reader["Register_users_no"];
					}catch
					{}
					
					try{
					engage_resume.Checker_users_no = (int)reader["Checker_users_no"];
					}catch
					{}
					
					try{
					engage_resume.Regist_time = (DateTime)reader["Regist_time"];
					}catch
					{}
					
					try{
					engage_resume.Check_time = (DateTime)reader["Check_time"];
					}catch
					{}
					
					try{
					engage_resume.Interview_status = (int)reader["Interview_status"];
					}catch
					{}
					
					try{
					engage_resume.Interview_amount = (int)reader["Interview_amount"];
					}catch
					{}
					
					try{
					engage_resume.Total_point = (double)reader["Total_point"];
					}catch
					{}
					
					try{
					engage_resume.Test_amount = (int)reader["Test_amount"];
					}catch
					{}
					
					try{
					engage_resume.Test_checker_users_no = (int)reader["Test_checker_users_no"];
					}catch
					{}
					
					try{
					engage_resume.Test_check_time = (DateTime)reader["Test_check_time"];
					}catch
					{}
					
					try{
					engage_resume.Pass_register_users_no = (int)reader["Pass_register_users_no"];
					}catch
					{}
					
					try{
					engage_resume.Pass_regist_time = (DateTime)reader["Pass_regist_time"];
					}catch
					{}
					
					try{
					engage_resume.Pass_checker_users_no = (int)reader["Pass_checker_users_no"];
					}catch
					{}
					
					try{
					engage_resume.Pass_check_time = (DateTime)reader["Pass_check_time"];
					}catch
					{}
					
					try{
					engage_resume.Pass_check_status = (int)reader["Pass_check_status"];
					}catch
					{}
					
					try{
					engage_resume.Pass_checkComment = (string)reader["Pass_checkComment"];
					}catch
					{}
					
					try{
					engage_resume.Pass_passComment = (string)reader["Pass_passComment"];
					}catch
					{}
					
					cc_no = (int)reader["Cc_no"]; //FK
					ced_no = (int)reader["Ced_no"]; //FK
					cg_no = (int)reader["Cg_no"]; //FK
					cn_no = (int)reader["Cn_no"]; //FK
					cr_no = (int)reader["Cr_no"]; //FK
					cs_no = (int)reader["Cs_no"]; //FK
					emr_no = (int)reader["Emr_no"]; //FK

                    reader.Close();
		
					engage_resume.Cc_no = Config_countryService.GetConfig_countryById(cc_no);
					engage_resume.Ced_no = Config_educated_degreeService.GetConfig_educated_degreeById(ced_no);
					engage_resume.Cg_no = Config_goodatService.GetConfig_goodatById(cg_no);
					engage_resume.Cn_no = Config_nationService.GetConfig_nationById(cn_no);
					engage_resume.Cr_no = Config_religionService.GetConfig_religionById(cr_no);
					engage_resume.Cs_no = Config_specialityService.GetConfig_specialityById(cs_no);
					engage_resume.Emr_no = Engage_major_releaseService.GetEngage_major_releaseById(emr_no);

                    return engage_resume;
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
		
		
		
		
        private static IList<Engage_resume> GetEngage_resumesBySql( string safeSql )
        {
            List<Engage_resume> list = new List<Engage_resume>();

			try
			{
				DataTable table = DBHelper.GetDataTable( safeSql );
				
				foreach (DataRow row in table.Rows)
				{
					Engage_resume engage_resume = new Engage_resume();
					
					try{
					engage_resume.Id = (int)row["Id"];
					}catch
					{}
					try{
					engage_resume.Human_name = (string)row["Human_name"];
					}catch
					{}
					try{
					engage_resume.Engage_type = (string)row["Engage_type"];
					}catch
					{}
					try{
					engage_resume.Human_address = (string)row["Human_address"];
					}catch
					{}
					try{
					engage_resume.Human_postcode = (string)row["Human_postcode"];
					}catch
					{}
					try{
					engage_resume.Human_telephone = (string)row["Human_telephone"];
					}catch
					{}
					try{
					engage_resume.Human_homephone = (string)row["Human_homephone"];
					}catch
					{}
					try{
					engage_resume.Human_mobilephone = (string)row["Human_mobilephone"];
					}catch
					{}
					try{
					engage_resume.Human_email = (string)row["Human_email"];
					}catch
					{}
					try{
					engage_resume.Human_hobby = (string)row["Human_hobby"];
					}catch
					{}
					try{
					engage_resume.Human_sex = (string)row["Human_sex"];
					}catch
					{}
					try{
					engage_resume.Human_party = (string)row["Human_party"];
					}catch
					{}
					try{
					engage_resume.Human_birthday = (DateTime)row["Human_birthday"];
					}catch
					{}
					try{
					engage_resume.Human_age = (int)row["Human_age"];
					}catch
					{}
					try{
					engage_resume.Human_educated_year = (int)row["Human_educated_year"];
					}catch
					{}
					try{
					engage_resume.Human_college = (string)row["Human_college"];
					}catch
					{}
					try{
					engage_resume.Human_id_card = (string)row["Human_id_card"];
					}catch
					{}
					try{
					engage_resume.Human_birthplace = (string)row["Human_birthplace"];
					}catch
					{}
					try{
					engage_resume.Demand_salary_standard = (decimal)row["Demand_salary_standard"];
					}catch
					{}
					try{
					engage_resume.Human_history_record = (string)row["Human_history_record"];
					}catch
					{}
					try{
					engage_resume.Remark = (string)row["Remark"];
					}catch
					{}
					try{
					engage_resume.Recomandation = (string)row["Recomandation"];
					}catch
					{}
					try{
					engage_resume.Human_picture = (string)row["Human_picture"];
					}catch
					{}
					try{
					engage_resume.Attachment_name = (string)row["Attachment_name"];
					}catch
					{}
					try{
					engage_resume.Check_status = (int)row["Check_status"];
					}catch
					{}
					try{
					engage_resume.Register_users_no = (int)row["Register_users_no"];
					}catch
					{}
					try{
					engage_resume.Checker_users_no = (int)row["Checker_users_no"];
					}catch
					{}
					try{
					engage_resume.Regist_time = (DateTime)row["Regist_time"];
					}catch
					{}
					try{
					engage_resume.Check_time = (DateTime)row["Check_time"];
					}catch
					{}
					try{
					engage_resume.Interview_status = (int)row["Interview_status"];
					}catch
					{}
					try{
					engage_resume.Interview_amount = (int)row["Interview_amount"];
					}catch
					{}
					try{
					engage_resume.Total_point = (double)row["Total_point"];
					}catch
					{}
					try{
					engage_resume.Test_amount = (int)row["Test_amount"];
					}catch
					{}
					try{
					engage_resume.Test_checker_users_no = (int)row["Test_checker_users_no"];
					}catch
					{}
					try{
					engage_resume.Test_check_time = (DateTime)row["Test_check_time"];
					}catch
					{}
					try{
					engage_resume.Pass_register_users_no = (int)row["Pass_register_users_no"];
					}catch
					{}
					try{
					engage_resume.Pass_regist_time = (DateTime)row["Pass_regist_time"];
					}catch
					{}
					try{
					engage_resume.Pass_checker_users_no = (int)row["Pass_checker_users_no"];
					}catch
					{}
					try{
					engage_resume.Pass_check_time = (DateTime)row["Pass_check_time"];
					}catch
					{}
					try{
					engage_resume.Pass_check_status = (int)row["Pass_check_status"];
					}catch
					{}
					try{
					engage_resume.Pass_checkComment = (string)row["Pass_checkComment"];
					}catch
					{}
					try{
					engage_resume.Pass_passComment = (string)row["Pass_passComment"];
					}catch
					{}
					engage_resume.Cc_no = Config_countryService.GetConfig_countryById((int)row["Cc_no"]); //FK
					engage_resume.Ced_no = Config_educated_degreeService.GetConfig_educated_degreeById((int)row["Ced_no"]); //FK
					engage_resume.Cg_no = Config_goodatService.GetConfig_goodatById((int)row["Cg_no"]); //FK
					engage_resume.Cn_no = Config_nationService.GetConfig_nationById((int)row["Cn_no"]); //FK
					engage_resume.Cr_no = Config_religionService.GetConfig_religionById((int)row["Cr_no"]); //FK
					engage_resume.Cs_no = Config_specialityService.GetConfig_specialityById((int)row["Cs_no"]); //FK
					engage_resume.Emr_no = Engage_major_releaseService.GetEngage_major_releaseById((int)row["Emr_no"]); //FK
	
					list.Add(engage_resume);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
		
        private static IList<Engage_resume> GetEngage_resumesBySql( string sql, params SqlParameter[] values )
        {
            List<Engage_resume> list = new List<Engage_resume>();

			try
			{
				DataTable table = DBHelper.GetDataTable( sql, values );
				
				foreach (DataRow row in table.Rows)
				{
					Engage_resume engage_resume = new Engage_resume();
					
					try{
					engage_resume.Id = (int)row["Id"];
					}catch
					{}
					try{
					engage_resume.Human_name = (string)row["Human_name"];
					}catch
					{}
					try{
					engage_resume.Engage_type = (string)row["Engage_type"];
					}catch
					{}
					try{
					engage_resume.Human_address = (string)row["Human_address"];
					}catch
					{}
					try{
					engage_resume.Human_postcode = (string)row["Human_postcode"];
					}catch
					{}
					try{
					engage_resume.Human_telephone = (string)row["Human_telephone"];
					}catch
					{}
					try{
					engage_resume.Human_homephone = (string)row["Human_homephone"];
					}catch
					{}
					try{
					engage_resume.Human_mobilephone = (string)row["Human_mobilephone"];
					}catch
					{}
					try{
					engage_resume.Human_email = (string)row["Human_email"];
					}catch
					{}
					try{
					engage_resume.Human_hobby = (string)row["Human_hobby"];
					}catch
					{}
					try{
					engage_resume.Human_sex = (string)row["Human_sex"];
					}catch
					{}
					try{
					engage_resume.Human_party = (string)row["Human_party"];
					}catch
					{}
					try{
					engage_resume.Human_birthday = (DateTime)row["Human_birthday"];
					}catch
					{}
					try{
					engage_resume.Human_age = (int)row["Human_age"];
					}catch
					{}
					try{
					engage_resume.Human_educated_year = (int)row["Human_educated_year"];
					}catch
					{}
					try{
					engage_resume.Human_college = (string)row["Human_college"];
					}catch
					{}
					try{
					engage_resume.Human_id_card = (string)row["Human_id_card"];
					}catch
					{}
					try{
					engage_resume.Human_birthplace = (string)row["Human_birthplace"];
					}catch
					{}
					try{
					engage_resume.Demand_salary_standard = (decimal)row["Demand_salary_standard"];
					}catch
					{}
					try{
					engage_resume.Human_history_record = (string)row["Human_history_record"];
					}catch
					{}
					try{
					engage_resume.Remark = (string)row["Remark"];
					}catch
					{}
					try{
					engage_resume.Recomandation = (string)row["Recomandation"];
					}catch
					{}
					try{
					engage_resume.Human_picture = (string)row["Human_picture"];
					}catch
					{}
					try{
					engage_resume.Attachment_name = (string)row["Attachment_name"];
					}catch
					{}
					try{
					engage_resume.Check_status = (int)row["Check_status"];
					}catch
					{}
					try{
					engage_resume.Register_users_no = (int)row["Register_users_no"];
					}catch
					{}
					try{
					engage_resume.Checker_users_no = (int)row["Checker_users_no"];
					}catch
					{}
					try{
					engage_resume.Regist_time = (DateTime)row["Regist_time"];
					}catch
					{}
					try{
					engage_resume.Check_time = (DateTime)row["Check_time"];
					}catch
					{}
					try{
					engage_resume.Interview_status = (int)row["Interview_status"];
					}catch
					{}
					try{
					engage_resume.Interview_amount = (int)row["Interview_amount"];
					}catch
					{}
					try{
					engage_resume.Total_point = (double)row["Total_point"];
					}catch
					{}
					try{
					engage_resume.Test_amount = (int)row["Test_amount"];
					}catch
					{}
					try{
					engage_resume.Test_checker_users_no = (int)row["Test_checker_users_no"];
					}catch
					{}
					try{
					engage_resume.Test_check_time = (DateTime)row["Test_check_time"];
					}catch
					{}
					try{
					engage_resume.Pass_register_users_no = (int)row["Pass_register_users_no"];
					}catch
					{}
					try{
					engage_resume.Pass_regist_time = (DateTime)row["Pass_regist_time"];
					}catch
					{}
					try{
					engage_resume.Pass_checker_users_no = (int)row["Pass_checker_users_no"];
					}catch
					{}
					try{
					engage_resume.Pass_check_time = (DateTime)row["Pass_check_time"];
					}catch
					{}
					try{
					engage_resume.Pass_check_status = (int)row["Pass_check_status"];
					}catch
					{}
					try{
					engage_resume.Pass_checkComment = (string)row["Pass_checkComment"];
					}catch
					{}
					try{
					engage_resume.Pass_passComment = (string)row["Pass_passComment"];
					}catch
					{}
					engage_resume.Cc_no = Config_countryService.GetConfig_countryById((int)row["Cc_no"]); //FK
					engage_resume.Ced_no = Config_educated_degreeService.GetConfig_educated_degreeById((int)row["Ced_no"]); //FK
					engage_resume.Cg_no = Config_goodatService.GetConfig_goodatById((int)row["Cg_no"]); //FK
					engage_resume.Cn_no = Config_nationService.GetConfig_nationById((int)row["Cn_no"]); //FK
					engage_resume.Cr_no = Config_religionService.GetConfig_religionById((int)row["Cr_no"]); //FK
					engage_resume.Cs_no = Config_specialityService.GetConfig_specialityById((int)row["Cs_no"]); //FK
					engage_resume.Emr_no = Engage_major_releaseService.GetEngage_major_releaseById((int)row["Emr_no"]); //FK
	
					list.Add(engage_resume);
				}
	
				return list;
			}
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
			
        }

        public static IList<Engage_resume> ResumeAdvSearch(int majorid, int resumestatus, string key, string beginTime, string endTime)
        {

            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(" 1=1 ");
            if (majorid != -1)
            {
                Engage_major_release release = Engage_major_releaseService.GetEngage_major_releaseByPostId(majorid);

                sb.Append(" and Emr_no=" + release.Id);
            }
            if (resumestatus != -1)
            {
                sb.Append(" and Interview_status=" + resumestatus);
            }
            if (!string.IsNullOrEmpty(beginTime))
            {
                if (!string.IsNullOrEmpty(endTime))
                {
                    sb.Append(string.Format(" and Regist_time between '{0}' and '{1}'", beginTime + " 00:00:00", endTime + " 23:59:59"));
                }
                else
                {
                    sb.Append(string.Format("and Regist_time>'{0}'", beginTime + " 00:00:00"));

                }
            }
            else
            {
                if (!string.IsNullOrEmpty(endTime))
                {
                    sb.Append(string.Format("and Regist_time<'{0}'", endTime + " 23:59:59"));
                }
            }

            if (!string.IsNullOrEmpty(key))
            {
                sb.AppendFormat(" and Human_name like '%{0}%' or Human_telephone like '%{1}%' or Human_id_card like '%{2}%' or Human_history_record like '%{3}%'", key, key, key, key);
            }

            string strsql = "select * from Engage_resume where " + sb.ToString();
            return GetEngage_resumesBySql(strsql);

        }

    }
}

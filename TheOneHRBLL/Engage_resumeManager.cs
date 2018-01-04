//============================================================
// Producnt name:		BLL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2010-3-30 14:06:49
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using TheOneHRDAL;
using TheOneHRModels;

namespace TheOneHRBLL
{

    public static partial class Engage_resumeManager
    {

		
		//override
		public static Engage_resume AddEngage_resume(string Human_name,string Engage_type,string Human_address,string Human_postcode,string Human_telephone,string Human_homephone,string Human_mobilephone,string Human_email,string Human_hobby,string Human_sex,string Human_party,DateTime Human_birthday,int Human_age,int Human_educated_year,string Human_college,string Human_id_card,string Human_birthplace,decimal Demand_salary_standard,string Human_history_record,string Remark,string Recomandation,string Human_picture,string Attachment_name,int Check_status,int Register_users_no,int Checker_users_no,DateTime Regist_time,DateTime Check_time,int Interview_status,int Interview_amount,double Total_point,int Test_amount,int Test_checker_users_no,DateTime Test_check_time,int Pass_register_users_no,DateTime Pass_regist_time,int Pass_checker_users_no,DateTime Pass_check_time,int Pass_check_status,string Pass_checkComment,string Pass_passComment,int Cc_no,int Ced_no,int Cg_no,int Cn_no,int Cr_no,int Cs_no,int Emr_no)
		{
			Engage_resume engage_resume = new Engage_resume();

			TransData_AddEngage_resume(Human_name,Engage_type,Human_address,Human_postcode,Human_telephone,Human_homephone,Human_mobilephone,Human_email,Human_hobby,Human_sex,Human_party,Human_birthday,Human_age,Human_educated_year,Human_college,Human_id_card,Human_birthplace,Demand_salary_standard,Human_history_record,Remark,Recomandation,Human_picture,Attachment_name,Check_status,Register_users_no,Checker_users_no,Regist_time,Check_time,Interview_status,Interview_amount,Total_point,Test_amount,Test_checker_users_no,Test_check_time,Pass_register_users_no,Pass_regist_time,Pass_checker_users_no,Pass_check_time,Pass_check_status,Pass_checkComment,Pass_passComment,Cc_no,Ced_no,Cg_no,Cn_no,Cr_no,Cs_no,Emr_no,  engage_resume );
            //FK	
			engage_resume.Cc_no = Config_countryService.GetConfig_countryById(Cc_no); //FK
			engage_resume.Ced_no = Config_educated_degreeService.GetConfig_educated_degreeById(Ced_no); //FK
			engage_resume.Cg_no = Config_goodatService.GetConfig_goodatById(Cg_no); //FK
			engage_resume.Cn_no = Config_nationService.GetConfig_nationById(Cn_no); //FK
			engage_resume.Cr_no = Config_religionService.GetConfig_religionById(Cr_no); //FK
			engage_resume.Cs_no = Config_specialityService.GetConfig_specialityById(Cs_no); //FK
			engage_resume.Emr_no = Engage_major_releaseService.GetEngage_major_releaseById(Emr_no); //FK
		
			return Engage_resumeService.AddEngage_resume(engage_resume);
		}
        public static Engage_resume AddEngage_resume(Engage_resume engage_resume)
        {
            return Engage_resumeService.AddEngage_resume(engage_resume);
        }

        public static void DeleteEngage_resume(Engage_resume engage_resume)
        {
            Engage_resumeService.DeleteEngage_resume(engage_resume);
        }

        public static void DeleteEngage_resumeById(int id)
        {
            Engage_resumeService.DeleteEngage_resumeById(id);
        }

		public static void ModifyEngage_resume(Engage_resume engage_resume)
        {
            Engage_resumeService.ModifyEngage_resume(engage_resume);
        }
		//overload
		public static void ModifyEngage_resume(int Id,string Human_name,string Engage_type,string Human_address,string Human_postcode,string Human_telephone,string Human_homephone,string Human_mobilephone,string Human_email,string Human_hobby,string Human_sex,string Human_party,DateTime Human_birthday,int Human_age,int Human_educated_year,string Human_college,string Human_id_card,string Human_birthplace,decimal Demand_salary_standard,string Human_history_record,string Remark,string Recomandation,string Human_picture,string Attachment_name,int Check_status,int Register_users_no,int Checker_users_no,DateTime Regist_time,DateTime Check_time,int Interview_status,int Interview_amount,double Total_point,int Test_amount,int Test_checker_users_no,DateTime Test_check_time,int Pass_register_users_no,DateTime Pass_regist_time,int Pass_checker_users_no,DateTime Pass_check_time,int Pass_check_status,string Pass_checkComment,string Pass_passComment,int Cc_no,int Ced_no,int Cg_no,int Cn_no,int Cr_no,int Cs_no,int Emr_no)
        {
			Engage_resume engage_resume = new Engage_resume();
	        //PK
			engage_resume.Id=Id;
			TransData_ModifyEngage_resume(Id,Human_name,Engage_type,Human_address,Human_postcode,Human_telephone,Human_homephone,Human_mobilephone,Human_email,Human_hobby,Human_sex,Human_party,Human_birthday,Human_age,Human_educated_year,Human_college,Human_id_card,Human_birthplace,Demand_salary_standard,Human_history_record,Remark,Recomandation,Human_picture,Attachment_name,Check_status,Register_users_no,Checker_users_no,Regist_time,Check_time,Interview_status,Interview_amount,Total_point,Test_amount,Test_checker_users_no,Test_check_time,Pass_register_users_no,Pass_regist_time,Pass_checker_users_no,Pass_check_time,Pass_check_status,Pass_checkComment,Pass_passComment,Cc_no,Ced_no,Cg_no,Cn_no,Cr_no,Cs_no,Emr_no,engage_resume);
			
            //FK
			engage_resume.Cc_no = Config_countryService.GetConfig_countryById(Cc_no); //FK
			engage_resume.Ced_no = Config_educated_degreeService.GetConfig_educated_degreeById(Ced_no); //FK
			engage_resume.Cg_no = Config_goodatService.GetConfig_goodatById(Cg_no); //FK
			engage_resume.Cn_no = Config_nationService.GetConfig_nationById(Cn_no); //FK
			engage_resume.Cr_no = Config_religionService.GetConfig_religionById(Cr_no); //FK
			engage_resume.Cs_no = Config_specialityService.GetConfig_specialityById(Cs_no); //FK
			engage_resume.Emr_no = Engage_major_releaseService.GetEngage_major_releaseById(Emr_no); //FK
		
			 Engage_resumeService.ModifyEngage_resume(engage_resume);
		}

        public static IList<Engage_resume> GetAllEngage_resumes()
        {
            return Engage_resumeService.GetAllEngage_resumes();
        }

        public static Engage_resume GetEngage_resumeById(int id)
        {
            return Engage_resumeService.GetEngage_resumeById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddEngage_resume(string Human_name,string Engage_type,string Human_address,string Human_postcode,string Human_telephone,string Human_homephone,string Human_mobilephone,string Human_email,string Human_hobby,string Human_sex,string Human_party,DateTime Human_birthday,int Human_age,int Human_educated_year,string Human_college,string Human_id_card,string Human_birthplace,decimal Demand_salary_standard,string Human_history_record,string Remark,string Recomandation,string Human_picture,string Attachment_name,int Check_status,int Register_users_no,int Checker_users_no,DateTime Regist_time,DateTime Check_time,int Interview_status,int Interview_amount,double Total_point,int Test_amount,int Test_checker_users_no,DateTime Test_check_time,int Pass_register_users_no,DateTime Pass_regist_time,int Pass_checker_users_no,DateTime Pass_check_time,int Pass_check_status,string Pass_checkComment,string Pass_passComment,int Cc_no,int Ced_no,int Cg_no,int Cn_no,int Cr_no,int Cs_no,int Emr_no, Engage_resume engage_resume )
        {

			try{if (Human_name.ToString() == "0001-1-1 0:00:00") engage_resume.Human_name = null; else engage_resume.Human_name = Human_name;}catch{}
			try{if (Engage_type.ToString() == "0001-1-1 0:00:00") engage_resume.Engage_type = null; else engage_resume.Engage_type = Engage_type;}catch{}
			try{if (Human_address.ToString() == "0001-1-1 0:00:00") engage_resume.Human_address = null; else engage_resume.Human_address = Human_address;}catch{}
			try{if (Human_postcode.ToString() == "0001-1-1 0:00:00") engage_resume.Human_postcode = null; else engage_resume.Human_postcode = Human_postcode;}catch{}
			try{if (Human_telephone.ToString() == "0001-1-1 0:00:00") engage_resume.Human_telephone = null; else engage_resume.Human_telephone = Human_telephone;}catch{}
			try{if (Human_homephone.ToString() == "0001-1-1 0:00:00") engage_resume.Human_homephone = null; else engage_resume.Human_homephone = Human_homephone;}catch{}
			try{if (Human_mobilephone.ToString() == "0001-1-1 0:00:00") engage_resume.Human_mobilephone = null; else engage_resume.Human_mobilephone = Human_mobilephone;}catch{}
			try{if (Human_email.ToString() == "0001-1-1 0:00:00") engage_resume.Human_email = null; else engage_resume.Human_email = Human_email;}catch{}
			try{if (Human_hobby.ToString() == "0001-1-1 0:00:00") engage_resume.Human_hobby = null; else engage_resume.Human_hobby = Human_hobby;}catch{}
			try{if (Human_sex.ToString() == "0001-1-1 0:00:00") engage_resume.Human_sex = null; else engage_resume.Human_sex = Human_sex;}catch{}
			try{if (Human_party.ToString() == "0001-1-1 0:00:00") engage_resume.Human_party = null; else engage_resume.Human_party = Human_party;}catch{}
			try{if (Human_birthday.ToString() == "0001-1-1 0:00:00") engage_resume.Human_birthday = null; else engage_resume.Human_birthday = Human_birthday;}catch{}
			try{if (Human_age.ToString() == "0001-1-1 0:00:00") engage_resume.Human_age = null; else engage_resume.Human_age = Human_age;}catch{}
			try{if (Human_educated_year.ToString() == "0001-1-1 0:00:00") engage_resume.Human_educated_year = null; else engage_resume.Human_educated_year = Human_educated_year;}catch{}
			try{if (Human_college.ToString() == "0001-1-1 0:00:00") engage_resume.Human_college = null; else engage_resume.Human_college = Human_college;}catch{}
			try{if (Human_id_card.ToString() == "0001-1-1 0:00:00") engage_resume.Human_id_card = null; else engage_resume.Human_id_card = Human_id_card;}catch{}
			try{if (Human_birthplace.ToString() == "0001-1-1 0:00:00") engage_resume.Human_birthplace = null; else engage_resume.Human_birthplace = Human_birthplace;}catch{}
			try{if (Demand_salary_standard.ToString() == "0001-1-1 0:00:00") engage_resume.Demand_salary_standard = null; else engage_resume.Demand_salary_standard = Demand_salary_standard;}catch{}
			try{if (Human_history_record.ToString() == "0001-1-1 0:00:00") engage_resume.Human_history_record = null; else engage_resume.Human_history_record = Human_history_record;}catch{}
			try{if (Remark.ToString() == "0001-1-1 0:00:00") engage_resume.Remark = null; else engage_resume.Remark = Remark;}catch{}
			try{if (Recomandation.ToString() == "0001-1-1 0:00:00") engage_resume.Recomandation = null; else engage_resume.Recomandation = Recomandation;}catch{}
			try{if (Human_picture.ToString() == "0001-1-1 0:00:00") engage_resume.Human_picture = null; else engage_resume.Human_picture = Human_picture;}catch{}
			try{if (Attachment_name.ToString() == "0001-1-1 0:00:00") engage_resume.Attachment_name = null; else engage_resume.Attachment_name = Attachment_name;}catch{}
			try{if (Check_status.ToString() == "0001-1-1 0:00:00") engage_resume.Check_status = null; else engage_resume.Check_status = Check_status;}catch{}
			try{if (Register_users_no.ToString() == "0001-1-1 0:00:00") engage_resume.Register_users_no = null; else engage_resume.Register_users_no = Register_users_no;}catch{}
			try{if (Checker_users_no.ToString() == "0001-1-1 0:00:00") engage_resume.Checker_users_no = null; else engage_resume.Checker_users_no = Checker_users_no;}catch{}
			try{if (Regist_time.ToString() == "0001-1-1 0:00:00") engage_resume.Regist_time = null; else engage_resume.Regist_time = Regist_time;}catch{}
			try{if (Check_time.ToString() == "0001-1-1 0:00:00") engage_resume.Check_time = null; else engage_resume.Check_time = Check_time;}catch{}
			try{if (Interview_status.ToString() == "0001-1-1 0:00:00") engage_resume.Interview_status = null; else engage_resume.Interview_status = Interview_status;}catch{}
			try{if (Interview_amount.ToString() == "0001-1-1 0:00:00") engage_resume.Interview_amount = null; else engage_resume.Interview_amount = Interview_amount;}catch{}
			try{if (Total_point.ToString() == "0001-1-1 0:00:00") engage_resume.Total_point = null; else engage_resume.Total_point = Total_point;}catch{}
			try{if (Test_amount.ToString() == "0001-1-1 0:00:00") engage_resume.Test_amount = null; else engage_resume.Test_amount = Test_amount;}catch{}
			try{if (Test_checker_users_no.ToString() == "0001-1-1 0:00:00") engage_resume.Test_checker_users_no = null; else engage_resume.Test_checker_users_no = Test_checker_users_no;}catch{}
			try{if (Test_check_time.ToString() == "0001-1-1 0:00:00") engage_resume.Test_check_time = null; else engage_resume.Test_check_time = Test_check_time;}catch{}
			try{if (Pass_register_users_no.ToString() == "0001-1-1 0:00:00") engage_resume.Pass_register_users_no = null; else engage_resume.Pass_register_users_no = Pass_register_users_no;}catch{}
			try{if (Pass_regist_time.ToString() == "0001-1-1 0:00:00") engage_resume.Pass_regist_time = null; else engage_resume.Pass_regist_time = Pass_regist_time;}catch{}
			try{if (Pass_checker_users_no.ToString() == "0001-1-1 0:00:00") engage_resume.Pass_checker_users_no = null; else engage_resume.Pass_checker_users_no = Pass_checker_users_no;}catch{}
			try{if (Pass_check_time.ToString() == "0001-1-1 0:00:00") engage_resume.Pass_check_time = null; else engage_resume.Pass_check_time = Pass_check_time;}catch{}
			try{if (Pass_check_status.ToString() == "0001-1-1 0:00:00") engage_resume.Pass_check_status = null; else engage_resume.Pass_check_status = Pass_check_status;}catch{}
			try{if (Pass_checkComment.ToString() == "0001-1-1 0:00:00") engage_resume.Pass_checkComment = null; else engage_resume.Pass_checkComment = Pass_checkComment;}catch{}
			try{if (Pass_passComment.ToString() == "0001-1-1 0:00:00") engage_resume.Pass_passComment = null; else engage_resume.Pass_passComment = Pass_passComment;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyEngage_resume(int Id,string Human_name,string Engage_type,string Human_address,string Human_postcode,string Human_telephone,string Human_homephone,string Human_mobilephone,string Human_email,string Human_hobby,string Human_sex,string Human_party,DateTime Human_birthday,int Human_age,int Human_educated_year,string Human_college,string Human_id_card,string Human_birthplace,decimal Demand_salary_standard,string Human_history_record,string Remark,string Recomandation,string Human_picture,string Attachment_name,int Check_status,int Register_users_no,int Checker_users_no,DateTime Regist_time,DateTime Check_time,int Interview_status,int Interview_amount,double Total_point,int Test_amount,int Test_checker_users_no,DateTime Test_check_time,int Pass_register_users_no,DateTime Pass_regist_time,int Pass_checker_users_no,DateTime Pass_check_time,int Pass_check_status,string Pass_checkComment,string Pass_passComment,int Cc_no,int Ced_no,int Cg_no,int Cn_no,int Cr_no,int Cs_no,int Emr_no, Engage_resume engage_resume)
		{

			try{if (Human_name.ToString() == "0001-1-1 0:00:00") engage_resume.Human_name = null; else engage_resume.Human_name = Human_name;}catch{}
			try{if (Engage_type.ToString() == "0001-1-1 0:00:00") engage_resume.Engage_type = null; else engage_resume.Engage_type = Engage_type;}catch{}
			try{if (Human_address.ToString() == "0001-1-1 0:00:00") engage_resume.Human_address = null; else engage_resume.Human_address = Human_address;}catch{}
			try{if (Human_postcode.ToString() == "0001-1-1 0:00:00") engage_resume.Human_postcode = null; else engage_resume.Human_postcode = Human_postcode;}catch{}
			try{if (Human_telephone.ToString() == "0001-1-1 0:00:00") engage_resume.Human_telephone = null; else engage_resume.Human_telephone = Human_telephone;}catch{}
			try{if (Human_homephone.ToString() == "0001-1-1 0:00:00") engage_resume.Human_homephone = null; else engage_resume.Human_homephone = Human_homephone;}catch{}
			try{if (Human_mobilephone.ToString() == "0001-1-1 0:00:00") engage_resume.Human_mobilephone = null; else engage_resume.Human_mobilephone = Human_mobilephone;}catch{}
			try{if (Human_email.ToString() == "0001-1-1 0:00:00") engage_resume.Human_email = null; else engage_resume.Human_email = Human_email;}catch{}
			try{if (Human_hobby.ToString() == "0001-1-1 0:00:00") engage_resume.Human_hobby = null; else engage_resume.Human_hobby = Human_hobby;}catch{}
			try{if (Human_sex.ToString() == "0001-1-1 0:00:00") engage_resume.Human_sex = null; else engage_resume.Human_sex = Human_sex;}catch{}
			try{if (Human_party.ToString() == "0001-1-1 0:00:00") engage_resume.Human_party = null; else engage_resume.Human_party = Human_party;}catch{}
			try{if (Human_birthday.ToString() == "0001-1-1 0:00:00") engage_resume.Human_birthday = null; else engage_resume.Human_birthday = Human_birthday;}catch{}
			try{if (Human_age.ToString() == "0001-1-1 0:00:00") engage_resume.Human_age = null; else engage_resume.Human_age = Human_age;}catch{}
			try{if (Human_educated_year.ToString() == "0001-1-1 0:00:00") engage_resume.Human_educated_year = null; else engage_resume.Human_educated_year = Human_educated_year;}catch{}
			try{if (Human_college.ToString() == "0001-1-1 0:00:00") engage_resume.Human_college = null; else engage_resume.Human_college = Human_college;}catch{}
			try{if (Human_id_card.ToString() == "0001-1-1 0:00:00") engage_resume.Human_id_card = null; else engage_resume.Human_id_card = Human_id_card;}catch{}
			try{if (Human_birthplace.ToString() == "0001-1-1 0:00:00") engage_resume.Human_birthplace = null; else engage_resume.Human_birthplace = Human_birthplace;}catch{}
			try{if (Demand_salary_standard.ToString() == "0001-1-1 0:00:00") engage_resume.Demand_salary_standard = null; else engage_resume.Demand_salary_standard = Demand_salary_standard;}catch{}
			try{if (Human_history_record.ToString() == "0001-1-1 0:00:00") engage_resume.Human_history_record = null; else engage_resume.Human_history_record = Human_history_record;}catch{}
			try{if (Remark.ToString() == "0001-1-1 0:00:00") engage_resume.Remark = null; else engage_resume.Remark = Remark;}catch{}
			try{if (Recomandation.ToString() == "0001-1-1 0:00:00") engage_resume.Recomandation = null; else engage_resume.Recomandation = Recomandation;}catch{}
			try{if (Human_picture.ToString() == "0001-1-1 0:00:00") engage_resume.Human_picture = null; else engage_resume.Human_picture = Human_picture;}catch{}
			try{if (Attachment_name.ToString() == "0001-1-1 0:00:00") engage_resume.Attachment_name = null; else engage_resume.Attachment_name = Attachment_name;}catch{}
			try{if (Check_status.ToString() == "0001-1-1 0:00:00") engage_resume.Check_status = null; else engage_resume.Check_status = Check_status;}catch{}
			try{if (Register_users_no.ToString() == "0001-1-1 0:00:00") engage_resume.Register_users_no = null; else engage_resume.Register_users_no = Register_users_no;}catch{}
			try{if (Checker_users_no.ToString() == "0001-1-1 0:00:00") engage_resume.Checker_users_no = null; else engage_resume.Checker_users_no = Checker_users_no;}catch{}
			try{if (Regist_time.ToString() == "0001-1-1 0:00:00") engage_resume.Regist_time = null; else engage_resume.Regist_time = Regist_time;}catch{}
			try{if (Check_time.ToString() == "0001-1-1 0:00:00") engage_resume.Check_time = null; else engage_resume.Check_time = Check_time;}catch{}
			try{if (Interview_status.ToString() == "0001-1-1 0:00:00") engage_resume.Interview_status = null; else engage_resume.Interview_status = Interview_status;}catch{}
			try{if (Interview_amount.ToString() == "0001-1-1 0:00:00") engage_resume.Interview_amount = null; else engage_resume.Interview_amount = Interview_amount;}catch{}
			try{if (Total_point.ToString() == "0001-1-1 0:00:00") engage_resume.Total_point = null; else engage_resume.Total_point = Total_point;}catch{}
			try{if (Test_amount.ToString() == "0001-1-1 0:00:00") engage_resume.Test_amount = null; else engage_resume.Test_amount = Test_amount;}catch{}
			try{if (Test_checker_users_no.ToString() == "0001-1-1 0:00:00") engage_resume.Test_checker_users_no = null; else engage_resume.Test_checker_users_no = Test_checker_users_no;}catch{}
			try{if (Test_check_time.ToString() == "0001-1-1 0:00:00") engage_resume.Test_check_time = null; else engage_resume.Test_check_time = Test_check_time;}catch{}
			try{if (Pass_register_users_no.ToString() == "0001-1-1 0:00:00") engage_resume.Pass_register_users_no = null; else engage_resume.Pass_register_users_no = Pass_register_users_no;}catch{}
			try{if (Pass_regist_time.ToString() == "0001-1-1 0:00:00") engage_resume.Pass_regist_time = null; else engage_resume.Pass_regist_time = Pass_regist_time;}catch{}
			try{if (Pass_checker_users_no.ToString() == "0001-1-1 0:00:00") engage_resume.Pass_checker_users_no = null; else engage_resume.Pass_checker_users_no = Pass_checker_users_no;}catch{}
			try{if (Pass_check_time.ToString() == "0001-1-1 0:00:00") engage_resume.Pass_check_time = null; else engage_resume.Pass_check_time = Pass_check_time;}catch{}
			try{if (Pass_check_status.ToString() == "0001-1-1 0:00:00") engage_resume.Pass_check_status = null; else engage_resume.Pass_check_status = Pass_check_status;}catch{}
			try{if (Pass_checkComment.ToString() == "0001-1-1 0:00:00") engage_resume.Pass_checkComment = null; else engage_resume.Pass_checkComment = Pass_checkComment;}catch{}
			try{if (Pass_passComment.ToString() == "0001-1-1 0:00:00") engage_resume.Pass_passComment = null; else engage_resume.Pass_passComment = Pass_passComment;}catch{}
		}
		#endregion
    }
}



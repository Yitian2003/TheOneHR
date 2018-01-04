//============================================================
// Producnt name:		Models
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2010-3-30 14:06:46
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
namespace TheOneHRModels
{
	
	[Serializable()]
	public partial class Engage_resume
	{
	    #region private field
		
			private int id;
			private string human_name;
			private string engage_type;
			private string human_address;
			private string human_postcode;
			private Engage_major_release emr_no;
			private string human_telephone;
			private string human_homephone;
			private string human_mobilephone;
			private string human_email;
			private string human_hobby;
			private Config_goodat cg_no;
			private string human_sex;
			private Config_nation cn_no;
			private Config_religion cr_no;
			private string human_party;
			private Config_country cc_no;
			private Nullable<DateTime> human_birthday;
			private Nullable<int> human_age;
			private Config_educated_degree ced_no;
			private Nullable<int> human_educated_year;
			private Config_speciality cs_no;
			private string human_college;
			private string human_id_card;
			private string human_birthplace;
			private Nullable<decimal> demand_salary_standard;
			private string human_history_record;
			private string remark;
			private string recomandation;
			private string human_picture;
			private string attachment_name;
			private Nullable<int> check_status;
			private Nullable<int> register_users_no;
			private Nullable<int> checker_users_no;
			private Nullable<DateTime> regist_time;
			private Nullable<DateTime> check_time;
			private Nullable<int> interview_status;
			private Nullable<int> interview_amount;
			private Nullable<double> total_point;
			private Nullable<int> test_amount;
			private Nullable<int> test_checker_users_no;
			private Nullable<DateTime> test_check_time;
			private Nullable<int> pass_register_users_no;
			private Nullable<DateTime> pass_regist_time;
			private Nullable<int> pass_checker_users_no;
			private Nullable<DateTime> pass_check_time;
			private Nullable<int> pass_check_status;
			private string pass_checkComment;
			private string pass_passComment;

        #endregion

        #region constructor

			public Engage_resume() {
			}

        #endregion

        #region public property

			public int Id {
				get { return id; }
				set { id = value; }
			}
			
			public string Human_name {
				get { return human_name; }
				set { human_name = value; }
			}
			
			public string Engage_type {
				get { return engage_type; }
				set { engage_type = value; }
			}
			
			public string Human_address {
				get { return human_address; }
				set { human_address = value; }
			}
			
			public string Human_postcode {
				get { return human_postcode; }
				set { human_postcode = value; }
			}
			
			public Engage_major_release Emr_no {
				get { return emr_no; }
				set { emr_no = value; }
			}
			
			public string Human_telephone {
				get { return human_telephone; }
				set { human_telephone = value; }
			}
			
			public string Human_homephone {
				get { return human_homephone; }
				set { human_homephone = value; }
			}
			
			public string Human_mobilephone {
				get { return human_mobilephone; }
				set { human_mobilephone = value; }
			}
			
			public string Human_email {
				get { return human_email; }
				set { human_email = value; }
			}
			
			public string Human_hobby {
				get { return human_hobby; }
				set { human_hobby = value; }
			}
			
			public Config_goodat Cg_no {
				get { return cg_no; }
				set { cg_no = value; }
			}
			
			public string Human_sex {
				get { return human_sex; }
				set { human_sex = value; }
			}
			
			public Config_nation Cn_no {
				get { return cn_no; }
				set { cn_no = value; }
			}
			
			public Config_religion Cr_no {
				get { return cr_no; }
				set { cr_no = value; }
			}
			
			public string Human_party {
				get { return human_party; }
				set { human_party = value; }
			}
			
			public Config_country Cc_no {
				get { return cc_no; }
				set { cc_no = value; }
			}
			
			public Nullable<DateTime> Human_birthday {
				get { return human_birthday; }
				set { human_birthday = value; }
			}
			
			public Nullable<int> Human_age {
				get { return human_age; }
				set { human_age = value; }
			}
			
			public Config_educated_degree Ced_no {
				get { return ced_no; }
				set { ced_no = value; }
			}
			
			public Nullable<int> Human_educated_year {
				get { return human_educated_year; }
				set { human_educated_year = value; }
			}
			
			public Config_speciality Cs_no {
				get { return cs_no; }
				set { cs_no = value; }
			}
			
			public string Human_college {
				get { return human_college; }
				set { human_college = value; }
			}
			
			public string Human_id_card {
				get { return human_id_card; }
				set { human_id_card = value; }
			}
			
			public string Human_birthplace {
				get { return human_birthplace; }
				set { human_birthplace = value; }
			}
			
			public Nullable<decimal> Demand_salary_standard {
				get { return demand_salary_standard; }
				set { demand_salary_standard = value; }
			}
			
			public string Human_history_record {
				get { return human_history_record; }
				set { human_history_record = value; }
			}
			
			public string Remark {
				get { return remark; }
				set { remark = value; }
			}
			
			public string Recomandation {
				get { return recomandation; }
				set { recomandation = value; }
			}
			
			public string Human_picture {
				get { return human_picture; }
				set { human_picture = value; }
			}
			
			public string Attachment_name {
				get { return attachment_name; }
				set { attachment_name = value; }
			}
			
			public Nullable<int> Check_status {
				get { return check_status; }
				set { check_status = value; }
			}
			
			public Nullable<int> Register_users_no {
				get { return register_users_no; }
				set { register_users_no = value; }
			}
			
			public Nullable<int> Checker_users_no {
				get { return checker_users_no; }
				set { checker_users_no = value; }
			}
			
			public Nullable<DateTime> Regist_time {
				get { return regist_time; }
				set { regist_time = value; }
			}
			
			public Nullable<DateTime> Check_time {
				get { return check_time; }
				set { check_time = value; }
			}
			
			public Nullable<int> Interview_status {
				get { return interview_status; }
				set { interview_status = value; }
			}
			
			public Nullable<int> Interview_amount {
				get { return interview_amount; }
				set { interview_amount = value; }
			}
			
			public Nullable<double> Total_point {
				get { return total_point; }
				set { total_point = value; }
			}
			
			public Nullable<int> Test_amount {
				get { return test_amount; }
				set { test_amount = value; }
			}
			
			public Nullable<int> Test_checker_users_no {
				get { return test_checker_users_no; }
				set { test_checker_users_no = value; }
			}
			
			public Nullable<DateTime> Test_check_time {
				get { return test_check_time; }
				set { test_check_time = value; }
			}
			
			public Nullable<int> Pass_register_users_no {
				get { return pass_register_users_no; }
				set { pass_register_users_no = value; }
			}
			
			public Nullable<DateTime> Pass_regist_time {
				get { return pass_regist_time; }
				set { pass_regist_time = value; }
			}
			
			public Nullable<int> Pass_checker_users_no {
				get { return pass_checker_users_no; }
				set { pass_checker_users_no = value; }
			}
			
			public Nullable<DateTime> Pass_check_time {
				get { return pass_check_time; }
				set { pass_check_time = value; }
			}
			
			public Nullable<int> Pass_check_status {
				get { return pass_check_status; }
				set { pass_check_status = value; }
			}
			
			public string Pass_checkComment {
				get { return pass_checkComment; }
				set { pass_checkComment = value; }
			}
			
			public string Pass_passComment {
				get { return pass_passComment; }
				set { pass_passComment = value; }
			}
			
			
        #endregion

	}
}



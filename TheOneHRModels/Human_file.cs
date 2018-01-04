//============================================================
// Producnt name:		Models
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-2-21 22:02:24
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
namespace TheOneHRModels
{
	
	[Serializable()]
	public partial class Human_file
	{
	    #region private field
		
			private int id;
			private string human_no;
			private Config_file_third_kind ctk_no;
			private Config_post cp_no;
			private Config_major cm_no;
			private string human_name;
			private string human_sex;
			private string human_email;
			private string human_telephone;
			private string human_qq;
			private string human_mobilephone;
			private string human_address;
			private string human_postcode;
			private Config_country cc_no;
			private Nullable<DateTime> human_birthday;
			private string human_birthplace;
			private Config_nation cn_no;
			private Config_religion cr_no;
			private string human_party;
			private string human_society_security_no;
			private string human_id_card;
			private Nullable<int> human_age;
			private Config_educated_degree ced_no;
			private Nullable<int> human_educated_year;
			private Config_speciality cs_no;
			private Salary_standard ss_no;
			private Config_bank cb_no;
			private string human_account;
			private string human_hobby;
			private Config_goodat cg_no;
			private string human_history_record;
			private string human_family_membership;
			private string remark;
			private string human_picture;
			private string attachment_name;
			private Nullable<decimal> demand_salaray_sum;
			private Nullable<decimal> paid_salary_sum;
			private Nullable<int> major_change_amount;
			private Nullable<int> bonus_amount;
			private Nullable<int> training_amount;
			private Nullable<int> file_chang_amount;
			private Nullable<int> check_status;
			private UserInfo register_users_no;
			private Nullable<int> checker_users_no;
			private Nullable<int> changer_users_no;
			private Nullable<DateTime> regist_time;
			private Nullable<DateTime> check_time;
			private Nullable<DateTime> change_time;
			private Nullable<DateTime> lastly_change_time;
			private Nullable<DateTime> delete_time;
			private Nullable<DateTime> recovery_time;
			private Nullable<int> human_file_status;

        #endregion

        #region constructor

			public Human_file() {
			}

        #endregion

        #region public property

			public int Id {
				get { return id; }
				set { id = value; }
			}
			
			public string Human_no {
				get { return human_no; }
				set { human_no = value; }
			}
			
			public Config_file_third_kind Ctk_no {
				get { return ctk_no; }
				set { ctk_no = value; }
			}
			
			public Config_post Cp_no {
				get { return cp_no; }
				set { cp_no = value; }
			}
			
			public Config_major Cm_no {
				get { return cm_no; }
				set { cm_no = value; }
			}
			
			public string Human_name {
				get { return human_name; }
				set { human_name = value; }
			}
			
			public string Human_sex {
				get { return human_sex; }
				set { human_sex = value; }
			}
			
			public string Human_email {
				get { return human_email; }
				set { human_email = value; }
			}
			
			public string Human_telephone {
				get { return human_telephone; }
				set { human_telephone = value; }
			}
			
			public string Human_qq {
				get { return human_qq; }
				set { human_qq = value; }
			}
			
			public string Human_mobilephone {
				get { return human_mobilephone; }
				set { human_mobilephone = value; }
			}
			
			public string Human_address {
				get { return human_address; }
				set { human_address = value; }
			}
			
			public string Human_postcode {
				get { return human_postcode; }
				set { human_postcode = value; }
			}
			
			public Config_country Cc_no {
				get { return cc_no; }
				set { cc_no = value; }
			}
			
			public Nullable<DateTime> Human_birthday {
				get { return human_birthday; }
				set { human_birthday = value; }
			}
			
			public string Human_birthplace {
				get { return human_birthplace; }
				set { human_birthplace = value; }
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
			
			public string Human_society_security_no {
				get { return human_society_security_no; }
				set { human_society_security_no = value; }
			}
			
			public string Human_id_card {
				get { return human_id_card; }
				set { human_id_card = value; }
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
			
			public Salary_standard Ss_no {
				get { return ss_no; }
				set { ss_no = value; }
			}
			
			public Config_bank Cb_no {
				get { return cb_no; }
				set { cb_no = value; }
			}
			
			public string Human_account {
				get { return human_account; }
				set { human_account = value; }
			}
			
			public string Human_hobby {
				get { return human_hobby; }
				set { human_hobby = value; }
			}
			
			public Config_goodat Cg_no {
				get { return cg_no; }
				set { cg_no = value; }
			}
			
			public string Human_history_record {
				get { return human_history_record; }
				set { human_history_record = value; }
			}
			
			public string Human_family_membership {
				get { return human_family_membership; }
				set { human_family_membership = value; }
			}
			
			public string Remark {
				get { return remark; }
				set { remark = value; }
			}
			
			public string Human_picture {
				get { return human_picture; }
				set { human_picture = value; }
			}
			
			public string Attachment_name {
				get { return attachment_name; }
				set { attachment_name = value; }
			}
			
			public Nullable<decimal> Demand_salaray_sum {
				get { return demand_salaray_sum; }
				set { demand_salaray_sum = value; }
			}
			
			public Nullable<decimal> Paid_salary_sum {
				get { return paid_salary_sum; }
				set { paid_salary_sum = value; }
			}
			
			public Nullable<int> Major_change_amount {
				get { return major_change_amount; }
				set { major_change_amount = value; }
			}
			
			public Nullable<int> Bonus_amount {
				get { return bonus_amount; }
				set { bonus_amount = value; }
			}
			
			public Nullable<int> Training_amount {
				get { return training_amount; }
				set { training_amount = value; }
			}
			
			public Nullable<int> File_chang_amount {
				get { return file_chang_amount; }
				set { file_chang_amount = value; }
			}
			
			public Nullable<int> Check_status {
				get { return check_status; }
				set { check_status = value; }
			}
			
			public UserInfo Register_users_no {
				get { return register_users_no; }
				set { register_users_no = value; }
			}
			
			public Nullable<int> Checker_users_no {
				get { return checker_users_no; }
				set { checker_users_no = value; }
			}
			
			public Nullable<int> Changer_users_no {
				get { return changer_users_no; }
				set { changer_users_no = value; }
			}
			
			public Nullable<DateTime> Regist_time {
				get { return regist_time; }
				set { regist_time = value; }
			}
			
			public Nullable<DateTime> Check_time {
				get { return check_time; }
				set { check_time = value; }
			}
			
			public Nullable<DateTime> Change_time {
				get { return change_time; }
				set { change_time = value; }
			}
			
			public Nullable<DateTime> Lastly_change_time {
				get { return lastly_change_time; }
				set { lastly_change_time = value; }
			}
			
			public Nullable<DateTime> Delete_time {
				get { return delete_time; }
				set { delete_time = value; }
			}
			
			public Nullable<DateTime> Recovery_time {
				get { return recovery_time; }
				set { recovery_time = value; }
			}
			
			public Nullable<int> Human_file_status {
				get { return human_file_status; }
				set { human_file_status = value; }
			}
			
			
        #endregion

	}
}



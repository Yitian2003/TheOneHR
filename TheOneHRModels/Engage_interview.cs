//============================================================
// Producnt name:		Models
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-10-3 21:06:49
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
namespace TheOneHRModels
{
	
	[Serializable()]
	public partial class Engage_interview
	{
	    #region private field
		
			private int id;
			private Nullable<int> interview_amount;
			private string image_degree;
			private string native_language_degree;
			private string foreign_language_degree;
			private string response_speed_degree;
			private string eQ_degree;
			private string iQ_degree;
			private string multi_quality_degree;
			private Nullable<int> register_users_no;
			private Nullable<int> checker_users_no;
			private Nullable<DateTime> regist_time;
			private Nullable<DateTime> check_time;
			private Engage_resume er_no;
			private string result;
			private string interview_comment;
			private string check_comment;
			private Nullable<int> check_status;

        #endregion

        #region constructor

			public Engage_interview() {
			}

        #endregion

        #region public property

			public int Id {
				get { return id; }
				set { id = value; }
			}
			
			public Nullable<int> Interview_amount {
				get { return interview_amount; }
				set { interview_amount = value; }
			}
			
			public string Image_degree {
				get { return image_degree; }
				set { image_degree = value; }
			}
			
			public string Native_language_degree {
				get { return native_language_degree; }
				set { native_language_degree = value; }
			}
			
			public string Foreign_language_degree {
				get { return foreign_language_degree; }
				set { foreign_language_degree = value; }
			}
			
			public string Response_speed_degree {
				get { return response_speed_degree; }
				set { response_speed_degree = value; }
			}
			
			public string EQ_degree {
				get { return eQ_degree; }
				set { eQ_degree = value; }
			}
			
			public string IQ_degree {
				get { return iQ_degree; }
				set { iQ_degree = value; }
			}
			
			public string Multi_quality_degree {
				get { return multi_quality_degree; }
				set { multi_quality_degree = value; }
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
			
			public Engage_resume Er_no {
				get { return er_no; }
				set { er_no = value; }
			}
			
			public string Result {
				get { return result; }
				set { result = value; }
			}
			
			public string Interview_comment {
				get { return interview_comment; }
				set { interview_comment = value; }
			}
			
			public string Check_comment {
				get { return check_comment; }
				set { check_comment = value; }
			}
			
			public Nullable<int> Check_status {
				get { return check_status; }
				set { check_status = value; }
			}
			
			
        #endregion

	}
}



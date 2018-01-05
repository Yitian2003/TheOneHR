//============================================================
// Producnt name:		Models
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-10-6 2:46:03
//============================================================

using System;
using System.Collections.Generic;
using System.Text;

namespace TheOneHRModels
{
	
	[Serializable()]
	public partial class Engage_exam
	{
	    #region private field
		
			private int id;
			private string exam_number;
			private Engage_major_release emr_no;
			private Nullable<int> register_users_no;
			private Nullable<DateTime> regist_time;
			private Nullable<int> limite_time;

        #endregion

        #region constructor

			public Engage_exam() {
			}

        #endregion

        #region public property

			public int Id {
				get { return id; }
				set { id = value; }
			}
			
			public string Exam_number {
				get { return exam_number; }
				set { exam_number = value; }
			}
			
			public Engage_major_release Emr_no {
				get { return emr_no; }
				set { emr_no = value; }
			}
			
			public Nullable<int> Register_users_no {
				get { return register_users_no; }
				set { register_users_no = value; }
			}
			
			public Nullable<DateTime> Regist_time {
				get { return regist_time; }
				set { regist_time = value; }
			}
			
			public Nullable<int> Limite_time {
				get { return limite_time; }
				set { limite_time = value; }
			}
			
			
        #endregion

	}
}



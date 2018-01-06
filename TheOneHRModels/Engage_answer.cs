//============================================================
// Producnt name:		Models
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-10-6 2:46:01
//============================================================

using System;
using System.Collections.Generic;
using System.Text;

namespace TheOneHRModels
{
	
	[Serializable()]
	public partial class Engage_answer
	{
	    #region private field
		
			private int id;
			private string answer_number;
			private Engage_exam ee_no;
			private Engage_resume er_no;
			private Nullable<int> use_time;
			private Nullable<decimal> total_point;

        #endregion

        #region constructor

			public Engage_answer() {
			}

        #endregion

        #region public property

			public int Id {
				get { return id; }
				set { id = value; }
			}
			
			public string Answer_number {
				get { return answer_number; }
				set { answer_number = value; }
			}
			
			public Engage_exam Ee_no {
				get { return ee_no; }
				set { ee_no = value; }
			}
			
			public Engage_resume Er_no {
				get { return er_no; }
				set { er_no = value; }
			}
			
			public Nullable<int> Use_time {
				get { return use_time; }
				set { use_time = value; }
			}
			
			public Nullable<decimal> Total_point {
				get { return total_point; }
				set { total_point = value; }
			}
			
			
        #endregion

	}
}



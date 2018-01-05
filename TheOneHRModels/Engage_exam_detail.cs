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
	public partial class Engage_exam_detail
	{
	    #region private field
		
			private int id;
			private Engage_exam ee_no;
			private Config_question_second_kind cqsk_no;
			private Nullable<int> question_amount;

        #endregion

        #region constructor

			public Engage_exam_detail() {
			}

        #endregion

        #region public property

			public int Id {
				get { return id; }
				set { id = value; }
			}
			
			public Engage_exam Ee_no {
				get { return ee_no; }
				set { ee_no = value; }
			}
			
			public Config_question_second_kind Cqsk_no {
				get { return cqsk_no; }
				set { cqsk_no = value; }
			}
			
			public Nullable<int> Question_amount {
				get { return question_amount; }
				set { question_amount = value; }
			}
			
			
        #endregion

	}
}



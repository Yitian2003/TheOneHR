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
	public partial class Engage_answer_detail
	{
	    #region private field
		
			private int id;
			private Engage_answer ea_no;
			private string answer_details_number;
			private Engage_subject es_no;
			private string answer;

        #endregion

        #region constructor

			public Engage_answer_detail() {
			}

        #endregion

        #region public property

			public int Id {
				get { return id; }
				set { id = value; }
			}
			
			public Engage_answer Ea_no {
				get { return ea_no; }
				set { ea_no = value; }
			}
			
			public string Answer_details_number {
				get { return answer_details_number; }
				set { answer_details_number = value; }
			}
			
			public Engage_subject Es_no {
				get { return es_no; }
				set { es_no = value; }
			}
			
			public string Answer {
				get { return answer; }
				set { answer = value; }
			}
			
			
        #endregion

	}
}



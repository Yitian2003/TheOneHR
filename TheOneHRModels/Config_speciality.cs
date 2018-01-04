//============================================================
// Producnt name:		Models
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-2-18 13:30:24
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
namespace TheOneHRModels
{
	
	[Serializable()]
	public partial class Config_speciality
	{
	    #region private field
		
			private int id;
			private string speciality_name;

        #endregion

        #region constructor

			public Config_speciality() {
			}

        #endregion

        #region public property

			public int Id {
				get { return id; }
				set { id = value; }
			}
			
			public string Speciality_name {
				get { return speciality_name; }
				set { speciality_name = value; }
			}
			
			
        #endregion

	}
}



//============================================================
// Producnt name:		Models
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-2-18 13:30:19
//============================================================

using System;
using System.Collections.Generic;
using System.Text;

namespace TheOneHRModels
{
	
	[Serializable()]
	public partial class Config_country
	{
	    #region private field
		
			private int id;
			private string country_name;

        #endregion

        #region constructor

			public Config_country() {
			}

        #endregion

        #region public property

			public int Id {
				get { return id; }
				set { id = value; }
			}
			
			public string Country_name {
				get { return country_name; }
				set { country_name = value; }
			}
			
			
        #endregion

	}
}



//============================================================
// Producnt name:		Models
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-2-18 13:30:20
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
namespace TheOneHRModels
{
	
	[Serializable()]
	public partial class Config_educated_degree
	{
	    #region private field
		
			private int id;
			private string educated_degree_name;

        #endregion

        #region constructor

			public Config_educated_degree() {
			}

        #endregion

        #region public property

			public int Id {
				get { return id; }
				set { id = value; }
			}
			
			public string Educated_degree_name {
				get { return educated_degree_name; }
				set { educated_degree_name = value; }
			}
			
			
        #endregion

	}
}



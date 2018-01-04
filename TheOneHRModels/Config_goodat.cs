//============================================================
// Producnt name:		Models
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-2-18 13:30:21
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
namespace TheOneHRModels
{
	
	[Serializable()]
	public partial class Config_goodat
	{
	    #region private field
		
			private int id;
			private string goodat_name;

        #endregion

        #region constructor

			public Config_goodat() {
			}

        #endregion

        #region public property

			public int Id {
				get { return id; }
				set { id = value; }
			}
			
			public string Goodat_name {
				get { return goodat_name; }
				set { goodat_name = value; }
			}
			
			
        #endregion

	}
}



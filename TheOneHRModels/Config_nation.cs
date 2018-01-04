//============================================================
// Producnt name:		Models
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-2-18 13:30:23
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
namespace TheOneHRModels
{
	
	[Serializable()]
	public partial class Config_nation
	{
	    #region private field
		
			private int id;
			private string nation_name;

        #endregion

        #region constructor

			public Config_nation() {
			}

        #endregion

        #region public property

			public int Id {
				get { return id; }
				set { id = value; }
			}
			
			public string Nation_name {
				get { return nation_name; }
				set { nation_name = value; }
			}
			
			
        #endregion

	}
}



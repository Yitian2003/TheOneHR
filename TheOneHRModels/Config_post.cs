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
	public partial class Config_post
	{
	    #region private field
		
			private int id;
			private string post_name;

        #endregion

        #region constructor

			public Config_post() {
			}

        #endregion

        #region public property

			public int Id {
				get { return id; }
				set { id = value; }
			}
			
			public string Post_name {
				get { return post_name; }
				set { post_name = value; }
			}
			
			
        #endregion

	}
}



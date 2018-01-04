//============================================================
// Producnt name:		BLL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-2-18 13:30:24
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using TheOneHRDAL;
using TheOneHRModels;

namespace TheOneHRBLL
{

    public static partial class Config_nationManager
    {

		
		//override
		public static Config_nation AddConfig_nation(string Nation_name)
		{
			Config_nation config_nation = new Config_nation();

			TransData_AddConfig_nation(Nation_name,  config_nation );
		
			return Config_nationService.AddConfig_nation(config_nation);
		}
        public static Config_nation AddConfig_nation(Config_nation config_nation)
        {
            return Config_nationService.AddConfig_nation(config_nation);
        }

        public static void DeleteConfig_nation(Config_nation config_nation)
        {
            Config_nationService.DeleteConfig_nation(config_nation);
        }

        public static void DeleteConfig_nationById(int id)
        {
            Config_nationService.DeleteConfig_nationById(id);
        }

		public static void ModifyConfig_nation(Config_nation config_nation)
        {
            Config_nationService.ModifyConfig_nation(config_nation);
        }
		//overload
		public static void ModifyConfig_nation(int Id,string Nation_name)
        {
			Config_nation config_nation = new Config_nation();
	        //PK
			config_nation.Id=Id;
			TransData_ModifyConfig_nation(Id,Nation_name,config_nation);
		
			 Config_nationService.ModifyConfig_nation(config_nation);
		}

        public static IList<Config_nation> GetAllConfig_nations()
        {
            return Config_nationService.GetAllConfig_nations();
        }

        public static Config_nation GetConfig_nationById(int id)
        {
            return Config_nationService.GetConfig_nationById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddConfig_nation(string Nation_name, Config_nation config_nation )
        {

			try{if (Nation_name.ToString() == "0001-1-1 0:00:00") config_nation.Nation_name = null; else config_nation.Nation_name = Nation_name;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyConfig_nation(int Id,string Nation_name, Config_nation config_nation)
		{

			try{if (Nation_name.ToString() == "0001-1-1 0:00:00") config_nation.Nation_name = null; else config_nation.Nation_name = Nation_name;}catch{}
		}
		#endregion
    }
}



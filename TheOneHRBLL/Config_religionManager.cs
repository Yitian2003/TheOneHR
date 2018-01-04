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

    public static partial class Config_religionManager
    {

		
		//override
		public static Config_religion AddConfig_religion(string Religion_name)
		{
			Config_religion config_religion = new Config_religion();

			TransData_AddConfig_religion(Religion_name,  config_religion );
		
			return Config_religionService.AddConfig_religion(config_religion);
		}
        public static Config_religion AddConfig_religion(Config_religion config_religion)
        {
            return Config_religionService.AddConfig_religion(config_religion);
        }

        public static void DeleteConfig_religion(Config_religion config_religion)
        {
            Config_religionService.DeleteConfig_religion(config_religion);
        }

        public static void DeleteConfig_religionById(int id)
        {
            Config_religionService.DeleteConfig_religionById(id);
        }

		public static void ModifyConfig_religion(Config_religion config_religion)
        {
            Config_religionService.ModifyConfig_religion(config_religion);
        }
		//overload
		public static void ModifyConfig_religion(int Id,string Religion_name)
        {
			Config_religion config_religion = new Config_religion();
	        //PK
			config_religion.Id=Id;
			TransData_ModifyConfig_religion(Id,Religion_name,config_religion);
		
			 Config_religionService.ModifyConfig_religion(config_religion);
		}

        public static IList<Config_religion> GetAllConfig_religions()
        {
            return Config_religionService.GetAllConfig_religions();
        }

        public static Config_religion GetConfig_religionById(int id)
        {
            return Config_religionService.GetConfig_religionById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddConfig_religion(string Religion_name, Config_religion config_religion )
        {

			try{if (Religion_name.ToString() == "0001-1-1 0:00:00") config_religion.Religion_name = null; else config_religion.Religion_name = Religion_name;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyConfig_religion(int Id,string Religion_name, Config_religion config_religion)
		{

			try{if (Religion_name.ToString() == "0001-1-1 0:00:00") config_religion.Religion_name = null; else config_religion.Religion_name = Religion_name;}catch{}
		}
		#endregion
    }
}



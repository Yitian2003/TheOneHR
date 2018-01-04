//============================================================
// Producnt name:		BLL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-2-18 13:30:22
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using TheOneHRDAL;
using TheOneHRModels;

namespace TheOneHRBLL
{

    public static partial class Config_goodatManager
    {

		
		//override
		public static Config_goodat AddConfig_goodat(string Goodat_name)
		{
			Config_goodat config_goodat = new Config_goodat();

			TransData_AddConfig_goodat(Goodat_name,  config_goodat );
		
			return Config_goodatService.AddConfig_goodat(config_goodat);
		}
        public static Config_goodat AddConfig_goodat(Config_goodat config_goodat)
        {
            return Config_goodatService.AddConfig_goodat(config_goodat);
        }

        public static void DeleteConfig_goodat(Config_goodat config_goodat)
        {
            Config_goodatService.DeleteConfig_goodat(config_goodat);
        }

        public static void DeleteConfig_goodatById(int id)
        {
            Config_goodatService.DeleteConfig_goodatById(id);
        }

		public static void ModifyConfig_goodat(Config_goodat config_goodat)
        {
            Config_goodatService.ModifyConfig_goodat(config_goodat);
        }
		//overload
		public static void ModifyConfig_goodat(int Id,string Goodat_name)
        {
			Config_goodat config_goodat = new Config_goodat();
	        //PK
			config_goodat.Id=Id;
			TransData_ModifyConfig_goodat(Id,Goodat_name,config_goodat);
		
			 Config_goodatService.ModifyConfig_goodat(config_goodat);
		}

        public static IList<Config_goodat> GetAllConfig_goodats()
        {
            return Config_goodatService.GetAllConfig_goodats();
        }

        public static Config_goodat GetConfig_goodatById(int id)
        {
            return Config_goodatService.GetConfig_goodatById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddConfig_goodat(string Goodat_name, Config_goodat config_goodat )
        {

			try{if (Goodat_name.ToString() == "0001-1-1 0:00:00") config_goodat.Goodat_name = null; else config_goodat.Goodat_name = Goodat_name;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyConfig_goodat(int Id,string Goodat_name, Config_goodat config_goodat)
		{

			try{if (Goodat_name.ToString() == "0001-1-1 0:00:00") config_goodat.Goodat_name = null; else config_goodat.Goodat_name = Goodat_name;}catch{}
		}
		#endregion
    }
}



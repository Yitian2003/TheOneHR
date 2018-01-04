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

    public static partial class Config_specialityManager
    {

		
		//override
		public static Config_speciality AddConfig_speciality(string Speciality_name)
		{
			Config_speciality config_speciality = new Config_speciality();

			TransData_AddConfig_speciality(Speciality_name,  config_speciality );
		
			return Config_specialityService.AddConfig_speciality(config_speciality);
		}
        public static Config_speciality AddConfig_speciality(Config_speciality config_speciality)
        {
            return Config_specialityService.AddConfig_speciality(config_speciality);
        }

        public static void DeleteConfig_speciality(Config_speciality config_speciality)
        {
            Config_specialityService.DeleteConfig_speciality(config_speciality);
        }

        public static void DeleteConfig_specialityById(int id)
        {
            Config_specialityService.DeleteConfig_specialityById(id);
        }

		public static void ModifyConfig_speciality(Config_speciality config_speciality)
        {
            Config_specialityService.ModifyConfig_speciality(config_speciality);
        }
		//overload
		public static void ModifyConfig_speciality(int Id,string Speciality_name)
        {
			Config_speciality config_speciality = new Config_speciality();
	        //PK
			config_speciality.Id=Id;
			TransData_ModifyConfig_speciality(Id,Speciality_name,config_speciality);
		
			 Config_specialityService.ModifyConfig_speciality(config_speciality);
		}

        public static IList<Config_speciality> GetAllConfig_specialities()
        {
            return Config_specialityService.GetAllConfig_specialities();
        }

        public static Config_speciality GetConfig_specialityById(int id)
        {
            return Config_specialityService.GetConfig_specialityById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddConfig_speciality(string Speciality_name, Config_speciality config_speciality )
        {

			try{if (Speciality_name.ToString() == "0001-1-1 0:00:00") config_speciality.Speciality_name = null; else config_speciality.Speciality_name = Speciality_name;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyConfig_speciality(int Id,string Speciality_name, Config_speciality config_speciality)
		{

			try{if (Speciality_name.ToString() == "0001-1-1 0:00:00") config_speciality.Speciality_name = null; else config_speciality.Speciality_name = Speciality_name;}catch{}
		}
		#endregion
    }
}



//============================================================
// Producnt name:		BLL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-2-18 13:30:21
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using TheOneHRDAL;
using TheOneHRModels;

namespace TheOneHRBLL
{

    public static partial class Config_educated_degreeManager
    {

		
		//override
		public static Config_educated_degree AddConfig_educated_degree(string Educated_degree_name)
		{
			Config_educated_degree config_educated_degree = new Config_educated_degree();

			TransData_AddConfig_educated_degree(Educated_degree_name,  config_educated_degree );
		
			return Config_educated_degreeService.AddConfig_educated_degree(config_educated_degree);
		}
        public static Config_educated_degree AddConfig_educated_degree(Config_educated_degree config_educated_degree)
        {
            return Config_educated_degreeService.AddConfig_educated_degree(config_educated_degree);
        }

        public static void DeleteConfig_educated_degree(Config_educated_degree config_educated_degree)
        {
            Config_educated_degreeService.DeleteConfig_educated_degree(config_educated_degree);
        }

        public static void DeleteConfig_educated_degreeById(int id)
        {
            Config_educated_degreeService.DeleteConfig_educated_degreeById(id);
        }

		public static void ModifyConfig_educated_degree(Config_educated_degree config_educated_degree)
        {
            Config_educated_degreeService.ModifyConfig_educated_degree(config_educated_degree);
        }
		//overload
		public static void ModifyConfig_educated_degree(int Id,string Educated_degree_name)
        {
			Config_educated_degree config_educated_degree = new Config_educated_degree();
	        //PK
			config_educated_degree.Id=Id;
			TransData_ModifyConfig_educated_degree(Id,Educated_degree_name,config_educated_degree);
		
			 Config_educated_degreeService.ModifyConfig_educated_degree(config_educated_degree);
		}

        public static IList<Config_educated_degree> GetAllConfig_educated_degrees()
        {
            return Config_educated_degreeService.GetAllConfig_educated_degrees();
        }

        public static Config_educated_degree GetConfig_educated_degreeById(int id)
        {
            return Config_educated_degreeService.GetConfig_educated_degreeById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddConfig_educated_degree(string Educated_degree_name, Config_educated_degree config_educated_degree )
        {

			try{if (Educated_degree_name.ToString() == "0001-1-1 0:00:00") config_educated_degree.Educated_degree_name = null; else config_educated_degree.Educated_degree_name = Educated_degree_name;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyConfig_educated_degree(int Id,string Educated_degree_name, Config_educated_degree config_educated_degree)
		{

			try{if (Educated_degree_name.ToString() == "0001-1-1 0:00:00") config_educated_degree.Educated_degree_name = null; else config_educated_degree.Educated_degree_name = Educated_degree_name;}catch{}
		}
		#endregion
    }
}



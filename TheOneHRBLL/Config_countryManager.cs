//============================================================
// Producnt name:		BLL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-2-18 13:30:19
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using TheOneHRDAL;
using TheOneHRModels;

namespace TheOneHRBLL
{

    public static partial class Config_countryManager
    {

		
		//override
		public static Config_country AddConfig_country(string Country_name)
		{
			Config_country config_country = new Config_country();

			TransData_AddConfig_country(Country_name,  config_country );
		
			return Config_countryService.AddConfig_country(config_country);
		}
        public static Config_country AddConfig_country(Config_country config_country)
        {
            return Config_countryService.AddConfig_country(config_country);
        }

        public static void DeleteConfig_country(Config_country config_country)
        {
            Config_countryService.DeleteConfig_country(config_country);
        }

        public static void DeleteConfig_countryById(int id)
        {
            Config_countryService.DeleteConfig_countryById(id);
        }

		public static void ModifyConfig_country(Config_country config_country)
        {
            Config_countryService.ModifyConfig_country(config_country);
        }
		//overload
		public static void ModifyConfig_country(int Id,string Country_name)
        {
			Config_country config_country = new Config_country();
	        //PK
			config_country.Id=Id;
			TransData_ModifyConfig_country(Id,Country_name,config_country);
		
			 Config_countryService.ModifyConfig_country(config_country);
		}

        public static IList<Config_country> GetAllConfig_countries()
        {
            return Config_countryService.GetAllConfig_countries();
        }

        public static Config_country GetConfig_countryById(int id)
        {
            return Config_countryService.GetConfig_countryById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddConfig_country(string Country_name, Config_country config_country )
        {

			try{if (Country_name.ToString() == "0001-1-1 0:00:00") config_country.Country_name = null; else config_country.Country_name = Country_name;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyConfig_country(int Id,string Country_name, Config_country config_country)
		{

			try{if (Country_name.ToString() == "0001-1-1 0:00:00") config_country.Country_name = null; else config_country.Country_name = Country_name;}catch{}
		}
		#endregion
    }
}



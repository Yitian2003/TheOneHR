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

    public static partial class Config_postManager
    {

		
		//override
		public static Config_post AddConfig_post(string Post_name)
		{
			Config_post config_post = new Config_post();

			TransData_AddConfig_post(Post_name,  config_post );
		
			return Config_postService.AddConfig_post(config_post);
		}
        public static Config_post AddConfig_post(Config_post config_post)
        {
            return Config_postService.AddConfig_post(config_post);
        }

        public static void DeleteConfig_post(Config_post config_post)
        {
            Config_postService.DeleteConfig_post(config_post);
        }

        public static void DeleteConfig_postById(int id)
        {
            Config_postService.DeleteConfig_postById(id);
        }

		public static void ModifyConfig_post(Config_post config_post)
        {
            Config_postService.ModifyConfig_post(config_post);
        }
		//overload
		public static void ModifyConfig_post(int Id,string Post_name)
        {
			Config_post config_post = new Config_post();
	        //PK
			config_post.Id=Id;
			TransData_ModifyConfig_post(Id,Post_name,config_post);
		
			 Config_postService.ModifyConfig_post(config_post);
		}

        public static IList<Config_post> GetAllConfig_posts()
        {
            return Config_postService.GetAllConfig_posts();
        }

        public static Config_post GetConfig_postById(int id)
        {
            return Config_postService.GetConfig_postById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddConfig_post(string Post_name, Config_post config_post )
        {

			try{if (Post_name.ToString() == "0001-1-1 0:00:00") config_post.Post_name = null; else config_post.Post_name = Post_name;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyConfig_post(int Id,string Post_name, Config_post config_post)
		{

			try{if (Post_name.ToString() == "0001-1-1 0:00:00") config_post.Post_name = null; else config_post.Post_name = Post_name;}catch{}
		}
		#endregion
    }
}



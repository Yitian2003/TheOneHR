using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOneHRModels;
using TheOneHRDAL;

namespace TheOneHRBLL
{
    public class Config_file_first_kindManager
    {
        public static IList<Config_file_first_kind> GetAllSConfig_file_first_kinds()
        {
            return Config_file_first_kindService.GetAllConfig_file_first_kinds();
        }

        public static Config_file_first_kind GetConfig_file_first_kindById(int id)
        {
            return Config_file_first_kindService.GetConfig_file_first_kindById(id);
        }

        public static bool AddConfig_file_first_kind(Config_file_first_kind config_file_first_kind)
        {
            return Config_file_first_kindService.AddConfig_file_first_kind(config_file_first_kind) > 0;
        }

        public static bool ModifyConfig_file_first_kind(Config_file_first_kind config_file_first_kind)
        {
            return Config_file_first_kindService.ModifyConfig_file_first_kind(config_file_first_kind) > 0;
        }

        public static bool DelConfig_file_first_kind(int id)
        {
            return Config_file_first_kindService.DelConfig_file_first_kind(id) > 0;
        }

        public static IList<Config_file_first_kind> GetFirstBranchByCondition(string condition)
        {
            return Config_file_first_kindService.GetFirstBranchByCondition(condition);
        }
    }
}

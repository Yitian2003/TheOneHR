using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOneHRModels;
using TheOneHRDAL;

namespace TheOneHRBLL
{
    public class Config_file_third_kindManager
    {
        public static IList<Config_file_third_kind> GetAllSConfig_file_third_kinds()
        {
            return Config_file_third_kindService.GetAllConfig_file_third_kinds();
        }

        public static Config_file_third_kind GetConfig_file_third_kindById(int id)
        {
            return Config_file_third_kindService.GetConfig_file_third_kindById(id);
        }

        public static bool AddConfig_file_third_kind(Config_file_third_kind config_file_third_kind)
        {
            return Config_file_third_kindService.AddConfig_file_third_kind(config_file_third_kind) > 0;
        }

        public static bool ModifyConfig_file_third_kind(Config_file_third_kind config_file_third_kind)
        {
            return Config_file_third_kindService.ModifyConfig_file_third_kind(config_file_third_kind) > 0;
        }

        public static bool DelConfig_file_third_kind(int id)
        {
            return Config_file_third_kindService.DelConfig_file_third_kind(id) > 0;
        }

        public static IList<Config_file_third_kind> GetThirdBranchByCondition(string condition)
        {
            return Config_file_third_kindService.GetThirdBranchByCondition(condition);
        }

        public static IList<Config_file_third_kind> GetConfig_file_third_kindByBranchTwoId(int branch2Id)
        {
            return Config_file_third_kindService.GetConfig_file_third_kindByBranchTwoId(branch2Id);
        }
    }
}

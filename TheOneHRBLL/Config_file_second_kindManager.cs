using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOneHRModels;
using TheOneHRDAL;

namespace TheOneHRBLL
{
    public class Config_file_second_kindManager
    {
        public static IList<Config_file_second_kind> GetAllConfig_file_second_kinds()
        {
            return Config_file_second_kindService.GetAllConfig_file_second_kinds();
        }

        public static Config_file_second_kind GetConfig_file_second_kindById(int id)
        {
            return Config_file_second_kindService.GetConfig_file_second_kindById(id);
        }

        public static bool AddConfig_file_second_kind(Config_file_second_kind config_file_second_kind)
        {
            return Config_file_second_kindService.AddConfig_file_second_kind(config_file_second_kind) > 0;
        }

        public static bool ModifyConfig_file_second_kind(Config_file_second_kind config_file_second_kind)
        {
            return Config_file_second_kindService.ModifyConfig_file_second_kind(config_file_second_kind) > 0;
        }

        public static bool DelConfig_file_second_kind(int id)
        {
            return Config_file_second_kindService.DelConfig_file_second_kind(id) > 0;
        }

        public static IList<Config_file_second_kind> GetSecondBranchByCondition(string condition)
        {
            return Config_file_second_kindService.GetSecondBranchByCondition(condition);
        }

        public static IList<Config_file_second_kind> GetConfig_file_second_kindByBranchOneId(int branch1Id)
        {
            return Config_file_second_kindService.GetConfig_file_second_kindByBranchOneId(branch1Id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOneHRModels;
using TheOneHRDAL;

namespace TheOneHRBLL
{
    public class Config_question_first_kindManager
    {
        public static IList<Config_question_first_kind> GetAllConfig_question_first_kinds()
        {
            return Config_question_first_kindService.GetAllConfig_question_first_kinds();
        }

        public static Config_question_first_kind GetConfig_question_first_kindById(int id)
        {
            return Config_question_first_kindService.GetConfig_question_first_kindById(id);
        }

        public static bool AddConfig_question_first_kind(Config_question_first_kind kind)
        {
            return Config_question_first_kindService.AddConfig_question_first_kind(kind) > 0;
        }

        public static bool ModifyConfig_question_first_kind(Config_question_first_kind kind)
        {
            return Config_question_first_kindService.ModifyConfig_question_first_kind(kind) > 0;
        }

        public static bool DelConfig_question_first_kind(int id)
        {
            return Config_question_first_kindService.DelConfig_question_first_kind(id) > 0;
        }

       
    }
}

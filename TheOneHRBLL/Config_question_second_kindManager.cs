using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TheOneHRDAL;
using TheOneHRModels;

namespace TheOneHRBLL
{
    public class Config_question_second_kindManager
    {
        public static IList<Config_question_second_kind> GetAllConfig_question_second_kinds()
        {
            return Config_question_second_kindService.GetAllConfig_question_second_kinds();
        }

        public static Config_question_second_kind GetConfig_question_second_kindById(int id)
        {
            return Config_question_second_kindService.GetConfig_question_second_kindById(id);
        }

        public static bool AddConfig_question_second_kind(Config_question_second_kind kind)
        {
            return Config_question_second_kindService.AddConfig_question_second_kind(kind) > 0;
        }

        public static bool ModifyConfig_question_second_kind(Config_question_second_kind kind)
        {
            return Config_question_second_kindService.ModifyConfig_question_second_kind(kind) > 0;
        }

        public static bool DelConfig_question_second_kind(int id)
        {
            return Config_question_second_kindService.DelConfig_question_second_kind(id) > 0;
        }

        public static IList<Config_question_second_kind> GetConfig_question_second_kindByQ1Id(int q1Id)
        {
            return Config_question_second_kindService.GetConfig_question_second_kindByQ1Id(q1Id);
        }
    }
}

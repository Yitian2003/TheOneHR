using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOneHRDAL;
using TheOneHRModels;

namespace TheOneHRBLL
{
    public class Config_major_kindManager
    {
        public static IList<Config_major_kind> GetAllConfig_major_kinds()
        {
            return Config_major_kindService.GetAllConfig_major_kinds();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOneHRModels;
using TheOneHRDAL;

namespace TheOneHRBLL
{
    public class Config_majorManager
    {
        public static IList<Config_major> GetAllConfig_majors()
        {
            return Config_majorService.GetAllConfig_majors();
        }

        public static Config_major GetConfig_majorById(int id)
        {
            return Config_majorService.GetConfig_majorById(id);
        }

        public static IList<Config_major> GetConfig_majorByKind(int kindId)
        {
            return Config_majorService.GetMajorByKindId(kindId);
        }
    }
}

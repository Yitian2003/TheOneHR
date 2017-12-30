using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOneHRModels;
using TheOneHRDAL;

namespace TheOneHRBLL
{
    public class Sys_rightManager
    {
        public static IList<Sys_right> GetAllSys_rights()
        {
            return Sys_rightService.GetAllSys_rights();
        }

        public static Sys_right GetSys_rightById(int id)
        {
            return Sys_rightService.GetSys_rightById(id);
        }

        public static bool AddSys_right(Sys_right sys_right)
        {
            return Sys_rightService.AddSys_right(sys_right) > 0;
        }

        public static bool ModifySys_right(Sys_right sys_right)
        {
            return Sys_rightService.ModifySys_right(sys_right) > 0;
        }

        public static bool DelSys_right(int id)
        {
            return Sys_rightService.DelSys_right(id) > 0;
        }
    }
}

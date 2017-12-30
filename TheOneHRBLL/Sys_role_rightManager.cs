using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOneHRModels;
using TheOneHRDAL;

namespace TheOneHRBLL
{
    public class Sys_role_rightManager
    {
        public static IList<Sys_role_right> GetAllSys_role_rights()
        {
            return Sys_role_rightService.GetAllSys_role_rights();
        }

        public static Sys_role_right GetSys_role_rightById(int id)
        {
            return Sys_role_rightService.GetSys_role_rightById(id);
        }

        public static bool AddSys_role_right(Sys_role_right sys_role_right)
        {
            return Sys_role_rightService.AddSys_role_right(sys_role_right) > 0;
        }

        public static bool ModifySys_role_right(Sys_role_right sys_role_right)
        {
            return Sys_role_rightService.ModifySys_role_right(sys_role_right) > 0;
        }

        public static bool DelSys_role_right(int id)
        {
            return Sys_role_rightService.DelSys_role_right(id) > 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOneHRModels;
using TheOneHRDAL;

namespace TheOneHRBLL
{
    public class Sys_roleManager
    {
        public static IList<Sys_role> GetAllSys_roles()
        {
            return Sys_roleService.GetAllSys_roles();
        }

        public static Sys_role GetSys_roleById(int id)
        {
            return Sys_roleService.GetSys_roleById(id);
        }

        public static bool AddSys_role(Sys_role sys_role)
        {
            return Sys_roleService.AddSys_role(sys_role) > 0;
        }

        public static bool ModifySys_role(Sys_role sys_role)
        {
            return Sys_roleService.ModifySys_role(sys_role) > 0;
        }

        public static bool DelSys_role(int id)
        {
            return Sys_roleService.DelSys_role(id) > 0;
        }
    }
}

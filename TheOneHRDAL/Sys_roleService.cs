using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TheOneHRModels;

namespace TheOneHRDAL
{
    public class Sys_roleService
    {

        private static IList<Sys_role> GetSys_rolesBySQL(string sql)
        {
            IList<Sys_role> roles = new List<Sys_role>();

            DataTable dataTable = DBHelper.GetDataTable(sql);

            if(dataTable != null)
            {
                for(int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Sys_role role = new Sys_role();
                    role.Id = int.Parse(dataTable.Rows[i]["Id"].ToString());
                    role.Role_Name = dataTable.Rows[i]["Role_name"].ToString();
                    role.Role_Desc = dataTable.Rows[i]["Role_desc"].ToString();

                    roles.Add(role);
                }
            }

            return roles;
        }
        public static IList<Sys_role> GetAllSys_roles()
        {
            string sql = "select * from Sys_role";
            return GetSys_rolesBySQL(sql);
        }

        public static Sys_role GetSys_roleById(int id)
        {
            string sql = "select * from Sys_role where Id=" + id.ToString();
            try
            {
                return GetSys_rolesBySQL(sql)[0];
            }
            catch
            {
                return null;
            }
            
        }

        public static int AddSys_role(Sys_role role)
        {
            string sql = string.Format("insert into [Sys_role] ([Role_name], [Role_desc]) Values('{0}','{1}')",
                role.Role_Name, role.Role_Desc);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int ModifySys_role(Sys_role role)
        {
            string sql = string.Format("UPDATE [Sys_role] SET[Role_name] = '{0}',[Role_desc]='{1}' WHERE Id={2}",
                role.Role_Name, role.Role_Desc, role.Id);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int DelSys_role(int id)
        {
            string sql = "delete from Sys_role where Id=" + id.ToString();
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}

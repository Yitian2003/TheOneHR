using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TheOneHRModels;

namespace TheOneHRDAL
{
    public class Sys_role_rightService
    {
        private static IList<Sys_role_right> GetSys_role_rightBySQL(string sql)
        {
            IList<Sys_role_right> role_rights = new List<Sys_role_right>();

            DataTable dataTable = DBHelper.GetDataTable(sql);

            if(dataTable != null)
            {
                for(int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Sys_role_right role_right = new Sys_role_right();
                    role_right.Id = int.Parse(dataTable.Rows[i]["Id"].ToString());
                    role_right.Rf_role = Sys_roleService.GetSys_roleById(int.Parse(dataTable.Rows[i]["Rf_role_no"].ToString()));
                    role_right.Rf_right = Sys_rightService.GetSys_rightById(int.Parse(dataTable.Rows[i]["Rf_right_no"].ToString()));

                    role_rights.Add(role_right);
                }
            }
            
            return role_rights;
        }

        public static IList<Sys_role_right> GetAllSys_role_rights()
        {
            string sql = "select * from Sys_role_right";
            return GetSys_role_rightBySQL(sql);
        }

        public static Sys_role_right GetSys_role_rightById(int id)
        {
            string sql = "select * from Sys_role_right where Id=" + id.ToString();

            try
            {
                return GetSys_role_rightBySQL(sql)[0];
            }
            catch
            {
                return null;
            }
        }

        public static int AddSys_role_right(Sys_role_right role_right)
        {
            string sql = string.Format("insert into [Sys_role_right] ([Rf_role_no], [Rf_right_no]) Values({0},{1})",
                role_right.Rf_role.Id, role_right.Rf_right.Id);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int ModifySys_role_right(Sys_role_right role_right)
        {
            string sql = string.Format("update [Sys_role_right] set [Rf_role_no]={0}, [Rf_right_no={1} where Id={2}",
               role_right.Rf_role.Id, role_right.Rf_right.Id, role_right.Id);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int DelSys_role_right(int id)
        {
            string sql = "delete from Sys_role_right where Id=" + id.ToString();
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}

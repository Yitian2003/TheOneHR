using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TheOneHRModels;

namespace TheOneHRDAL
{
    public class Sys_rightService
    {
        private static IList<Sys_right> GetSys_rightsBySQL(string sql)
        {
            IList<Sys_right> rights = new List<Sys_right>();

            DataTable dataTable = DBHelper.GetDataTable(sql);

            if(dataTable != null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Sys_right right = new Sys_right();
                    right.Id = int.Parse(dataTable.Rows[i]["Id"].ToString());
                    right.Right_parent_code = int.Parse(dataTable.Rows[i]["Right_parent_code"].ToString());
                    right.Right_type = dataTable.Rows[i]["Right_type"].ToString();
                    right.Right_text = dataTable.Rows[i]["Right_type"].ToString();
                    right.Right_url = dataTable.Rows[i]["Right_url"].ToString();
                    right.Right_tip = dataTable.Rows[i]["Right_tip"].ToString();

                    rights.Add(right);
                }
                
            }
            return rights;
        }

        public static IList<Sys_right> GetAllSys_rights()
        {
            string sql = "select * from Sys_right";
            return GetSys_rightsBySQL(sql);
        }

        public static Sys_right GetSys_rightById(int id)
        {
            string sql = "select * from Sys_right where Id=" + id.ToString();

            try
            {
                return GetSys_rightsBySQL(sql)[0];
            } catch
            {
                return null;
            }
        }

        public static int AddSys_right(Sys_right right)
        {
            string sql = string.Format("insert into [Sys_right] ([Right_parent_code], [Right_type], [Right_text], [Right_url], [Right_tip]) Values({0},'{1}','{2}','{3}','{4}')",
                right.Right_parent_code, right.Right_type, right.Right_text, right.Right_url, right.Right_tip);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int ModifySys_right(Sys_right right)
        {
            string sql = string.Format("UPDATE [Sys_right] SET [Right_parent_code] = {0},[Right_type]='{1}' ,[Right_text]='{2}',[Right_url]='{3}',[Right_tip]='{4}' WHERE Id={5}",
                right.Right_parent_code, right.Right_type, right.Right_text, right.Right_url, right.Right_tip, right.Id);

            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int DelSys_right(int id)
        {
            string sql = "delet from Sys_right where Id=" + id.ToString();
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}

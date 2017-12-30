using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TheOneHRModels;

namespace TheOneHRDAL
{
    public class UserInfoService
    {
        private static IList<UserInfo> GetUserBySQL(string sql)
        {
            IList<UserInfo> users = new List<UserInfo>();

            DataTable dataTable = DBHelper.GetDataTable(sql);

            if(dataTable != null)
            {
                for(int i = 0; i< dataTable.Rows.Count; i++)
                {
                    UserInfo user = new UserInfo();
                    user.Id = int.Parse(dataTable.Rows[i]["Id"].ToString());
                    user.User_name = dataTable.Rows[i]["Users_name"].ToString();
                    user.User_password = dataTable.Rows[i]["Users_password"].ToString();
                    // get role from foregn key
                    user.Sys_role = Sys_roleService.GetSys_roleById(int.Parse(dataTable.Rows[i]["Roleno"].ToString()));

                    users.Add(user);
                }
            }
            return users;
        }
        public static IList<UserInfo> GetAllUserInfos()
        {
            string sql = "select * from UserInfo";

            return GetUserBySQL(sql);
        }

        public static UserInfo GetUserById(int id)
        {
            string sql = "select * from UserInfo where Id=" + id.ToString();

            try
            {
                return GetUserBySQL(sql)[0];
            }
            catch
            {
                return null;
            }
            
        }

        public static int AddUser(UserInfo user)
        {
            string sql = string.Format("insert into [UserInfor] ([Users_name], [Users_password], [Roleno]) Values('{0}','{1}',{2})",
                user.User_name, user.User_password, user.Sys_role.Id);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int ModifyUser(UserInfo user)
        {
            string sql = string.Format("UPDATE [UserInfo] SET[Users_name] = '{0}',[Users_password]='{1}',[Roleno] ={2} WHERE Id={3}", 
                user.User_name, user.User_password, user.Sys_role.Id, user.Id);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int DelUser(int id)
        {
            string sql = "delete from UserInfo where Id=" + id.ToString();
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static UserInfo GetUserByLoginId(string loginId)
        {
            string sql = string.Format("select * from UserInfo where Users_name='{0}'", loginId);
            try
            {
                return GetUserBySQL(sql)[0];
            } catch
            {
                return null;
            }
            
        }
    }
}

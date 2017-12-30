using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOneHRModels;
using TheOneHRDAL;

namespace TheOneHRBLL
{
    public class UserInfoManager
    {
        public static IList<UserInfo> GetAllUserInfos()
        {
            return UserInfoService.GetAllUserInfos();
        }

        public static UserInfo GetUserById(int id)
        {
            return UserInfoService.GetUserById(id);
        }

        public static bool AddUser(UserInfo user)
        {
            return UserInfoService.AddUser(user) > 0;
        }

        public static bool ModifyUser(UserInfo user)
        {
            return UserInfoService.ModifyUser(user) > 0;
        }

        public static bool DelUser(int id)
        {
            return UserInfoService.DelUser(id) > 0;
        }

        public static bool Login(string username, string password, out UserInfo user)
        {
            UserInfo userInfo = UserInfoService.GetUserByLoginId(username);

            if(userInfo != null)
            {
                if(userInfo.User_password == password)
                {
                    user = userInfo;
                    return true;
                }
                else
                {
                    user = null;
                    return false;
                }
                
            }
            else
            {
                user = null;
                return false;
            }
            
        }
    }
}

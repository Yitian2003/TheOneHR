using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOneHRModels
{
    public class UserInfo
    {
        #region private field
        private int _id;
        private string _user_name;
        private string _user_password;
        private Sys_role _sys_role;
        #endregion

        #region public Property
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string User_name
        {
            get
            {
                return _user_name;
            }

            set
            {
                _user_name = value;
            }
        }

        public string User_password
        {
            get
            {
                return _user_password;
            }

            set
            {
                _user_password = value;
            }
        }

        public Sys_role Sys_role
        {
            get
            {
                return _sys_role;
            }

            set
            {
                _sys_role = value;
            }
        }
        #endregion
    }
}

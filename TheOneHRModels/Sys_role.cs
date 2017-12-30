using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOneHRModels
{
    public class Sys_role
    {
        #region private field
        private int _id;
        private string _role_name;
        private string _role_Desc;
        #endregion

        #region public property
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

        public string Role_Name
        {
            get
            {
                return _role_name;
            }

            set
            {
                _role_name = value;
            }
        }

        public string Role_Desc
        {
            get
            {
                return _role_Desc;
            }

            set
            {
                _role_Desc = value;
            }
        }
        #endregion
    }
}

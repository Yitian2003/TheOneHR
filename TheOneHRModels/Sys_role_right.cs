using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOneHRModels
{
    public class Sys_role_right
    {
        #region private field
        private int _id;
        private Sys_role _rf_role;
        private Sys_right _rf_right;
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

        public Sys_role Rf_role
        {
            get
            {
                return _rf_role;
            }

            set
            {
                _rf_role = value;
            }
        }

        public Sys_right Rf_right
        {
            get
            {
                return _rf_right;
            }

            set
            {
                _rf_right = value;
            }
        }
        #endregion
    }
}

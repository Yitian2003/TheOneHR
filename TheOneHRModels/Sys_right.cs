using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOneHRModels
{
    public class Sys_right
    {
        #region private field
        private int _id;
        private int _right_parent_code;
        private string _right_type;
        private string _right_text;
        private string _right_url;
        private string _right_tip;
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

        public int Right_parent_code
        {
            get
            {
                return _right_parent_code;
            }

            set
            {
                _right_parent_code = value;
            }
        }

        public string Right_type
        {
            get
            {
                return _right_type;
            }

            set
            {
                _right_type = value;
            }
        }

        public string Right_text
        {
            get
            {
                return _right_text;
            }

            set
            {
                _right_text = value;
            }
        }

        public string Right_url
        {
            get
            {
                return _right_url;
            }

            set
            {
                _right_url = value;
            }
        }

        public string Right_tip
        {
            get
            {
                return _right_tip;
            }

            set
            {
                _right_tip = value;
            }
        }
        #endregion
    }
}

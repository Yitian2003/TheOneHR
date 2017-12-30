using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOneHRModels
{
    [Serializable()]
    public partial class Config_major
    {
        #region private field

        private int id;
        private Config_major_kind cmk;
        private string major_no;
        private string major_name;

        #endregion

        #region constructor

        public Config_major()
        {
        }

        #endregion

        #region public property

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Config_major_kind Cmk
        {
            get { return cmk; }
            set { cmk = value; }
        }

        public string Major_no
        {
            get { return major_no; }
            set { major_no = value; }
        }

        public string Major_name
        {
            get { return major_name; }
            set { major_name = value; }
        }


        #endregion

    }
}

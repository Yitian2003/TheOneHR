using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOneHRModels
{
    [Serializable()]
    public partial class Config_major_kind
    {
        #region private field

        private int id;
        private string major_kind_no;
        private string major_kind_name;

        #endregion

        #region constructor

        public Config_major_kind()
        {
        }

        #endregion

        #region public property

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Major_kind_no
        {
            get { return major_kind_no; }
            set { major_kind_no = value; }
        }

        public string Major_kind_name
        {
            get { return major_kind_name; }
            set { major_kind_name = value; }
        }


        #endregion

    }
}

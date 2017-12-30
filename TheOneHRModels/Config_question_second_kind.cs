using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOneHRModels
{
    [Serializable()]
    public partial class Config_question_second_kind
    {
        #region private field

        private int id;
        private Config_question_first_kind cqfk_no;
        private string second_kind_no;
        private string second_kind_name;

        #endregion

        #region constructor

        public Config_question_second_kind()
        {
        }

        #endregion

        #region public property

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Config_question_first_kind Cqfk_no
        {
            get { return cqfk_no; }
            set { cqfk_no = value; }
        }

        public string Second_kind_no
        {
            get { return second_kind_no; }
            set { second_kind_no = value; }
        }

        public string Second_kind_name
        {
            get { return second_kind_name; }
            set { second_kind_name = value; }
        }


        #endregion

    }
}

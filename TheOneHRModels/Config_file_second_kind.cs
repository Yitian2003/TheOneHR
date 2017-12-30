using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOneHRModels
{
    public class Config_file_second_kind
    {
        #region private field

        private int id;
        private Config_file_first_kind cfk;
        private string second_kind_no;
        private string second_kind_name;
        private string second_kind_salary_no;
        private string second_kind_sale_no;

        #endregion

        #region constructor

        public Config_file_second_kind()
        {
        }

        #endregion

        #region public property

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Config_file_first_kind Cfk
        {
            get { return cfk; }
            set { cfk = value; }
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

        public string Second_kind_salary_no
        {
            get { return second_kind_salary_no; }
            set { second_kind_salary_no = value; }
        }

        public string Second_kind_sale_no
        {
            get { return second_kind_sale_no; }
            set { second_kind_sale_no = value; }
        }


        #endregion
    }
}

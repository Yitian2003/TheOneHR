using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOneHRModels
{
    public class Config_file_third_kind
    {
        #region private field

        private int id;
        private Config_file_second_kind csk;
        private string third_kind_no;
        private string third_kind_name;
        private string third_kind_salary_no;
        private string third_kind_is_retail;

        #endregion

        #region constructor

        public Config_file_third_kind()
        {
        }

        #endregion

        #region public property

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Config_file_second_kind Csk
        {
            get { return csk; }
            set { csk = value; }
        }

        public string Third_kind_no
        {
            get { return third_kind_no; }
            set { third_kind_no = value; }
        }

        public string Third_kind_name
        {
            get { return third_kind_name; }
            set { third_kind_name = value; }
        }

        public string Third_kind_salary_no
        {
            get { return third_kind_salary_no; }
            set { third_kind_salary_no = value; }
        }

        public string Third_kind_is_retail
        {
            get { return third_kind_is_retail; }
            set { third_kind_is_retail = value; }
        }


        #endregion
    }
}

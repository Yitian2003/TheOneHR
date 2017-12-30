using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOneHRModels
{
    public class Config_file_first_kind
    {
        #region private field

        private int id;
        private string first_kind_no;
        private string first_kind_name;
        private string first_kind_salary_no;
        private string first_kind_sale_no;

        #endregion

        #region constructor

        public Config_file_first_kind()
        {
        }

        #endregion

        #region public property

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string First_kind_no
        {
            get { return first_kind_no; }
            set { first_kind_no = value; }
        }

        public string First_kind_name
        {
            get { return first_kind_name; }
            set { first_kind_name = value; }
        }

        public string First_kind_salary_no
        {
            get { return first_kind_salary_no; }
            set { first_kind_salary_no = value; }
        }

        public string First_kind_sale_no
        {
            get { return first_kind_sale_no; }
            set { first_kind_sale_no = value; }
        }


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOneHRModels
{
    public class Engage_major_release
    {
        #region private field

        private int id;
        private Config_file_third_kind ctk;
        private Config_major cm;
        private Nullable<int> human_amount;
        private string engage_type;
        private UserInfo register_users;
        private UserInfo changer_users;
        private Nullable<DateTime> regist_time;
        private Nullable<DateTime> change_time;
        private string major_describe;
        private string engage_required;
        private Nullable<DateTime> deadline;

        #endregion

        #region constructor

        public Engage_major_release()
        {
        }

        #endregion

        #region public property

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Config_file_third_kind Ctk
        {
            get { return ctk; }
            set { ctk = value; }
        }

        public Config_major Cm
        {
            get { return cm; }
            set { cm = value; }
        }

        public Nullable<int> Human_amount
        {
            get { return human_amount; }
            set { human_amount = value; }
        }

        public string Engage_type
        {
            get { return engage_type; }
            set { engage_type = value; }
        }

        public UserInfo Register_users
        {
            get { return register_users; }
            set { register_users = value; }
        }

        public UserInfo Changer_users
        {
            get { return changer_users; }
            set { changer_users = value; }
        }

        public Nullable<DateTime> Regist_time
        {
            get { return regist_time; }
            set { regist_time = value; }
        }

        public Nullable<DateTime> Change_time
        {
            get { return change_time; }
            set { change_time = value; }
        }

        public string Major_describe
        {
            get { return major_describe; }
            set { major_describe = value; }
        }

        public string Engage_required
        {
            get { return engage_required; }
            set { engage_required = value; }
        }

        public Nullable<DateTime> Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }


        #endregion
    }
}

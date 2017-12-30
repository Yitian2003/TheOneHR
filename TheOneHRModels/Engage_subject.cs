using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOneHRModels
{
    [Serializable()]
    public partial class Engage_subject
    {
        #region private field

        private int id;
        private Config_question_second_kind cqsk_No;
        private UserInfo register_users_No;
        private Nullable<int> changer_users_No;
        private Nullable<DateTime> regist_time;
        private Nullable<DateTime> change_time;
        private string derivation;
        private string context;
        private string key_a;
        private string key_b;
        private string key_c;
        private string key_d;
        private string key_e;
        private string correct_key;

        #endregion

        #region constructor

        public Engage_subject()
        {
        }

        #endregion

        #region public property

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Config_question_second_kind Cqsk_No
        {
            get { return cqsk_No; }
            set { cqsk_No = value; }
        }

        public UserInfo Register_users_No
        {
            get { return register_users_No; }
            set { register_users_No = value; }
        }

        public Nullable<int> Changer_users_No
        {
            get { return changer_users_No; }
            set { changer_users_No = value; }
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

        public string Derivation
        {
            get { return derivation; }
            set { derivation = value; }
        }

        public string Context
        {
            get { return context; }
            set { context = value; }
        }

        public string Key_a
        {
            get { return key_a; }
            set { key_a = value; }
        }

        public string Key_b
        {
            get { return key_b; }
            set { key_b = value; }
        }

        public string Key_c
        {
            get { return key_c; }
            set { key_c = value; }
        }

        public string Key_d
        {
            get { return key_d; }
            set { key_d = value; }
        }

        public string Key_e
        {
            get { return key_e; }
            set { key_e = value; }
        }

        public string Correct_key
        {
            get { return correct_key; }
            set { correct_key = value; }
        }


        #endregion

    }
}

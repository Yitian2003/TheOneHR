using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOneHRDAL;
using TheOneHRModels;
using System.Data;

namespace TheOneHRBLL
{
    public class Engage_subjectManager
    {
        public static IList<Engage_subject> GetAllEngage_subjects()
        {
            return Engage_subjectService.GetAllEngage_subjects();
        }

        public static Engage_subject GetEngage_subjectById(int id)
        {
            return Engage_subjectService.GetEngage_subjectById(id);
        }

        public static bool AddEngage_subject(Engage_subject kind)
        {
            return Engage_subjectService.AddEngage_subject(kind) > 0;
        }

        public static bool ModifyEngage_subject(Engage_subject kind)
        {
            return Engage_subjectService.ModifyEngage_subject(kind) > 0;
        }

        public static bool DelEngage_subject(int id)
        {
            return Engage_subjectService.DelEngage_subject(id) > 0;
        }

        public static IList<Engage_subject> SearchEngage_subjectAdv(int categoryId, string key, string startTime, string endTime)
        {
            string condition = " 1=1 ";

            if(categoryId != -1)
            {
                condition += " and Cqsk_No=" + categoryId;
            }

            if(!string.IsNullOrEmpty(key))
            {
                condition += string.Format(" and Context like '%{0}%' or Users_name like '%{0}%' or Derivation like '%{0}%'", key);
            }

            if(!string.IsNullOrEmpty(startTime))
            {
                if(!string.IsNullOrEmpty(endTime))
                {
                    condition += string.Format(" and Regist_time between '{0}' and '{1}'", startTime + " 00:00:00", endTime + " 23:59:59");
                }
                else
                {
                    condition += string.Format(" and Regist_time > '{0}'", startTime + " 00:00:00");
                }
            }
            return Engage_subjectService.SearchEngage_subjectAdv(condition);
        }

        public static DataTable GetEngageSubjectList()
        {
            return Engage_subjectService.GetEngageSubjectList();
        }


    }
}

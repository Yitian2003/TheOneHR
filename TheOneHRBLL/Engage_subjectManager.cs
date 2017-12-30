using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOneHRDAL;
using TheOneHRModels;

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
    }
}

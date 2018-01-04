using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOneHRDAL;
using TheOneHRModels;

namespace TheOneHRBLL
{
    public class Engage_major_releaseManager
    {
        public static IList<Engage_major_release> GetAllEngage_major_releases()
        {
            return Engage_major_releaseService.GetAllEngage_major_releases();
        }

        public static Engage_major_release GetEngage_major_releaseById(int id)
        {
            return Engage_major_releaseService.GetEngage_major_releaseById(id);
        }

        public static bool AddEngage_major_release(Engage_major_release release)
        {
            return Engage_major_releaseService.AddEngage_major_release(release) > 0;
        }

        public static bool ModifyEngage_major_release(Engage_major_release release)
        {
            return Engage_major_releaseService.ModifyEngage_major_release(release) > 0;
        }

        public static bool DelEngage_major_release(int id)
        {
            return Engage_major_releaseService.DelEngage_major_release(id) > 0;
        }


        public static Engage_major_release GetEngage_major_releaseByPostId(int postid)
        {
            return Engage_major_releaseService.GetEngage_major_releaseByPostId(postid);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOneHRModels;

namespace TheOneHRDAL
{
    public class Engage_major_releaseService
    {
        private static IList<Engage_major_release> GetEngage_major_releaseBySQL(string sql)
        {
            IList<Engage_major_release> releases = new List<Engage_major_release>();

            DataTable dataTable = DBHelper.GetDataTable(sql);

            if(dataTable != null)
            {
                for(int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Engage_major_release release = new Engage_major_release();
                    release.Id = int.Parse(dataTable.Rows[i]["Id"].ToString());
                    release.Ctk = Config_file_third_kindService.GetConfig_file_third_kindById(int.Parse(dataTable.Rows[i]["Ctk_no"].ToString()));
                    release.Cm = Config_majorService.GetConfig_majorById(int.Parse(dataTable.Rows[i]["Cm_no"].ToString()));   
                    release.Human_amount = int.Parse(dataTable.Rows[i]["Human_amount"].ToString());
                    release.Engage_type = dataTable.Rows[i]["Engage_type"].ToString();
                    release.Register_users = UserInfoService.GetUserById(int.Parse(dataTable.Rows[i]["Register_users_no"].ToString()));
                    release.Changer_users = UserInfoService.GetUserById(int.Parse(dataTable.Rows[i]["Changer_users_no"].ToString()));
                    //release.Regist_time = DateTime.Parse(dataTable.Rows[i]["Regist_time"].ToString());
                    release.Regist_time = string.IsNullOrEmpty(dataTable.Rows[i]["Regist_time"].ToString()) ? (DateTime?)null : DateTime.Parse(dataTable.Rows[i]["Regist_time"].ToString());
                    //release.Change_time = DateTime.Parse(dataTable.Rows[i]["Change_time"].ToString());
                    release.Change_time = string.IsNullOrEmpty(dataTable.Rows[i]["Change_time"].ToString()) ? (DateTime?)null : DateTime.Parse(dataTable.Rows[i]["Change_time"].ToString());
                    release.Major_describe = dataTable.Rows[i]["Major_describe"].ToString();
                    release.Engage_required = dataTable.Rows[i]["Engage_required"].ToString();
                    //release.Deadline = DateTime.Parse(dataTable.Rows[i]["Deadline"].ToString());
                    release.Deadline = string.IsNullOrEmpty(dataTable.Rows[i]["Deadline"].ToString()) ? (DateTime?)null : DateTime.Parse(dataTable.Rows[i]["Deadline"].ToString());

                    releases.Add(release);
                }
            }
            return releases;
        }

        public static IList<Engage_major_release> GetAllEngage_major_releases()
        {
            string sql = "select * from Engage_major_release";
            return GetEngage_major_releaseBySQL(sql);
        }

        public static Engage_major_release GetEngage_major_releaseById(int id)
        {
            string sql = "select * from Engage_major_release where Id=" + id.ToString();

            try
            {
                return GetEngage_major_releaseBySQL(sql)[0];
            }
            catch
            {
                return null;
            }
        }

        public static int AddEngage_major_release(Engage_major_release release)
        {
            string sql = string.Format("insert into [Engage_major_release] ([Ctk_no], [Cm_no],[Human_amount],[Engage_type],[Register_users_no],[Changer_users_no],[Regist_time],[Change_time],[Major_describe],[Engage_required],[Deadline]) Values({0},{1},{2},'{3}',{4},{5},'{6}','{7}','{8}','{9}','{10}')",
                release.Ctk.Id, release.Cm.Id, release.Human_amount, release.Engage_type, release.Register_users.Id, release.Changer_users.Id, release.Regist_time, release.Change_time, release.Major_describe, release.Engage_required, release.Deadline); 
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int ModifyEngage_major_release(Engage_major_release release)
        {
            string sql = string.Format("UPDATE [Engage_major_release] SET [Ctk_no]={0}, [Cm_no]={1},[Human_amount]={2},[Engage_type]='{3}',[Register_users_no]={4},[Changer_users_no]={5},[Regist_time]='{6}',[Change_time]='{7}',[Major_describe]='{8}',[Engage_required]='{9}',[Deadline]='{10}' WHERE Id={11}",
                release.Ctk.Id, release.Cm.Id, release.Human_amount, release.Engage_type, release.Register_users.Id, release.Changer_users.Id, release.Regist_time, release.Change_time, release.Major_describe, release.Engage_required, release.Deadline, release.Id); 
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int DelEngage_major_release(int id)
        {
            string sql = "delete from Engage_major_release where Id=" + id.ToString();
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static Engage_major_release GetEngage_major_releaseByPostId(int postid)
        {
            string sql = "select top 1 * from Engage_major_release where Cm_no=" + postid;
            try
            {
                return GetEngage_major_releaseBySQL(sql)[0];
            }
            catch
            {
                return null;
            }
        }
    }
}

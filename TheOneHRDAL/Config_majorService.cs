using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOneHRModels;
using System.Data;

namespace TheOneHRDAL
{
    public class Config_majorService
    {
        private static IList<Config_major> GetConfig_majorBySQL(string sql)
        {
            IList<Config_major> majors = new List<Config_major>();

            DataTable dataTable = DBHelper.GetDataTable(sql);

            if (dataTable != null)
            {
                    for(int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        Config_major major = new Config_major();
                        major.Id = int.Parse(dataTable.Rows[i]["Id"].ToString());
                        major.Major_name = dataTable.Rows[i]["Major_name"].ToString();
                        major.Major_no = dataTable.Rows[i]["Major_no"].ToString();
                        major.Cmk = Config_major_kindService.GetConfig_major_kindById(int.Parse(dataTable.Rows[i]["Cmk_no"].ToString()));

                        majors.Add(major);
                    }
            }
            return majors;
        }

        public static IList<Config_major> GetAllConfig_majors()
        {
            string sql = "select * from Config_major";
            return GetConfig_majorBySQL(sql);
        }

        public static Config_major GetConfig_majorById(int id)
        {
            string sql = "select * from Config_major where Id=" + id.ToString();

            try
            {
                return GetConfig_majorBySQL(sql)[0];
            }
            catch
            {
                return null;
            }
        }

        public static IList<Config_major> GetMajorByKindId(int kindId)
        {
            string sql = "select * from Config_major where Cmk_no=" + kindId.ToString();
            return GetConfig_majorBySQL(sql);
        }
    }
}

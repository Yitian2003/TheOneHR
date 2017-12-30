using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheOneHRModels;
using System.Data;

namespace TheOneHRDAL
{
    public class Config_major_kindService
    {
        private static IList<Config_major_kind> GetConfig_major_kindBySQL(string sql)
        {
            IList<Config_major_kind> kinds = new List<Config_major_kind>();

            DataTable dataTable = DBHelper.GetDataTable(sql);

            if(dataTable != null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Config_major_kind kind = new Config_major_kind();
                    kind.Id = int.Parse(dataTable.Rows[i]["Id"].ToString());
                    kind.Major_kind_name = dataTable.Rows[i]["Major_kind_name"].ToString();
                    kind.Major_kind_no = dataTable.Rows[i]["Major_kind_no"].ToString();

                    kinds.Add(kind);
                }

            }
            return kinds;
        }

        public static IList<Config_major_kind> GetAllConfig_major_kinds()
        {
            string sql = "select * from Config_major_kind";
            return GetConfig_major_kindBySQL(sql);
        }

        public static Config_major_kind GetConfig_major_kindById(int id)
        {
            string sql = "select * from Config_major_kind where Id=" + id.ToString();
            try
            {
                return GetConfig_major_kindBySQL(sql)[0];
            }
            catch
            {
                return null;
            }
        }
    }
}

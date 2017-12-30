using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TheOneHRModels;

namespace TheOneHRDAL
{
    public class Config_file_first_kindService
    {
        private static IList<Config_file_first_kind> GetConfig_file_first_kindBySQL(string sql)
        {
            IList<Config_file_first_kind> config_file_first_kinds = new List<Config_file_first_kind>();

            DataTable dataTable = DBHelper.GetDataTable(sql);

            if(dataTable != null)
            {
                for(int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Config_file_first_kind config_file_first_kind = new Config_file_first_kind();
                    config_file_first_kind.Id = int.Parse(dataTable.Rows[i]["Id"].ToString());
                    config_file_first_kind.First_kind_no = dataTable.Rows[i]["First_kind_no"].ToString();
                    config_file_first_kind.First_kind_name = dataTable.Rows[i]["First_kind_name"].ToString();
                    config_file_first_kind.First_kind_salary_no = dataTable.Rows[i]["First_kind_salary_no"].ToString();
                    config_file_first_kind.First_kind_sale_no = dataTable.Rows[i]["First_kind_sale_no"].ToString();

                    config_file_first_kinds.Add(config_file_first_kind);
                }
                
            }
            return config_file_first_kinds;
        }

        public static IList<Config_file_first_kind> GetAllConfig_file_first_kinds()
        {
            string sql = "select * from Config_file_first_kind";
            return GetConfig_file_first_kindBySQL(sql);
        }

        public static Config_file_first_kind GetConfig_file_first_kindById(int id)
        {
            string sql = "select * from Config_file_first_kind where Id=" + id.ToString();

            try
            {
                return GetConfig_file_first_kindBySQL(sql)[0];
            }
            catch
            {
                return null;
            }
        }

        public static int AddConfig_file_first_kind(Config_file_first_kind config_file_first_kind)
        {
            string sql = string.Format("insert into [Config_file_first_kind] ([First_kind_no], [First_kind_name], [First_kind_salary_no], [First_kind_sale_no]) Values('{0}','{1}','{2}','{3}')",
                config_file_first_kind.First_kind_no, config_file_first_kind.First_kind_name, config_file_first_kind.First_kind_salary_no, config_file_first_kind.First_kind_sale_no);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int ModifyConfig_file_first_kind(Config_file_first_kind config_file_first_kind)
        {
            string sql = string.Format("UPDATE [Config_file_first_kind] SET [First_kind_no] = '{0}',[First_kind_name]='{1}',[First_kind_salary_no] ='{2}', [First_kind_sale_no] = '{3}' WHERE Id={4}",
                config_file_first_kind.First_kind_no, config_file_first_kind.First_kind_name, config_file_first_kind.First_kind_salary_no, config_file_first_kind.First_kind_sale_no, config_file_first_kind.Id);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int DelConfig_file_first_kind(int id)
        {
            string sql = "delete from Config_file_first_kind where Id=" + id.ToString();
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static IList<Config_file_first_kind> GetFirstBranchByCondition(string condition)
        {
            string sql = "select * from Config_file_first_kind where " + condition;
            return GetConfig_file_first_kindBySQL(sql);
        }
    }
}

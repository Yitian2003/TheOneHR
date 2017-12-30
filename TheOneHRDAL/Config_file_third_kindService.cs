using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TheOneHRModels;

namespace TheOneHRDAL
{
    public class Config_file_third_kindService
    {
        private static IList<Config_file_third_kind> GetConfig_file_third_kindBySQL(string sql)
        {
            IList<Config_file_third_kind> config_file_third_kinds = new List<Config_file_third_kind>();

            DataTable dataTable = DBHelper.GetDataTable(sql);

            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Config_file_third_kind config_file_third_kind = new Config_file_third_kind();
                    config_file_third_kind.Id = int.Parse(dataTable.Rows[i]["Id"].ToString());
                    config_file_third_kind.Third_kind_name = dataTable.Rows[i]["Third_kind_name"].ToString();
                    config_file_third_kind.Third_kind_no = dataTable.Rows[i]["Third_kind_no"].ToString();
                    config_file_third_kind.Third_kind_salary_no = dataTable.Rows[i]["Third_kind_salary_no"].ToString();
                    config_file_third_kind.Third_kind_is_retail = dataTable.Rows[i]["Third_kind_is_retail"].ToString();
                    config_file_third_kind.Csk = Config_file_second_kindService.GetConfig_file_second_kindById(int.Parse(dataTable.Rows[i]["Csk_no"].ToString()));

                    config_file_third_kinds.Add(config_file_third_kind);
                }
            }
            return config_file_third_kinds;
        }

        public static IList<Config_file_third_kind> GetAllConfig_file_third_kinds()
        {
            string sql = "select * from Config_file_third_kind";
            return GetConfig_file_third_kindBySQL(sql);
        }

        public static Config_file_third_kind GetConfig_file_third_kindById(int id)
        {
            string sql = "select * from Config_file_third_kind where Id=" + id.ToString();

            try
            {
                return GetConfig_file_third_kindBySQL(sql)[0];
            }
            catch
            {
                return null;
            }
        }

        public static int AddConfig_file_third_kind(Config_file_third_kind ctk)
        {
            string sql = string.Format("insert into [Config_file_third_kind] ([Csk_no], [Third_kind_no],[Third_kind_name],[Third_kind_salary_no],[Third_kind_is_retail]) Values({0},'{1}','{2}','{3}','{4}')",
                ctk.Csk.Id, ctk.Third_kind_no, ctk.Third_kind_name, ctk.Third_kind_salary_no, ctk.Third_kind_is_retail);
            return DBHelper.ExecuteNonQuery(sql);
        }

         public static int ModifyConfig_file_third_kind(Config_file_third_kind ctk)
        {
            string sql = string.Format("UPDATE [Config_file_third_kind] SET [Csk_no]={0}, [Third_kind_no]='{1}', [Third_kind_name]='{2}', [Third_kind_salary_no]='{3}', [Third_kind_is_retail]='{4}' WHERE Id={5}",
                ctk.Csk.Id, ctk.Third_kind_no, ctk.Third_kind_name, ctk.Third_kind_salary_no, ctk.Third_kind_is_retail, ctk.Id);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int DelConfig_file_third_kind(int id)
        {
            string sql = "delete from Config_file_third_kind where Id=" + id.ToString();
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static IList<Config_file_third_kind> GetThirdBranchByCondition(string condition)
        {
            string sql = "select * from Config_file_third_kind where " + condition;
            return GetConfig_file_third_kindBySQL(sql);
        }

        public static IList<Config_file_third_kind> GetConfig_file_third_kindByBranchTwoId(int branch2Id)
        {
            string sql = "select * from Config_file_third_kind where Csk_no=" + branch2Id.ToString();
            return GetConfig_file_third_kindBySQL(sql);
        }
    }
}

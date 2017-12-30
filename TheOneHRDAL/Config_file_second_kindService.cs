using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TheOneHRModels;

namespace TheOneHRDAL
{
    public class Config_file_second_kindService
    {
        private static IList<Config_file_second_kind> GetConfig_file_second_kindBySQL(string sql)
        {
            IList<Config_file_second_kind> config_file_second_kinds = new List<Config_file_second_kind>();

            DataTable dataTable = DBHelper.GetDataTable(sql);

            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Config_file_second_kind config_file_second_kind = new Config_file_second_kind();
                    config_file_second_kind.Id = int.Parse(dataTable.Rows[i]["Id"].ToString());
                    config_file_second_kind.Second_kind_name = dataTable.Rows[i]["Second_kind_name"].ToString();
                    config_file_second_kind.Second_kind_no = dataTable.Rows[i]["Second_kind_no"].ToString();
                    config_file_second_kind.Second_kind_salary_no = dataTable.Rows[i]["Second_kind_salary_no"].ToString();
                    config_file_second_kind.Second_kind_sale_no = dataTable.Rows[i]["Second_kind_sale_no"].ToString();
                    config_file_second_kind.Cfk = Config_file_first_kindService.GetConfig_file_first_kindById(int.Parse(dataTable.Rows[i]["Cfk_no"].ToString()));

                    config_file_second_kinds.Add(config_file_second_kind);
                }
            }
            return config_file_second_kinds;
        }

        public static IList<Config_file_second_kind> GetAllConfig_file_second_kinds()
        {
            string sql = "select * from Config_file_second_kind";
            return GetConfig_file_second_kindBySQL(sql);
        }

        public static Config_file_second_kind GetConfig_file_second_kindById(int id)
        {
            string sql = "select * from Config_file_second_kind where Id=" + id.ToString();

            try
            {
                return GetConfig_file_second_kindBySQL(sql)[0];
            }
            catch
            {
                return null;
            }
        }

        public static int AddConfig_file_second_kind(Config_file_second_kind csk)
        {
            string sql = string.Format("insert into [Config_file_second_kind] ([Cfk_no], [Second_kind_no],[Second_kind_name],[Second_kind_salary_no],[Second_kind_sale_no]) Values({0},'{1}','{2}','{3}','{4}')",
                csk.Cfk.Id, csk.Second_kind_no, csk.Second_kind_name, csk.Second_kind_salary_no, csk.Second_kind_sale_no);
            return DBHelper.ExecuteNonQuery(sql);
        }

         public static int ModifyConfig_file_second_kind(Config_file_second_kind csk)
        {
            string sql = string.Format("UPDATE [Config_file_second_kind] SET [Cfk_no]={0}, [Second_kind_no] = '{1}',[Second_kind_name]='{2}',[Second_kind_salary_no] ='{3}', [Second_kind_sale_no] = '{4}' WHERE Id={5}",
                csk.Cfk.Id, csk.Second_kind_no, csk.Second_kind_name, csk.Second_kind_salary_no, csk.Second_kind_sale_no, csk.Id);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int DelConfig_file_second_kind(int id)
        {
            string sql = "delete from Config_file_second_kind where Id=" + id.ToString();
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static IList<Config_file_second_kind> GetSecondBranchByCondition(string condition)
        {
            string sql = "select * from Config_file_second_kind where " + condition;
            return GetConfig_file_second_kindBySQL(sql);
        }

        public static IList<Config_file_second_kind> GetConfig_file_second_kindByBranchOneId(int branch1Id)
        {
            string sql = "select * from Config_file_second_kind where Cfk_no=" + branch1Id.ToString();
            return GetConfig_file_second_kindBySQL(sql);
        }
    }
}

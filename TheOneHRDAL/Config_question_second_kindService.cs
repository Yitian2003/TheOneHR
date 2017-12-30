using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TheOneHRModels;

namespace TheOneHRDAL
{
    public class Config_question_second_kindService
    {
        private static IList<Config_question_second_kind> GetConfig_question_second_kindBySQL(string sql)
        {
            IList<Config_question_second_kind> kinds = new List<Config_question_second_kind>();

            DataTable dataTable = DBHelper.GetDataTable(sql);

            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Config_question_second_kind kind = new Config_question_second_kind();

                    kind.Second_kind_name = dataTable.Rows[i]["Second_kind_name"].ToString();
                    kind.Second_kind_no = dataTable.Rows[i]["Second_kind_no"].ToString();
                    kind.Id = int.Parse(dataTable.Rows[i]["Id"].ToString());
                    kind.Cqfk_no = Config_question_first_kindService.GetConfig_question_first_kindById(int.Parse(dataTable.Rows[i]["Cqfk_no"].ToString()));

                    kinds.Add(kind);
                }
            }
            return kinds;
        }

        public static IList<Config_question_second_kind> GetAllConfig_question_second_kinds()
        {
            string sql = "select * from Config_question_second_kind";
            return GetConfig_question_second_kindBySQL(sql);
        }

        public static Config_question_second_kind GetConfig_question_second_kindById(int id)
        {
            string sql = "select * from Config_question_second_kind where Id=" + id.ToString();
            try
            {
                return GetConfig_question_second_kindBySQL(sql)[0];
            }
            catch
            {
                return null;
            }
        }

        public static int AddConfig_question_second_kind(Config_question_second_kind kind)
        {
            string sql = string.Format("insert into [Config_question_second_kind] ([Second_kind_no], [Second_kind_name], [Cqfk_no]) Values('{0}','{1}', {2})",
                kind.Second_kind_no, kind.Second_kind_name, kind.Cqfk_no.Id);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int ModifyConfig_question_second_kind(Config_question_second_kind kind)
        {
            string sql = string.Format("UPDATE [Config_question_second_kind] SET [Second_kind_no] = '{0}',[Second_kind_name]='{1}', [Cqfk_no]={2} WHERE Id={3}",
                kind.Second_kind_no, kind.Second_kind_name, kind.Cqfk_no.Id, kind.Id);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int DelConfig_question_second_kind(int id)
        {
            string sql = "delete from Config_question_second_kind where Id=" + id.ToString();
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static IList<Config_question_second_kind> GetConfig_question_second_kindByQ1Id(int q1Id)
        {
            string sql = "select * from Config_question_second_kind where Cqfk_no=" + q1Id.ToString();
            return GetConfig_question_second_kindBySQL(sql);
        }
    }
}

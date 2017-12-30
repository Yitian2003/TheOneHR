using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TheOneHRModels;

namespace TheOneHRDAL
{
    public class Config_question_first_kindService
    {
        private static IList<Config_question_first_kind> GetConfig_question_first_kindBySQL(string sql)
        {
            IList<Config_question_first_kind> kinds = new List<Config_question_first_kind>();

            DataTable dataTable = DBHelper.GetDataTable(sql);

            if(dataTable != null)
            {
                for(int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Config_question_first_kind kind = new Config_question_first_kind();

                    kind.First_kind_name = dataTable.Rows[i]["First_kind_name"].ToString();
                    kind.First_kind_no = dataTable.Rows[i]["First_kind_no"].ToString();
                    kind.Id = int.Parse(dataTable.Rows[i]["Id"].ToString());

                    kinds.Add(kind);
                }
            }
            return kinds;
        }

        public static IList<Config_question_first_kind> GetAllConfig_question_first_kinds()
        {
            string sql = "select * from Config_question_first_kind";
            return GetConfig_question_first_kindBySQL(sql);
        }

        public static Config_question_first_kind GetConfig_question_first_kindById(int id)
        {
            string sql = "select * from Config_question_first_kind where Id=" + id.ToString();
            try
            {
                return GetConfig_question_first_kindBySQL(sql)[0];
            } catch
            {
                return null;
            }
        }

        public static int AddConfig_question_first_kind(Config_question_first_kind kind)
        {
            string sql = string.Format("insert into [Config_question_first_kind] ([First_kind_no], [First_kind_name]) Values('{0}','{1}')",
                kind.First_kind_no, kind.First_kind_name);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int ModifyConfig_question_first_kind(Config_question_first_kind kind)
        {
            string sql = string.Format("UPDATE [Config_question_first_kind] SET [First_kind_no] = '{0}',[First_kind_name]='{1}' WHERE Id={2}",
                kind.First_kind_no, kind.First_kind_name, kind.Id);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int DelConfig_question_first_kind(int id)
        {
            string sql = "delete from Config_question_first_kind where Id=" + id.ToString();
            return DBHelper.ExecuteNonQuery(sql);
        }

      
    }
}

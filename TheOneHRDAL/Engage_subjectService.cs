using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TheOneHRModels;

namespace TheOneHRDAL
{
     public class Engage_subjectService

    {
        private static IList<Engage_subject> GetEngage_subjectBySQL(string sql)
        {
            IList<Engage_subject> subjects = new List<Engage_subject>();

            DataTable dataTable = DBHelper.GetDataTable(sql);

            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Engage_subject subject = new Engage_subject();
                    subject.Id = int.Parse(dataTable.Rows[i]["Id"].ToString());
                    subject.Cqsk_No = Config_question_second_kindService.GetConfig_question_second_kindById(int.Parse(dataTable.Rows[i]["Cqsk_No"].ToString()));
                    subject.Register_users_No = UserInfoService.GetUserById(int.Parse(dataTable.Rows[i]["Register_users_No"].ToString()));
                    subject.Changer_users_No = int.Parse(dataTable.Rows[i]["Changer_users_No"].ToString());
                    
                    subject.Regist_time = string.IsNullOrEmpty(dataTable.Rows[i]["Regist_time"].ToString()) ? (DateTime?)null : DateTime.Parse(dataTable.Rows[i]["Regist_time"].ToString());
                    subject.Change_time = string.IsNullOrEmpty(dataTable.Rows[i]["Change_time"].ToString()) ? (DateTime?)null : DateTime.Parse(dataTable.Rows[i]["Change_time"].ToString());

                    subject.Derivation = dataTable.Rows[i]["Derivation"].ToString();
                    subject.Context = dataTable.Rows[i]["Context"].ToString();
                    subject.Key_a = dataTable.Rows[i]["Key_a"].ToString();
                    subject.Key_b = dataTable.Rows[i]["Key_b"].ToString();
                    subject.Key_c = dataTable.Rows[i]["Key_c"].ToString();
                    subject.Key_d = dataTable.Rows[i]["Key_d"].ToString();
                    subject.Key_e = dataTable.Rows[i]["Key_e"].ToString();
                    subject.Correct_key = dataTable.Rows[i]["Correct_key"].ToString();

                    subjects.Add(subject);
                }
            }
            return subjects;
        }

        public static IList<Engage_subject> GetAllEngage_subjects()
        {
            string sql = "select * from Engage_subject";
            return GetEngage_subjectBySQL(sql);
        }

        public static Engage_subject GetEngage_subjectById(int id)
        {
            string sql = "select * from Engage_subject where Id=" + id.ToString();

            try
            {
                return GetEngage_subjectBySQL(sql)[0];
            }
            catch
            {
                return null;
            }
        }

        public static int AddEngage_subject(Engage_subject subject)
        {
            string sql = string.Format("insert into [Engage_subject] ([Cqsk_No], [Register_users_No],[Changer_users_No],[Regist_time],[Change_time], [Derivation], [Context], [Key_a], [Key_b], [Key_c], [Key_d], [Key_e], [Correct_key]) Values({0},{1},{2},'{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
                subject.Cqsk_No.Id, subject.Register_users_No.Id, subject.Changer_users_No, subject.Regist_time, subject.Change_time, subject.Derivation, subject.Context, subject.Key_a, subject.Key_b, subject.Key_c, subject.Key_d, subject.Key_e, subject.Correct_key);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int ModifyEngage_subject(Engage_subject subject)
        {
            string sql = string.Format("UPDATE [Engage_subject] SET [Cqsk_No]={0}, [Register_users_No]={1},[Changer_users_No]={2},[Regist_time]='{3}',[Change_time]='{4}', [Derivation]='{5}', [Context]='{6}', [Key_a]='{7}', [Key_b]='{8}', [Key_c]='{9}', [Key_d]='{10}', [Key_e]='{11}', [Correct_key]='{12}' WHERE Id={13}",
                subject.Cqsk_No.Id, subject.Register_users_No.Id, subject.Changer_users_No, subject.Regist_time, subject.Change_time, subject.Derivation, subject.Context, subject.Key_a, subject.Key_b, subject.Key_c, subject.Key_d, subject.Key_e, subject.Correct_key, subject.Id);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public static int DelEngage_subject(int id)
        {
            string sql = "delete from Engage_subject where Id=" + id.ToString();
            return DBHelper.ExecuteNonQuery(sql);
        }
        
    }
}

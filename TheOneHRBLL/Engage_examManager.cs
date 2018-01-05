//============================================================
// Producnt name:		BLL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-10-6 2:46:03
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using TheOneHRDAL;
using TheOneHRModels;

namespace TheOneHRBLL
{

    public static partial class Engage_examManager
    {

		
		//override
		public static Engage_exam AddEngage_exam(string Exam_number,int Register_users_no,DateTime Regist_time,int Limite_time,int Emr_no)
		{
			Engage_exam engage_exam = new Engage_exam();

			TransData_AddEngage_exam(Exam_number,Register_users_no,Regist_time,Limite_time,Emr_no,  engage_exam );
            //FK	
			engage_exam.Emr_no = Engage_major_releaseService.GetEngage_major_releaseById(Emr_no); //FK
		
			return Engage_examService.AddEngage_exam(engage_exam);
		}
        public static Engage_exam AddEngage_exam(Engage_exam engage_exam)
        {
            return Engage_examService.AddEngage_exam(engage_exam);
        }

        public static void DeleteEngage_exam(Engage_exam engage_exam)
        {
            Engage_examService.DeleteEngage_exam(engage_exam);
        }

        public static void DeleteEngage_examById(int id)
        {
            Engage_examService.DeleteEngage_examById(id);
        }

		public static void ModifyEngage_exam(Engage_exam engage_exam)
        {
            Engage_examService.ModifyEngage_exam(engage_exam);
        }
		//overload
		public static void ModifyEngage_exam(int Id,string Exam_number,int Register_users_no,DateTime Regist_time,int Limite_time,int Emr_no)
        {
			Engage_exam engage_exam = new Engage_exam();
	        //PK
			engage_exam.Id=Id;
			TransData_ModifyEngage_exam(Id,Exam_number,Register_users_no,Regist_time,Limite_time,Emr_no,engage_exam);
			
            //FK
			engage_exam.Emr_no = Engage_major_releaseService.GetEngage_major_releaseById(Emr_no); //FK
		
			 Engage_examService.ModifyEngage_exam(engage_exam);
		}

        public static IList<Engage_exam> GetAllEngage_exams()
        {
            return Engage_examService.GetAllEngage_exams();
        }

        public static Engage_exam GetEngage_examById(int id)
        {
            return Engage_examService.GetEngage_examById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddEngage_exam(string Exam_number,int Register_users_no,DateTime Regist_time,int Limite_time,int Emr_no, Engage_exam engage_exam )
        {

			try{if (Exam_number.ToString() == "0001-1-1 0:00:00") engage_exam.Exam_number = null; else engage_exam.Exam_number = Exam_number;}catch{}
			try{if (Register_users_no.ToString() == "0001-1-1 0:00:00") engage_exam.Register_users_no = null; else engage_exam.Register_users_no = Register_users_no;}catch{}
			try{if (Regist_time.ToString() == "0001-1-1 0:00:00") engage_exam.Regist_time = null; else engage_exam.Regist_time = Regist_time;}catch{}
			try{if (Limite_time.ToString() == "0001-1-1 0:00:00") engage_exam.Limite_time = null; else engage_exam.Limite_time = Limite_time;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyEngage_exam(int Id,string Exam_number,int Register_users_no,DateTime Regist_time,int Limite_time,int Emr_no, Engage_exam engage_exam)
		{

			try{if (Exam_number.ToString() == "0001-1-1 0:00:00") engage_exam.Exam_number = null; else engage_exam.Exam_number = Exam_number;}catch{}
			try{if (Register_users_no.ToString() == "0001-1-1 0:00:00") engage_exam.Register_users_no = null; else engage_exam.Register_users_no = Register_users_no;}catch{}
			try{if (Regist_time.ToString() == "0001-1-1 0:00:00") engage_exam.Regist_time = null; else engage_exam.Regist_time = Regist_time;}catch{}
			try{if (Limite_time.ToString() == "0001-1-1 0:00:00") engage_exam.Limite_time = null; else engage_exam.Limite_time = Limite_time;}catch{}
		}
		#endregion
    }
}



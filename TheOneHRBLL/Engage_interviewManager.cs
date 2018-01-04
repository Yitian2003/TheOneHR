//============================================================
// Producnt name:		BLL
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2009-10-3 21:06:52
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
using TheOneHRModels;
using TheOneHRDAL;

namespace TheOneHRBLL
{

    public static partial class Engage_interviewManager
    {

		
		//override
		public static Engage_interview AddEngage_interview(int Interview_amount,string Image_degree,string Native_language_degree,string Foreign_language_degree,string Response_speed_degree,string EQ_degree,string IQ_degree,string Multi_quality_degree,int Register_users_no,int Checker_users_no,DateTime Regist_time,DateTime Check_time,string Result,string Interview_comment,string Check_comment,int Check_status,int Er_no)
		{
			Engage_interview engage_interview = new Engage_interview();

			TransData_AddEngage_interview(Interview_amount,Image_degree,Native_language_degree,Foreign_language_degree,Response_speed_degree,EQ_degree,IQ_degree,Multi_quality_degree,Register_users_no,Checker_users_no,Regist_time,Check_time,Result,Interview_comment,Check_comment,Check_status,Er_no,  engage_interview );
            //FK	
			engage_interview.Er_no = Engage_resumeService.GetEngage_resumeById(Er_no); //FK
		
			return Engage_interviewService.AddEngage_interview(engage_interview);
		}
        public static Engage_interview AddEngage_interview(Engage_interview engage_interview)
        {
            return Engage_interviewService.AddEngage_interview(engage_interview);
        }

        public static void DeleteEngage_interview(Engage_interview engage_interview)
        {
            Engage_interviewService.DeleteEngage_interview(engage_interview);
        }

        public static void DeleteEngage_interviewById(int id)
        {
            Engage_interviewService.DeleteEngage_interviewById(id);
        }

		public static void ModifyEngage_interview(Engage_interview engage_interview)
        {
            Engage_interviewService.ModifyEngage_interview(engage_interview);
        }
		//overload
		public static void ModifyEngage_interview(int Id,int Interview_amount,string Image_degree,string Native_language_degree,string Foreign_language_degree,string Response_speed_degree,string EQ_degree,string IQ_degree,string Multi_quality_degree,int Register_users_no,int Checker_users_no,DateTime Regist_time,DateTime Check_time,string Result,string Interview_comment,string Check_comment,int Check_status,int Er_no)
        {
			Engage_interview engage_interview = new Engage_interview();
	        //PK
			engage_interview.Id=Id;
			TransData_ModifyEngage_interview(Id,Interview_amount,Image_degree,Native_language_degree,Foreign_language_degree,Response_speed_degree,EQ_degree,IQ_degree,Multi_quality_degree,Register_users_no,Checker_users_no,Regist_time,Check_time,Result,Interview_comment,Check_comment,Check_status,Er_no,engage_interview);
			
            //FK
			engage_interview.Er_no = Engage_resumeService.GetEngage_resumeById(Er_no); //FK
		
			 Engage_interviewService.ModifyEngage_interview(engage_interview);
		}

        public static IList<Engage_interview> GetAllEngage_interviews()
        {
            return Engage_interviewService.GetAllEngage_interviews();
        }

        public static Engage_interview GetEngage_interviewById(int id)
        {
            return Engage_interviewService.GetEngage_interviewById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddEngage_interview(int Interview_amount,string Image_degree,string Native_language_degree,string Foreign_language_degree,string Response_speed_degree,string EQ_degree,string IQ_degree,string Multi_quality_degree,int Register_users_no,int Checker_users_no,DateTime Regist_time,DateTime Check_time,string Result,string Interview_comment,string Check_comment,int Check_status,int Er_no, Engage_interview engage_interview )
        {

			try{if (Interview_amount.ToString() == "0001-1-1 0:00:00") engage_interview.Interview_amount = null; else engage_interview.Interview_amount = Interview_amount;}catch{}
			try{if (Image_degree.ToString() == "0001-1-1 0:00:00") engage_interview.Image_degree = null; else engage_interview.Image_degree = Image_degree;}catch{}
			try{if (Native_language_degree.ToString() == "0001-1-1 0:00:00") engage_interview.Native_language_degree = null; else engage_interview.Native_language_degree = Native_language_degree;}catch{}
			try{if (Foreign_language_degree.ToString() == "0001-1-1 0:00:00") engage_interview.Foreign_language_degree = null; else engage_interview.Foreign_language_degree = Foreign_language_degree;}catch{}
			try{if (Response_speed_degree.ToString() == "0001-1-1 0:00:00") engage_interview.Response_speed_degree = null; else engage_interview.Response_speed_degree = Response_speed_degree;}catch{}
			try{if (EQ_degree.ToString() == "0001-1-1 0:00:00") engage_interview.EQ_degree = null; else engage_interview.EQ_degree = EQ_degree;}catch{}
			try{if (IQ_degree.ToString() == "0001-1-1 0:00:00") engage_interview.IQ_degree = null; else engage_interview.IQ_degree = IQ_degree;}catch{}
			try{if (Multi_quality_degree.ToString() == "0001-1-1 0:00:00") engage_interview.Multi_quality_degree = null; else engage_interview.Multi_quality_degree = Multi_quality_degree;}catch{}
			try{if (Register_users_no.ToString() == "0001-1-1 0:00:00") engage_interview.Register_users_no = null; else engage_interview.Register_users_no = Register_users_no;}catch{}
			try{if (Checker_users_no.ToString() == "0001-1-1 0:00:00") engage_interview.Checker_users_no = null; else engage_interview.Checker_users_no = Checker_users_no;}catch{}
			try{if (Regist_time.ToString() == "0001-1-1 0:00:00") engage_interview.Regist_time = null; else engage_interview.Regist_time = Regist_time;}catch{}
			try{if (Check_time.ToString() == "0001-1-1 0:00:00") engage_interview.Check_time = null; else engage_interview.Check_time = Check_time;}catch{}
			try{if (Result.ToString() == "0001-1-1 0:00:00") engage_interview.Result = null; else engage_interview.Result = Result;}catch{}
			try{if (Interview_comment.ToString() == "0001-1-1 0:00:00") engage_interview.Interview_comment = null; else engage_interview.Interview_comment = Interview_comment;}catch{}
			try{if (Check_comment.ToString() == "0001-1-1 0:00:00") engage_interview.Check_comment = null; else engage_interview.Check_comment = Check_comment;}catch{}
			try{if (Check_status.ToString() == "0001-1-1 0:00:00") engage_interview.Check_status = null; else engage_interview.Check_status = Check_status;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyEngage_interview(int Id,int Interview_amount,string Image_degree,string Native_language_degree,string Foreign_language_degree,string Response_speed_degree,string EQ_degree,string IQ_degree,string Multi_quality_degree,int Register_users_no,int Checker_users_no,DateTime Regist_time,DateTime Check_time,string Result,string Interview_comment,string Check_comment,int Check_status,int Er_no, Engage_interview engage_interview)
		{

			try{if (Interview_amount.ToString() == "0001-1-1 0:00:00") engage_interview.Interview_amount = null; else engage_interview.Interview_amount = Interview_amount;}catch{}
			try{if (Image_degree.ToString() == "0001-1-1 0:00:00") engage_interview.Image_degree = null; else engage_interview.Image_degree = Image_degree;}catch{}
			try{if (Native_language_degree.ToString() == "0001-1-1 0:00:00") engage_interview.Native_language_degree = null; else engage_interview.Native_language_degree = Native_language_degree;}catch{}
			try{if (Foreign_language_degree.ToString() == "0001-1-1 0:00:00") engage_interview.Foreign_language_degree = null; else engage_interview.Foreign_language_degree = Foreign_language_degree;}catch{}
			try{if (Response_speed_degree.ToString() == "0001-1-1 0:00:00") engage_interview.Response_speed_degree = null; else engage_interview.Response_speed_degree = Response_speed_degree;}catch{}
			try{if (EQ_degree.ToString() == "0001-1-1 0:00:00") engage_interview.EQ_degree = null; else engage_interview.EQ_degree = EQ_degree;}catch{}
			try{if (IQ_degree.ToString() == "0001-1-1 0:00:00") engage_interview.IQ_degree = null; else engage_interview.IQ_degree = IQ_degree;}catch{}
			try{if (Multi_quality_degree.ToString() == "0001-1-1 0:00:00") engage_interview.Multi_quality_degree = null; else engage_interview.Multi_quality_degree = Multi_quality_degree;}catch{}
			try{if (Register_users_no.ToString() == "0001-1-1 0:00:00") engage_interview.Register_users_no = null; else engage_interview.Register_users_no = Register_users_no;}catch{}
			try{if (Checker_users_no.ToString() == "0001-1-1 0:00:00") engage_interview.Checker_users_no = null; else engage_interview.Checker_users_no = Checker_users_no;}catch{}
			try{if (Regist_time.ToString() == "0001-1-1 0:00:00") engage_interview.Regist_time = null; else engage_interview.Regist_time = Regist_time;}catch{}
			try{if (Check_time.ToString() == "0001-1-1 0:00:00") engage_interview.Check_time = null; else engage_interview.Check_time = Check_time;}catch{}
			try{if (Result.ToString() == "0001-1-1 0:00:00") engage_interview.Result = null; else engage_interview.Result = Result;}catch{}
			try{if (Interview_comment.ToString() == "0001-1-1 0:00:00") engage_interview.Interview_comment = null; else engage_interview.Interview_comment = Interview_comment;}catch{}
			try{if (Check_comment.ToString() == "0001-1-1 0:00:00") engage_interview.Check_comment = null; else engage_interview.Check_comment = Check_comment;}catch{}
			try{if (Check_status.ToString() == "0001-1-1 0:00:00") engage_interview.Check_status = null; else engage_interview.Check_status = Check_status;}catch{}
		}
		#endregion
    }
}



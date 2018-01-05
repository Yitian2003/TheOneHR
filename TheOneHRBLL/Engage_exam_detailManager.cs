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

    public static partial class Engage_exam_detailManager
    {

		
		//override
		public static Engage_exam_detail AddEngage_exam_detail(int Question_amount,int Cqsk_no,int Ee_no)
		{
			Engage_exam_detail engage_exam_detail = new Engage_exam_detail();

			TransData_AddEngage_exam_detail(Question_amount,Cqsk_no,Ee_no,  engage_exam_detail );
            //FK	
			engage_exam_detail.Cqsk_no = Config_question_second_kindService.GetConfig_question_second_kindById(Cqsk_no); //FK
			engage_exam_detail.Ee_no = Engage_examService.GetEngage_examById(Ee_no); //FK
		
			return Engage_exam_detailService.AddEngage_exam_detail(engage_exam_detail);
		}
        public static Engage_exam_detail AddEngage_exam_detail(Engage_exam_detail engage_exam_detail)
        {
            return Engage_exam_detailService.AddEngage_exam_detail(engage_exam_detail);
        }

        public static void DeleteEngage_exam_detail(Engage_exam_detail engage_exam_detail)
        {
            Engage_exam_detailService.DeleteEngage_exam_detail(engage_exam_detail);
        }

        public static void DeleteEngage_exam_detailById(int id)
        {
            Engage_exam_detailService.DeleteEngage_exam_detailById(id);
        }

		public static void ModifyEngage_exam_detail(Engage_exam_detail engage_exam_detail)
        {
            Engage_exam_detailService.ModifyEngage_exam_detail(engage_exam_detail);
        }
		//overload
		public static void ModifyEngage_exam_detail(int Id,int Question_amount,int Cqsk_no,int Ee_no)
        {
			Engage_exam_detail engage_exam_detail = new Engage_exam_detail();
	        //PK
			engage_exam_detail.Id=Id;
			TransData_ModifyEngage_exam_detail(Id,Question_amount,Cqsk_no,Ee_no,engage_exam_detail);
			
            //FK
			engage_exam_detail.Cqsk_no = Config_question_second_kindService.GetConfig_question_second_kindById(Cqsk_no); //FK
			engage_exam_detail.Ee_no = Engage_examService.GetEngage_examById(Ee_no); //FK
		
			 Engage_exam_detailService.ModifyEngage_exam_detail(engage_exam_detail);
		}

        public static IList<Engage_exam_detail> GetAllEngage_exam_details()
        {
            return Engage_exam_detailService.GetAllEngage_exam_details();
        }

        public static Engage_exam_detail GetEngage_exam_detailById(int id)
        {
            return Engage_exam_detailService.GetEngage_exam_detailById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddEngage_exam_detail(int Question_amount,int Cqsk_no,int Ee_no, Engage_exam_detail engage_exam_detail )
        {

			try{if (Question_amount.ToString() == "0001-1-1 0:00:00") engage_exam_detail.Question_amount = null; else engage_exam_detail.Question_amount = Question_amount;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyEngage_exam_detail(int Id,int Question_amount,int Cqsk_no,int Ee_no, Engage_exam_detail engage_exam_detail)
		{

			try{if (Question_amount.ToString() == "0001-1-1 0:00:00") engage_exam_detail.Question_amount = null; else engage_exam_detail.Question_amount = Question_amount;}catch{}
		}
		#endregion
    }
}



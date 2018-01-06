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

    public static partial class Engage_answer_detailManager
    {

		
		//override
		public static Engage_answer_detail AddEngage_answer_detail(string Answer_details_number,string Answer,int Ea_no,int Es_no)
		{
			Engage_answer_detail engage_answer_detail = new Engage_answer_detail();

			TransData_AddEngage_answer_detail(Answer_details_number,Answer,Ea_no,Es_no,  engage_answer_detail );
            //FK	
			engage_answer_detail.Ea_no = Engage_answerService.GetEngage_answerById(Ea_no); //FK
			engage_answer_detail.Es_no = Engage_subjectService.GetEngage_subjectById(Es_no); //FK
		
			return Engage_answer_detailService.AddEngage_answer_detail(engage_answer_detail);
		}
        public static Engage_answer_detail AddEngage_answer_detail(Engage_answer_detail engage_answer_detail)
        {
            return Engage_answer_detailService.AddEngage_answer_detail(engage_answer_detail);
        }

        public static void DeleteEngage_answer_detail(Engage_answer_detail engage_answer_detail)
        {
            Engage_answer_detailService.DeleteEngage_answer_detail(engage_answer_detail);
        }

        public static void DeleteEngage_answer_detailById(int id)
        {
            Engage_answer_detailService.DeleteEngage_answer_detailById(id);
        }

		public static void ModifyEngage_answer_detail(Engage_answer_detail engage_answer_detail)
        {
            Engage_answer_detailService.ModifyEngage_answer_detail(engage_answer_detail);
        }
		//overload
		public static void ModifyEngage_answer_detail(int Id,string Answer_details_number,string Answer,int Ea_no,int Es_no)
        {
			Engage_answer_detail engage_answer_detail = new Engage_answer_detail();
	        //PK
			engage_answer_detail.Id=Id;
			TransData_ModifyEngage_answer_detail(Id,Answer_details_number,Answer,Ea_no,Es_no,engage_answer_detail);
			
            //FK
			engage_answer_detail.Ea_no = Engage_answerService.GetEngage_answerById(Ea_no); //FK
			engage_answer_detail.Es_no = Engage_subjectService.GetEngage_subjectById(Es_no); //FK
		
			 Engage_answer_detailService.ModifyEngage_answer_detail(engage_answer_detail);
		}

        public static IList<Engage_answer_detail> GetAllEngage_answer_details()
        {
            return Engage_answer_detailService.GetAllEngage_answer_details();
        }

        public static Engage_answer_detail GetEngage_answer_detailById(int id)
        {
            return Engage_answer_detailService.GetEngage_answer_detailById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddEngage_answer_detail(string Answer_details_number,string Answer,int Ea_no,int Es_no, Engage_answer_detail engage_answer_detail )
        {

			try{if (Answer_details_number.ToString() == "0001-1-1 0:00:00") engage_answer_detail.Answer_details_number = null; else engage_answer_detail.Answer_details_number = Answer_details_number;}catch{}
			try{if (Answer.ToString() == "0001-1-1 0:00:00") engage_answer_detail.Answer = null; else engage_answer_detail.Answer = Answer;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyEngage_answer_detail(int Id,string Answer_details_number,string Answer,int Ea_no,int Es_no, Engage_answer_detail engage_answer_detail)
		{

			try{if (Answer_details_number.ToString() == "0001-1-1 0:00:00") engage_answer_detail.Answer_details_number = null; else engage_answer_detail.Answer_details_number = Answer_details_number;}catch{}
			try{if (Answer.ToString() == "0001-1-1 0:00:00") engage_answer_detail.Answer = null; else engage_answer_detail.Answer = Answer;}catch{}
		}
		#endregion
    }
}



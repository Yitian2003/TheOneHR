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

    public static partial class Engage_answerManager
    {

		
		//override
		public static Engage_answer AddEngage_answer(string Answer_number,int Use_time,decimal Total_point,int Ee_no,int Er_no)
		{
			Engage_answer engage_answer = new Engage_answer();

			TransData_AddEngage_answer(Answer_number,Use_time,Total_point,Ee_no,Er_no,  engage_answer );
            //FK	
			engage_answer.Ee_no = Engage_examService.GetEngage_examById(Ee_no); //FK
			engage_answer.Er_no = Engage_resumeService.GetEngage_resumeById(Er_no); //FK
		
			return Engage_answerService.AddEngage_answer(engage_answer);
		}
        public static Engage_answer AddEngage_answer(Engage_answer engage_answer)
        {
            return Engage_answerService.AddEngage_answer(engage_answer);
        }

        public static void DeleteEngage_answer(Engage_answer engage_answer)
        {
            Engage_answerService.DeleteEngage_answer(engage_answer);
        }

        public static void DeleteEngage_answerById(int id)
        {
            Engage_answerService.DeleteEngage_answerById(id);
        }

		public static void ModifyEngage_answer(Engage_answer engage_answer)
        {
            Engage_answerService.ModifyEngage_answer(engage_answer);
        }
		//overload
		public static void ModifyEngage_answer(int Id,string Answer_number,int Use_time,decimal Total_point,int Ee_no,int Er_no)
        {
			Engage_answer engage_answer = new Engage_answer();
	        //PK
			engage_answer.Id=Id;
			TransData_ModifyEngage_answer(Id,Answer_number,Use_time,Total_point,Ee_no,Er_no,engage_answer);
			
            //FK
			engage_answer.Ee_no = Engage_examService.GetEngage_examById(Ee_no); //FK
			engage_answer.Er_no = Engage_resumeService.GetEngage_resumeById(Er_no); //FK
		
			 Engage_answerService.ModifyEngage_answer(engage_answer);
		}

        public static IList<Engage_answer> GetAllEngage_answers()
        {
            return Engage_answerService.GetAllEngage_answers();
        }

        public static Engage_answer GetEngage_answerById(int id)
        {
            return Engage_answerService.GetEngage_answerById(id);
        }

		#region private Method
		//Trans Add Method 
		private static void TransData_AddEngage_answer(string Answer_number,int Use_time,decimal Total_point,int Ee_no,int Er_no, Engage_answer engage_answer )
        {

			try{if (Answer_number.ToString() == "0001-1-1 0:00:00") engage_answer.Answer_number = null; else engage_answer.Answer_number = Answer_number;}catch{}
			try{if (Use_time.ToString() == "0001-1-1 0:00:00") engage_answer.Use_time = null; else engage_answer.Use_time = Use_time;}catch{}
			try{if (Total_point.ToString() == "0001-1-1 0:00:00") engage_answer.Total_point = null; else engage_answer.Total_point = Total_point;}catch{}
        }
		//Trans Modify Method
		private static void TransData_ModifyEngage_answer(int Id,string Answer_number,int Use_time,decimal Total_point,int Ee_no,int Er_no, Engage_answer engage_answer)
		{

			try{if (Answer_number.ToString() == "0001-1-1 0:00:00") engage_answer.Answer_number = null; else engage_answer.Answer_number = Answer_number;}catch{}
			try{if (Use_time.ToString() == "0001-1-1 0:00:00") engage_answer.Use_time = null; else engage_answer.Use_time = Use_time;}catch{}
			try{if (Total_point.ToString() == "0001-1-1 0:00:00") engage_answer.Total_point = null; else engage_answer.Total_point = Total_point;}catch{}
		}
		#endregion
    }
}



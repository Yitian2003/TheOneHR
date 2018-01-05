using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheOneHRBLL;
using TheOneHRModels;

public partial class main_jobManager_InterviewManager_interviewReg : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if(Request["resumeid"] != null)
            {
                int resumeId = int.Parse(RequestString("resumeid"));
                Engage_resume resume = Engage_resumeManager.GetEngage_resumeById(resumeId);

                if(resume != null)
                {
                    lblMajor.Text = resume.Emr_no.Cm.Major_name;
                    lblJobType.Text = resume.Engage_type;
                    lblName.Text = resume.Human_name;
                    lblregine.Text = resume.Cr_no.Religion_name;
                    lblspecial.Text = resume.Cs_no.Speciality_name;
                    lblRegTime.Text = DateTime.Parse(resume.Regist_time.ToString()).ToShortDateString();
                    lblSuggest.Text = resume.Recomandation;
                    lblInterviewer.Text = CurrentUser.User_name;
                    lblInterviewTime.Text = DateTime.Now.ToShortDateString();
                    try { 
                        lblChecker.Text = UserInfoManager.GetUserById(int.Parse(resume.Checker_users_no.ToString())).User_name;
                    }
                    catch
                    {
                        //lblChecker.Text = "";
                    }

                    if(resume.Check_time != null)
                    {
                        lblCheckTime.Text = DateTime.Parse(resume.Check_time.ToString()).ToShortDateString();
                    }
                    else
                    {
                        lblCheckTime.Text = "";
                    }
                    
                    
                }
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        int resumeId = int.Parse(RequestString("resumeid"));
        Engage_resume resume = Engage_resumeManager.GetEngage_resumeById(resumeId);

        if(resume != null)
        {
            resume.Interview_status = 9;
            
        }

        try
        {
            Engage_resumeManager.ModifyEngage_resume(resume);
            Engage_interview interview = new Engage_interview();
            interview.Interview_amount += 1;
            interview.Image_degree = ddlimage_degree.SelectedValue;
            interview.Native_language_degree = ddlanguage_degree.SelectedValue;
            interview.Foreign_language_degree = ddlforeign_language_degree.SelectedValue;
            interview.Response_speed_degree = ddlresponse_speed_degree.SelectedValue;
            interview.EQ_degree = ddlEQ.SelectedValue;
            interview.IQ_degree = ddlIQ.SelectedValue;
            interview.Multi_quality_degree = ddlmulti_quality.SelectedValue;
            interview.Interview_comment = txtSuggest.Value;

            interview.Er_no = resume;
            interview.Check_status = 2;

            Engage_interviewManager.AddEngage_interview(interview);

            Response.Redirect("interviewList.aspx");
        }
        catch(Exception ex)
        {
            Alert(ex.Message);
        }
    }
}
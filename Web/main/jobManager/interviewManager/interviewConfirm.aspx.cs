using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheOneHRBLL;
using TheOneHRModels;

public partial class main_jobManager_interviewManager_interviewConfirm : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if(Request["interviewId"] != null)
            {
                int id = int.Parse(RequestString("interviewId"));
                Engage_interview interview = Engage_interviewManager.GetEngage_interviewById(id);
                int resumeId = interview.Er_no.Id;
                Engage_resume resume = Engage_resumeManager.GetEngage_resumeById(resumeId);

                lblMajor.Text = resume.Emr_no.Cm.Major_name;
                lblJobType.Text = resume.Engage_type;
                lblName.Text = resume.Human_name;
                lblReligion.Text = resume.Cr_no.Religion_name;
                lblSpecial.Text = resume.Cs_no.Speciality_name;
                try
                {
                    lblRegistTime.Text = DateTime.Parse(resume.Regist_time.ToString()).ToShortDateString();
                }
                catch (Exception ex)
                {

                }

                try
                {
                    lblInterviewCount.Text = interview.Interview_amount.ToString();
                }
                catch { }

                lblImageDegree.Text = interview.Image_degree;
                lblNativeLan.Text = interview.Native_language_degree;
                lblForeignLan.Text = interview.Foreign_language_degree;
                lblResponse.Text = interview.Response_speed_degree;
                lblMulti.Text = interview.Multi_quality_degree;
                lblInterviewer.Text = CurrentUser.User_name;
                lblInterviewTime.Text = DateTime.Now.ToShortDateString();
                lblEq.Text = interview.EQ_degree;
                lblIq.Text = interview.IQ_degree;

                try
                {
                    lblChecker.Text = UserInfoManager.GetUserById(int.Parse(interview.Checker_users_no.ToString())).User_name;
                    lblCheckTime.Text = DateTime.Parse(resume.Check_time.ToString()).ToShortDateString();
                }
                catch
                {
                    
                }
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        int id = int.Parse(RequestString("interviewId"));
        Engage_interview interview = Engage_interviewManager.GetEngage_interviewById(id);
        int resumeId = interview.Er_no.Id;
        Engage_resume resume = Engage_resumeManager.GetEngage_resumeById(resumeId);

        if(rdSuggest.SelectedIndex == 3)
        {
            try
            {
                Engage_interviewManager.DeleteEngage_interviewById(id);
                Engage_resumeManager.DeleteEngage_resumeById(resumeId);
                
                Response.Redirect("interviewList.aspx");
            }
            catch(Exception ex)
            {
                Alert(ex.Message);
            }
        }
        else
        {
            if(resume != null)
            {
                resume.Interview_status = int.Parse(rdSuggest.SelectedValue);
            }
            try
            {
                Engage_resumeManager.ModifyEngage_resume(resume);
                //interview.Check_status = int.Parse(rdSuggest.SelectedValue);
                interview.Check_status = 0; // 0: 已审核 1：未审核
                Engage_interviewManager.ModifyEngage_interview(interview);
                Response.Redirect("interviewList.aspx");
            } catch (Exception ex)
            {
                Alert(ex.Message);
            }
        }
    }
}
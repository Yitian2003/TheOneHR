using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using TheOneHRBLL;
using TheOneHRModels;

public partial class main_jobManager_resumeManager_resumeConfirm : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request["resumeid"] != null)
            {
                int resumeId = int.Parse(this.RequestString("resumeid"));
                Engage_resume resume = Engage_resumeManager.GetEngage_resumeById(resumeId);
                if (resume != null)
                {
                    //职位名称
                    lblMajor.Text = resume.Emr_no.Cm.Major_name;
                    //招聘类型 
                    lblJobType.Text = resume.Engage_type;
                    //简历名称
                    lblName.Text = resume.Human_name;
                    //所属国家
                    lblCoun.Text = resume.Cc_no.Country_name;
                    //宗教信仰
                    lblregine.Text = resume.Cr_no.Religion_name;
                    //专业
                    lblspecial.Text = resume.Cs_no.Speciality_name;
                    //学历
                    lbleducation.Text = resume.Ced_no.Educated_degree_name;
                    //简历登记时间
                    lblRegTime.Text = DateTime.Parse(resume.Regist_time.ToString()).ToShortDateString();
                    //简历的筛选时间
                    lblConfirmTime.Text = DateTime.Now.ToShortDateString();

                }
            }
        }
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Request["resumeid"] != null)
        {
            int resumeId = int.Parse(RequestString("resumeid"));

            Engage_resume resume = Engage_resumeManager.GetEngage_resumeById(resumeId);

            if (resume != null && rdOK.Checked)
            {
                resume.Recomandation = txtSuggest.Value.Trim();
                resume.Check_time = DateTime.Now;
                resume.Checker_users_no = CurrentUser.Id;
                resume.Interview_status = 1;

                try
                {
                    Engage_resumeManager.ModifyEngage_resume(resume);
                    Response.Redirect("resumeSearch.aspx");
                }
                catch (Exception ex)
                {
                    Alert(ex.Message);
                }
            }
            else if (rdNo.Checked)
            {
                try
                {
                    Engage_resumeManager.DeleteEngage_resumeById(resumeId);
                    Response.Redirect("resumeSearch.aspx");
                }
                catch
                {
                    Alert("修改失败");
                }


            }
        }
    }
}

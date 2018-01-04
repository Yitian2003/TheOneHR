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
using TheOneHRModels;
using TheOneHRBLL;

public partial class main_jobManager_resumeManager_ResumeRister : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["postid"] != null)
        {
            ddlMajor.SelectedValue = this.RequestString("postid");
            ddlMajor.Enabled = false;
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        Engage_resume resume = new Engage_resume();
        Engage_major_release major = Engage_major_releaseManager.GetEngage_major_releaseByPostId(int.Parse(ddlMajor.SelectedValue));
        resume.Emr_no = major; //职位
        resume.Engage_type = ddlRequestType.SelectedValue; //招聘类型
        resume.Human_name = txtResumeName.Value; //姓名
        //国籍
        resume.Cc_no = Config_countryManager.GetConfig_countryById(int.Parse(ddlCountry.SelectedValue));
        //学历
        resume.Ced_no = Config_educated_degreeManager.GetConfig_educated_degreeById(int.Parse(ddlCountry.SelectedValue));
        //宗教信仰
        resume.Cr_no = Config_religionManager.GetConfig_religionById(int.Parse(ddlReligion.SelectedValue));
        //民族
        resume.Cn_no = Config_nationManager.GetConfig_nationById(int.Parse(ddlNation.SelectedValue));
        //年龄
        resume.Human_age = int.Parse(txtArchiveAge.Value);
        //特长
        resume.Cg_no = Config_goodatManager.GetConfig_goodatById(int.Parse(ddlGoodat.SelectedValue ));
        //专业
        resume.Cs_no = Config_specialityManager.GetConfig_specialityById(int.Parse(ddlSpeciality.SelectedValue));
        if (fnPhoto.FileName.Trim()!="")
        {
            resume.Human_picture = "/images/photo/" + DateTime.Now.ToString("yyyymmddhhmmss") + ".jpg";   
        }

        resume.Check_status = 0;
        resume.Regist_time = DateTime.Now;
        resume.Register_users_no = this.CurrentUser.Id;
        resume.Interview_amount = 0;//面试的次数
        resume.Interview_status = -2; //简历初审
        resume.Test_amount = 0; //考试次数
        try
        {
            Engage_resumeManager.AddEngage_resume(resume);
            if (resume.Human_picture != "")
            {
                fnPhoto.SaveAs(resume.Human_picture);
            }
            Response.Redirect("resumeSearch.aspx");
        }
        catch
        {
            this.Alert("简历登记失败!");
        }

    }
}

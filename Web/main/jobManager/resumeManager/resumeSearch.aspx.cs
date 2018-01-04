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

public partial class main_jobManager_resumeManager_resumeSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        odsResume.SelectParameters["majorid"].DefaultValue = ddlMajor.SelectedValue;
        odsResume.SelectParameters[1].DefaultValue = ddlintreviewStatus.SelectedValue;
        odsResume.SelectParameters[2].DefaultValue = txtKey.Text;
        odsResume.SelectParameters[3].DefaultValue = beginTime.Value;
        odsResume.SelectParameters[4].DefaultValue = endTime.Value;

        odsResume.Select();
        gvResume.DataBind();
       // IList<Models.Engage_resume> resumes = BLL.Engage_resumeManager.ResumeAdvSearch();
    }

    public string GetResumStatus(object resumtstatusid)
    {
        string result = "";
        int id = int.Parse(resumtstatusid.ToString());
        switch (id)
        {
            case -2: result = "简历初审";
                break;
            case 1: result = "面试登记";
                break;
            case 2: result = "待笔试";
                break;
            case 9: result = "面试待审";
                break;
            case 5: result = "笔试待审";
                break;
            case 3: result = "推荐录用";
                break;
            case 4: result = "录用申请";
                break;
            case 6: result = "已录用";
                break;
            case 7: result = "未录用";
                break;
            case 8: result = "待清除";
                break;
            case 10: result = "已登记";
                break;
        }

        return result;
    }
    protected void gvResume_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            LinkButton linkModify = e.Row.FindControl("linkModify") as LinkButton;
            if (linkModify != null)
            {
                if (linkModify.Text != "简历初审")
                {
                    linkModify.OnClientClick = "return false";
                }
            }
        }
    }
    protected void linkModify_Command(object sender, CommandEventArgs e)
    {
        
        string id = e.CommandArgument.ToString();
        string resumeStatus = (sender as LinkButton).Text;
        if (resumeStatus == "简历初审")
        {
            Response.Redirect("/main/jobManager/resumeManager/resumeConfirm.aspx?resumeid=" + id);
        }
        else if (resumeStatus == "面试登记")
        {
            Response.Redirect("/main/jobManager/interviewManager/interviewReg.aspx?resumeid="+id);
        }

    }
}

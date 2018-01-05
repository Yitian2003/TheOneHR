using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheOneHRBLL;
using TheOneHRModels;

public partial class main_jobManager_interviewManager_interviewList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            for(int i = -2; i < 10; i++)
            {
                string result = GetResumStatus(i);
                if (!string.IsNullOrEmpty(result))
                {
                    ddlInterviewStatus.Items.Add(new ListItem(result, i.ToString()));
                }
            }
        }
    }

    private string GetResumStatus(object resumtstatusid)
    {
        string result = "";
        int id = int.Parse(resumtstatusid.ToString());
        switch (id)
        {
            case -2:
                result = "简历初审";
                break;
            case 1:
                result = "面试登记";
                break;
            case 2:
                result = "待笔试";
                break;
            case 9:
                result = "面试待审";
                break;
            case 5:
                result = "笔试待审";
                break;
            case 3:
                result = "推荐录用";
                break;
            case 4:
                result = "录用申请";
                break;
            case 6:
                result = "已录用";
                break;
            case 7:
                result = "未录用";
                break;
            case 8:
                result = "待清除";
                break;
            case 10:
                result = "已登记";
                break;
        }

        return result;
    }

    protected void ddlMajorKind_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = int.Parse(ddlMajorKind.SelectedValue);
        ddlMajor.Items.Clear();
        ddlMajor.Items.Add(new ListItem("Choose...", "-1"));
        if(id != -1)
        {
            IList<Config_major> majors = Config_majorManager.GetConfig_majorByKind(id);
            foreach(Config_major major in majors)
            {
                ListItem item = new ListItem();
                item.Text = major.Major_name;
                item.Value = major.Id.ToString();
                ddlMajor.Items.Add(item);
            }
        }
    }

    protected void LinkConfirm_Command(object sender, CommandEventArgs e)
    {
        string interviewId = e.CommandArgument.ToString();
        Response.Redirect("interviewConfirm.aspx?interviewId=" + interviewId);
    }

    protected void gvInterview_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            int id = int.Parse(e.Row.Cells[0].Text);
            Engage_interview intervew = Engage_interviewManager.GetEngage_interviewById(id);

            int checkStatus = (int)intervew.Check_status;
            LinkButton linkConfirm = e.Row.FindControl("linkConfirm") as LinkButton;

            if(linkConfirm != null)
            {
                if(checkStatus != 1)
                {
                    linkConfirm.OnClientClick = "return false";
                    linkConfirm.Text = "已审核";
                }
                
            }
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        odsInterview.SelectParameters[0].DefaultValue = ddlMajor.SelectedValue;
        odsInterview.SelectParameters[1].DefaultValue = ddlInterviewStatus.SelectedValue;
        odsInterview.SelectParameters[2].DefaultValue = txtKey.Text.Trim();
        odsInterview.SelectParameters[3].DefaultValue = beginTime.Value;
        odsInterview.SelectParameters[4].DefaultValue = endTime.Value;

        odsInterview.Select();
        gvInterview.DataBind();
    }
}
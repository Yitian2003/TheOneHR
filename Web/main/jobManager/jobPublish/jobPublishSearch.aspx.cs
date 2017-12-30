using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main_jobManager_jobPublishSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void linkReqJob_Command(object sender, CommandEventArgs e)
    {
        int id = int.Parse(e.CommandArgument.ToString());
        Response.Redirect("xxx.aspx?id=" + id);
    }

    protected void gvJobList_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            DateTime endTime;
            if(DateTime.TryParse(e.Row.Cells[5].Text, out endTime))
            {
                DateTime currentTime = DateTime.Now;

                if (currentTime > endTime && endTime != null)
                {
                    LinkButton linkReqJob = e.Row.FindControl("linkReqJob") as LinkButton;

                    if (linkReqJob != null)
                    {
                        linkReqJob.Text = "职位已过期";
                        linkReqJob.OnClientClick = " return false;";
                    }
                }
            }
            
            
        }
    }
}
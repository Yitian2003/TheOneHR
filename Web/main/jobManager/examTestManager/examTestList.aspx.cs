using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main_jobManager_examTestManager_examTestList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void gvExam_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[0].Text = (e.Row.RowIndex + 1).ToString();
        }
    }

    protected void linkGo_Command(object sender, CommandEventArgs e)
    {
        string emrNo = e.CommandArgument.ToString();
        Response.Redirect("examTestBuild.aspx?emrNo=" + emrNo);
    }
}
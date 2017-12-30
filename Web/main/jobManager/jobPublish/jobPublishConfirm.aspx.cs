using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheOneHRModels;
using TheOneHRBLL;

public partial class main_jobManager_jobPublish_jobPublishConfirm : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("jobPublishReg.aspx");
    }

    protected void linkDel_Command(object sender, CommandEventArgs e)
    {
        int id = int.Parse(e.CommandArgument.ToString());

        try
        {
            Engage_major_releaseManager.DelEngage_major_release(id);
            gvJobList.DataBind();
        }
        catch
        {
            Alert("删除失败");
        }
        
    }

    protected void linkEdit_Command(object sender, CommandEventArgs e)
    {
        string id = e.CommandArgument.ToString();
        Response.Redirect("jobPublishChange.aspx?id=" + id);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main_branchManager_delThirdBranch : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["id"] != null)
        {
            int id = int.Parse(Request["id"].ToString());
            try
            {
                TheOneHRBLL.Config_file_third_kindManager.DelConfig_file_third_kind(id);
            }
            catch
            {
                this.Alert("删除机构失败");
                //this.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('删除机构失败')");
            }
            Response.Redirect("threeBranchManager.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main_branchManager_delTwo : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["Id"] != null)
        {
            int id = int.Parse(Request["Id"].ToString());

            try
            {
                TheOneHRBLL.Config_file_second_kindManager.DelConfig_file_second_kind(id);

            } catch
            {
                //this.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('删除机构失败')", true);
                Alert("删除机构失败");
            }

            Response.Redirect("twoBranchManager.aspx");
        }
    }
}
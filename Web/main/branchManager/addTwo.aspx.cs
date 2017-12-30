using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main_branchManager_addTwo : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        TheOneHRModels.Config_file_second_kind kind = new TheOneHRModels.Config_file_second_kind();
        kind.Second_kind_name = txtBranchName.Value.Trim();
        kind.Cfk = TheOneHRBLL.Config_file_first_kindManager.GetConfig_file_first_kindById(int.Parse(ddlBranch11.SelectedValue));

        try
        {
            TheOneHRBLL.Config_file_second_kindManager.AddConfig_file_second_kind(kind);
            Response.Redirect("twoBranchManager.aspx");
        } catch
        {
            //this.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('添加机构失败')", true);
            Alert("添加机构失败");
        }
    }
}
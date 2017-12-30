using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main_branchManager_addOne : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtBranchName.Value))
        {
            TheOneHRModels.Config_file_first_kind kind = new TheOneHRModels.Config_file_first_kind();
            kind.First_kind_name = txtBranchName.Value.Trim();

            try
            {
                TheOneHRBLL.Config_file_first_kindManager.AddConfig_file_first_kind(kind);
                Response.Redirect("oneBranchManager.aspx");
            }
            catch
            {
                ClientScript.RegisterStartupScript(GetType(), null, "(alert'(添加机构失败')", true);
            }
        }
    }
}
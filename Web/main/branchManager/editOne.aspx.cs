using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main_branchManager_editOne : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack && Request["Id"] != null)
        {
            int id = int.Parse(Request["Id"].ToString());
            TheOneHRModels.Config_file_first_kind kind = TheOneHRBLL.Config_file_first_kindManager.GetConfig_file_first_kindById(id);
            txtBranchName.Value = kind.First_kind_name;
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request["Id"].ToString());
        TheOneHRModels.Config_file_first_kind kind = TheOneHRBLL.Config_file_first_kindManager.GetConfig_file_first_kindById(id);

        if (!string.IsNullOrEmpty(txtBranchName.Value.Trim()))
        {
            if(kind != null)
            {
                kind.First_kind_name = txtBranchName.Value.Trim();

                try
                {
                    TheOneHRBLL.Config_file_first_kindManager.ModifyConfig_file_first_kind(kind);

                    Response.Redirect("oneBranchManager.aspx");
                }
                catch
                {
                    ClientScript.RegisterStartupScript(GetType(), null, "alert('编辑机构失败')", true);
                }
                
            }
        }
    }
}
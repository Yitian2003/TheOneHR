using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main_branchManager_editTwo : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if(Request["Id"] != null)
            {
                int id = int.Parse(Request["Id"].ToString());
                TheOneHRModels.Config_file_second_kind kind = TheOneHRBLL.Config_file_second_kindManager.GetConfig_file_second_kindById(id);
                txtBranchName.Value = kind.Second_kind_name;
            }
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request["Id"].ToString());
        TheOneHRModels.Config_file_second_kind kind = TheOneHRBLL.Config_file_second_kindManager.GetConfig_file_second_kindById(id);

        if (kind != null)
        {
            kind.Second_kind_name = txtBranchName.Value.Trim();

            try
            {
                TheOneHRBLL.Config_file_second_kindManager.ModifyConfig_file_second_kind(kind);
                Response.Redirect("twoBranchManager.aspx");
            }
            catch
            {
                //this.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('添加机构失败')", true);
                Alert("编辑机构失败");
            }
        }
    }
}
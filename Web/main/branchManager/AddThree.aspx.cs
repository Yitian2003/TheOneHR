using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheOneHRModels;
using TheOneHRBLL;

public partial class main_branchManager_AddThree : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindDDl();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        TheOneHRModels.Config_file_third_kind kind = new TheOneHRModels.Config_file_third_kind();
        kind.Third_kind_name = txtBranchName.Value.Trim();
        kind.Csk = TheOneHRBLL.Config_file_second_kindManager.GetConfig_file_second_kindById(int.Parse(ddlBranch2.SelectedValue));
        try
        {
            TheOneHRBLL.Config_file_third_kindManager.AddConfig_file_third_kind(kind);
            Response.Redirect("threeBranchManager.aspx");
        }
        catch
        {
            Alert("添加机构失败");
            //this.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('添加机构失败')", true);
        }
        
    }

    private void BindDDl()
    {
        ddlBranch2.Items.Clear();

        IList<Config_file_second_kind> sKinds = Config_file_second_kindManager.GetAllConfig_file_second_kinds();

        ddlBranch2.Items.Add(new ListItem("Choose...", "-1"));

        foreach (Config_file_second_kind kind in sKinds)
        {
            ListItem item = new ListItem();
            item.Text = kind.Cfk.First_kind_name + " - " + kind.Second_kind_name;
            item.Value = kind.Id.ToString();
            ddlBranch2.Items.Add(item);
        }
    }
}
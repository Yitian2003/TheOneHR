using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheOneHRModels;
using TheOneHRBLL;

public partial class main_branchManager_threeBranchManager : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindDDl(); 
        }
    }

    private void BindDDl()
    {
        ddlBranch2.Items.Clear();

        IList<Config_file_second_kind> sKinds = Config_file_second_kindManager.GetAllConfig_file_second_kinds();

        ddlBranch2.Items.Add(new ListItem("Choose...", "-1"));

        foreach(Config_file_second_kind kind in sKinds)
        {
            ListItem item = new ListItem();
            item.Text = kind.Cfk.First_kind_name + " - " + kind.Second_kind_name;
            item.Value = kind.Id.ToString();
            ddlBranch2.Items.Add(item);
        }
    }

    protected void btnQuery_Click(object sender, EventArgs e)
    {
        string condition = " 1=1 ";
        if (ddlBranch2.SelectedValue.Equals("-1")){
            if(!string.IsNullOrEmpty(txtBranchName.Value.Trim())) {
                condition += string.Format(" and Third_kind_name like '{0}%'", txtBranchName.Value);
            }
        } else
        {
            if (!string.IsNullOrEmpty(txtBranchName.Value.Trim()))
            {
                condition += string.Format(" and Third_kind_name like '{0}%' and Csk_no={1}", txtBranchName.Value, ddlBranch2.SelectedValue);

            }
            else
            {
                condition += " and Csk_no=" + ddlBranch2.SelectedValue;
            }
        }

        odsBranch.SelectParameters[0].DefaultValue = condition;
        odsBranch.Select();
        rptBranch.DataBind();
    }
}
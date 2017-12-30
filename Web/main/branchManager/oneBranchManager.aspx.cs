using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main_branchManager_oneBranchManager : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string condition = " 1= 1 ";
        if (!string.IsNullOrEmpty(txtBranchName.Value.Trim()))
        {
            condition += string.Format(" and First_kind_name like '{0}%'", txtBranchName.Value.Trim());
        }

        odsBranch.SelectParameters[0].DefaultValue = condition;
        odsBranch.Select();
        rptBranch.DataBind();
    }
}
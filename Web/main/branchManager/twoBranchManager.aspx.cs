using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main_branchManager_twoBranchManager : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string condition = " 1=1 ";

        if (ddlBranch1.SelectedValue.Equals("0"))
        {
            if (!string.IsNullOrEmpty(txtBranchName.Value.Trim()))
            {
                condition += string.Format(" and Second_kind_name like '{0}%'", txtBranchName.Value);
            }
        }
        else
        {
            if (!string.IsNullOrEmpty(txtBranchName.Value.Trim()))
            {
                condition += string.Format(" and Second_kind_name like '{0}%' and Cfk_no={1}", txtBranchName.Value, ddlBranch1.SelectedValue);
            }
            else
            {
                condition += " and Cfk_no=" + ddlBranch1.SelectedValue;
            }
        }

        CultureInfo oldCI = Thread.CurrentThread.CurrentCulture;

        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

        odsBranch1.SelectParameters[0].DefaultValue = condition;
        odsBranch1.Select();
        rptBranch.DataBind();
    }
}
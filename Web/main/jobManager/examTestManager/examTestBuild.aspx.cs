using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheOneHRModels;
using TheOneHRBLL;

public partial class main_jobManager_examTestManager_examTestBuild : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if(Request["emrNo"] != null)
            {
                int emrNo = int.Parse(RequestString("emrNo"));
                Engage_major_release release = Engage_major_releaseManager.GetEngage_major_releaseById(emrNo);
                lblMajorKind.Text = release.Cm.Cmk.Major_kind_name;
                lblMajorName.Text = release.Cm.Major_name;
                lblRegister.Text = CurrentUser.User_name;
                lblRegTime.Text = DateTime.Now.ToShortDateString();
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

    }
}
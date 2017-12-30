using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheOneHRBLL;
using TheOneHRModels;

public partial class main_jobManager_jobPublish_jobPublishChange : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            int id = int.Parse(this.RequestString("id"));
            Engage_major_release release = Engage_major_releaseManager.GetEngage_major_releaseById(id);

            lblBranch1.Text = release.Ctk.Csk.Cfk.First_kind_name.ToString();
            lblBranch2.Text = release.Ctk.Csk.Second_kind_name.ToString();
            lblBranch3.Text = release.Ctk.Third_kind_name.ToString();
            ddlRequestType.SelectedValue = release.Engage_type;
            lblJobName.Text = release.Cm.Major_name;
            txtEndDate.Text = DateTime.Parse(release.Deadline.ToString()).ToShortDateString();
            txtRequestNum.Text = release.Human_amount.ToString();
            lblRegister.Text = release.Register_users.User_name.ToString();
            lblUpdateTime.Text = DateTime.Now.ToShortDateString();
            txtjobDesc.Text = release.Major_describe;
            txtJobRequest.Text = release.Engage_required;
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        int id = int.Parse(RequestString("id"));
        Engage_major_release release = Engage_major_releaseManager.GetEngage_major_releaseById(id);

        release.Engage_type = ddlRequestType.SelectedValue;
        release.Deadline = DateTime.Parse(txtEndDate.Text);
        release.Human_amount = int.Parse(txtRequestNum.Text);
        release.Major_describe = txtjobDesc.Text;
        release.Engage_required = txtJobRequest.Text;
        release.Change_time = DateTime.Now;
        release.Changer_users = this.CurrentUser;

        try
        {
            Engage_major_releaseManager.ModifyEngage_major_release(release);
            Response.Redirect("jobPublishConfirm.aspx");

        }catch (Exception ex)
        {
            
            this.Alert(ex.Message);
        }
        
    }
}
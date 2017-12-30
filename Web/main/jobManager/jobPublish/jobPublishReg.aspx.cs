using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheOneHRModels;
using TheOneHRBLL;

public partial class main_jobManager_jobPublish_jobPublishReg : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtRegister.Text = this.CurrentUser.User_name;
            txtRegTime.Text = DateTime.Now.ToShortDateString();
        }
    }

    protected void ddlBranch1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlBranch2.Items.Clear();
        ddlBranch2.Items.Add(new ListItem("Choose..", "-1"));
        ddlBranch3.Items.Clear();
        ddlBranch3.Items.Add(new ListItem("Choose...", "-1"));

        int branch1Id = int.Parse(ddlBranch1.SelectedValue);

        if(branch1Id != -1)
        {
            IList<Config_file_second_kind> branch2 = Config_file_second_kindManager.GetConfig_file_second_kindByBranchOneId(branch1Id);

            foreach(Config_file_second_kind kind in branch2)
            {
                ListItem item = new ListItem();
                item.Text = kind.Second_kind_name;
                item.Value = kind.Id.ToString();
                ddlBranch2.Items.Add(item);
            }
        }
        
    }

    protected void ddlBranch2_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlBranch3.Items.Clear();
        ddlBranch3.Items.Add(new ListItem("Choose...", "-1"));

        int branch2Id = int.Parse(ddlBranch2.SelectedValue);
        if(branch2Id != -1)
        {
            IList<Config_file_third_kind> kinds = Config_file_third_kindManager.GetConfig_file_third_kindByBranchTwoId(branch2Id);

            foreach(Config_file_third_kind kind in kinds)
            {
                ListItem item = new ListItem();
                item.Text = kind.Third_kind_name;
                item.Value = kind.Id.ToString();
                ddlBranch3.Items.Add(item);
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Engage_major_release release = new Engage_major_release();
        release.Ctk = Config_file_third_kindManager.GetConfig_file_third_kindById(int.Parse(ddlBranch3.SelectedValue));
        release.Cm = Config_majorManager.GetConfig_majorById(int.Parse(ddlMajor.SelectedValue));
        release.Deadline = DateTime.Parse(txtEndDate.Text);
        release.Engage_required = txtJobRequest.Text;
        release.Engage_type = ddlRequestType.SelectedItem.Text;
        release.Human_amount = int.Parse(txtRequestNum.Text);
        release.Major_describe = txtjobDesc.Text;
        release.Regist_time = DateTime.Now;
        release.Register_users = this.CurrentUser;
        release.Changer_users = this.CurrentUser;
        release.Change_time = DateTime.Now;

        try
        {
            Engage_major_releaseManager.AddEngage_major_release(release);
            Response.Redirect("jobPublishConfirm.aspx");
        }
        catch(Exception ex)
        {
            
            this.Alert(ex.Message);
        }
    }
}
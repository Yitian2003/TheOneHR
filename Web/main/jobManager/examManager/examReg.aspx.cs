using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheOneHRModels;
using TheOneHRBLL;

public partial class main_jobManager_examManager_examReg : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtRegister.Text = this.CurrentUser.User_name;
            txtRegTime.Text = DateTime.Now.ToShortDateString();
        }
    }

    protected void ddlCategory1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlCategory2.Items.Clear();
        ddlCategory2.Items.Add(new ListItem("Choose...", "-1"));

        int id = int.Parse(ddlCategory1.SelectedValue);

        if(id != -1)
        {
            IList<Config_question_second_kind> kinds = Config_question_second_kindManager.GetConfig_question_second_kindByQ1Id(id);

            foreach(Config_question_second_kind kind in kinds)
            {
                ListItem item = new ListItem();
                item.Text = kind.Second_kind_name;
                item.Value = kind.Id.ToString();

                ddlCategory2.Items.Add(item);
            }
        }
        
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Engage_subject subject = new Engage_subject();
        subject.Cqsk_No = Config_question_second_kindManager.GetConfig_question_second_kindById(int.Parse(ddlCategory2.SelectedValue));
        subject.Context = txtQTitle.Text;
        subject.Key_a = txtQA.Text;
        subject.Key_b = txtQB.Text;
        subject.Key_c = txtQC.Text;
        subject.Key_d = txtQD.Text;
        subject.Key_e = txtQE.Text;

        string correctKeys = "";
        foreach(ListItem item in chkAnswer.Items)
        {
            if (item.Selected)
            {
                correctKeys += item.Value;
            }
        }
        subject.Correct_key = correctKeys;
        subject.Register_users_No = this.CurrentUser;
        subject.Changer_users_No = this.CurrentUser.Id;
        subject.Regist_time = DateTime.Now;
        subject.Derivation = txtFrom.Text;

        try
        {
            Engage_subjectManager.AddEngage_subject(subject);
            Response.Redirect("examSearch.aspx");
        }
        catch (Exception ex)
        {
            this.Alert(ex.Message);
        }
        
    }
}
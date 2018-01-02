using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheOneHRModels;
using TheOneHRBLL;

public partial class main_jobManager_examManager_examModify : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int id = int.Parse(RequestString("id"));
            Engage_subject subjuct = Engage_subjectManager.GetEngage_subjectById(id);

            if (subjuct != null)
            {
                lblCategory1.Text = subjuct.Cqsk_No.Cqfk_no.First_kind_name;
                lblCategory2.Text = subjuct.Cqsk_No.Second_kind_name;
                txtQTitle.Text = subjuct.Context;
                txtQA.Text = subjuct.Key_a;
                txtQB.Text = subjuct.Key_b;
                txtQC.Text = subjuct.Key_c;
                txtQD.Text = subjuct.Key_d;
                txtQE.Text = subjuct.Key_e;
                txtFrom.Text = subjuct.Derivation;
                lblRegist.Text = subjuct.Register_users_No.User_name;

                if (subjuct.Regist_time.HasValue)
                {
                    lblRegistTime.Text = subjuct.Regist_time.Value.ToShortDateString();
                } else
                {
                    lblRegistTime.Text = "";
                }

                string answer = subjuct.Correct_key;
                for(int i = 0; i < answer.Length; i++)
                {
                    char a = answer[i];
                    for (int j = 0; j < chkAnswer.Items.Count; j++)
                    {
                        if(chkAnswer.Items[j].Text.ToUpper() == a.ToString().ToUpper())
                        {
                            chkAnswer.Items[j].Selected = true;
                            break;
                        }
                    }
                }

            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Engage_subject subject = Engage_subjectManager.GetEngage_subjectById(int.Parse(RequestString("Id")));

        if(subject != null)
        {
            subject.Context = txtQTitle.Text;
            subject.Key_a = txtQA.Text;
            subject.Key_b = txtQB.Text;
            subject.Key_c = txtQC.Text;
            subject.Key_d = txtQD.Text;
            subject.Key_e = txtQE.Text;

            string correctKey = "";
            foreach(ListItem item in chkAnswer.Items)
            {
                if (item.Selected) correctKey += item.Text;
            }
            subject.Correct_key = correctKey;
            subject.Derivation = txtFrom.Text;
            subject.Change_time = DateTime.Now;
            subject.Changer_users_No = CurrentUser.Id;

            try
            {
                Engage_subjectManager.ModifyEngage_subject(subject);
                this.Alert("修改试题成功");
                Response.Redirect("examSearch.aspx");

            } catch (Exception ex)
            {
                Alert(ex.Message);
            }

        }
    }
}
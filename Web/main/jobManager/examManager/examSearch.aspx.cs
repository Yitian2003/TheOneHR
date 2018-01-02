using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheOneHRModels;
using TheOneHRBLL;

public partial class main_jobManager_examManager_examSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //ddlCategory2.SelectedValue
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

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        odsEngageSubject.SelectParameters[0].DefaultValue = ddlCategory2.SelectedValue;
        odsEngageSubject.SelectParameters[1].DefaultValue = txtTerm.Text.Trim();
        odsEngageSubject.SelectParameters[2].DefaultValue = beginTime.Value.Trim();
        odsEngageSubject.SelectParameters[3].DefaultValue = endTime.Value.Trim();

        odsEngageSubject.Select();
        gvExam.DataBind();
    }

    protected void linkModify_Command(object sender, CommandEventArgs e)
    {
        int id = int.Parse(e.CommandArgument.ToString());
        Response.Redirect("examModify.aspx?id=" + id.ToString());
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main_branchManager_editThree : PageBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if(Request["id"] != null)
            {
                int id = int.Parse(Request["id"].ToString());
                TheOneHRModels.Config_file_third_kind kind = TheOneHRBLL.Config_file_third_kindManager.GetConfig_file_third_kindById(id);
                txtBranchName.Value = kind.Third_kind_name;
            }
        }
    }

    protected void btn_save_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request["id"].ToString());
        TheOneHRModels.Config_file_third_kind kind = TheOneHRBLL.Config_file_third_kindManager.GetConfig_file_third_kindById(id);

        if(kind != null)
        {
            kind.Third_kind_name = txtBranchName.Value;

            //CultureInfo oldCI = Thread.CurrentThread.CurrentCulture;

            //Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            try
            {
                TheOneHRBLL.Config_file_third_kindManager.ModifyConfig_file_third_kind(kind);
                Response.Redirect("threeBranchManager.aspx");
            }
            catch(Exception ex)
            {
               
                string alertString = ex.Message.ToString();
                this.Alert("编辑失败");
                //this.ClientScript.RegisterStartupScript(this.GetType(), null, "alert(alertString)");
            }
            
        }
        
    }
}
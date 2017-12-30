using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheOneHRModels;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, ImageClickEventArgs e)
    {
        string username = txtUser.Value.Trim();
        string password = txtPwd.Value.Trim();

        UserInfo userInfo = new UserInfo();

        if(TheOneHRBLL.UserInfoManager.Login(username, password, out userInfo))
        {
            Session["userinfo"] = userInfo;
            Response.Redirect("/main/loading.htm");
        }
        else
        {
            this.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('Username or Password Error')", true);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PageBase
/// </summary>
public class PageBase : System.Web.UI.Page
{
    public PageBase()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    protected override void OnLoad(EventArgs e)
    {
        if (this.CurrentUser == null)
        {
            Response.Redirect("~/Login.aspx");
        }
        base.OnLoad(e);
    }

    public TheOneHRModels.UserInfo CurrentUser
    {
        get
        {
            if(Session["userinfo"] != null)
            {
                return Session["userinfo"] as TheOneHRModels.UserInfo;
            }
            else
            {
                return null;
            }
        }
    }

    public void Alert(string msg)
    {
        ClientScript.RegisterStartupScript(GetType(), null, "alert('" + msg + "')", true);
    }

    public string RequestString (string key)
    {
        if (Request[key] != null)
        {
            return Request[key].ToString();
        }
        else return null;
    }
}
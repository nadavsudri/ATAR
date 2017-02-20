using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AfterLogPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string username = Session["log"].ToString();
            afheader.InnerText = "Hello " + username ?? "You are not Logged in properly";
        }
        catch { Response.Redirect("MyA7X.aspx"); }
    }

    protected void logoutbtn_ServerClick(object sender, EventArgs e)
    {
        Session["log"] = null;
        Response.Redirect("MyA7X.aspx");
    }
}
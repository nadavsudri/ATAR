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
        string username = Session["log"].ToString();
        afheader.InnerText = "Hello " + username.Substring(1);      
    }

    protected void logoutbtn_ServerClick(object sender, EventArgs e)
    {
        Session["log"] = "f";
        Response.Redirect("MyA7X.aspx");
    }
}
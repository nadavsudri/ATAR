using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyA7X : System.Web.UI.Page
{
    private List<string> usernames;
    private List<string> passwords;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session.Count != 0)
        {
            if (Session["Log"].ToString()[0] == 't')
            {
                //user is already logged in, redirect to another page 
                Response.Redirect("AfterLogPage.aspx");
            }
        }
        // user needs to log into the website

        string connectionstring = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(connectionstring))
        using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Table];", connection))
        {
            DataTable users = new DataTable();
            adapter.Fill(users);
            usernames = users.AsEnumerable().Select(x => x[1].ToString()).ToList();//list of all usernames
            passwords = users.AsEnumerable().Select(x => x[2].ToString()).ToList();//list of all passwords       
        }
    }


    protected void loginbut_ServerClick(object sender, EventArgs e)
    {
        if (usernames.Contains(usernamebox.Value))
        {
            int index = usernames.IndexOf(usernamebox.Value);
            if (passwords[index] == passwordbox.Value)
            {
                Alert("Logged In");
                Session["log"] = "t" + usernamebox.Value;
                Response.Redirect("AfterLogPage.aspx");
            }

        }

    }
    protected void redirecttosignup(object sender, EventArgs e)
    {
        Response.Redirect("Register_Page.aspx");
    }
    private void Alert(string message)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", string.Format("<script> alert('{0}'); </script>", message));
    }
}
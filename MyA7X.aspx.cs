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
        string connectionstring = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(connectionstring))
        using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Table];", connection))
        {
            DataTable users = new DataTable();
            adapter.Fill(users);
            usernames = users.AsEnumerable().Select(x => x[1].ToString()).ToList();//list of all usernames
            passwords = users.AsEnumerable().Select(x => x[2].ToString()).ToList();//list of all passwords       
        }
        Page.ClientScript.RegisterStartupScript(this.GetType(), "MyKey", "checklogin();", true);
    }

    protected void loginbut_ServerClick(object sender, EventArgs e)
    {
        bool found = false;
        int i=0;
        for (i = 0; i < usernames.Count; i++)
        {
            if (usernames[i]==usernamebox.Value)
            {
                found = true;
                break;
            }
        }
        if (found)
        {
            if (passwords[i]==passwordbox.Value)
            {
                Alert("Logged In");
                Page.ClientScript.RegisterStartupScript(this.GetType(), "MyKey", "login();", true);
                 
            }
        }
    }
    private void Alert(string message)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", string.Format("<script> alert('{0}'); </script>", message));
    }
}
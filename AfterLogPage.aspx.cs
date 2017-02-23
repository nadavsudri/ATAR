using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AfterLogPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            List<string> urls = new List<string>();
            List<string> usernames = new List<string>();
            string username = Session["log"].ToString();
            afheader.InnerText = "Hello " + username ?? "You are not Logged in properly";
            string connectionstring = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Table];", connection))
            {
                DataTable users = new DataTable();
                adapter.Fill(users);
                urls = users.AsEnumerable().Select(x => x[3].ToString()).ToList();//list of usernames
                usernames = users.AsEnumerable().Select(x => x[1].ToString()).ToList();//list of all usernames
            }
            int index = usernames.IndexOf(username);
            string currenturl = urls[index];
            if (currenturl == null||currenturl=="")
            {
                ProfilePic.Src = @"http://www.propertybaazaar.com/images/noprofile.png";
            }
            else
            {
                ProfilePic.Src = urls[index];
            }
            // ProfilePic.Src=


        }
        catch { Response.Redirect("MyA7X.aspx"); }
    }

    protected void logoutbtn_ServerClick(object sender, EventArgs e)
    {
        Session["log"] = null;
        Response.Redirect("MyA7X.aspx");
    }

    protected void uploadbutton_ServerClick(object sender, EventArgs e)
    {
        string url = urlbox.Value;
        if (CheckImage(url))
        {
            if (url != null && url != "")
            {
                ProfilePic.Src = url;
                string query = string.Format("UPDATE [Table] SET url='{0}' WHERE username='{1}';", url, Session["log"].ToString().Substring(0));
                string connectionstring = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        else
        {
            Alert("Image not found");
        }
    }
    private void Alert(string message)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", string.Format("<script> alert('{0}'); </script>", message));
    }

    protected void cancelbutton_ServerClick(object sender, EventArgs e)
    {
        urlbox.Value = "";
    }
    private bool CheckImage(string url)
    {
        HttpWebResponse response = null;
        HttpWebRequest request = null;
        try
        {
            request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "HEAD";
        }
        catch
        {
            return false;
        }

        try
        {
            response = (HttpWebResponse)request.GetResponse();
            return true;
        }
        catch
        {
            return false;
        }
        finally
        {
            if (response != null)
            {
                response.Close();
            }
        }
    }
}
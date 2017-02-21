using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;

public partial class Default2 : System.Web.UI.Page
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
    }
    protected void subbut_ServerClick(object sender, EventArgs e)
    {
        ClientScriptManager manager = Page.ClientScript;
        string username = userbox.Value;
        string password = passbox.Value;
        string passwordconfirm = passboxcon.Value;
        Regex regex = new Regex(@"(?=.*[A-Z])(?=.*[a-z])(?=.*\d)[0-9a-zA-Z!-+]{8,}");
        Match match = regex.Match(password);
        if (username==null||password==null)
        {
            Alert("All Fields must be filled");
        }
        if (usernames.Contains(username))
        {
            Alert("Username is already taken!");
        }
        else
        {
            if (match.Success)
            {
                if (password == passwordconfirm)
                {
                    string query = string.Format("INSERT INTO [Table] (username,password) VALUES ('{0}','{1}');", username, password);
                    string connectionstring = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    Alert("Registered");
                    Response.Redirect("MyA7X.aspx");
                }
                else
                {
                    Alert("Passwords have to match");
                }
            }
        }
    }
    private void Alert(string message)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", string.Format("<script> alert('{0}'); </script>", message));
    }
}
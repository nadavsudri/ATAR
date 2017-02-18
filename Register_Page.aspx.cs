using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(connectionstring))
        using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Table];",connection))
        {
            DataTable users = new DataTable();
            adapter.Fill(users);
            List<string> usernames = users.AsEnumerable().Select(x => x[1].ToString()).ToList();//list of all usernames
            List<string> passwords = users.AsEnumerable().Select(x => x[2].ToString()).ToList();//list of all usernames

          
        }



    }
}
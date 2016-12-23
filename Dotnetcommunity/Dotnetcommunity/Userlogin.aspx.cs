using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Dotnetcommunity
{
    public partial class Userlogin : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter parmeUser = new SqlParameter("@UserName", TxtUserName.Text.Trim());
                SqlParameter parmePass = new SqlParameter("@Password", TxtPasssword.Text.Trim());
                SqlCommand com = new SqlCommand("Sp_login_validation", conn);
                com.Parameters.Add(parmeUser);
                com.Parameters.Add(parmePass);
                com.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader da = com.ExecuteReader();
                Response.Redirect("Home.aspx");
            }
            finally
            {
                conn.Close();
                lblError.Text = "User name and password is wrong ";

            }
        }
    }
}
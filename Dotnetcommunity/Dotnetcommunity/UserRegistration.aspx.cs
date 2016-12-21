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
    public partial class UserRegistration : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            Security_Question();
        }

        protected void Security_Question()
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("select * FROM ddlQuestion",conn);
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet Ds = new DataSet();
                Da.Fill(Ds);
                ddlQuestion.DataTextField = Ds.Tables[0].Columns["Question"].ToString();
                ddlQuestion.DataValueField = Ds.Tables[0].Columns["QuestionId"].ToString();
                ddlQuestion.DataSource = Ds.Tables[0];
                ddlQuestion.DataBind();
            }
            catch
            {
                Console.WriteLine("this is error ");

            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand();


            }
            catch
            {

            }
        }
    }
}
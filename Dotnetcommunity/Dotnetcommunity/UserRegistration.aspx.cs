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
            try
            {
                Security_Question();
            }
            catch
            {
                Console.WriteLine("hello this is wrong");
            }
        }

        protected void Security_Question()
        {
            try
            {


                SqlCommand cmd = new SqlCommand("select * FROM ddlQuestion", conn);
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet Ds = new DataSet();
                conn.Open();
                Da.Fill(Ds);
                conn.Close();
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
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());

                conn.Open();
                string Name = txtName.Text;
                string UserName = TxtUsername.Text;
                string Password = Txtpassword.Text;
                string SecQuestion = ddlQuestion.SelectedItem.Value;
                string Answers = TxtAnswer.Text;
                string Status = Txtstatus.Text;
                SqlCommand cmd = new SqlCommand("INSERT INTO LoginId VALUES (@Name,@userName,@password,@SecQuestion,@Answers,@Status);", conn);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@SecQuestion", SecQuestion);
                cmd.Parameters.AddWithValue("@Answers", Answers);
                cmd.Parameters.AddWithValue("@Status", Status);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i == 1)
                {
                    lblDisplay.Text = "Inserted Successfully";
                }
                else
                {
                    lblDisplay.Text = "Unsuccessfull of insert";
                }

            }
            catch
            {

            }
        }
    }
}
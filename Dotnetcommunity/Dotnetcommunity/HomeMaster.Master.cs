using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dotnetcommunity
{
    public partial class HomeMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
   

        protected void btnHome_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserRegistration.aspx");
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Userlogin.aspx");
        }
    }
}
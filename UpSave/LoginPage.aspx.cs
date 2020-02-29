using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpSave
{
    public partial class LoginPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Error_Flag.Visible = false;
        }

        protected void login_button_ServerClick(object sender, EventArgs e)
        {
            
        }

        protected void SignUp_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("~/SignUpPage.aspx");
        }
    }
}
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UpSave.Our_Scripts;

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
            string username = email.Value;
            string password = Password.Value;
            string account_id = DatabaseIO.Login(username, password);
            if(account_id.Equals("not found"))
            {
                Error_Flag.Visible = true;
                email.Value = "";
                Password.Value = "";
            }
            else
            {
                Error_Flag.Visible = false;
                Cookies.WriteCookie(account_id, this.Response);
            }
        }

        protected void SignUp_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("~/SignUpPage.aspx");
        }
    }
}
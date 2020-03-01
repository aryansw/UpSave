using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UpSave.Our_Scripts;

namespace UpSave
{
    public partial class SignUpPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Error_Flag.Visible = false;
        }

        protected void login_button_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("~/LoginPage.aspx");
        }

        protected void SignUp_ServerClick(object sender, EventArgs e)
        {

            Customer customer = new Customer
            {
                first_name = first_name.Value,
                last_name = last_name.Value,
                address = new Address
                {
                    street_name = street_name.Value,
                    street_number = street_number.Value,
                    city = city.Value,
                    zip = zip.Value,
                    state = state.Value,
                },
            };
            String account_id = DatabaseIO.Register(email.Value, Password.Value, customer);
            if (account_id.Equals("not found"))
            {
                Error_Flag.Visible = true;
                email.Value = "";
                Password.Value = "";
            }
            else
            {
                Error_Flag.Visible = false;
                Cookies.WriteCookie(account_id, this.Response);
                Response.Redirect("MyProfile.aspx");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UpSave.Our_Scripts;

namespace UpSave
{
    public partial class MyProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string account_id = Cookies.ReadCookie(this.Request, this.Response);
            Customer customer = ServerRequests.GetCustomer(account_id);
            Customer_Data details = DatabaseIO.ReadCustomer(account_id);
            first_name.Value = customer.first_name;
            last_name.Value = customer.last_name;
            email.Value = details.username;
            pass.Value = details.password;
            street_name.Value = customer.address.street_name;
            street_num.Value = customer.address.street_number;
            city.Value = customer.address.city;
            state.Value = customer.address.state;
            zipcode.Value = customer.address.zip;
            country.Value = "USA";
        }
    }
}
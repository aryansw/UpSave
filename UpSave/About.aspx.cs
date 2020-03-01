    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UpSave.Our_Scripts;

namespace UpSave
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                _id = "ajfoiajdojasdsadasdj",
                first_name = "Demo",
                last_name = "FOrrij",
                address = new Address
                {
                    street_number = "1275",
                    street_name = "west street",
                    city = "dubai",
                    state = "IN",
                    zip = "47907"
                }
            };
            System.Diagnostics.Debug.WriteLine(Our_Scripts.ServerRequests.PutCustomer(customer));
        }
    }
}
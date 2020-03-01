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
            Payments.RetrievePayments("5e5bb4d0f1bac107157e0d40");
        }
    }
}
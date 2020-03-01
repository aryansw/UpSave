using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpSave
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                LastUpdate.Text = "Last update: " + DateTime.Now.ToLongTimeString();
            }
        }
        protected void demo(object sender, EventArgs e)
        {
            
        }
    }
}
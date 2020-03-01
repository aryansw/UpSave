using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpSave
{
    public partial class ExpecAndGoal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void get_range_ServerClick(object sender, EventArgs e)
        {
            
            System.Diagnostics.Debug.WriteLine(time_range.Value);
            number.InnerText = time_range.Value;
        }

        protected void get_suggestions(object sender, EventArgs e)
        {
            
        }
    }
}
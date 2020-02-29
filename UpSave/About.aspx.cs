using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpSave
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object read = ReadDictionary.readCustomerDictionary();
            foreach(string input in read)
            {
                System.Diagnostics.Debug.WriteLine(input);
            }
        }
    }
}
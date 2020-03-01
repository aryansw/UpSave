using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UpSave.Our_Scripts;

namespace UpSave
{
    public partial class ExpecAndGoal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String store = HttpContext.Current.Request.Url.Query;
            if(store != null)
            {
                if (store.Split('=').Length == 2)
                {
                    if (store.Split('=')[0].Equals("time_range"))
                    {
                        int time = int.Parse(store.Split('=')[1]);
                        string user_id = Cookies.ReadCookie(this.Request, this.Response);
                        String account_id = Account.GetAccountID(user_id);
                        Payments[] payments = Payments.RetrievePayments(account_id);
                        decimal[] stuff = Payments.spending(account_id);
                        decimal[] save = RequestHandling.ExpectedSavings(Payments.spending_, 20000, Account.GetAccount(user_id).balance, time);
                        approx.InnerText = String.Format("Approximate Savings over {0} months: ${1:#.##}", time, save[1]);
                        Months.InnerText = String.Format("Time Span: {0} Months", time);
                        Range.InnerText = String.Format("Range: ${0:#.##} - ${1:#.##}", save[2], save[0]);
                        Likely.InnerText = String.Format("Likely: ${0:#.##}", save[1]);
                        time_range.Value = time.ToString();
                    }
                    if (store.Split('=')[0].Equals("number"))
                    {
                        int number = int.Parse(store.Split('=')[1]);
                    }
                }
            }
        }

        protected void get_range_ServerClick(object sender, EventArgs e)
        {
            
            System.Diagnostics.Debug.WriteLine(time_range.Value);
            int time = int.Parse(time_range.Value);
            string user_id = Cookies.ReadCookie(this.Request, this.Response);
            String account_id = Account.GetAccountID(user_id);
            Payments[] payments = Payments.RetrievePayments(account_id);
            decimal[] stuff = Payments.spending(account_id);
            decimal[] save = RequestHandling.ExpectedSavings(Payments.spending_, 20000, Account.GetAccount(user_id).balance, time);
            approx.InnerText= String.Format("Approximate Savings over {0} months: ${1:#.##}", time, save[1]);
            Months.InnerText = String.Format("Time Span: {0} Months", time);
            Range.InnerText = String.Format("Range: ${0:#.##} - ${1:#.##}", save[2], save[0]);
            Likely.InnerText = String.Format("Likely: ${0:#.##}", save[1]);
        }

        protected void button_ServerClick(object sender, EventArgs e)
        {

        }
    }
}
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace UpSave
{
    public class Payments
    {
        public string id;
        public string type;
        public string merchant_id;
        public string purchase_date;
        public decimal amount;
        public string status;
        public string medium;
        public string description;

        public static Payments[] RetrievePayments(string str)
        {

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(string.Format("http://api.reimaginebanking.com/accounts/" + str + "/purchases?key=2576f38896155fd18751261143cff4c4"));
            webRequest.Method = "GET";
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            System.Diagnostics.Debug.WriteLine(webResponse.StatusCode);
            System.Diagnostics.Debug.WriteLine(webResponse.Server);

            string jsonArrayString;
            using (Stream stream = webResponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonArrayString = reader.ReadToEnd();
            }
            System.Diagnostics.Debug.WriteLine(jsonArrayString);
            object json = JsonConvert.DeserializeObject(jsonArrayString);
            List<Payments> payments = new List<Payments>();
            foreach (JToken item in ((JToken)(json)).Children())
            {
                System.Diagnostics.Debug.WriteLine(item.ToString());

                Payments payment = item.ToObject<Payments>();
                payment.id = str;
                payments.Add(payment);

            }
            return payments.ToArray();
        }

        public static decimal[] spending_ = new decimal[3];
        public static decimal averagespent = 0;
        public static decimal leastspent = int.MaxValue;
        public static decimal maxspent = int.MinValue;
        static int n = 0;

        static void calctotal_spending(decimal value)
        {
            n++;
            averagespent = (averagespent * n + value) / n + 1;
            if (leastspent > value)
                leastspent = value;
            if (maxspent < value)
                maxspent = value;
            spending_[0] = leastspent;
            spending_[1] = averagespent;
            spending_[2] = maxspent;

        }
        public static decimal[] spending(string account_id)
        {
            spending_ = new decimal[3];
            averagespent = 0;
            leastspent = int.MaxValue;
            maxspent = int.MinValue;
            n = 0;
            var a = RetrievePayments(account_id);
            decimal[] spending = new decimal[6];
            foreach (int L in new int[] { 0, 1, 2, 3, 4, 5 })
            {
                spending[L] = 0;
            }
            foreach (Payments x in a)
            {
                calctotal_spending(x.amount);
                if (x.description.ToLower() == "entertainment") spending[0] += x.amount;
                if (x.description.ToLower() == "outing") spending[1] += x.amount;
                if (x.description.ToLower() == "shopping") spending[2] += x.amount;
                if (x.description.ToLower() == "transport") spending[3] += x.amount;
                if (x.description.ToLower() == "grocery") spending[4] += x.amount;
                if (x.description.ToLower() == "dues") spending[5] += x.amount;


            }
            return spending;
        }

    }
}

using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System;
using System.Collections.Generic;
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
       
        public static Payments[] RetrievePayments( string str="0000000")
        {

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(string.Format("http://api.reimaginebanking.com/accounts/"+ str +"/purchases?key=2576f38896155fd18751261143cff4c4"));
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
            object json = JsonConvert.DeserializeObject(payment);
            List<Payments> payment = new List<Payments>();
            foreach (JToken item in ((JToken)(json)).Children())
            {
                System.Diagnostics.Debug.WriteLine(item.ToString());

                Payments payment = item.ToObject<Payments>();
                payment.Add(Payments);

            }
            return payment.ToArray();
        }
        int func()
        {


            decimal[] spending(List<Payments> a)
            { decimal* a = new decimal[6];
                foreach(L in range(6)){
                    spending[a] = 0;
                }
                foreach (decimal x in a)

                {
                    if (x.lowercase == "entertainment") spending[0] += x.amount;
                    if (x.lowercase == "outing") spending[1] += x.amount;
                    if (x.lowercase == "shopping") spending[2] += x.amount;
                    if (x.lowercase == "transport") spending[3] += x.amount;
                    if (x.lowercase == "grocery") spending[4] += x.amount;
                    if (x.lowercase == "dues") spending[5] += x.amount;


                }
                return a[];
            }
        } }
}

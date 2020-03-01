using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web;

namespace UpSave.Our_Scripts
{
    public class ServerRequests {
        public static Customer[] GetCustomers()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(string.Format("http://api.reimaginebanking.com/customers?key=2576f38896155fd18751261143cff4c4"));
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
            List<Customer> customers = new List<Customer>();
            foreach (JToken item in ((JToken)(json)).Children())
            {
                System.Diagnostics.Debug.WriteLine(item.ToString());

                    Customer  customer = item.ToObject<Customer>();
                    customers.Add(customer);
                
            }
            return customers.ToArray();
        }
    }
}
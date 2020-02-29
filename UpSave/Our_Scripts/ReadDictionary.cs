using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UpSave.Our_Scripts;

namespace UpSave
{
    public class ReadDictionary
    {
        public static string readCustomerDictionary()
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
            string jsonString = jsonArrayString.Substring(1, 197);
            System.Diagnostics.Debug.WriteLine(jsonString);
           
            return jsonString;
        }

        public static void Main()
        {
            Customer customer = new Customer(json: readCustomerDictionary());
            System.Diagnostics.Debug.WriteLine(customer.Getid());
        }
    }
}
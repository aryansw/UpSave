using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;


namespace UpSave
{
	public class Requests(){
        public static string PutMerchant(Merchant merchant)
        {   
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Format("http://api.reimaginebanking.com/merchants?key=2576f38896155fd18751261143cff4c4"));
            request.KeepAlive = false;
            request.ProtocolVersion = HttpVersion.Version10;
            request.Method = "POST";

            string json = new JavaScriptSerializer().Serialize(merchant);
            byte[] postBytes = Encoding.UTF8.GetBytes(json);

            System.Diagnostics.Debug.WriteLine(json);
            request.ContentType = "application/json; charset=UTF-8";
            request.Accept = "application/json";
            request.ContentLength = postBytes.Length;
            Stream requestStream = request.GetRequestStream();
            var streamWriter = new StreamWriter(requestStream);
            streamWriter.Write(json);
            streamWriter.Close();
            var httpResponse = (HttpWebResponse)request.GetResponse();
            string result;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream(), System.Text.Encoding.UTF8))
            {
                result = streamReader.ReadToEnd();
            }
            object json1 = JsonConvert.DeserializeObject(result);
            foreach (JToken item in ((JToken)(json1)).Children())
            {
                if (item.HasValues)
                {
                    foreach (JToken a in ((JToken)(item)).Children())
                    {
                        try
                        {
                            String get_id = a.Last().ToObject<String>();
                            return get_id;
                        }
                        catch (Exception) { }
                    }
                }
            }
            return "";
        }
        public static Merchant[] GetarrMerchants(){

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(string.Format("http://api.reimaginebanking.com/merchants?key=2576f38896155fd18751261143cff4c4"));
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

                Customer customer = item.ToObject<Customer>();
                customers.Add(customer);

            }
            return customers.ToArray();
        }
    }
}

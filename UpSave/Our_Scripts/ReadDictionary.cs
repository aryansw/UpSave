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

        public static List<string> readCustomerDictionary()

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
            jsonArrayString = jsonArrayString.Substring(1, jsonArrayString.Length - 1);
            char[] charArray = new char[jsonArrayString.Length];
            List<string> jsonStrings = new List<string>();
            int flag = 0;
            string eachString = "";
            for (int i = 0; i < jsonArrayString.Length; i++)
            {
                char c = charArray[i];
                if (c == '{')
                {
                    if (flag != 0)
                    {
                        charArray[i] = c;
                    }
                    flag++;
                }
                else if (c == '}')
                {
                    flag--;
                    if (flag != 0)
                    {
                        charArray[i] = c;
                    }
                    for (int j = 0; j < charArray.Length; j++)
                    {
                        eachString += charArray[j];
                        charArray[j] = ' ';
                    }
                    jsonStrings.Add(eachString);
                    eachString = "";
                }
                else
                {
                    charArray[i] = c;
                }
            }
            System.Diagnostics.Debug.WriteLine(jsonStrings);
            return jsonStrings;
        }

    }
}
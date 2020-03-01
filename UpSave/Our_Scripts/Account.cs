using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace UpSave.Our_Scripts
{
    public class Account
    {
        public string _id;
        public string type; //Checking, Credit Card, or Savings
        public string nickname;
        public int rewards;
        public decimal balance;
        public string account_number;
        public string customer_id;

        public Account()
        {
            this._id = "abc";
            this.type = "Checking";
            this.nickname = "abc";
            this.rewards = 1331;
            this.balance = 42069;
            this.account_number = "adada";
            this.customer_id = "15293";
        }

        public static string GetAccountID(string customer_id)
        {
            foreach(Account account in GetAccounts())
            {
                if (account.customer_id.Equals(customer_id))
                {
                    return account._id;
                }
            }
            return null;
        }

        public static Account[] GetAccounts()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(
                string.Format("http://api.reimaginebanking.com/accounts?key=2576f38896155fd18751261143cff4c4"));
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
            List<Account> accounts = new List<Account>();
            foreach (JToken item in ((JToken)(json)).Children())
            {
                System.Diagnostics.Debug.WriteLine(item.ToString());

                Account account = item.ToObject<Account>();
                accounts.Add(account);

            }
            return accounts.ToArray();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;

namespace UpSave.Our_Scripts
{
    public class Account
    {
    public String id;
    public string type;
    public string nickname;
    public int rewards;
    public decimal balance;
    public string account_number;
    public string customer_id;

    public Account(string json)
    {
        Account account = new JavaScriptSerializer().Deserialize<Account>(json);
        this.id = account.id;
        this.type = account.type;
        this.nickname = account.nickname;
        this.rewards = account.rewards;
            this.balance = account.balance;
            this.account_number = account.account_number;
            this.customer_id = account.customer_id;
    }
    public static Account[] Generate(List<string> y)
    {
        int l = 0;
        Account[] a = new Account[y.Count];
        foreach (string i in y)
        {
            a[l] = new Account(json: i);
            l++;
        }
        return a;
    }

    public Account(Account account)
    {
            this.id = account.id;
            this.type = account.type;
            this.nickname = account.nickname;
            this.rewards = account.rewards;
            this.balance = account.balance;
            this.account_number = account.account_number;
            this.customer_id = account.customer_id;
            ;
     }

    public Account()
    {
            this.id = "abc";
            this.type = "abc";
            this.nickname = "abc";
            this.rewards = 1331;
            this.balance = 42069;
            this.account_number = "adada";
            this.customer_id = "15293";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.Script.Serialization;

namespace UpSave.Our_Scripts
{
    public class Deposit
    {

        public string medium;
        public string transaction_date;
        public string status;
        //public float amount;
        public string description;

        public Deposit(string json)
        {
            Deposit withdrawal = new JavaScriptSerializer().Deserialize<Deposit>(json);
            this.medium = withdrawal.medium;
            this.transaction_date = withdrawal.transaction_date;
            this.status = withdrawal.status;
            //this.amount = withdrawal.amount;
            this.description = withdrawal.description;
        }

        public Deposit()
        {
            this.medium = "ez";
            this.transaction_date = "2020-20-20";
            this.status = "completed";
            //this.amount = int.MinValue;
            this.description = "testing testing 1 2 3";
        }
    }
}
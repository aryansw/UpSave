﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace UpSave.Our_Scripts
{
    public class Customer
    {
        private string id;
        private string firstName;

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string value)
        {
            firstName = value;
        }

        private string lastName;

        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string value)
        {
            lastName = value;
        }

        private Dictionary<string, string> address;

        public Customer(string json)
        {
            Customer customer = new JavaScriptSerializer().Deserialize<Customer>(json);
            this.SetLastName(customer.GetLastName());
            this.SetFirstName(customer.GetFirstName());
            this.Setid(customer.Getid());
            this.ChangeAddress(customer.getAddress());
        }
        public Customer()
        {
            this.SetFirstName("broky");
            this.Setid("sid");

        }
        public string Getid()
        {
            return id;

        }

        public string Setid(string a)
        {
            id = a;
            return id;
        }

        public int ChangeAddress(Dictionary<string, string> a)
        {
            address = a;
            return 1;
        }

        public Dictionary<string,string> getAddress()
        {
            return address;
        }
    }
}
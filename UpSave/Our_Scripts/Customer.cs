﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace UpSave.Our_Scripts
{
    public class Customer
    {
        public static JavaScriptSerializer serializer = new JavaScriptSerializer();
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Dictionary<string, string> Address { get; set; }

        public Customer(string json)
        {
            Customer customer = serializer.Deserialize<Customer>(json);
            this.LastName = customer.LastName;
            this.FirstName = customer.FirstName;
            this.Id = customer.Id;
            this.Address = customer.Address;

        }
        public Customer(List<string> x)
        { int l = 0;
            Customer a = new Customer[x.Count];
            foreach (string i in x) 
            { 
                a[l] = new Customer(i);
                l++;
            }
            return a;
        }
    

        public Customer(Customer a)
        {
            this.LastName = customer.LastName;
            this.FirstName = customer.FirstName;
            this.Id = customer.Id;
            this.Address = customer.Address;
        }

        public Customer()
        {
            this.FirstName = "NaNOAs";
            this.LastName = "barrak";
            this.Id = "sid";
            this.Address = new Dictionary<string, string>()
            {
                {"street_number","nil" },
                {"street_name","potato"},
                {"city","manhattan" },
                {"zip","string" }
            };
            
        }
        
    }
}
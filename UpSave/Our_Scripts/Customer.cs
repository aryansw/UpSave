using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace UpSave.Our_Scripts
{
    public class Address
    {
        public string street_number { get; set; }
        public string street_name { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
    }
    public class Customer
    {
        public string _id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Address address { get; set; }

        public Customer(string json)
        {   
            Customer customer = new JavaScriptSerializer().Deserialize<Customer>(json);
            this.last_name=customer.last_name;
            this.first_name=customer.first_name;
            this._id=customer._id;
            this.address=customer.address;
            System.Diagnostics.Debug.WriteLine(customer.address);
        }
        public Customer()
        {
            this.first_name = "broky";
            this._id = "sid";


        }

    }
}
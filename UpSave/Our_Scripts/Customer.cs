using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace UpSave.Our_Scripts
{
    public class Customer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Dictionary<string, string> Address { get; set; }

        public Customer(string json)
        {   
            Customer customer = new JavaScriptSerializer().Deserialize<Customer>(json);
            this.LastName=customer.LastName;
            this.FirstName=customer.FirstName;
            this.Id=customer.Id;
            this.Address=customer.Address;
            System.Diagnostics.Debug.WriteLine(customer.Address);
        }
        public Customer()
        {
            this.FirstName = "broky";
            this.Id = "sid";
<<<<<<< HEAD


=======
            this.Address = new Dictionary<string, string>()
            {
                {"street_number","nil" },
                {"street_name","potato"},
                {"city","manhattan" },
                {"zip","string" }
            };
            
>>>>>>> parent of ac69b44... Deposit class done
        }

    }
}
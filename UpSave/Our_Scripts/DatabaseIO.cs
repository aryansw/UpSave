using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpSave.Our_Scripts
{
    public class DatabaseIO : FireBaseMethods
    {
        public static string Login(string email, string pass)
        {
            foreach(Customer_Data customer in ReadAllCustomers())
            {
                if (customer.username.Equals(email)){
                    if (customer.password.Equals(pass))
                    {
                        return customer.account_id;
                    }
                }
            }
            return "not found";
        }

        public static void WriteCustomer(String email, String pass, Customer customer)
        {
            ConnectToDataBase();
            var new_customer = new Customer_Data{ username = email, password = pass, account_id = customer.Id };
            FireBaseMethods.InsertData("Customers/" + customer.Id, new_customer);    
        }

        public static Customer_Data ReadCustomer(String account_id)
        {
            foreach(Customer_Data customer in ReadAllCustomers())
            {
                if (account_id.Equals(customer.account_id))
                {
                    return customer;
                }
            }
            return new Customer_Data();
        }

        public static List<Customer_Data> ReadAllCustomers()
        {
            ConnectToDataBase();
            var  response = GetData("Customers");
            object json = JsonConvert.DeserializeObject(response.Body);
            List<Customer_Data> customers = new List<Customer_Data>();
            foreach (JToken item in ((JToken)(json)).Children())
            {
                System.Diagnostics.Debug.WriteLine(item.ToString());
                
                foreach (JToken data in item.Children()) { 
                    Customer_Data customer = data.ToObject<Customer_Data>();
                    customers.Add(customer);
                }
            }
            return customers;
        }
    }
    public class Customer_Data
    {
        public string username;
        public string password;
        public string account_id;
    }
}
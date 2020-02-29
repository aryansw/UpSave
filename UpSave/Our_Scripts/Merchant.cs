using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.Script.Serialization;

namespace UpSave
{
    public class Merchant
    {
        //string name;
        //string category;

        //name
        public string name;
        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        //address
        Dictionary<string, string> address = new Dictionary<string, string>();
        public Dictionary<string, string> getAddress() {
            return this.address;
        }

        public void setAddress(Dictionary<string, string> address)
        {
            this.address = address;
        }

        //category
        public string category;
        public string getCategory()
        {
            return this.category;
        }

        public void setCategory(string category)
        {
            this.category = category;
        }

        //geocode
        Dictionary<string, string> geocode = new Dictionary<string, string>();
        public Dictionary<string, string> getGeocode()
        {
            return this.geocode;
        }

        public void setGeocode(Dictionary<string, string> geocode)
        {
            this.geocode = geocode;
        }
        public Merchant(string input)
        {
            Merchant merchant = new JavaScriptSerializer().Deserialize<Merchant>(input);
            this.SetName(merchant.GetName());
            this.setAddress(merchant.getAddress());
            this.setCategory(merchant.getCategory());
            this.setGeocode(merchant.getGeocode());
        }
    }
}
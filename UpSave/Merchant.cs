public class Merchant
{
    string name;
    string category;
    Dictionary<string, string> address = new Dictionary<string, string>();
    Dictionary<string, string> geocode = new Dictionary<string, string>();

    public string name { get; set; }
    public string category { get; set; }
    public Dictionary<string, string> address { get; set; }
    public Dictionary<string, string> geocode { get; set; }

    public Merchant(string input)
    {
        Merchant merchant = new JavaScriptSerializer().Deserialize<Merchant>(json);
        this.setName(merchant.getName());
        this.setAddress(merchant.getAddress());
        this.setGeocode(merchant.getGeocode());

    }
}
class Address
{
    
    private string street;
    private string city;
    private string state;
    private string country;

    
    public Address(string s, string c, string st, string co)
    {
        s = street;
        c = city;
        st = state;
        co = country;
    }

    
    public string Fulladd()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}

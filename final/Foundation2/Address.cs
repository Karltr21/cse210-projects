 class Address
{
    //address class
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

    public void Setstreet(string n)
    {
        street = n;
    }
    public string Getstreet()
    {
        return street;
    }
    public void Setcity(string n)
    {
        city = n;
    }
    public string Getcity()
    {
        return city;
    }
    public void Setstate(string n)
    {
        state = n;
    }
    public string Getstate()
    {
        return state;
    }
    public void Setcountry(string n)
    {
        country = n;
    }
    public string Getcountry()
    {
        return country;
    }

    //determines if they live in America
    public bool USA()
    {
        bool i = true;
        if (country == "USA")
        {
             i = true;
        }
        else
        {
             i = false;
        }
        return i;
    }

    //Creates the address
    public string FullAdd()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}
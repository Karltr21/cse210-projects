class Customer
{
    private string name;
    private Address address;

    public Customer(string n, Address add)
    {
        name = n;
        address = add;
    }

    public void Setname(string n)
    {
        name = n;
    }
    public string Getname()
    {
        return name;
    }

    public void Setadd(Address add)
    {
        address = add;
    }
    public string Getadd()
    {
        return address.FullAdd();
    }

     public bool LivesInUSA()
    {
        return address.USA();
    }
}
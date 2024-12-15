class Outdoor : Event 
{
    protected string weather;

    public Outdoor(string ty, string t, string d, string da, string ti, Address add, string q)
    {
        type = ty;
        title = t;
        description = d;
        date = da;
        time = ti;
        address = add;
        q = weather;
    }
    public void Full()
    {
        Console.WriteLine($"{title}: {description}, {date} at {time}");
        Console.WriteLine($"Where? {address.Fulladd}");
    }
    public void Weather ()
    {
        Console.WriteLine($"Just a heads up! The weather for this event will be {weather}");
    }
}
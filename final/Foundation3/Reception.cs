class Receptions : Event
{
    private List<string> rsvp = new List<string>();

    public Receptions(string ty, string t, string d, string da, string ti, Address add, List<string> q = null)
    {
        type = ty;
        title = t;
        description = d;
        date = da;
        time = ti;
        address = add;
        rsvp = q;
    }
    public void Full()
    {
        Console.WriteLine($"{title}: {description}, {date} at {time} ");
        Console.WriteLine($"Where? {address.Fulladd()}, {string.Join(", ", rsvp)}");
    }
    public void Email(string x)
    {
        Console.WriteLine($"Dear welcomed guest! Thank you so much for being willing to come to the {x}. We appreciate you reserving your psot ahead of time and will make sure you are welcomed!");
    }
}
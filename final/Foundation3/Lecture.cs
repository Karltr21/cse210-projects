class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string ty, string t, string d, string da, string ti, Address add, string sp, int cap)
    {
        type = ty;
        title = t;
        description = d;
        date = da;
        time = ti;
        address = add;
        speaker = sp;
        capacity = cap;
    }

    public void Full()
    {
        Console.WriteLine($"{type}: {description}, {date} at {time}");
        Console.WriteLine($"Where? {address.Fulladd}  With special speaker: {speaker}, Capacity: {capacity}");
    }
}

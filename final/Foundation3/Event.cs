class Event
{
    protected string title;
    protected string description;
    protected string date;
    protected string time;

    protected Address address; 
    protected string type;

   



    public void Details()
    {
        Console.WriteLine($"{title}, {description}, {date}, {time}, {address.Fulladd}");

    }
    public void Short()
    {
        Console.WriteLine($"{type}, {title}, {date}");
    }
    
}
class Running : Activity
{
    private double distance; 

    public Running(string date, int minutes, double distances) : base(date, minutes)
    {
        distance = distances;
    }

    public override double Getdistance()
    {
        return distance;
    }
    public void Setdistance(int x)
    {
        distance = x;
    }

    public override double Getspeed()
    {
        return (distance / Getminutes()) * 60;
    }

    public override double Getpace()
    {
        return Getminutes() / distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running - Distance: {Getdistance():F1} miles, Speed: {Getspeed():F1} mph, Pace: {Getpace():F1} min per mile";
    }
    
}
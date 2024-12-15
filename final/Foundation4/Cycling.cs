class Cycling : Activity
{
    private double speed; 

    public Cycling(string date, int minutes, double speeds) : base(date, minutes)
    {
        speed = speeds;
    }

    public override double Getdistance()
    {
        return (speed * Getminutes()) / 60;
    }

    public override double Getspeed()
    {
        return speed;
    }

    public override double Getpace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling - Distance: {Getdistance():F1} miles, Speed: {Getspeed():F1} mph, Pace: {Getpace():F1} min per mile";
    }
}
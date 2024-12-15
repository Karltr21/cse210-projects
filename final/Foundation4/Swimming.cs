class Swimming : Activity
{
    private int laps;

    public Swimming(string date, int minutes, int lap) : base(date, minutes)
    {
        laps = lap;
    }

    public override double Getdistance()
    {
        return laps * 50 / 1000.0 * 0.62; 
    }

    public override double Getspeed()
    {
        return (Getdistance() / Getminutes()) * 60;
    }

    public override double Getpace()
    {
        return Getminutes() / Getdistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming - Distance: {Getdistance():F2} miles, Speed: {Getspeed():F1} mph, Pace: {Getpace():F1} min per mile";
    }
}
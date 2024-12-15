using System.Runtime.CompilerServices;

abstract class Activity
{ //Abstract class that is the parent class has the date and minutes as attributes and the distance is in the sub classes
    private string date;
    private int minute;

    public Activity(string dates, int minutes)
    {
        date = dates;
        minute = minutes;
    }

    public string Getdate()
    {
        return date; 
    }
    
    
    public void Setdate (string dates)
    {
        date = dates;
    }

    public int Getminutes()
    {
        return minute;
    }
    
    public void Setminute(int x)
    {
        minute = x;
    }
    

    public abstract double Getdistance();
    public abstract double Getspeed();
    public abstract double Getpace();


    public virtual string GetSummary()
    {
        return $"{date} ({minute} min):";
    }


}
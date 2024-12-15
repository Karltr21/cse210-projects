using System;

class Program
{
    static void Main(string[] args)
     {
        
        var activities = new List<Activity>
        {
            new Running("2024-12-14", 30, 3.0),
            new Cycling("2024-12-15", 45, 15.0),
            new Swimming("2024-12-16", 25, 40)
        };

        // Display the summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
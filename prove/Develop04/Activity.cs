using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;

public class Activity
{
    int time;

    // Method to display welcome message
    public void DisplayWelcome(string x, string y)
    {
        Console.WriteLine($"Welcome to the {x}");
        Animation(1,2,0);
        Console.WriteLine();
        Console.WriteLine(y);
    }

    public int time_count()
    {
        Console.WriteLine("How long do want this activity to be? (ex: 10)sec: ");
        int Length = Convert.ToInt32(Console.ReadLine());
        return Length;
    }

    // Method to display ending message
    public void DisplayEnding()
    {
        Console.WriteLine("\nWe hope that helped you! ");
        Animation(1,2,0);
        Console.WriteLine();
        Console.WriteLine("Thanks again for stopping by and taking the time to relax with us!");
        Animation(1,2,0);
        Console.Clear();
    }

    public static string SelectRandomMessage(List<string> suggestions) //Random List line selector
    {
        
        Random random = new Random();
        int randomIndex = random.Next(suggestions.Count);

        return suggestions[randomIndex];
    }

    // Method to display animation
    public void Animation(int a, int length, int count_length)
    {
        List<string> Characters = new List<string> { "/", "|", "\\", "-" };
        int x = count_length;

        // Run animation for the given length of time
        for (int f = 0; f < length; f++)  
        {
            if (a == 1)
            {
                for (int i = 0; i < Characters.Count; i++)
                {
                    Console.Write(Characters[i]);
                    Thread.Sleep(500);  
                    Console.Write("\b \b");  
                }
            }
            else
            {
                for (int i = 1; i < x; i++)
                {
                    Console.Write($"{i}");
                    Thread.Sleep(1000);  
                    Console.Write("\b \b");  
                }
            }
        }
    }
}



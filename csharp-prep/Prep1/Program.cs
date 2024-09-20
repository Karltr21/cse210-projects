using System;
// Karl Richards

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string first ;
        first = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string last ;
        last = Console.ReadLine();
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

class Program
{
    static void Main(string[] args)

    {
        Breathing john = new Breathing ();
        List Jane = new List ();
        Reflection Sheep = new Reflection ();

        Console.WriteLine("Welcome to the Mindfullness Program!\n");
        do
        {
            Console.WriteLine("Choose an activity to start:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit\n");

            Console.WriteLine("What would you like to do? ");
            string userInput = Console.ReadLine();
            if (userInput == "4")
            {
                break;
            }
            if (userInput == "1")
            {
                Console.Clear();
                john.Full_Breathe();
            }
            if (userInput == "2")
            {
                Console.Clear();
                Sheep.Full_Reflection();
            }
            if (userInput == "3")
            {
                Console.Clear();
                Jane.Full_List();
            }
        } while (true);

        Console.Clear();

        Console.WriteLine("Thanks for joining us! Come back later clear your mind!\n");
    }
}

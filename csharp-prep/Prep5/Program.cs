using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string Name = PromptUserName();
        int fav_num = PromptUserNumber();
        int Squared = SquareNumber(fav_num);

        DisplayResults(Squared, Name);

            
    }
    static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!\n");
        }
        
    static string PromptUserName()
        {
            Console.WriteLine("Please Enter your name:");
            string name = Console.ReadLine();
            return name;
        }
    static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number:\n");
            string num = Console.ReadLine();
            int number = int.Parse(num);
            return number;
        }
    static int SquareNumber(int fav_num)
        {
            int squared = fav_num * fav_num;
            return squared;
        }
    static void DisplayResults(int num, string name )
        {
             Console.WriteLine($"{name}, the square of your favorite number is {num}.");
         }

    
}
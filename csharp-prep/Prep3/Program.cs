using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);
        int guess;

        

        do {
            Console.WriteLine("Guess a magic number: ");
            string b = Console.ReadLine();
            guess = int.Parse(b);
            if (guess > magic)
                Console.WriteLine("A little too high. Try again!\n");
            else if (guess < magic)
                Console.WriteLine("A little too low! Try again!\n");
            else
                Console.WriteLine("Good Job! You got it!");

        } while (guess != magic);
    }
}
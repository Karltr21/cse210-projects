using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Memorizer();
    }

    static void Memorizer()
    {
        Verse verse = new Verse();
        string userInput;

        Console.WriteLine("Welcome to the Scripture Memorizer App!\n");

        // Display the full verse initially
        Console.WriteLine("Full Verse: Isaiah 41:10");
        Console.WriteLine(string.Join(" ", verse.GetVerseWithHiddenWords())); // Full verse display
        Console.WriteLine();

        do
        {
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            userInput = Console.ReadLine()?.Trim();

            if (userInput == "quit")
            {
                break;
            }

            // Clear the console each time Enter is pressed
            Console.Clear();

            // Hide three random words each time Enter is pressed
            verse.HideRandomWords(3);
            List<string> hiddenVerse = verse.GetVerseWithHiddenWords();

            // Display the verse with hidden words
            Console.WriteLine("Current Scripture:");
            Console.WriteLine(string.Join(" ", hiddenVerse));

            // Check if all words are hidden
            if (!hiddenVerse.Any(word => word.Contains('_')))
            {
                Console.WriteLine("\nAll words are hidden! Good Luck!");
                break;
            }

        } while (true);

        Console.WriteLine("Thanks for joining us! Come back later to try again!\n");
    }
}

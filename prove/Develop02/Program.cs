using System;
using System.Collections.Generic;
using System.IO;



class Program
{
    static void Main(string[] args)
    {
        List<JournalEntry> entries_array = new List<JournalEntry>();
        Save_Loader fileHandler = new Save_Loader();
        int i;

        Console.WriteLine("Welcome to the Journal Program!\n");

        do
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Choose one of the options: ");
            if (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            if (i == 1) // Prompt generator and recorder
            {
                JournalEntry entry = new JournalEntry();
                prompt_generator question = new prompt_generator();
                
                entry.prompt = question.RandomGen();
                entry.response = Console.ReadLine();
                entry.entryDateTime = DateTime.Now;

                entries_array.Add(entry);
                Console.WriteLine("Entry recorded!\n");
            }
            else if (i == 2)
            //Display function
            {
                    foreach (var entry in entries_array)
                    {
                        Console.WriteLine($"Prompt: {entry.prompt} Response: {entry.response}");
                        Console.WriteLine($"Time: {entry.entryDateTime}");
                    }
            }
            else if (i == 3)
            {
                Console.Write("Enter the filename to save to (.txt): ");
                string filename = Console.ReadLine();
                fileHandler.SaveEntries(filename, entries_array);
            }
            else if (i == 4)
            {
                Console.Write("Enter the filename to load from: ");
                string filename = Console.ReadLine();
                entries_array = fileHandler.LoadEntries(filename);
            }
            else if (i != 5)
            {
                Console.WriteLine("Invalid option, please choose again.");
            }

        } while (i != 5);

        Console.WriteLine("Thanks for writing with us!");
    }
}

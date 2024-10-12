using System;
using System.Collections.Generic;
using System.IO;

public class Save_Loader
{
    // Save journal entries to a file
    public void SaveEntries(string filename, List<JournalEntry> entries)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in entries)
            {
                outputFile.WriteLine(entry.Prompt);
                outputFile.WriteLine(entry.Response);
                outputFile.WriteLine(entry.EntryDateTime);
            }
        }
        Console.WriteLine($"Entries saved to file: {filename}");
    }

    // Load journal entries from a file
    public List<JournalEntry> LoadEntries(string filename)
    {
        List<JournalEntry> entries = new List<JournalEntry>();

        if (File.Exists(filename))
        {
            using (StreamReader inputFile = new StreamReader(filename))
            {
                while (!inputFile.EndOfStream)
                {
                    string prompt = inputFile.ReadLine();
                    string response = inputFile.ReadLine();
                    DateTime entryDateTime = DateTime.Parse(inputFile.ReadLine());
                    entries.Add(new JournalEntry(prompt, response, entryDateTime));
                }
            }
            Console.WriteLine($"Entries loaded from file: {filename}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }

        return entries;
    }
}

public class prompt_generator
{
    // Generate and return a random prompt
    public string pro_gen()
    {
        List<string> prompt = new List<string>{
            "What is one thing you are grateful for?",
            "Who made you smile today?",
            "How have you seen the hand of the Lord today?",
            "What surprised you today?",
            "What was the hardest thing you did today?",
            "What is something you learned today?"
        };

        Random random = new Random();
        return prompt[random.Next(prompt.Count)];
    }

    // Record and return user's response to the prompt
    public string recorder(string prompt)
    {
        Console.WriteLine($"{prompt}\n");
        return Console.ReadLine();
    }
}

public class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime EntryDateTime { get; set; }

    // Constructor for new entries
    public JournalEntry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        EntryDateTime = DateTime.Now;
    }

    // Constructor for loading entries from file
    public JournalEntry(string prompt, string response, DateTime entryDateTime)
    {
        Prompt = prompt;
        Response = response;
        EntryDateTime = entryDateTime;
    }

    // Override ToString to display entries neatly
    public override string ToString()
    {
        return $"Prompt: {Prompt}\nResponse: {Response}\nDate: {EntryDateTime}\n";
    }
}

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

            if (i == 1)
            {
                prompt_generator question = new prompt_generator();
                string suggestion = question.pro_gen();
                string response = question.recorder(suggestion);

                JournalEntry entry = new JournalEntry(suggestion, response);
                entries_array.Add(entry);

                Console.WriteLine("Entry saved!\n");
            }
            else if (i == 2)
            {
                if (entries_array.Count == 0)
                {
                    Console.WriteLine("No entries yet.");
                }
                else
                {
                    foreach (var entry in entries_array)
                    {
                        Console.WriteLine(entry);
                    }
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

using System.Security.Cryptography.X509Certificates;

public class List : Activity

{
    string welcome = "List Activity";
    string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    List<string> suggestions = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    int x = 0;

    public void Full_List()
    {
            //Main function
        DisplayWelcome(welcome,description);
        int List_length = time_count();
        Console.WriteLine(SelectRandomMessage(suggestions));

        List<string> userInputs = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(List_length);
        Console.WriteLine("Get Ready!");
        Animation(1,3,0);
        
        while (DateTime.Now < endTime)
        {

            Animation(2,1,List_length);

            Console.WriteLine("List your thoughts (or type 'done' to finish):");
            string input = Console.ReadLine();

            if (input.ToLower() == "done")
            {
                break;  
            }

            userInputs.Add(input);  
        }

         int totalWords = 0;
        foreach (string item in userInputs)
        {
            totalWords += item.Split(' ').Length;
        }

        // Display the result
        Console.WriteLine($"\nYou listed {userInputs.Count} items with a total of {totalWords} words.");

        DisplayEnding();


    }
}
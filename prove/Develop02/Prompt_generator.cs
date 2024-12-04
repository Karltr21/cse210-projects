public class prompt_generator
{
    
    private List<string> prompt = new List<string>{
            "What is one thing you are grateful for?",
            "Who made you smile today?",
            "How have you seen the hand of the Lord today?",
            "What surprised you today?",
            "What was the hardest thing you did today?",
            "What is something you learned today?"
        };

        
        
    public string RandomGen ()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 5);
        string prompt_choice = prompt[randomNumber];
        Console.WriteLine($"{prompt_choice}");
        return prompt_choice;
    }

    // 
    public string recorder(string y)
    {
        Console.WriteLine($"{y}\n");
        return Console.ReadLine();
    }
}
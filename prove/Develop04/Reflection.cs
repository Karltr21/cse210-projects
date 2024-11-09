public class Reflection : Activity
{

    List<string> Prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

    List<string> Reflection_prompt = new List<string>
        {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };


        string welcome = "Reflection Activity";
        string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    public void Full_Reflection() // Main Function
    {
        DisplayWelcome(welcome, description);
        int Reflect_length = time_count();

        Console.WriteLine(SelectRandomMessage(Prompts));
        DateTime endTime = DateTime.Now.AddSeconds(Reflect_length);
        Console.WriteLine("Get Ready!");
        Animation(1,3,0);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"{SelectRandomMessage(Reflection_prompt)}\n");
            Animation(1,4,0);
        }

        DisplayEnding();
    }

}
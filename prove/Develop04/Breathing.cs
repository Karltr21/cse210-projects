using System.Security.Cryptography.X509Certificates;

public class Breathing : Activity
{
    


    public void Full_Breathe()
    {
        string welcome = "Breathing Activity!";
        string entrance = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        int breathing = 0;
        
        DisplayWelcome(welcome, entrance);
        int time_input = time_count();
        while (breathing < time_input)
        {
            Console.WriteLine($"Breath in.....");
            Animation(2,1,5);
            breathing += 5;

            Console.WriteLine($"Breath out.....");
            Animation(2,1,5);
            breathing += 5;
        }
        DisplayEnding();

    }
}
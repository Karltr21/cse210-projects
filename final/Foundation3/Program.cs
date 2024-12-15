using System;

class Program
{
    static void Main(string[] args)
    {


    List<string> titles = new List<string>
    {
        "Happy reception",
        "Team Strategy Session",
        "Client Presentation",
        "Mars with the boys",
        "Golfing"
    };

    List<string> descriptions = new List<string>
    {
        "Discussing new hires and team dynamics",
        "Reviewing the team's goals and project timelines",
        "Presenting the latest product updates to the client",
        "Reviewing the latest code changes and issues",
        "Planning next steps and setting deadlines for the project"
    };

    List<string> times = new List<string>
    {
        "9:00 AM",
        "1:00 PM",
        "11:30 AM",
        "3:00 PM",
        "4:30 PM"
    };

    List<string> dates = new List<string>
    {
        "2024-12-14",
        "2024-12-15",
        "2024-12-16",
        "2024-12-17",
        "2024-12-18"
    };


    List <string> w = new List<string>
            {
                "Jack",
                "Jill",
                "Mack"
            };
    
    

    Address s = new Address("Elmo Str.", "Kuna", "Idaho", "USA");


        for (int i =0; i < 3; i++)
        {

             string Random(List<string> list)
            {
                Random rand = new Random();
                int index = rand.Next(list.Count);
                return list[index];
            }

        string randomTitle = Random(titles);
        string randomDescription = Random(descriptions);
        string randomTime = Random(times);
        string randomDate = Random(dates);

        if (i == 0)
        {
            Lecture lecture = new Lecture("Lecture",randomTitle, randomDescription, randomDate, randomTime, s , "Dr. Smith", 100);
            lecture.Short();
            lecture.Full();
            lecture.Details();
        }


        else if (i == 1)
        {
            Outdoor outdoor = new Outdoor("Outdoor",randomTitle, randomDescription, randomDate, randomTime ,s , "Sunny");
            outdoor.Short();
            outdoor.Full();
            outdoor.Details();
            outdoor.Weather();
        }
        
        
        else if (i == 2)
        {
            Receptions reception = new Receptions("Reception",randomTitle, randomDescription, randomDate, randomTime, s ,w);
            reception.Short();
            reception.Full();
            reception.Details();
            reception.Email(randomTitle);
        }
     }
    }

}

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

class Program
{
    List<Goals> _goals = new List<Goals>();  
    static void Main(string[] args)
    {

        Program program = new Program();  // Initialize the classes
        SaveLoad Saveload = new SaveLoad();


        string i;
        int total_points = 0;

        Console.WriteLine("Welcome to the Eternal Quest App!\n");
        

        do
        {
            Thread.Sleep(2000);
            Console.WriteLine($"You have {total_points} points!\n");
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit\n");
            Console.WriteLine("What would you like to do? Select an option: ");
            i = Console.ReadLine();

            if (i == "1")
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal ");
                Console.WriteLine("What type of goal would you like to create:");
                string number = Console.ReadLine();
                switch (number)
                { //I used a switch case to figure out with type of goal I was going to need be called.
                    case "1":
                        Simple simpleGoal = new Simple();
                        simpleGoal.SetType("simple");
                        simpleGoal.Simple_goal();
                        program._goals.Add(simpleGoal);
                        break;

                    case "2":
                        Eternal EternalGoal = new Eternal();
                        EternalGoal.SetType("eternal");
                        EternalGoal.Eternal_goals();
                        program._goals.Add(EternalGoal);
                        break;

                    case "3":
                        Checklist ChecklistGoal = new Checklist();
                        ChecklistGoal.SetType("checklist");
                        ChecklistGoal.Checklist_goal();
                        program._goals.Add(ChecklistGoal);
                        break;
                }
            }

            if (i == "2")
            {
                Console.WriteLine("These are your goals:\n");
                foreach (Goals goal in program._goals)
                {
                    string box = "[]";
                    if (goal.Is_Completed() == true)
                    {
                        box = "[X]";
                    }

                    if (goal.GetType() == "checklist")
                    {
                        //This checks to see if the goal is a checklist and then adds the additional information
                    

                        Console.WriteLine($"{box} {goal.GetName()}: {goal.GetDescription()} - {goal.GetValue()} points");
                        Console.WriteLine($"Completed: [{goal.Getrep}/{goal.Getreq}] Bonus = {goal.GetbonusValue}");
                    }

                    Console.WriteLine($"{box} {goal.GetName()}: {goal.GetDescription()} - {goal.GetValue()} points");
                    Thread.Sleep(5000);
                }
            }

            if (i == "3")
            {
                Saveload.Save(program._goals);

            }

            if (i == "4")
            {
                Saveload.Load(program._goals);
            }

            if (i == "5")
            //My event recorder and acts as a second display in a way
            {
                Console.WriteLine("Select a goal to record an event:");
                for (int it = 0; it < program._goals.Count; it++)
                {
                    Console.WriteLine($"{it + 1}. {program._goals[it].GetDescription()}");
                }
                int goalpicked = int.Parse(Console.ReadLine()) - 1;
                if (goalpicked >= 0 && goalpicked < program._goals.Count)
                {
                    total_points += program._goals[goalpicked].Complete();
                    
                }
            }

        } while (i != "6");

        //Bye bye
        Console.Clear();
        Console.WriteLine("Thanks for joining us and we hope to see you again soon!\n");
        Thread.Sleep(2000);
        Console.Clear();
    }
}

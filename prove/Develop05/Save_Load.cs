using System;
using System.Collections.Generic;
using System.IO;

class SaveLoad
{
    // Save method
    public void Save(List<Goals> _goals)
    {
        Console.WriteLine("Where would you like to save your goals:");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goals goal in _goals)
            {
                // Save format: Type|Name,Description,Value,Completed,AdditionalProperties (Bonus, req, rep)
                if (goal is Simple simpleGoal)
                {
                    outputFile.WriteLine($"simple|{simpleGoal.GetName()}|{simpleGoal.GetDescription()}|{simpleGoal.GetValue()}|{simpleGoal.Is_Completed()}");
                }
                else if (goal is Eternal eternalGoal)
                {
                    outputFile.WriteLine($"eternal|{eternalGoal.GetName()}|{eternalGoal.GetDescription()}|{eternalGoal.GetValue()}|{eternalGoal.Is_Completed()}");
                }
                else if (goal is Checklist checklistGoal)
                {
                    outputFile.WriteLine($"checklist|{checklistGoal.GetName()}|{checklistGoal.GetDescription()}|{checklistGoal.GetValue()}|{checklistGoal.Is_Completed()}|{checklistGoal.GetbonusValue()}|{checklistGoal.Getreq}|{checklistGoal.Getrep}");
                }
            }
        }
        Console.WriteLine("Goals have been saved successfully!");
        Thread.Sleep(1000);
    }

    // Load method 

    // Save format: Type|Name,Description,Value,Completed,AdditionalProperties (Bonus, req, rep)
    public void Load(List<Goals> _goals)
    {
        Console.WriteLine("Where would you like to load your goals from:");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts[0] == "simple")
            {
                Simple loadedSimple = new Simple();
                loadedSimple.SetType(parts[0]);
                loadedSimple.SetName(parts[1]);
                loadedSimple.SetDescription(parts[2]);
                loadedSimple.SetValue(int.Parse(parts[3]));
                loadedSimple.Check_completed(bool.Parse(parts[4]));
                _goals.Add(loadedSimple);
            }
            else if (parts[0] == "eternal")
            {
                Eternal loadedEternal = new Eternal();
                loadedEternal.SetType(parts[0]);
                loadedEternal.SetName(parts[1]);
                loadedEternal.SetDescription(parts[2]);
                loadedEternal.SetValue(int.Parse(parts[3]));
                loadedEternal.Check_completed(bool.Parse(parts[4]));
                _goals.Add(loadedEternal);
            }
            else if (parts[0] == "checklist")
            {
                Checklist Checklist = new Checklist();
                Checklist.SetType(parts[0]);
                Checklist.SetName(parts[1]);
                Checklist.SetDescription(parts[2]);
                Checklist.SetValue(int.Parse(parts[3]));
                Checklist.Check_completed(bool.Parse(parts[4]));
                Checklist.SetbonusValue(int.Parse(parts[5]));
                Checklist.Setreq(int.Parse(parts[6]));
                Checklist.Setrep(int.Parse(parts[7]));
                _goals.Add(Checklist);
            }
        }
    }
}

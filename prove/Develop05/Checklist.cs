using System;

class Checklist : Goals
{


    public Checklist()
    {
        _repitions = 1;
    }

    

    public override int Complete()
    {
        int total = 0;
        
        //This section here checks to see if the goal has met the required amount of times done to see if they get the bonus
        if (_repitions >= _requirment)
        {
            total += _bonusValue;  
            _completed = true;      
            _repitions = 0;        
        }
        else
        {
            _repitions += 1;       
            total += _value;       
        }
        
        return total;
    }

    public void Checklist_goal()
    {
        //Additonal parts for the Goal_Prompt to add the additional information needed for the checklist requirments
        Goal_prompt();
        
        Console.WriteLine("How many times do you want to do this before earning a bonus?");
        Setreq(int.Parse(Console.ReadLine()));  
        Console.WriteLine("What will be your bonus value (in points)?");
        SetbonusValue(int.Parse(Console.ReadLine()));  
    }
}

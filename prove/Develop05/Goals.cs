using System.Globalization;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;

abstract class Goals
{
    //attributes and Getters and Setters
    protected int _value;
    protected string _name;
    protected string _type;
    protected string _description;

    protected bool _completed;

    protected int _bonusValue;
    protected int _requirment;
    protected int _repitions;


    public Goals ()
    {
        _type = "";
        _name = "";
        _description = "";
        _value = 0;
        _completed = false;
        _bonusValue = 0;
        _requirment = 0;
        _repitions = 0;
    }

    public int GetbonusValue ()
    {
        return _bonusValue;
    }
    public void SetbonusValue (int value)
    {
        _bonusValue = value;
    }
    public int Getrep ()
    {
        return _repitions;
    }
    public void Setrep (int value)
    {
        _repitions = value;
    }
    public int Getreq ()
    {
        return _requirment;
    }
    public void Setreq (int value)
    {
        _requirment = value;
    }

    public bool Is_Completed()
    {
        return _completed;
    }
    public void Check_completed(bool check)
    {
        _completed = check;
    }

    public string GetName ()
    {
        return _name;
    }
    public void SetName (string name)
    {
        _name = name;
    }

    public int GetValue ()
    {
        return _value;
    }
    public void SetValue (int value)
    {
        _value = value;
    }

    public string GetType ()
    {
        return _type;
    }
    public void SetType (string type)
    {
        _type = type;
    }

    public string GetDescription ()
    {
        return _description;
    }
    public void SetDescription (string description)
    {
        _description = description;
    }

//This method grabs all of the data we need about the goal and stores it in the object
    public void Goal_prompt() 
    {

        Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("Give a short description of the goal: ");
        _description = Console.ReadLine();
        Console.WriteLine("How many points do you want to get for completing this goal:");
        _value = int.Parse(Console.ReadLine());


    }


//This will be the method that will be used to total points and change the bool status dependant on the type of goal
    public abstract int Complete();
    
    
}
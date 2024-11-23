
class Simple : Goals {

    //This is my simple goal file. It builds and assigns the goal for the simple goal 


    public override int Complete()
    {
        _completed = true;
        return _value;
    }  //makes the completed bool true for the goal if called and returns the points to be added into the total points

    public void Simple_goal ()
    {
        Goal_prompt();
    }
}
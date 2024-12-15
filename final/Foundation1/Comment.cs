class Comment
{
    public string name;
    public string text;

    public string Getcomments(List <string> y, List <string> x)
    {
        Random random = new Random();
        int comment_gen = x.Count;
        int name_gen = y.Count;
        int randomnumber = random.Next(3, 5);
        int random_name = random.Next(0, name_gen);
        name = y[random_name];
        int random_comment = random.Next(0,comment_gen);
        string complete_comment = $"{name}: {text} ";
        return complete_comment;
        
    }
}
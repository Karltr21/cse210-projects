class Video
{
    public string title;
    public string author;
    public int length;
    public List <Comment> comments;
    

    public void Getcomments(List <string> y, List <string> x)
    {
        Random random = new Random();
        int comment_gen = x.Count;
        int name_gen = y.Count;
        int randomnumber = random.Next(3, 5);
        for (int i = 1; i<= randomnumber; i++)
        {
            Comment joke = new Comment();
            int random_name = random.Next(0, name_gen);
            joke.name = y[random_name];
            int random_comment = random.Next(0,comment_gen);
            joke.text = x[random_comment];
            comments.Add(joke);
        }

    }
    public void Get_Video_info(List <string> y, List <string> x, List<int> z)
    {
        Random random = new Random();
        int title_gen = x.Count;
        int author_gen = y.Count;
        int length_gen = z.Count;


        author = y[random.Next(0, author_gen)];
        title = x[random.Next(0, title_gen)];
        length = z[random.Next(0, length_gen)];

    }

    
}
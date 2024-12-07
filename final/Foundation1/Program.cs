using System;
using System.ComponentModel.Design;

class Program
{
    
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        List <string> title = new List<string>
        {
            "Benefits of AI",
            "Top 10 Tech Gadgets",
            "Mr. Beast vs 10 million fans",
            "Surviving your first night in Minecraft",
            "How it should have ended",
            "Roasting your mom",
            "Surving in the Alaska for three days"
        };
        List <int> length = new List<int>
        {
            23,34,10,4,73,16
        };
        List <string> names = new List<string>
        {
            "James", "Jerry", "Jim", "John", "Jack", "Jake", "Jeremiah",
            "Joan", "Juan", "Jerry", "Jacob", "Jasper", "Jackson"
        };
        List <string> comment_options = new List<string>
        {
            "How does this not have more views? It's amazing!",
            "The quality of your content keeps getting better and better!",
            "I’ve been waiting all day for this upload!",
            "Your creativity is unmatched. Keep it up!",
            "I literally just went through this last week. Crazy timing!",
            "This video is so me it's scary.",
            "Watching this while procrastinating on the thing I should be doing.",
            "This was exactly what I needed to see today.",
            "This video reminds me of the time I got lost in IKEA for three hours.",
            "I can’t explain it, but this feels like my grandma’s basement in 2007.",
            "The way you pronounced ‘tomato’ just changed the trajectory of my life.",
            "I had a dream about this exact video last week, and now I’m freaked out.",
            "This is giving me strong 'Tuesday at 3:47 PM in 2012' vibes.",
            "This video is the reason my toaster is plotting against me.",
            "I watched this, and now my fridge won’t stop humming the theme song from Shrek.",
            "The vibes here are so powerful I think I accidentally astral projected.",
            "I sneezed while watching this, and now I can taste colors.",
            "I put this video on loop, and my neighbor's dog started breakdancing."
        };

        for (int i = 0; i<= 3; i++)
        {
            Video movie = new Video();
            movie.Getcomments(names, comment_options);
            movie.Get_Video_info(names, title, length);
            videos.Add(movie);
        }

        foreach (Video video in  videos)
        {
            Console.WriteLine(video);
         
        }
        


    }

}
using System;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Shafiq");

        try
        {
            user.AddVideo(new SayaTubeVideo("Review Film Interstellar oleh Shafiq"));
            user.AddVideo(new SayaTubeVideo("Review Film Inception oleh Shafiq"));
            user.AddVideo(new SayaTubeVideo("Review Film Tenet oleh Shafiq"));
            user.AddVideo(new SayaTubeVideo("Review Film The Batman oleh Shafiq"));
            user.AddVideo(new SayaTubeVideo("Review Film Dune oleh Shafiq"));
            user.AddVideo(new SayaTubeVideo("Review Film The Prestige oleh Shafiq"));
            user.AddVideo(new SayaTubeVideo("Review Film Oppenheimer oleh Shafiq"));
            user.AddVideo(new SayaTubeVideo("Review Film Parasite oleh Shafiq"));
            user.AddVideo(new SayaTubeVideo("Review Film Knives Out oleh Shafiq"));
            user.AddVideo(new SayaTubeVideo("Review Film The Dark Knight oleh Shafiq"));

            foreach (var video in user.GetType().GetField("uploadedVideos", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(user) as List<SayaTubeVideo>)
            {
                video.IncreasePlayCount(25000000);
            }

            user.PrintAllVideoPlaycount();
            Console.WriteLine("Total Play Count: " + user.GetTotalVideoPlayCount());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Muhammad Shafiq Rasuna");
        video.IncreasePlayCount(100);
        video.PrintVideoDetails();
    }
}

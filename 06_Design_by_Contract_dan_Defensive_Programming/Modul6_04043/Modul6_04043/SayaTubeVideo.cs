using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 200)
            throw new ArgumentException("Judul tidak boleh kosong dan maksimal 200 karakter");

        this.title = title;
        this.playCount = 0;
        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
    }

    public void IncreasePlayCount(int count)
    {
        if (count > 25000000 || count < 0)
            throw new ArgumentOutOfRangeException("Play count maksimal 25.000.000 dan tidak negatif");

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Terjadi overflow saat menambah play count.");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}, Title: {title}, Play Count: {playCount}");
    }

    public int GetPlayCount() => playCount;
    public string GetTitle() => title;
}

using System;

/// <summary>
/// Representasi dari video dengan ID, judul, dan jumlah play count.
/// </summary>
public class SayaTubeVideo
{
    // Atribut private
    private int id;
    private string title;
    private int playCount;

    /// <summary>
    /// Konstruktor untuk inisialisasi video dengan judul dan ID acak.
    /// </summary>
    /// <param name="title">Judul video</param>
    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    /// <summary>
    /// Menambah jumlah play count video.
    /// </summary>
    /// <param name="count">Jumlah yang ingin ditambahkan ke play count</param>
    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    /// <summary>
    /// Menampilkan detail video ke konsol.
    /// </summary>
    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID   : {id}");
        Console.WriteLine($"Title      : {title}");
        Console.WriteLine($"Play Count : {playCount}");
    }
}

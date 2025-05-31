using System;

/// <summary>
/// Kelas untuk merepresentasikan sebuah video dalam sistem SayaTube.
/// </summary>
public class SayaTubeVideo
{
    // Atribut private
    private int id;
    private string title;
    private int playCount;

    /// <summary>
    /// Konstruktor: Menginisialisasi objek video dengan judul dan ID acak.
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
    /// Menambahkan jumlah penayangan ke video.
    /// </summary>
    /// <param name="count">Jumlah yang ingin ditambahkan</param>
    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
    }

    /// <summary>
    /// Menampilkan detail video: ID, judul, dan jumlah penayangan.
    /// </summary>
    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID   : " + id);
        Console.WriteLine("Title      : " + title);
        Console.WriteLine("Play Count : " + playCount);
    }
}

using System;
using System.Collections.Generic;

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username { get; }

    public SayaTubeUser(string username)
    {
        if (string.IsNullOrEmpty(username) || username.Length > 100)
            throw new ArgumentException("Username tidak boleh kosong dan maksimal 100 karakter");

        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
    }

    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null || video.GetPlayCount() >= int.MaxValue)
            throw new ArgumentException("Video tidak valid untuk ditambahkan");

        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.GetPlayCount();
        }
        return total;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 0; i < uploadedVideos.Count && i < 8; i++)
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
        }
    }
}

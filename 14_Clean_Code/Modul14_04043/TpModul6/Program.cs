using System;

class Program
{
    static void Main()
    {
        // Membuat objek video dengan judul tertentu
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Muhammad Shafiq Rasuna");

        // Menambahkan jumlah penayangan (play count)
        video.IncreasePlayCount(100);

        // Menampilkan detail video
        video.PrintVideoDetails();
    }
}

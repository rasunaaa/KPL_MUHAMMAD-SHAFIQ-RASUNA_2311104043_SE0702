using System;

class Program
{
    static void Main()
    {
        // Buat 2 variabel singleton
        var data1 = PusatDataSingleton.GetDataSingleton();
        var data2 = PusatDataSingleton.GetDataSingleton();

        // Tambahkan data ke data1
        data1.AddSebuahData("Muhammad Shafiq Rasuna");
        data1.AddSebuahData("Andi Pratama");
        data1.AddSebuahData("Asisten Praktikum: Rizky Naufal Alghifari");

        // Tampilkan data dari data2
        Console.WriteLine("Data dari data2:");
        data2.PrintSemuaData();

        // Hapus nama asisten di data2
        data2.HapusSebuahData(2);

        // Tampilkan data dari data1
        Console.WriteLine("\nSetelah dihapus dari data2, cetak dari data1:");
        data1.PrintSemuaData();

        // Hitung jumlah data
        Console.WriteLine($"\nJumlah data di data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah data di data2: {data2.GetSemuaData().Count}");
    }
}

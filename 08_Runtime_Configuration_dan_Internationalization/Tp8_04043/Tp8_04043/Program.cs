using System;

class Program
{
    static void Main()
    {
        CovidConfig config = new CovidConfig();

        Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}:");
        double suhu = double.Parse(Console.ReadLine());

        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
        int hari = int.Parse(Console.ReadLine());

        bool suhuNormal = false;

        if (config.satuan_suhu == "celcius")
            suhuNormal = suhu >= 36.5 && suhu <= 37.5;
        else if (config.satuan_suhu == "fahrenheit")
            suhuNormal = suhu >= 97.7 && suhu <= 99.5;

        bool kondisiDiterima = suhuNormal && hari < config.batas_hari_deman;

        Console.WriteLine(kondisiDiterima ? config.pesan_diterima : config.pesan_ditolak);

        // Ubah satuan untuk percobaan:
        config.UbahSatuan();
        Console.WriteLine($"Satuan diubah menjadi: {config.satuan_suhu}");
    }
}
